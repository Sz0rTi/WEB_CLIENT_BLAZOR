using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models.Out
{
    public class InvoiceSellOut
    {
        public Guid ClientId { get; set; }
        public double PriceNetto { get; set; }
        public DateTime PaymentDeadline { get; set; }
        public bool IsPaid { get; set; }
        public List<ProductSellOut> ProductsSell { get; set; }
    }
}
