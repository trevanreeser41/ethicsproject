using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EthicsProject.Models
{
    [Table("Prompt")]
    public class Prompt
    {
        [Key]
        public int prompt_id { get; set; }
        public string prompt_text { get; set; }
    }
}