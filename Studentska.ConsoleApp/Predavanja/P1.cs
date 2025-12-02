using Studentska.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentska.ConsoleApp.Predavanja
{
    public class P1
    {
        static ISMS _sms ;

        public static void Pokreni(ISMS sms)
        {            
            _sms = sms;
            //OsnovniTipoviPodataka();   
            //BazniTip();
            //Records();
            //VrijednostiReference();
            //Info(DateTime.Now);

            _sms.PosaljiPoruku("061123456", "Pozdrav iz P1 klase!");
        }

        private static void VrijednostiReference()
        {
            Student goran1 = new Student(150052, "Goran", "Skondric", true);
            Student goran2 = goran1; 
            goran2.Prezime = "PREZIME";

            sStudent goran3 = new sStudent(150053, "Goran", "Skondric", true);
            sStudent goran4 = goran3;
            goran4.Prezime = "PREZIME";

            Student[] g1 = new Student[3];
            sStudent[] g2 = new sStudent[3];

            for (int i = 0; i < g1.Length; i++)
            {
                g1[i] = new Student();
               // g1[i].Indeks  = 150000 + i;
                g1[i].Ime = "Ime_" + i;
                g1[i].Prezime = "Prezime_" + i;
                g1[i].Aktivan = true;
                g1[i].Semestar = 1 + i;
                Console.WriteLine(g1[i]);
            }
            for (int i = 0; i < g2.Length; i++)
            {
                g2[i].Indeks = 150000 + i;
                g2[i].Ime = "Ime_" + i;
                g2[i].Prezime = "Prezime_" + i;
                g2[i].Aktivan = true;
                g2[i].Semestar = 1 + i;
                Console.WriteLine(g2[i]);

            }




        }

        private static void Records()
        {
            Osoba2 denis = new Osoba2(2, "Denis", "Music");
            var (id, ime, prezime) = denis;
            Console.WriteLine($"{id} {ime} {prezime}");
            Console.WriteLine(denis);
            //Osoba denis2 =denis with { Prezime = "Music2" };
        }

        private static void BazniTip()
        {
            object x = 5; //boxing
            object ime = "Denis";
            Student obj = new Student()
            {
                Prezime = "Music",
                //Indeks = 150051,
                Aktivan = true,
                Semestar = 3,
            };
            Console.WriteLine(obj);
            Console.WriteLine(x);        

        }

        private static void Info(object obj)
        {
            Student student1 = obj as Student;
            if(student1 != null)
            {
                Console.WriteLine(student1.GetInfo());
            }
            else if (obj is DateTime dt)
            {
                Console.WriteLine(dt.ToString("dd.MM.yyyy"));
            }
            else
            {
                Console.WriteLine(obj);
            }

            //Console.WriteLine(s.ToString());
            //if (obj is Student s)
            //{
            //    Console.WriteLine(s.GetInfo());
            //}
            //else if(obj is DateTime dt)
            //{
            //    Console.WriteLine(dt.ToString("dd.MM.yyyy"));
            //}
            //else
            //{
            //    Console.WriteLine(obj);
            //}
        }

        private static void OsnovniTipoviPodataka()
        {
            int godina = 2024;
            int trenutnaGodina = new int();
            if(trenutnaGodina == 0)
            {
                trenutnaGodina = DateTime.Now.Year;
            }


            string ime = "Marko";
            bool aktivan = true;

            string ispis1 = "Godina: " + godina + ", Ime: " + ime + ", Aktivan: " + aktivan;
            string ispis2 = $"Godina: {godina}, Ime: {ime}, Aktivan: {aktivan}";

            Console.WriteLine(ispis1);
            Console.WriteLine(ispis2);

            Student denis = new Student
            {
              //  Indeks = 150051,
                Ime = "Denis",
                Prezime = "Music",
                Semestar = 3,
                Aktivan = true
            };
            Student goran = new Student(150052, "Goran", "Skondric", true);

            Student jasmin = new Student();//objekt ... samo referenca
            jasmin.Ime = "Jasmin";
            jasmin.Prezime = "Mujanovic";            
            jasmin.Semestar = 5;

            






        }
    }

    public record Osoba2(int Id, string Ime, string Prezime);

    public class Osoba1
    {
        public int Id { get; }
        public string Ime { get; }
        public string Prezime { get; }
        public Osoba1(int Id, string Ime, string Prezime)
        {
            this.Id= Id;
            this.Ime= Ime;
            this.Prezime= Prezime;
        }
        override public string ToString()
        {
            return $"{Id} {Ime} {Prezime}";
        }

    }


}
