using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PS03.Models;
namespace PS03.Pages
{
    public class BMICalculatorModel : PageModel
    {
        private readonly ILogger<BMICalculatorModel> _logger;
        public Person person { get; set; }
        public BMICalculatorModel(ILogger<BMICalculatorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost(Person person)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (person.unit == "m")
                person.bmi = person.weight / (person.height * person.height);
            if (person.unit == "cm")
            {
                float x = person.height / 100;
                person.bmi = person.weight / (x * x);
            }

            person.bmi = (float)Math.Round(person.bmi, 1);

            return RedirectToPage("Test",person);
        }
    }
}