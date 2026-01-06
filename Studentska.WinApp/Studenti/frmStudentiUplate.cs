using Studentska.Data;
using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;
using Studentska.WinApp.Izvjestaji;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.Studenti
{
    public partial class frmStudentiUplate : Form
    {
        VrstaUplateServis vrstaUplateServis = new VrstaUplateServis();
        AkademskaGodinaServis akademskaGodinaServis = new AkademskaGodinaServis();
        StudentServis _studentServis = new StudentServis();
        StudentUplataServis _studentUplataServis = new StudentUplataServis();



        Student _student;
        public frmStudentiUplate(int id)
        {
            InitializeComponent();

            _student = _studentServis.GetById(id);
            dgvUplateStudenta.AutoGenerateColumns = false;
        }

        private void frmStudentiUplate_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UcitajPodatke()
        {
            UcitajAkademskeGodine();
            UcitajVrsteUplata();
            UcitajUplateStudenta();
            UcitajPodatkeOStudentu();
        }

        private void UcitajPodatkeOStudentu()
        {
            pbSlika.Image = ImageHelper.ByteToImage(_student.Slika);
            lblImePrezime.Text = _student.Ime + " " + _student.Prezime;
            lblIndeks.Text = _student.Indeks;
        }

        private void UcitajUplateStudenta()
        {
            dgvUplateStudenta.DataSource = null;
            dgvUplateStudenta.DataSource = _studentUplataServis.GetByStudentId(_student.Id);
        }

        private void UcitajVrsteUplata()
        {
            cmbVrstaUplate.UcitajPodatke(vrstaUplateServis.GetAll());
        }

        private void UcitajAkademskeGodine()
        {
            cmbAkademskaGodina.UcitajPodatke(akademskaGodinaServis.GetAll());
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var novaUplata = new StudentUplata
                {
                    StudentId = _student.Id,
                    VrstaUplateId = (int)cmbVrstaUplate.SelectedValue,
                    AkademskaGodinaId = (int)cmbAkademskaGodina.SelectedValue,
                    Iznos = int.Parse(txtIznos.Text),
                    DatumUplate = dtpDatumUplate.Value
                };
                _studentUplataServis.Add(novaUplata);
                UcitajUplateStudenta();
            }
        }

        private bool ValidanUnos()
        {
            //TODO: Implement validation logic  
            return true;
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var uplate = dgvUplateStudenta.DataSource as List<StudentUplata>;
            var studentUplate = new dtoStudentUplate
            {
                Student = _student,
                Uplate = uplate
            };
            var frmIzvjestaj = new frmIzvjestaji(studentUplate);
            frmIzvjestaj.ShowDialog();
        }

        public class dtoStudentUplate
        {
            public Student Student { get; set; }
            public List<StudentUplata> Uplate { get; set; }
            }
    }
}
