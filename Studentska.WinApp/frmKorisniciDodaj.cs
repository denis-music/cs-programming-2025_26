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

namespace Studentska.WinApp
{
    public partial class frmKorisniciDodaj : Form
    {

        KorisnikServis db = new KorisnikServis();

        public frmKorisniciDodaj()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofdSlika.ShowDialog() == DialogResult.OK)
            {
                pbSlika.Image = Image.FromFile(ofdSlika.FileName);
            }
        }

        private void frmKorisniciDodaj_Load(object sender, EventArgs e)
        {
            txtLozinka.Text = GenerisiLozinku();
        }

        private string GenerisiLozinku(int brojZnakova = 10)
        {
            string dozvoljniZnakovi = "abcdefghijkljmnoprstuvzwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()";
            Random rand = new Random();
            StringBuilder lozinka = new StringBuilder();//xQ1!2@abC3
            for (int i = 0; i < brojZnakova; i++)
                lozinka.Append(dozvoljniZnakovi[rand.Next(dozvoljniZnakovi.Length)]);
            return lozinka.ToString();
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }

        private void GenerisiKorisnickoIme()
        {
            txtKorisnickoIme.Text = $"{txtIme.Text.ToLower()}.{txtPrezime.Text.ToLower()}@edu.fit.ba";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiKorisnickoIme();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var korisnik = new Korisnik
            (
                txtIme.Text,
                txtPrezime.Text,
                dtpDatumRodjenja.Value,
                pbSlika.Image,
                txtKorisnickoIme.Text,
                txtLozinka.Text,
                cbAktivan.Checked
            );
            db.Add(korisnik);
            MessageBox.Show("Novi korisnik je uspješno dodan.", 
                "Obavijest", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
