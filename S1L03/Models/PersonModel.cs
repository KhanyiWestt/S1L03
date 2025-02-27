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

        [Display(Name = "First Name")] //Add as decorator
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] //Add as decorator
        public string LastName { get; set; }
        
        [Display(Name = "Current Age")] //Add as decorator
        public int Age { get; set; } = 0;

        [Display(Name = "Living Status")] //Add as decorator
        // [Required(ErrorMessage = "Name is mandatory")]=> Example of manditory decorator
        public bool IsAlive { get; set; } = true;
    }
}