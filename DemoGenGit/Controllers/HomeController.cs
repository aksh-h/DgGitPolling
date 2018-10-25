using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoGenGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            string contact = System.IO.File.ReadAllText(Server.MapPath("~") + @"\DgGitPolling\DemoGenGitPolling\Template\Contact.json");
            if (contact != "")
            {
                JObject obj = new JObject();
                obj = JsonConvert.DeserializeObject<JObject>(contact);
                string name = obj["Name"].ToString();
                string company = obj["Company"].ToString();
                ViewBag.Name = name;
                ViewBag.Company = company;
            }
            return View();
        }
    }
}
