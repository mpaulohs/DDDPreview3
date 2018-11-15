using Microsoft.EntityFrameworkCore;

namespace ReverseEngineeringDatabase.Data.Models
{
    public partial class RevEngDbContext : DbContext
    {
        public RevEngDbContext()
        {
        }

        public RevEngDbContext(DbContextOptions<RevEngDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
///#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SQL5040.site4now.net;Initial Catalog=DB_A417B1_swaggermph;User Id=DB_A417B1_swaggermph_admin;Password=florida#09;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-preview3-35497");

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });
        }
    }
}
