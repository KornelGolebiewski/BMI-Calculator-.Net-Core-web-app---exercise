using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS03.Models;

namespace PS03.Pages
{
    public class TestModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Person person { get; set; }
        public void OnGet()
        {
        }
    }
}
