using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PS03.Models
{
    public class Person
    {
        [Required(ErrorMessage = "Field is required")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [MaxLength(15,ErrorMessage="Use up to 15 characters")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [EmailAddress]
        [Display(Name = "E-mail")]
        public string email { get; set; }
        [Range(1, 120, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Age")] 
        public int age { get; set; }
        [Display(Name = "Gender")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Weight")]
        public float weight { get; set; }
        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Height")]
        public float height { get; set; }

        [Required(ErrorMessage = "Field is required")]
        [Display(Name = "Height measure unit")]
        public string unit { get; set; }

        [Display(Name = "BMI")]
        public float bmi { get; set; }

    }
}
