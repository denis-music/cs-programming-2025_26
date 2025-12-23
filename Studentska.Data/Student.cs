using System.Drawing;

namespace Studentska.Data
{

    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Semestar { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int SpolId{ get; set; }
        public Spol Spol { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public bool Aktivan { get; set; }
        public byte[] Slika { get; set; }

        public Student()
        {
            //Indeks = indeks.ToString();
            //Ime = ime;
            //Prezime = prezime;
            //Aktivan = aktivan;
        }

        public string GetInfo()
        {
            return $"{Id} {Indeks} {Ime} {Prezime}";
        }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime} {Semestar} {Aktivan}";
        }
    }

    public struct sStudent
    {
        public int Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Semestar { get; set; }
        public bool Aktivan { get; set; }

        public sStudent(int indeks = 0, string ime = "", string prezime = "", bool aktivan = true)
        {
            Indeks = indeks;
            Ime = ime;
            Prezime = prezime;
            Aktivan = aktivan;
        }

        public string GetInfo()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }

        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime} {Semestar} {Aktivan}";
        }



    }
}
