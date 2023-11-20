
namespace ilkin_zip.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
                
        }
        public DbSet<Food> foods { get; set; }
        public DbSet<Image> images { get; set; }
        
    }
}
