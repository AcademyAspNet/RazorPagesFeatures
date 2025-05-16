using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesFeatures.Pages
{
    public class UserModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int? OrderBy { get; set; }

        //private readonly LinkGenerator _linkGenerator;

        //public UserModel(LinkGenerator linkGenerator)
        //{
        //    _linkGenerator = linkGenerator;
        //}

        //public string PathToHomePage { get; private set; }

        public void OnGet()
        {
            //PathToHomePage = _linkGenerator.GetPathByPage("/Syntax");
        }
    }
}
