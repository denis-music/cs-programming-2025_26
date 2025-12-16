using Studentska.Data;

namespace Studentska.Servis
{

    public class PredmetServis //
    {
        public List<Predmet> GetAll()
        {
            return InMemoryDb.tblPredmeti;
        }
        public List<Predmet> GetByNaziv(string nazivPredmeta)
        {
            return InMemoryDb.tblPredmeti.Where(predmet => predmet.Naziv.Contains(nazivPredmeta)).ToList();
        }

        public Predmet Add(Predmet noviPredmet)
        {
            noviPredmet.Id = InMemoryDb.tblPredmeti.Count + 1;//4
            InMemoryDb.tblPredmeti.Add(noviPredmet);
            return noviPredmet;
        }

        public Predmet? GetById(int id)
        {
            return InMemoryDb.tblPredmeti.Find(predmet => predmet.Id == id);
        }
    }



    public class PolozeniPredmetServis //
    {
        public List<PolozeniPredmet> GetAll()
        {
            return InMemoryDb.tblPolozeniPredmeti;
        }        

        public PolozeniPredmet Add(PolozeniPredmet noviPolozeniPredmet)
        {
            noviPolozeniPredmet.Id = InMemoryDb.tblPolozeniPredmeti.Count + 1;//4
            InMemoryDb.tblPolozeniPredmeti.Add(noviPolozeniPredmet);
            return noviPolozeniPredmet;
        }

        public PolozeniPredmet? GetById(int id)
        {
            return InMemoryDb.tblPolozeniPredmeti.Find(polozeni => polozeni.Id == id);
        }

        public List<PolozeniPredmet> GetByStudentId(int stidentId)
        {
            return InMemoryDb.tblPolozeniPredmeti.Where(polozeni => polozeni.StudentId == stidentId).ToList();
        }
    }

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
