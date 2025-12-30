using Microsoft.EntityFrameworkCore;

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


    public abstract class BaseServis<T> where T : class
    {
        protected StudentskaDbContext _dbContext = new StudentskaDbContext();

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }       

        public void Add(T obj)
        {
            _dbContext.Set<T>().Add(obj);
            _dbContext.SaveChanges();
        }

        public T? GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }
    }
    public class AkademskaGodinaServis : BaseServis<AkademskaGodina>
    {

    }
    public class VrstaUplateServis : BaseServis<VrstaUplate>
    {

    }
    public class StudentUplataServis : BaseServis<StudentUplata>
    {

        public List<StudentUplata> GetByStudentId(int studentId)
        {
            return _dbContext.StudentiUplate.Include(s=>s.AkademskaGodina).Include(s=>s.VrstaUplate).Where(su => su.StudentId == studentId).ToList();
        }

    }



}
