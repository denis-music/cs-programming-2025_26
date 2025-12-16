using Studentska.Servis;
using Studentska.WinApp.Helpers;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentska.WinApp
{
    public partial class frmPrijava : Form
    {
        KorisnikServis db = new KorisnikServis();

        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {
                var korisnickoIme = txtKorisnickoIme.Text;
                var lozinka = txtLozinka.Text;

                var korisnik = db.GetByKorisnickoIme(korisnickoIme);//denis.muisc
                if (korisnik != null)
                {
                    if (korisnik.Lozinka == lozinka)
                    {
                        if (korisnik.Aktivan)
                        {
                            Hide();
                            MessageBox.Show($"Uspješna prijava {korisnik.Prezime} {korisnik.Ime}");
                            frmGlavna frmGlavna = new frmGlavna();
                            if (frmGlavna.ShowDialog() == DialogResult.OK)
                                Show();
                            else
                                Close();
                        }
                        else
                        {
                            MessageBox.Show("Korisnik nije aktivan");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(Resursi.Get(Kljucevi.InvalidLoginData));
                    return;
                }
                
            }
        }

        private bool ValidanUnos()
        {
           return Validator.ValidanUnos(txtKorisnickoIme, err, Resursi.Get(Kljucevi.UserNameRequired)) &&
                  Validator.ValidanUnos(txtLozinka, err, Resursi.Get(Kljucevi.PasswordRequired));
        }
    }

}
