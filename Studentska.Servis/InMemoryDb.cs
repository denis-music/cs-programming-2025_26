using Studentska.Data;

namespace Studentska.Servis
{
    public class InMemoryDb
    {
        public static List<Korisnik> tblKorisnici = GenerisiKorisnike();
        public static List<Student> tblStudenti = GenerisiStudente();

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
            new Student(150001, "Ime1", "Prezime1", true) {Id=1, Semestar=1 },
            new Student(150002, "Ime2", "Prezime2", true) {Id=2, Semestar=2 },
            new Student(150003, "Ime3", "Prezime3", false){Id=3, Semestar=3 },
        };
        }
    }
}
