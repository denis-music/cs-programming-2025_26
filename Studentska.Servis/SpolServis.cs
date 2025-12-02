using Studentska.Data;

namespace Studentska.Servis
{
    public class SpolServis 
    {        
        public List<Spol> GetAll()
        {
            return InMemoryDb.tblSpolovi;
        }
        public Spol Add(Spol noviSpol)//create
        {
            noviSpol.Id = InMemoryDb.tblSpolovi.Count + 1;//4
            InMemoryDb.tblSpolovi.Add(noviSpol);
            return noviSpol;
        }       
        public Spol? GetById(int id)
        {
            return InMemoryDb.tblSpolovi.Find(spol => spol.Id == id);
        }
    }
}
