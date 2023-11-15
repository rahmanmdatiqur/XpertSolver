using System.ComponentModel.DataAnnotations;

namespace XpertAssesment.Models
{
    public class User
    {

        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ProfileName { get; set; }
        public DateTime DateOfbirth { get; set; }
        public int followedUserId { get; set; }
       
    }
}
