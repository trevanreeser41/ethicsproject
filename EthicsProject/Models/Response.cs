using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EthicsProject.Models
{
    [Table("Response")]
    public class Response
    {
        [Key]
        public int response_id { get; set; }
        public string response_text { get; set; }
        public DateTime time_submitted { get; set; }
        public Prompt prompt { get; set; }
        public Rating rating { get; set; }
    }
}