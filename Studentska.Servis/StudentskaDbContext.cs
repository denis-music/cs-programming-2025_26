using Microsoft.EntityFrameworkCore;

using Studentska.Data;

using System.Configuration;

namespace Studentska.Servis
{
    public class StudentskaDbContext : DbContext
    {
        //Server=192.168.8.8\SQL2025;Database=Studentska;User Id=dbUser;Password=Test1326;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite(ConfigurationManager.ConnectionStrings["StudentskaDb"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Uloge)
                .WithMany(u => u.Studenti)
                .UsingEntity(t => t.ToTable("StudentiUloge"));
        }

        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public DbSet<Uloga> Uloge { get; set; }
        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<VrstaUplate> VrsteUplata { get; set; }
        public DbSet<StudentUplata> StudentiUplate { get; set; }







    }
}
