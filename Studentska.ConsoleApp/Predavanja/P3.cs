using Studentska.Data;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.ConsoleApp.Predavanja
{
    internal class P3
    {

        static ISMS _sms;
        public static void Pokreni(ISMS sms)
        {
            _sms = sms;
            //Nasljedjivanje();
            //Interfejsi();
            //SmsServis();
            //Enumeracije();
            //TestRef();
            //TestOut();
            TestIn();
        }

        private static void TestIn()
        {
            int broj = 5;
            InicijalizujVarIn(in broj);
            Student student = new Student();
            InicijalizujObjIn(in student);
            
        }

        private static void InicijalizujObjIn(in Student student)
        {
            student.Indeks = 12345;
         //   student = new Student();
        }

        private static void InicijalizujVarIn(in int broj)
        {
            //broj = 10;
        }

        private static void TestOut()
        {
            int broj;
            InicijalizirajOut(out broj);

            //int rezultatParsiranja;//123
            if(int.TryParse("123", out int rezultatParsiranja))
                Console.WriteLine($"Parse uspjesan ->{rezultatParsiranja}");
            
            
            Console.WriteLine(rezultatParsiranja);
        }

        private static void InicijalizirajOut(out int broj)
        {
            broj = 10;
        }

        private static void TestRef()
        {
            int broj=0;
            Uvecaj(ref broj);
            Console.WriteLine(broj);//
            List<int> ints = new List<int>() { 1, 2, 3 };
            Console.WriteLine(ints.Count);
            AlocirajListu(ints);
            Console.WriteLine(ints.Count);
        }

        private static void AlocirajListu(List<int> ints)
        {
            ints[0] = 66;
            //ints = new List<int>() { 14, 24, 34, 44, 54 };
        }

        private static void Uvecaj(ref int broj)
        {
            broj+= 10;
        }

        private static IEnumerable<int> GetOcjene()
        {
            yield return 6;
            yield return 8;
            yield return 9;
            yield return 6;
            yield return 7;
            yield return 10;
        }

        private static void Enumeracije()
        {
            //foreach (var ocjena in GetOcjene())
            //{
            //    Console.WriteLine($"Ocjena: {ocjena}");
            //}
            VanredniStudent denis = new VanredniStudent();

            // 6, 8, 9, 6, 7, 10 
            foreach (var ocjena in denis)
            {
                Console.WriteLine($"Ocjena iz objekta denis: {ocjena}");
            }
        }

        private static void SmsServis()
        {
            _sms.PosaljiPoruku("+38761234567", "Pozdrav iz Studentska aplikacije");
        }

        private static void Interfejsi()
        {
            IStudent dlStudent1 = new DLStudent(54321, "Interface_Ime", "Interface_Prezime");
            dlStudent1.PrijaviIspit("Matematika");

            TestInterfejsa(dlStudent1);
            TestInterfejsa(new DLStudent(54321, "Interface_Ime", "Interface_Prezime"));
            TestInterfejsa(new VanredniStudent());
        }

        private static void TestInterfejsa(IStudent student)
        {
            student.PrijaviIspit("Fizika");
            student.GetPotvrda("za stipendiju");
        }

        private static void Nasljedjivanje()
        {
            //Osoba osoba = new Osoba("Ime", "Prezime");

            Osoba dlStudent = new DLStudent(12345, "Student_Ime", "Student_Prezime");
            Console.WriteLine(dlStudent.Info());
        }
    }

    public class VanredniStudent : IStudent, IEnumerable
    {
        int[] _ocjene = new int[] { 6, 8, 9, 6, 7, 10 };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _ocjene.Length; i++)
                yield return _ocjene[i];
        }

        public string GetPotvrda(string svrha)
        {
            throw new NotImplementedException();
        }
        public bool PrijaviIspit(string predmet)
        {
            throw new NotImplementedException();
        }
    }







    public interface ISMS
    {
        void PosaljiPoruku(string primalac, string poruka);
        bool ProvjeriValidnostBroja(string broj);
    }


    public class DummyTelecomOperator : ISMS
    {
        string _endpoint = "https://api.nasakompaija.ba/sms";
        string _token = "nasInterniToken";
        public bool ProvjeriValidnostBroja(string broj)
        {
            Console.WriteLine($"Broj {broj} je dostupan");
            return true;
        }
        public void PosaljiPoruku(string primalac, string poruka)
        {
            Console.WriteLine($"{primalac} -> {poruka}");
        }
    }


    public class TelecomOperator : ISMS
    {
        string _endpoint = "https://api.telecom.com/sms";
        string _token = "abcdef123456";
        public bool ProvjeriValidnostBroja(string broj)
        {
            Console.WriteLine($"Broj {broj} je dostupan");
            return true;
        }
        public void PosaljiPoruku(string primalac, string poruka)
        {
            Console.WriteLine($"{primalac} -> {poruka}");
        }
    }







    public interface IStudent
    {
        bool PrijaviIspit(string predmet);//predmetId ili ispitId
        string GetPotvrda(string svrha);
    }

  
    public abstract class Osoba
    {
        protected string _Ime { get; set; }
        protected string _Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            _Prezime = prezime;
            _Ime = ime;
        }
        public abstract string Info();
    }
    public class DLStudent : Osoba, IStudent
    {
        int _brojIndeksa;
        public DLStudent(int brojIndeksa, string ime, string prezime) : base(ime, prezime)
        {
            _brojIndeksa = brojIndeksa;
        }

        public string GetPotvrda(string svrha)
        {
            return $"Kreirana vam je potvrda za {svrha}";
        }
        public bool PrijaviIspit(string predmet)
        {
            return true;
        }

        public void PosaljiPoruku(string primalac, string poruka)
        {
            Console.WriteLine($"Poslata poruka {poruka} na {primalac}");
        }

        public override string Info()
        {
            return $"{_brojIndeksa} {_Ime} {_Prezime}";
        }

    }


}
