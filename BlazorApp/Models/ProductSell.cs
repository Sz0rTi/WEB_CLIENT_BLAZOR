using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models.Out
{
    public class ProductSell
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public double PricePerItemNetto { get; set; }
        public double PricePerItemBrutto { get; set; }
        public Guid TaxStageID { get; set; }
        public Guid UnitID { get; set; }
    }
}
