using System.ComponentModel.DataAnnotations;

namespace XpertAssesment.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }    
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
