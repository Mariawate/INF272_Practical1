using INF272_Practical1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Practical1.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<StudyGroupMember> members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u22749536", Name = "Maria", Surname = "Mbambu", EmailAddress = "u22749536@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24595901", Name = "Petrus", Surname = "Chabedi", EmailAddress = "u24595901@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22557173", Name = "Masilo", Surname = "Makola", EmailAddress = "u22557173@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22761421", Name = "Maria Lynn", Surname = "Vewesse", EmailAddress = "u22761421@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u23578140", Name = "Kopano", Surname = "Moloi", EmailAddress = "u23578140@tuks.co.za" }
            };

            return View(members);
        }
    }
}