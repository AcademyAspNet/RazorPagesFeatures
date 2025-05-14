using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesFeatures.Pages
{
    public class PostModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Year { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Month { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? Day { get; set; }

        public void OnGet()
        {
        }
    }
}
