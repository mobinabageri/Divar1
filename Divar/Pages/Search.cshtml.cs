using Divar.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace Divar.Pages
{
    public class SearchModel : PageModel
    {
        private readonly DivarContext _context;
        public readonly List<Ad> adment;
        
        public SearchModel(DivarContext context)
        {

            _context = context;
            adment = _context.Ads.ToList();
        }
        public void OnGet()
        {

        }

        public void  OnPost(string search)
        {
            var x=  adment.Where(m => m.Name == search|| m.Discription == search).ToList();
        }



    }



}
