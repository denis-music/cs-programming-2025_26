using Studentska.Data;

namespace Studentska.Servis
{
    public class StudentServis //CRUD Student
    {
        public Student this[int index] {//indexer operator[]
            get { return InMemoryDb.tblStudenti[index]; }
            set { InMemoryDb.tblStudenti[index] = value; }
        }
        public List<Student> GetAll()
        {
            return InMemoryDb.tblStudenti;
        }
        public Student? GetByIndeks(int indeks)
        {
            return InMemoryDb.tblStudenti.Find(student => student.Indeks == indeks);
        }

        public Student Add(Student noviStudent)//create
        {
            noviStudent.Id = InMemoryDb.tblStudenti.Count + 1;//4
            InMemoryDb.tblStudenti.Add(noviStudent);
            return noviStudent;
        }

        public Student GetByJMBG(string jmbg)
        {
            return null;
        }
    }
}
