using System.ComponentModel.DataAnnotations; // Add to project
//Ensure that CodeLens is activated
//Select >> Tools >> Options >> Text Editor >> All Languages >> CodeLens
namespace S1L03.Models
{
    public class PersonModel
    {
        //Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"

        [Required(ErrorMessage = "Student Number is required")]

        [Display(Name = "Student Number")] //Add as decorator
        public string StudentNumber { get; set; } 

        [Display(Name = "Name")] //Add as decorator
        public string Name { get; set; }
        
        [Display(Name = "Surname")] //Add as decorator
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [Display(Name = "Email Address")] //Add as decorator
        // [Required(ErrorMessage = "Name is mandatory")]=> Example of manditory decorator
        public string EmailAddress{ get; set; }

        [Display(Name = "Link to personal page")]
        public string myLink { get; set; }//Adding myLink property of type string
    }
}