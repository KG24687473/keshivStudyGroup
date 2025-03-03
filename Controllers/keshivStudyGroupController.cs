using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using keshivStudyGroup.Models;

namespace keshivStudyGroup.Controllers
{
    public class keshivStudyGroupController : Controller
    {
        public ActionResult Index()
        {
            List<keshivStudyGroupParticipant> members = new List<keshivStudyGroupParticipant>
            {
                new keshivStudyGroupParticipant { StudentID = "u24687473", Name = "Keshiv", Surname = "Gounden", StudentEmail = "u24687473@tuks.co.za" },
                new keshivStudyGroupParticipant { StudentID = "u23738929", Name = "Modiri", Surname = "Thobane", StudentEmail = "u23738929@tuks.co.za" },
                new keshivStudyGroupParticipant { StudentID = "u20417200", Name = "Naqeeb", Surname = "Hussain Dawood", StudentEmail = "u20417200@tuks.co.za" },
                new keshivStudyGroupParticipant { StudentID = "u24647323", Name = "Dian", Surname = "Erasmus", StudentEmail = "u24647323@tuks.co.za" },
                new keshivStudyGroupParticipant { StudentID = "u22578642", Name = "Nicola", Surname = "James", StudentEmail = "u22578642@tuks.co.za" }
            };

            return View(members);
        }
    }
}