using Studentska.Data;

namespace Studentska.Servis
{
    public class GradServis : BaseServis<Grad>
    {        
        public List<Grad> GetByNaziv(string nazivGrada)
        {
            return _dbContext.Gradovi.Where(grad => grad.Naziv.Contains(nazivGrada)).ToList();
        }

        public List<Grad> GetByDrzavaId(int drzavaId)
        {
            return _dbContext.Gradovi.Where(grad => grad.DrzavaId == drzavaId).ToList();
        }    
    }

    public class UlogaServis
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<Uloga> GetAll()
        {
            return _dbContext.Uloge.ToList();
        }        
    }
}
