using System.Collections.Generic;
using System.Web.Mvc;


namespace S1L03.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StudentNumber = "u24719872", Name = "Khanyisile", Surname ="Mazibuko", EmailAddress = "u24719872@tuks.co.za", myLink="~/Html/Khanyi.html"});//~/content/...used to access static files
            people.Add(new Models.PersonModel { StudentNumber = "u22585762", Name = "Ashleigh", Surname = "Hullet", EmailAddress = "u2258762@tuks.co.za" , myLink="~/Html/Ashleigh.html"});
            people.Add(new Models.PersonModel { StudentNumber = "u24652777", Name = "Unathi", Surname = "Ledweba", EmailAddress= "u24652777@tuks.co.za", myLink="~/Html/Unathi.html"});
            people.Add(new Models.PersonModel { StudentNumber = "u24687406", Name = "Ntsika", Surname= "Makama", EmailAddress = "u24687406@tuks.co.za", myLink="~/Html/Ntsika.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u24829839", Name = "Lesedi", Surname = "Magondo", EmailAddress = "u24829839@tuks.co.za", myLink="~/Html/Lesedi.html"});

            return View(people);

        }
 
    }
}