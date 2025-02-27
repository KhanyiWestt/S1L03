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

            people.Add(new Models.PersonModel { FirstName = "Name 1", LastName = "Surname 1", Age = 1, IsAlive = true });
            people.Add(new Models.PersonModel { FirstName = "Name 2", LastName = "Surname 2", Age = 2, IsAlive = false });
            people.Add(new Models.PersonModel { FirstName = "Name 3", LastName = "Surname 3", Age = 3, IsAlive = true });
            people.Add(new Models.PersonModel { FirstName = "Name 4", LastName = "Surname 4", Age = 4, IsAlive = false });
            people.Add(new Models.PersonModel { FirstName = "Name 5", LastName = "Surname 5", Age = 5, IsAlive = true });

            return View(people);

        }
 
    }
}