using Microsoft.EntityFrameworkCore;

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
            UpdateUloga(noviStudent);
            _dbContext.Studenti.Add(noviStudent);
            _dbContext.SaveChanges();
            return noviStudent;
        }

        private void UpdateUloga(Student noviStudent)
        {
            var idUlogaStudent = noviStudent.Uloge.Select(u => u.Id).ToList();//2,4
            noviStudent.Uloge.Clear();
            foreach (var idUloge in idUlogaStudent)
                noviStudent.Uloge.Add(_dbContext.Uloge.Find(idUloge));
        }

        public Student Update(Student noviStudent)//create
        {          
            UpdateUloga(noviStudent);
            _dbContext.SaveChanges();
            return noviStudent;
        }

        public Student GetById(int id)
        {
            return _dbContext.Studenti.Include(s=>s.Uloge).Where(s=>s.Id == id).First();
        }
    }
}
