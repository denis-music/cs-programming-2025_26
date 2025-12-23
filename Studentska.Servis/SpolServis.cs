using Studentska.Data;

namespace Studentska.Servis
{
    public class SpolServis 
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<Spol> GetAll()
        {
            return _dbContext.Spolovi.ToList();
        }
        public Spol Add(Spol noviSpol)//create
        {
            //noviSpol.Id = _dbContext.Spolovi.Count + 1;//4
            _dbContext.Spolovi.Add(noviSpol);
            return noviSpol;
        }       
        public Spol? GetById(int id)
        {
            return _dbContext.Spolovi.Find(id);
        }
    }
}
