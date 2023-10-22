using mentorApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace mentorApi
{
    //control+ noqte
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()//one to many elaqesi qurduq Fl.uent APi
                .HasOne<School>(s => s.School)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.SchoolId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }


    }
}
