using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double PriceNetto { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
        public Guid TaxStageID { get; set; }
        public Guid UnitID { get; set; }
        public int Amount { get; set; }
    }

    public enum Controller
    {
        categories,
        clients,
        products,
        invoicesells,
        invoicebuys,
        login,
        units,
        taxstages
    }
}
