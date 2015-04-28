namespace WebApiProject.Models
{
    using System.Data.Entity;

    public class VideoDb : DbContext
    {
        public DbSet<Video> Videos { get; set; }        
    }
}