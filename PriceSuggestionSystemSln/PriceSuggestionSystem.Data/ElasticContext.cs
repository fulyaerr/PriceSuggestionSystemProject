using Nest;
using PriceSuggestionSystem.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceSuggestionSystem.Data
{
    public class ElasticContext : IElasticContext
    {
        private readonly ElasticClient _elasticClient;

        public ElasticContext(ElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public IndexResponseDTO CreateIndex<T>(string indexName) where T : class
        {
            var createIndexDescriptor = new CreateIndexDescriptor(indexName)
            .Map(m => m.AutoMap())
            .Aliases(a => a.Alias(ConfigurationManager.AppSettings["aliasName"]));

            var response = _elasticClient.Indices.Create(createIndexDescriptor);

            return new IndexResponseDTO()
            {
                IsValid = response.IsValid,
                StatusMessage = response.DebugInformation,
                Exception = response.OriginalException
            };
        }
    }
}
