using Studentska.Data;
using Studentska.Servis;

namespace Studentska.WinApp
{
    public partial class Form1 : Form
    {

        StudentServis db = new StudentServis();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ispis = "";
            foreach (Student s in db.GetAll())
            {
                ispis += $"{s.ToString()}{Environment.NewLine}";
            }
            MessageBox.Show(ispis);


            Student noviStudent = new Student()
            {
                Indeks = 150100,
                Ime = "Novi",
                Prezime = "Student",
                Aktivan = true,
                Semestar = 1
            };
            db.Add(noviStudent);
            ispis = "";
            foreach (Student s in db.GetAll())
            {
                ispis += $"{s.ToString()}{Environment.NewLine}";
            }
            MessageBox.Show(ispis);


        }
    }
}
