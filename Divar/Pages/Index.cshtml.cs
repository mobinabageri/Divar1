using Divar.Db;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Divar.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DivarContext _context;
        public readonly List<Ad> adment;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, DivarContext context)
        {
            _logger = logger;
            _context = context;
            adment = _context.Ads.ToList();
        }

        public void OnGet()
        {

        }
    }
}
