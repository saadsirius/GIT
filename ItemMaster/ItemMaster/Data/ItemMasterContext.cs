using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ItemMaster.Models;

namespace ItemMaster.Data
{
    public class ItemMasterContext : DbContext
    {
        public ItemMasterContext (DbContextOptions<ItemMasterContext> options)
            : base(options)
        {
        }

        public DbSet<ItemMaster.Models.Item> Item { get; set; }
    }
}
