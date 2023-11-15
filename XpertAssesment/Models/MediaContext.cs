using Microsoft.EntityFrameworkCore;

namespace XpertAssesment.Models
{
    public class MediaContext:DbContext
    {
        public MediaContext(DbContextOptions<MediaContext> options):base(options) 
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostDetail> PostDetails { get; set; }
        public DbSet<Follower> Followers { get; set; }
    }
}
