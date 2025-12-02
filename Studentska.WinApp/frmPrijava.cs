using Studentska.Servis;

using System.Resources;

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

    public class Kljucevi
    {
         public const string InvalidLoginData = "invalid_login_data";
        public const string UserNameRequired = "username_required";
        public const string PasswordRequired = "password_required";

        


    }


    public class Resursi
    {
        static ResourceManager manager = new ResourceManager("Studentska.WinApp.Properties.Resources",
            typeof(frmPrijava).Assembly);

        public static string Get(string kljuc)
        {
            return manager.GetString(kljuc);
        }
    }



    public class Validator 
    {
        public static bool ValidanUnos(Control control, ErrorProvider err, string poruka)
        {
            bool validan = true;
            if (control is ComboBox cmb && cmb.SelectedIndex < 0)
                validan = false;
            else if (control is PictureBox pb && pb.Image == null )
                validan = false;
            else if (control is TextBox txt && string.IsNullOrWhiteSpace(txt.Text))
                validan = false;

            if (!validan)
            {
                err.SetError(control, poruka);
                return false;
            }            
            err.Clear();
            return true;
        }
    }

}
