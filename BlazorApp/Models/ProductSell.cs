using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ProductSell
    {
        public Guid ID { get; set; }
        public Guid InvoiceSellID { get; set; }
        public Guid ProductID { get; set; }
        [Range(1.0,100000000.0,ErrorMessage = "Ilość nie może wynosić 0")]
        public int Amount { get; set; }
        [Range(0.01,10000000.0, ErrorMessage = "Cena nie może wynosić 0")]
        public double PricePerItemNetto { get; set; }
        public double PricePerItemBrutto { get; set; }
        public Guid TaxStageID { get; set; }
        public Guid UnitID { get; set; }
    }
}
