using Studentska.Data.Entiteti;

namespace Studentska.Servis.Servisi
{
    public class UlogaServis
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<Uloga> GetAll()
        {
            return _dbContext.Uloge.ToList();
        }        
    }
}
