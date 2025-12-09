using Accessibility;

using Studentska.Data;
using Studentska.Servis;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
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

        private Student _student;

        public frmStudentiAddEdit(Student? odabraniStudent = null)
        {
            InitializeComponent();
            _student = odabraniStudent ?? new Student();
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

            if (_student.Id > 0)
                UcitajPodatkeOStudentu();
            else
            {
                UcitajBrojIndeksa();
                UcitajLozinku();
            }
        }

        private void UcitajPodatkeOStudentu()
        {
             txtIme.Text = _student.Ime;
            txtPrezime.Text = _student.Prezime;
            cmbSpol.SelectedValue = _student.SpolId;
            txtIndeks.Text = _student.Indeks;
            txtLozinka.Text = _student.Lozinka;
            cmbDrzave.SelectedValue = _student.Grad.DrzavaId;
            cmbGrad.SelectedValue = _student.GradId;
            pbSlika.Image = _student.Slika;
            cbAktivan.Checked = _student.Aktivan;
            dtpDatumRodjenja.Value = _student.DatumRodjenja;            
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
            cmbDrzave.UcitajPodatke(_drzavaServis.GetAll());
        }

        private void UcitajSpolove()
        {
            cmbSpol.UcitajPodatke(_spolServis.GetAll());
        }

        private void UcitajGradove(int drzavaId)
        {
            cmbGrad.UcitajPodatke(_gradServis.GetByDrzavaId(drzavaId));
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
                var spol = cmbSpol.SelectedItem as Spol;
                var grad = cmbGrad.SelectedItem as Grad;
                var drzava = cmbDrzave.SelectedItem as Drzava;

                try
                {
                    _student.Ime = txtIme.Text;
                    _student.Prezime = txtPrezime.Text;
                    _student.SpolId = spol.Id;
                    _student.Spol = spol;
                    _student.Indeks = txtIndeks.Text;
                    _student.Lozinka = txtLozinka.Text;
                    _student.GradId = grad.Id;
                    _student.Grad = grad;
                    _student.Slika = pbSlika.Image;
                    _student.Aktivan = cbAktivan.Checked;
                    _student.DatumRodjenja = dtpDatumRodjenja.Value;

                    if (_student.Id == 0)
                        _studentServis.Add(_student);                   

                    MessageBox.Show(Resursi.Get(Kljucevi.UserSuccessfullyAdded), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
                Validator.ValidanUnos(pbSlika, err, Resursi.Get(Kljucevi.UserNameRequired));
        }

    }


    public static class Ekstenzije
    {
        public static void UcitajPodatke<T>(this ComboBox cmb, List<T> dataSource,
            string valueMember = "Id", string displayMember = "Naziv")
        {
            cmb.DataSource = dataSource;
            cmb.DisplayMember = displayMember;
            cmb.ValueMember = valueMember;
        }
    }


    public class Generator
    {
        public static string GenerisiIndeks()
        {
            return $"IB{((DateTime.Now.Year - 2000) * 10000) + new StudentServis().GetBrojStudenata() + 1}";
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
