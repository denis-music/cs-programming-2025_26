using Studentska.Data;

namespace Studentska.Servis
{
    public class GradServis 
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<Grad> GetAll()
        {
            return _dbContext.Gradovi.ToList();
        }
        public List<Grad> GetByNaziv(string nazivGrada)
        {
            return _dbContext.Gradovi.Where(grad => grad.Naziv.Contains(nazivGrada)).ToList();
        }

        public Grad Add(Grad noviGrad)//create
        {
           // noviGrad.Id = _dbContext.Gradovi.Count + 1;//4
            _dbContext.Gradovi.Add(noviGrad);
            return noviGrad;
        }
        public List<Grad> GetByDrzavaId(int drzavaId)
        {
            return _dbContext.Gradovi.Where(grad => grad.DrzavaId == drzavaId).ToList();
        }
        public Grad? GetById(int id)
        {
            return _dbContext.Gradovi.Find(id);
        }
    }
}
