using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace XpertAssesment.Models
{
    public class PostDetail
    {

        [Key]
        public int PostDetailId { get; set; }
        [ForeignKey("Post_tbl")]
        public int PostId { get; set; }
        public string MediaFile { get; set; }
    }
}
