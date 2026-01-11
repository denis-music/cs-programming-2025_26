using ClosedXML.Excel;

using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
using static Studentska.WinApp.Izvjestaji.dsIzvjestaji;
using System.Net.NetworkInformation;


namespace Studentska.WinApp.Asinhrono
{
    public partial class frmProvjeraDostupnosti : Form
    {

        StudentServis studentServis = new StudentServis();

        public frmProvjeraDostupnosti()
        {
            InitializeComponent();
        }

        //public async void GetNaredniHost()

        public async Task<string> GetNaredniHost()
        {
            await Task.Run(() => ProvjeriDostupnost("www.amazon.com", 30));
            return "www.klix.ba";
        }
        private async void btnPing_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                var adresa = cmbHost.Text;
                var brojPonavljanja = int.Parse(cmbBrojZahtjeva.Text);

                await Task.Run(() => ProvjeriDostupnost("www.amazon.com", brojPonavljanja));//5s

                var naredniHost = await GetNaredniHost();
                await Task.Run(() => ProvjeriDostupnost(naredniHost, brojPonavljanja));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ProvjeriDostupnost(string adresa, int brojPonavljanja)
        {
            var ping = new Ping();
            for (int i = 0; i < brojPonavljanja; i++)
            {
                var odgovor = ping.Send(adresa);
                BeginInvoke(() => PrikaziDetalje(odgovor));
                Thread.Sleep(100);
            }
        }
        public int Brojac { get; set; }

        private void PrikaziDetalje(PingReply odgovor)
        {
            txtIspis.AppendText($"{++Brojac}. {odgovor.Address}\t{odgovor.Status}\t{odgovor.RoundtripTime}ms{Environment.NewLine}");
        }
        private void btnUcitajPodatke_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                    Task.Run(() => UcitajStudentskePodatke(ofd.FileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajStudentskePodatke(string fileName)
        {
            var studentiIzExcela = UcitajStudenteIzExcela(fileName);
            var slika = studentServis.GetById(1).Slika;

            foreach (var red in studentiIzExcela)
            {
                var noviStudent = new Student()
                {
                    Prezime = red.Prezime,
                    Ime = red.Ime,
                    Indeks = red.Indeks,
                    Aktivan = true,
                    DatumRodjenja = DateTime.Now,
                    GradId = 1,
                    SpolId = 1,
                    Lozinka = "test",
                    Semestar = 1,
                    Slika = slika
                };
                studentServis.Add(noviStudent);
                Thread.Sleep(50);
                BeginInvoke(() => PrikaziDetalje(noviStudent));
            }
        }

        private void PrikaziDetalje(Student noviStudent)
        {
            txtIspis.AppendText($"{++Brojac}. {noviStudent.Indeks}\t{noviStudent.Ime}\t{noviStudent.Prezime}{Environment.NewLine}");
        }

        private StudentiDataTable UcitajStudenteIzExcela(string fileName)
        {
            var excelFajl = new XLWorkbook(fileName);
            var prviSheet = excelFajl.Worksheet(1);

            var tblStudenti = new StudentiDataTable();

            foreach (var redExcel in prviSheet.RowsUsed())
            {
                var redStudenti = tblStudenti.NewStudentiRow();
                redStudenti.Indeks = redExcel.Cell(1).GetString();
                redStudenti.Ime = redExcel.Cell(2).GetString();
                redStudenti.Prezime = redExcel.Cell(3).GetString();
                tblStudenti.AddStudentiRow(redStudenti);
            }
            return tblStudenti;
        }
    }
}
