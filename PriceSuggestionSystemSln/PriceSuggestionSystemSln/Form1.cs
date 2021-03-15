using Nest;
using PriceSuggestionSystem.Core.Common;
using PriceSuggestionSystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriceSuggestionSystemSln
{
    public partial class Form1 : Form
    {
        static string indexNameProduct = ConfigurationManager.AppSettings["ElasticSearchIndexNameProduct"];
        static string url = ConfigurationManager.AppSettings["ElasticSearchURI"];
        static string alias = ConfigurationManager.AppSettings["aliasName"];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtUrunMarka.Text = string.Empty;
            txtMarketAdi.Text = string.Empty;
            txtUrunAdi.Text = string.Empty;
            txtUrunFiyat.Text = string.Empty;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());
                
                var product = new Product
                {
                    id = Guid.NewGuid().ToString(),
                    mark = txtUrunMarka.Text,
                    marketName = txtMarketAdi.Text,
                    name = txtUrunAdi.Text,
                    price = txtUrunFiyat.Text
                };

                var result = elasticClient.Index<Product>(product, i => i.Index(indexNameProduct).Id(new Id(product.id)).Refresh(Elasticsearch.Net.Refresh.WaitFor));
                if (result.IsValid)
                {
                    MessageBox.Show("Kayıt Başarılı");
                }
                else
                {
                    MessageBox.Show("Hata:" + result.Result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata:" + ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnFiltre_Click(object sender, EventArgs e)
        {
            var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());

            var result = elasticClient.Search<Product>(s => s
              .Index(indexNameProduct)
              .Query(q => q.QueryString(qs => qs.Query(txtFullSearchUrun.Text))));

            if (!result.IsValid)
            {
                throw new Exception(result.OriginalException.Message);
            }

            grdFullSearchUrun.DataSource = result.Documents.ToList();
        }
    }
}
