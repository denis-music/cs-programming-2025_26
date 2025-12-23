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
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<PolozeniPredmet> PolozeniPredmeti { get; set; }






    }



    public class InMemoryDb
    {
        public static List<Korisnik> tblKorisnici = GenerisiKorisnike();
        public static List<Student> tblStudenti = GenerisiStudente();
        public static List<Drzava> tblDrzave = GenerisiDrzave();
        public static List<Grad> tblGradovi = GenerisiGradove();  
        public static List<Spol> tblSpolovi = GenerisiSpolove();
        public static List<Predmet> tblPredmeti = GenerisiPredmete();
        public static List<PolozeniPredmet> tblPolozeniPredmeti = new List<PolozeniPredmet>();


        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>()
            {
                new Predmet(){ Id=1, Naziv="Matematika I", Oznaka="MATI", Aktivan=true, Semestar = 1 },
                new Predmet(){ Id=2, Naziv="Matematika II", Oznaka="MATII", Aktivan=true, Semestar = 2 },
                new Predmet(){ Id=3, Naziv="Programiranje I", Oznaka="PRI", Aktivan=true, Semestar = 1 },
            };
        }        

        private static List<Spol> GenerisiSpolove()
        {
            return new List<Spol>()
            {
                new Spol(){ Id=1, Naziv="**********", Aktivan=true },
                new Spol(){ Id=2, Naziv="Muski", Aktivan=true },
                new Spol(){ Id=3, Naziv="Zenski", Aktivan=true }
            };
        }
        private static List<Grad> GenerisiGradove()
        {
            return new List<Grad>()
            {
                new Grad(){ Id=1, Naziv="Sarajevo", Oznaka="SJJ", DrzavaId=1, Aktivan=true },
                new Grad(){ Id=2, Naziv="Beograd", Oznaka="BGD", DrzavaId=2, Aktivan=true },
                new Grad(){ Id=3, Naziv="Zagreb", Oznaka="ZAG", DrzavaId=3, Aktivan=true },
                new Grad(){ Id=4, Naziv="Podgorica", Oznaka="PGC", DrzavaId=4, Aktivan=true },
                new Grad(){ Id=5, Naziv="Banja Luka", Oznaka="BNX", DrzavaId=1, Aktivan=true },
                new Grad(){ Id=6, Naziv="Novi Sad", Oznaka="NSD", DrzavaId=2, Aktivan=true }
            };
        }
        private static List<Drzava> GenerisiDrzave()
        {
            return new List<Drzava>()
            {
                new Drzava(){ Id=1, Naziv="Bosna i Hercegovina", Oznaka="BA", Aktivan=true },
                new Drzava(){ Id=2, Naziv="Srbija", Oznaka="RS", Aktivan=true },
                new Drzava(){ Id=3, Naziv="Hrvatska", Oznaka="HR", Aktivan=true },
                new Drzava(){ Id=4, Naziv="Crna Gora", Oznaka="ME", Aktivan=true }
            };
        }
        private static List<Korisnik> GenerisiKorisnike()
        {
            return new List<Korisnik>()
        {
            new Korisnik("Ime1", "Prezime1",DateTime.Now,null, "korisnik1", "korisnik1",  true) { Id=1 },
            new Korisnik("Ime2", "Prezime2",DateTime.Now,null, "korisnik2", "korisnik2",  true) { Id=2 },
            new Korisnik("Ime3", "Prezime3",DateTime.Now,null, "korisnik3", "korisnik3",  false){ Id=3 },
        };
        }
        private static List<Student> GenerisiStudente()
        {
            return new List<Student>()
        {
            new Student(){ Id = 1,DatumRodjenja = DateTime.Now, Ime="Marko", Prezime="Markovic", Indeks="IB150001", Semestar=3, SpolId=1, GradId=1, Aktivan=true },
            new Student(){ Id = 2,DatumRodjenja = DateTime.Now, Ime="Jelena", Prezime="Jovanovic", Indeks="IB150002", Semestar=5, SpolId=2, GradId=2, Aktivan=true },
            new Student(){ Id = 3,DatumRodjenja = DateTime.Now, Ime="Ivan", Prezime="Ivic", Indeks="IB150003", Semestar=1, SpolId=1, GradId=3, Aktivan=false  },
            new Student(){ Id = 4,DatumRodjenja = DateTime.Now, Ime="Ana", Prezime="Anic", Indeks="IB150004", Semestar=7, SpolId=2, GradId=4, Aktivan=true },
            new Student(){ Id = 5,DatumRodjenja = DateTime.Now, Ime="Petar", Prezime="Petrovic", Indeks="IB150005", Semestar=2, SpolId=1, GradId=5, Aktivan=true },
            new Student(){ Id = 6,DatumRodjenja = DateTime.Now, Ime="Maja", Prezime="Majic", Indeks="IB150006", Semestar=4, SpolId=2, GradId=6, Aktivan=false }

        };
        }
    }
}
