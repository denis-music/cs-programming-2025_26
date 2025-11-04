using Studentska.Data;

namespace Studentska.Servis
{
    public class KorisnikServis //CRUD Korisnik
    {
        public Korisnik this[int index] {//indexer operator[]
            get { return InMemoryDb.tblKorisnici[index]; }
            set { InMemoryDb.tblKorisnici[index] = value; }
        }
        public List<Korisnik> GetAll()
        {
            return InMemoryDb.tblKorisnici;
        }
        public Korisnik? GetByKorisnickoIme(string korisnickoIme)
        {
            return InMemoryDb.tblKorisnici.Find(korisnik => korisnik.KorisnickoIme == korisnickoIme);
        }

        public Korisnik Add(Korisnik noviKorisnik)//create
        {
            noviKorisnik.Id = InMemoryDb.tblKorisnici.Count + 1;//4
            InMemoryDb.tblKorisnici.Add(noviKorisnik);
            return noviKorisnik;
        }

        public Korisnik GetByJMBG(string jmbg)
        {
            return null;
        }
    }
}
