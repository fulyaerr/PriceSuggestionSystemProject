using Nest;
using System;
using System.Configuration;

namespace PriceSuggestionSystem.Core.Common
{
    public class ElasticHelper
    {
        private static readonly Lazy<ElasticHelper> _Instance = new Lazy<ElasticHelper>(() => new ElasticHelper());

        private ElasticHelper()
        {

        }

        public static ElasticHelper Instance
        {
            get
            {
                return _Instance.Value;
            }
        }

        #region Public Methods
        public ConnectionSettings GetConnectionSettings()
        {
            var connectionSettings = new ConnectionSettings(new Uri(ConfigurationManager.AppSettings["ElasticSearchURI"]));

            return connectionSettings;
        }
        #endregion

    }
}
