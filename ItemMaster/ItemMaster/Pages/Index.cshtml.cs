using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ItemMaster.Data;
using ItemMaster.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ItemMaster.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ItemMaster.Data.ItemMasterContext _context;

        public IndexModel(ItemMaster.Data.ItemMasterContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList ItemCodes { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Description { get; set; }
        public async Task OnGetAsync()
        {
            Item = await _context.Item.ToListAsync();
        }
    }
}
