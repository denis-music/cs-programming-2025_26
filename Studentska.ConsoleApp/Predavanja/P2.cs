using Studentska.Data;
using Studentska.Servis;

using System.Text;

namespace Studentska.ConsoleApp.Predavanja
{
    public class P2
    {
        static StudentServis db = new StudentServis();
        static ISMS _sms;

        public static void Pokreni(ISMS sms)
        {
            _sms = sms;
            //Infrastrukura();
            //Nullvrijednosti();
            //Var();
            //Imutabilnost();
            Params();
        }

        private static void Params()
        {

            _sms.PosaljiPoruku("061123456", "Pozdrav, prosli put smo radili params!");

            Console.WriteLine($"Suma -> {Sumiraj(new int[]{5, 6, 3, 8, 9})}");
            Console.WriteLine($"Suma -> { Sumiraj(5, 6, 3, 8, 9, 5)}");
           
            string ime = "Denis";
            DateTime danas = DateTime.Now;//21.10.2025

            var ispis = string.Join(", ", danas, 55, ime, "Ana");
            Console.WriteLine(ispis);

        }

        private static int Sumiraj(params int[] niz)
        {
            return niz.Sum();
        }

        private static void Imutabilnost()
        {
            string ime = "Denis";
            ime = ime.ToUpper();//DENIS 
            Console.WriteLine(ime);

            DateTime danas = DateTime.Now;//21.10.2025
            DateTime za5dana = danas.AddDays(5);//26.10.2025
            Console.WriteLine(danas);
            Console.WriteLine(za5dana);
        }

        private static void Var()
        {
            var broj = 5;
            var denis = new Student();

            var lista = db.GetAll();
            Student goran = new();
        }

        private static void Nullvrijednosti()
        {
            Student student = db.GetByIndeks(150001);//vraca null
            //student = Student
            string prezime = student?.Prezime ?? "Nema podataka";
            Console.WriteLine(prezime);

            Student goran = null;
            
            int? broj = null;// 0 ili -1
            Nullable<int> broj2 = null;// 0 ili -1



        }

        private static void Infrastrukura()
        {

            foreach (Student s in db.GetAll())
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n----------------------------------\n");
            Student noviStudent = new Student()
            {
                Indeks = 150100,
                Ime = "Novi",
                Prezime = "Student",
                Aktivan = true,
                Semestar = 1
            };
            db.Add(noviStudent);
            foreach (Student s in db.GetAll())
            {
                Console.WriteLine(s);
            }

        }
    }

    public class AppInfo
    {
        const string NazivAplikacije = "Studentska aplikacija";
        readonly string VerzijaAplikacije;

        public AppInfo(string verzijaAplikacije)
        {
            VerzijaAplikacije = verzijaAplikacije;//CONST
        }
        public override string ToString()
        {            
            return base.ToString();
        }

    }

}