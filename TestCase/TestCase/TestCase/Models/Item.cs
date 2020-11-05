using System;

namespace TestCase.Models
{
    public class Item
    {
        public int ItemCode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string CustomerDescription { get; set; }
        public bool SalesItem { get; set; }
        public bool StockItem { get; set; }
        public bool PurchasedItem { get; set; }
        public string Barcode { get; set; }
        public enum ManagedBy { None = 1, Serial = 2, Batch = 3 }
        public double MinimumInventory { get; set; }
        public double MaximumInventory { get; set; }
        public string Remarks { get; set; }
        public string ImagePath { get; set; }


    }
}