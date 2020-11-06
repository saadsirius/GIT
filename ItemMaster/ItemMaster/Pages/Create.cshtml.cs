using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ItemMaster.Data;
using ItemMaster.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ItemMaster.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ItemMaster.Data.ItemMasterContext _context;

        public CreateModel(ItemMaster.Data.ItemMasterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Item Item { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Item.Add(Item);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private IHostingEnvironment ihostingEnvironment;

        public string FilePath { get; set; }


   

        public void OnPost(IFormFile photo)
        {
            var path = Path.Combine(ihostingEnvironment.WebRootPath, "images", photo.FileName);
            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream);
            FilePath = photo.FileName;
        }
    }
}
