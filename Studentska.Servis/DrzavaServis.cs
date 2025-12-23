using Studentska.Data;

namespace Studentska.Servis
{

    public class DrzavaServis //
    {

        StudentskaDbContext _dbContext = new StudentskaDbContext();


        public List<Drzava> GetAll()
        {
            return _dbContext.Drzave.ToList();
        }
        //public Drzava? GetByNaziv(string nazivDrzave)
        public List<Drzava> GetByNaziv(string nazivDrzave)
        {
            //return InMemoryDb.tblDrzave.Find(drzava => drzava.Naziv== nazivDrzave);
            return _dbContext.Drzave.Where(drzava => drzava.Naziv.Contains(nazivDrzave)).ToList();
        }

        public Drzava Add(Drzava novaDrzava)//create
        {
            //novaDrzava.Id = InMemoryDb.tblDrzave.Count + 1;//4
            _dbContext.Drzave.Add(novaDrzava);
            _dbContext.SaveChanges();
            return novaDrzava;
        }

        public Drzava? GetById(int id)
        {
            return _dbContext.Drzave.Find(id);
        }
    }
}
