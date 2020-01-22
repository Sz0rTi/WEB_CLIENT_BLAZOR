using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class SummaryProductBuy
    {
        public Guid ID { get; set; }
        public Guid SummaryID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public double AvgBuyPrice { get; set; }
        public double SumBought { get; set; }
        public string UserID { get; set; }
    }
}
