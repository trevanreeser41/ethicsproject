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
        public class homepage_response
        {
            [Key]
            public int homepage_response_id { get; set; }
            public string response_text { get; set; }
            public DateTime time_submitted { get; set; }
        }

        public class homepage_rating
        {
            [Key]
            public int homepage_rating_id { get; set; }
            public bool ethical { get; set; }
            public bool skillful { get; set; }

            public homepage_response homepage_Response { get; set; }
        }

        public class homepage_prompt
        {
            [Key]
            public int homepage_prompt_id { get; set; }
            public string prompt_text { get; set; }
        }
        
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}