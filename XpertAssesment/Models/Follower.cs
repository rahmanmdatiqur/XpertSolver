using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace XpertAssesment.Models
{
    public class Follower
    {
        [Key]
        public int FlId { get; set; }
        public int followingUserId { get; set; }
        [ForeignKey("User_tbl")]
        public int followedUserId { get; set; }
        public string FlName { get; set; }
        public string Comments { get; set; }
    }
}
