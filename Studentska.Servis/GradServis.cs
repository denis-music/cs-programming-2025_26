using Studentska.Data;

namespace Studentska.Servis
{
    public class GradServis 
    {
        public List<Grad> GetAll()
        {
            return InMemoryDb.tblGradovi;
        }
        public List<Grad> GetByNaziv(string nazivGrada)
        {
            return InMemoryDb.tblGradovi.Where(grad => grad.Naziv.Contains(nazivGrada)).ToList();
        }

        public Grad Add(Grad noviGrad)//create
        {
            noviGrad.Id = InMemoryDb.tblGradovi.Count + 1;//4
            InMemoryDb.tblGradovi.Add(noviGrad);
            return noviGrad;
        }
        public List<Grad> GetByDrzavaId(int drzavaId)
        {
            return InMemoryDb.tblGradovi.Where(grad => grad.DrzavaId == drzavaId).ToList();
        }
        public Grad? GetById(int id)
        {
            return InMemoryDb.tblGradovi.Find(grad => grad.Id == id);
        }
    }
}
