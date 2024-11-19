using Divar.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divar.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly DivarContext _context;

        public  List<City> Cities;

        public  readonly List<Category> categories;
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger , DivarContext context)
        {
            _logger = logger;
            _context = context;
            categories = _context.Categories.ToList();
            Cities = _context.Cities.ToList();
        }

        public void OnGet()
        {
        }
        public void OnPost(string title ,string body , int category , int city) {

            Ad ad = new Ad();
            ad.Name = title;
            ad.Discription = body;
            ad.CityId = city;
            ad.CategoryId = category;
               _context.Ads.Add(ad);
               _context.SaveChanges();



        }
    }

}
