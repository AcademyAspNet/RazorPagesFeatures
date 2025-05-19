using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesFeatures.Pages
{
    public class SimpleFormModel : PageModel
    {
        private readonly ILogger<SimpleFormModel> _logger;

        public SimpleFormModel(ILogger<SimpleFormModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        [BindProperty]
        public string? Login { get; set; }

        [BindProperty]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [BindProperty]
        public string? Color { get; set; }

        public bool IsPost { get; private set; } = false;

        public void OnPost()
        {
            IsPost = true;

            //return RedirectToPage("Index");
        }

        public void OnPostAnother()
        {
            Login = "Another " + Request.Form["login"];
            Password = "Another " + Request.Form["password"];
            Color = Request.Form["color"];

            IsPost = true;
        }
    }
}
