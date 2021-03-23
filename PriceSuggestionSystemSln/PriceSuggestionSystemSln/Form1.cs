using Nest;
using PriceSuggestionSystem.Core.Common;
using PriceSuggestionSystem.Data;
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
        static string indexNameFullTextMessage = ConfigurationManager.AppSettings["ElasticSearchIndexNameFullTextMessage"];
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
                    price = Convert.ToDecimal(txtUrunFiyat.Text)
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
              .Query(q => q.QueryString(qs => qs.Query("*" + txtFullSearchUrun.Text + "*").AllowLeadingWildcard(true))));

            if (!result.IsValid)
            {
                throw new Exception(result.OriginalException.Message);
            }

            grdFullSearchUrun.DataSource = result.Documents.ToList();
        }

        private void btnIndexCreate_Click(object sender, EventArgs e)
        {
            var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());
            var elasticContext = new ElasticContext(elasticClient);
            CreateIndex(elasticContext, indexNameProduct);
        }

        private static void CreateIndex(ElasticContext elasticContext, string indexName)
        {
            var response = elasticContext.CreateIndex<Product>(indexName);
            if (response.IsValid)
            {
                MessageBox.Show("Index Başarılı Şekilde Oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Hata : " + response.StatusMessage);
            }
        }

        private void btnMesajKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());

                var message = new FullTextMessage
                {
                    id = Guid.NewGuid(),
                    data = txtMesajMetni.Text
                };

                var result = elasticClient.Index<FullTextMessage>(message, i => i.Index(indexNameFullTextMessage).Id(new Id(message.id)).Refresh(Elasticsearch.Net.Refresh.WaitFor));
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

        private void btnFormatliKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());
                string[] messageFormat = txtFormatliMesaj.Text.Split('_');
                var product = new Product()
                {
                    id = Guid.NewGuid().ToString(),
                    mark = messageFormat[2],
                    marketName = messageFormat[0],
                    name = messageFormat[1],
                    dimencion = messageFormat[3],
                    price = Convert.ToDecimal(messageFormat[4])
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

        private void btnMesajAra_Click(object sender, EventArgs e)
        {
            var elasticClient = new ElasticClient(ElasticHelper.Instance.GetConnectionSettings());

            var result = elasticClient.Search<FullTextMessage>(s => s
              .Index(indexNameFullTextMessage)
              .Query(q => q.QueryString(qs => qs.Query("*" + txtFullMessageSearch.Text + "*").AllowLeadingWildcard(true))));

            if (!result.IsValid)
            {
                throw new Exception(result.OriginalException.Message);
            }

            grdFullSearchMessage.DataSource = result.Documents.ToList();
        }
    }
}
