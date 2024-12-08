using Divar.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace Divar.Pages
{
    public class SearchModel : PageModel
    {
        private readonly DivarContext _context;
        public readonly List<Ad> adment;
        public List<Ad> res;
        public SearchModel(DivarContext context)
        {

            _context = context;
            adment = _context.Ads.ToList();
        }
        public void OnGet(List<Ad> searchresult)
        {
        }

        public void  OnPost(string search)
        {
            string searchres = search.Trim();


            List<Ad> searchresult = _context.Ads.Where(a => a.Name.Contains(searchres) || a.Discription.Contains(searchres)).ToList() ;
            res = (List<Ad>)(ViewData["result"] = searchresult);
        }




    }



}
