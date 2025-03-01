using INF272_Practical1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Practical1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            List<MyClass> members = new List<MyClass>
            {
                new MyClass{ StudentNumber = 12345678, Name = "Maria", Surname = "Mbambu", EmailAddress = "maria.mbambu@tuks.co.za" },
                new MyClass { StudentNumber = 23456789, Name = "John", Surname = "Smith", EmailAddress = "john.smith@tuks.co.za" },
                new MyClass { StudentNumber = 34567890, Name = "Emily", Surname = "Jones", EmailAddress = "emily.jones@tuks.co.za" },
                new MyClass { StudentNumber = 45678901, Name = "Liam", Surname = "Brown", EmailAddress = "liam.brown@tuks.co.za" },
                new MyClass { StudentNumber = 56789012, Name = "Sophia", Surname = "Williams", EmailAddress = "sophia.williams@tuks.co.za" }
            };

            return View(members);
        }
    }
}