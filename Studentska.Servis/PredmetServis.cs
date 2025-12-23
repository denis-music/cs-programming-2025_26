using Studentska.Data;

namespace Studentska.Servis
{
    public class PredmetServis //
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<Predmet> GetAll()
        {
            return _dbContext.Predmeti.ToList();
        }
        public List<Predmet> GetByNaziv(string nazivPredmeta)
        {
            return _dbContext.Predmeti.Where(predmet => predmet.Naziv.Contains(nazivPredmeta)).ToList();
        }

        public Predmet Add(Predmet noviPredmet)
        {
            //noviPredmet.Id = _dbContext.Predmeti.Count + 1;//4
            _dbContext.Predmeti.Add(noviPredmet);
            _dbContext.SaveChanges();
            return noviPredmet;
        }

        public Predmet? GetById(int id)
        {
            return _dbContext.Predmeti.Find(id);
        }
    }
}
