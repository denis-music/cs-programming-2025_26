namespace Studentska.Data
{
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }

        public Korisnik(string ime = "", string prezime = "", string korisnickoIme = "", string lozinka= "", bool aktivan = true)
        {
            Ime = ime;
            Prezime = prezime;
            Aktivan = aktivan;
            KorisnickoIme = korisnickoIme;
            Lozinka = lozinka;
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime} ({KorisnickoIme} - {Aktivan})";
        }
    }
}
