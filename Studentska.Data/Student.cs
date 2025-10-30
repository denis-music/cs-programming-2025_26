namespace Studentska.Data
{
    public class Grad { public string Naziv { get; set; } }
    public class Prebivaliste { public Grad Grad { get; set; } }


    public class Student
    {
        public Prebivaliste Prebivaliste { get; set; }

        public int Id { get; set; }
        public int Indeks { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Semestar { get; set; }
        public bool Aktivan { get; set; }        

        public Student(int indeks = 0, string ime = "",string prezime = "", bool aktivan = true)
        {
            Indeks = indeks;
            Ime = ime;
            Prezime = prezime;
            Aktivan = aktivan;
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
