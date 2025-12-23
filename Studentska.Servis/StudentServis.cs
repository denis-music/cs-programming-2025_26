using Studentska.Data;

namespace Studentska.Servis
{
    public class StudentServis //CRUD Student
    {
        StudentskaDbContext _dbContext = new StudentskaDbContext();

        public int GetBrojStudenata() { return _dbContext.Studenti.Count(); }
        public List<Student> GetAll()
        {
            return _dbContext.Studenti.ToList();
        }
        public Student? GetByIndeks(string indeks)
        {
            return _dbContext.Studenti.Where(student => student.Indeks == indeks).First();
        }

        public Student Add(Student noviStudent)//create
        {
            //noviStudent.Id = InMemoryDb.tblStudenti.Count + 1;//4
            _dbContext.Studenti.Add(noviStudent);
            _dbContext.SaveChanges();
            return noviStudent;
        }

        public Student Update(Student noviStudent)//create
        {            
            _dbContext.Studenti.Update(noviStudent);
            _dbContext.SaveChanges();
            return noviStudent;
        }

        public Student GetByJMBG(string jmbg)
        {
            return null;
        }
    }
}
