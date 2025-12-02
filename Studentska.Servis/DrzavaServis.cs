using Studentska.Data;

namespace Studentska.Servis
{
    public class DrzavaServis //
    {        
        public List<Drzava> GetAll()
        {
            return InMemoryDb.tblDrzave;
        }
        //public Drzava? GetByNaziv(string nazivDrzave)
        public List<Drzava> GetByNaziv(string nazivDrzave)
        {
            //return InMemoryDb.tblDrzave.Find(drzava => drzava.Naziv== nazivDrzave);
            return InMemoryDb.tblDrzave.Where(drzava => drzava.Naziv.Contains(nazivDrzave)).ToList();
        }

        public Drzava Add(Drzava novaDrzava)//create
        {
            novaDrzava.Id = InMemoryDb.tblDrzave.Count + 1;//4
            InMemoryDb.tblDrzave.Add(novaDrzava);
            return novaDrzava;
        }

        public Drzava? GetById(int id)
        {
            return InMemoryDb.tblDrzave.Find(drzava=> drzava.Id == id);
        }
    }
}
