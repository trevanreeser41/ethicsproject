using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EthicsProject.Models
{
    public class DefaultController : Controller
    {
        public class Response
        {
            [Key]
            public int response_id { get; set; }
            public string response_text { get; set; }
            public DateTime time_submitted { get; set; }
        }

        public class Rating
        {
            [Key]
            public int rating_id { get; set; }
            public bool ethical { get; set; }
            public bool skillful { get; set; }
            public int MyProperty { get; set; }
            public LoginViewModel LoginViewModel { get; set; } // User
            public Response response { get; set; }
        }

        public class Prompt
        {
            [Key]
            public int prompt_id { get; set; }
            public string prompt_text { get; set; }
        }
        
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}