using Microsoft.EntityFrameworkCore;

using Studentska.Data;

namespace Studentska.Servis
{

    public class PolozeniPredmetServis //
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();
        public List<PolozeniPredmet> GetAll()
        {
            return _dbContext.PolozeniPredmeti.Include(x=>x.Predmet).ToList();
        }        

        public PolozeniPredmet Add(PolozeniPredmet noviPolozeniPredmet)
        {
            //noviPolozeniPredmet.Id = _dbContext.PolozeniPredmeti.Count + 1;//4
            _dbContext.PolozeniPredmeti.Add(noviPolozeniPredmet);
            _dbContext.SaveChanges();
            return noviPolozeniPredmet;
        }

        public PolozeniPredmet? GetById(int id)
        {
            return _dbContext.PolozeniPredmeti.Find(id);
        }

        public List<PolozeniPredmet> GetByStudentId(int studentId)
        {
            return  _dbContext.PolozeniPredmeti
                    .Include(x=>x.Predmet)
                    .Where(polozeni => polozeni.StudentId == studentId)
                    .ToList();
        }
    }
}
