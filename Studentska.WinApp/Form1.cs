using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Studentska.Data;
using Studentska.Servis;

using System.Dynamic;
using System.Text.Json.Serialization;

namespace Studentska.WinApp
{
    public partial class Form1 : Form
    {

        StudentServis db = new StudentServis();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //DinamickiTipovi();
            Linq();
        }

        private void Linq()
        {
            /*             
            SELECT first_name, age
            FROM Customers
            WHERE age = 22
             */
            var bodovi = new List<int>(){ 65, 75, 85, 90, 45, 55, 100, 40, 70 };

            var poloziliIspit = (from bod in bodovi
                                 where bod >= 65
                                 select bod).ToList();

            var studetniSaPrvimSlovomA = (from student in db.GetAll()
                                          where student.Ime.StartsWith("A")
                                          select student).ToList();


        }

        private async void DinamickiTipovi()
        {
            object studentData = db.GetAll();

            //object denis = new Student();
            //denis.PrijaviIspit();

            //var amra = new Student();
            //amra.PrijaviIspit();

            dynamic npp = new ExpandoObject();
            npp.Naziv = "Nastavni plani i program 2025";
            npp.BrojStranica = 120;
            npp.Autor = "Amra Amic";
            npp.Stranic = new List<HtmlDocument>();
            // MessageBox.Show(npp.Naziv.ToString());

            //string json = @"{
            //       'Naziv':'Nastavni plani i program 2025',
            //       'BrojStranica':'120',
            //       'Autor':'Amra Amic'
            //}";

            //dynamic nppFromJson = JsonConvert.DeserializeObject(json);
            ////MessageBox.Show(nppFromJson.Naziv.ToString());

            string adresaAPI = "https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m";
            var httpClient = new HttpClient();
            var odgovor = await httpClient.GetAsync(adresaAPI);

            var json = await odgovor.Content.ReadAsStringAsync();
            //dynamic rezultat = JsonConvert.DeserializeObject(json);
            //MessageBox.Show($"{rezultat.hourly.temperature_2m[0].ToString()} -> " +
            //    $"{rezultat.hourly.time[0].ToString()}");


            var rezultat = JsonConvert.DeserializeObject<Root>(json);
            MessageBox.Show($"{rezultat.hourly.time[0].ToString()}-> " +
                $"{rezultat.hourly.temperature_2m[0].ToString()}");
        }
    }


    public class Hourly
    {
        public List<string> time { get; set; }
        public List<double> temperature_2m { get; set; }
    }

    public class HourlyUnits
    {
        public string time { get; set; }
        public string temperature_2m { get; set; }
    }

    public class Root
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public double generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezone_abbreviation { get; set; }
        public double elevation { get; set; }
        public HourlyUnits hourly_units { get; set; }
        public Hourly hourly { get; set; }
    }

}
