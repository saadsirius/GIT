using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItemMaster.Models
{
    public class Item
    {
        [Key]
        public string ID { get; set; }
        public string ItemCodeID { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string CustomerDescription { get; set; }
        public bool SalesItem { get; set; }
        public bool StockItem { get; set; }
        public bool PurchasedItem { get; set; }
        public string Barcode { get; set; }
        [EnumDataType(typeof(ManagedItem))]
        public ManagedItem ManageItemBy { get; set; }
        public enum ManagedItem { None = 1, Serial = 2, Batch = 3 }
        public decimal MinimumInventory { get; set; }
        public decimal MaximumInventory { get; set; }
        public string Remarks { get; set; }
        public string ImagePath { get; set; }

    }
}
