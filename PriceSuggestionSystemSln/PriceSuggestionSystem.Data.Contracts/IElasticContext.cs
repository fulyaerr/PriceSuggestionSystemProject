using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceSuggestionSystem.Data.Contracts
{
    public interface IElasticContext
    {
        IndexResponseDTO CreateIndex<T>(string indexName) where T : class;
    }
}
