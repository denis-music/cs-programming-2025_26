using Accessibility;

using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi;
using Studentska.WinApp.Helpers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
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
        UlogaServis _ulogaServis = new UlogaServis();

        private Student _student;

        public frmStudentiAddEdit(int ? id = null)
        {
            InitializeComponent();
            _student = 
                id.HasValue ? _studentServis.GetById(id.Value) :  new Student();
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
            UcitajUloge();

            if (_student.Id > 0)
                UcitajPodatkeOStudentu();
            else
            {
                UcitajBrojIndeksa();
                UcitajLozinku();
            }
        }

        private void UcitajUloge()
        {
            clbUloge.DataSource = _ulogaServis.GetAll();
        }

        private void UcitajPodatkeOStudentu()
        {
            try
            {
                txtIme.Text = _student.Ime;
                txtPrezime.Text = _student.Prezime;
                cmbSpol.SelectedValue = _student.SpolId;
                txtIndeks.Text = _student.Indeks;
                txtLozinka.Text = _student.Lozinka;
                cmbDrzave.SelectedValue = _gradServis.GetById(_student.GradId).DrzavaId;
                cmbGrad.SelectedValue = _student.GradId;
                pbSlika.Image = ImageHelper.ByteToImage(_student.Slika);
                cbAktivan.Checked = _student.Aktivan;
                dtpDatumRodjenja.Value = _student.DatumRodjenja;

                for (int i = 0; i < clbUloge.Items.Count; i++)
                {
                    var uloga = clbUloge.Items[i] as Uloga;
                    if (_student.Uloge.Any(u=>u.Id == uloga.Id))
                        clbUloge.SetItemChecked(i, true);
                }
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }

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
                    //_student.Spol = spol;
                    _student.Indeks = txtIndeks.Text;
                    _student.Lozinka = txtLozinka.Text;
                    _student.GradId = grad.Id;
                    //_student.Grad = grad;
                    _student.Slika = ImageHelper.ImageToByte(pbSlika.Image);
                    _student.Aktivan = cbAktivan.Checked;
                    _student.DatumRodjenja = dtpDatumRodjenja.Value;

                    _student.Uloge = clbUloge.CheckedItems.Cast<Uloga>().ToList();

                    if (_student.Id == 0)
                        _studentServis.Add(_student);
                    else
                        _studentServis.Update(_student);

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

        private void btnToSlika_Click(object sender, EventArgs e)
        {
            PredjiNaNaredniTab();
        }

        private void PredjiNaNaredniTab()
        {
            tabControl1.SelectTab(tabControl1.SelectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnToUloge_Click(object sender, EventArgs e)
        {
            PredjiNaNaredniTab();
        }
    }

}
