using Studentska.Data;
using Studentska.Servis;
using Studentska.WinApp.Helpers;

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
    public partial class frmStudentiPredmeti : Form
    {

        PredmetServis predmetServis = new PredmetServis();
        PolozeniPredmetServis polozeniPredmetServis = new PolozeniPredmetServis();
        private Student _student;        

        public frmStudentiPredmeti(Student odabraniStudent)
        {
            InitializeComponent();
            _student = odabraniStudent;
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajSvePredemte();
                UcitajPolozenePredmete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greska -> {ex.Message}");
            }
        }

        private void UcitajPolozenePredmete()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = polozeniPredmetServis.GetByStudentId(_student.Id);
        }

        private void UcitajSvePredemte()
        {
            cmbPredmet.UcitajPodatke(predmetServis.GetAll());
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var predmet = cmbPredmet.SelectedItem as Predmet;

                var noviPolozeni = new PolozeniPredmet()
                {                    
                    PredmetId = predmet.Id,
                    //Predmet = predmet,
                    DatumPolaganja = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjena.Text),          
                    StudentId = _student.Id,
                    //Student = _student
                };
                polozeniPredmetServis.Add(noviPolozeni);
                UcitajPolozenePredmete();
            }
        }

        private bool ValidanUnos()
        {
            return true;
        }
    }
}
