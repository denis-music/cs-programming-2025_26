using Accessibility;

using Studentska.Data;
using Studentska.Servis;

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
    public partial class frmStudentiAddEdit : Form
    {
        SpolServis _spolServis = new SpolServis();
        DrzavaServis _drzavaServis = new DrzavaServis();
        GradServis _gradServis = new GradServis();
        StudentServis _studentServis = new StudentServis();

        public frmStudentiAddEdit()
        {
            InitializeComponent();
        }

        private void frmStudentiAddEdit_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPodatke();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajPodatke()
        {
            UcitajSpolove();
            UcitajDrzave();
            UcitajBrojIndeksa();
            UcitajLozinku();
        }

        private void UcitajLozinku()
        {
            txtLozinka.Text = Generator.GenerisiLozinku();
        }

        private void UcitajBrojIndeksa()
        {
            txtIndeks.Text = Generator.GenerisiIndeks();
        }

        private void UcitajDrzave()
        {
            cmbDrzave.DataSource = _drzavaServis.GetAll();
            cmbDrzave.DisplayMember = "Naziv";
            cmbDrzave.ValueMember = "Id";
        }

        private void UcitajSpolove()
        {
            cmbSpol.DataSource = _spolServis.GetAll();
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.ValueMember = "Id";
        }
        private void UcitajGradove(int drzavaId)
        {
            cmbGrad.DataSource = _gradServis.GetByDrzavaId(drzavaId);
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.ValueMember = "Id";
        }

        private void cmbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            var drzava = cmbDrzave.SelectedItem as Drzava;
            UcitajGradove(drzava.Id);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdSlika.FileName);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidanUnos(txtIme, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(txtPrezime, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(cmbSpol, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(txtIndeks, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(txtLozinka, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(cmbGrad, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                Validator.ValidanUnos(pbSlika, err, Resursi.Get(Kljucevi.UserNameRequired)) ;
        }
    }

    public class Generator
    {
        public static string GenerisiIndeks()
        {            
            return $"IB{((DateTime.Now.Year - 2000)*10000)+ new StudentServis().GetBrojStudenata()+1}";
        }
        public static string GenerisiLozinku(int brojZnakova = 10)
        {
            string dozvoljniZnakovi = "abcdefghijkljmnoprstuvzwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            Random rand = new Random();
            StringBuilder lozinka = new StringBuilder();//xQ1!2@abC3
            for (int i = 0; i < brojZnakova; i++)
                lozinka.Append(dozvoljniZnakovi[rand.Next(dozvoljniZnakovi.Length)]);
            return lozinka.ToString();
        }
    }

}
