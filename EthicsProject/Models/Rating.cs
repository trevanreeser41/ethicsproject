using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EthicsProject.Models
{
    [Table("Rating")]
    public class Rating
    {
        [Key]
        public int rating_id { get; set; }
        public bool ethical { get; set; }
        public bool skillful { get; set; }
        public int MyProperty { get; set; }
        public virtual ApplicationUser User { get; set; } // User
        public Response response { get; set; }
    }
}