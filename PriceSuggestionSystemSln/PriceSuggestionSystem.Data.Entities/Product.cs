using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceSuggestionSystem.Data.Entities
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string mark { get; set; }
        public decimal price { get; set; }
        public string marketName { get; set; }

    }
}
