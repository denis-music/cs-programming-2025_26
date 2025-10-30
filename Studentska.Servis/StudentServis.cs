using Studentska.Data;

namespace Studentska.Servis
{
    public class StudentServis //CRUD Student
    {
        List<Student> tblStudenti = new List<Student>()
        {
            new Student(150001, "Ime1", "Prezime1", true) {Id=1, Semestar=1 },
            new Student(150002, "Ime2", "Prezime2", true) {Id=2, Semestar=2 },
            new Student(150003, "Ime3", "Prezime3", false){Id=3, Semestar=3 },
        };
        public Student this[int index] {//indexer operator[]
            get { return tblStudenti[index]; }
            set { tblStudenti[index] = value; }
        }
        public List<Student> GetAll()
        {
            return tblStudenti;
        }
        public Student? GetByIndeks(int indeks)
        {
            return tblStudenti.Find(student => student.Indeks == indeks);
        }

        public Student Add(Student noviStudent)//create
        {
            noviStudent.Id= tblStudenti.Count + 1;//4
            tblStudenti.Add(noviStudent);
            return noviStudent;
        }

        public Student GetByJMBG(string jmbg)
        {
            return null;
        }
    }
}
