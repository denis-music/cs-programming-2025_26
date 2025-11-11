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
    public partial class frmDogadjaji : Form
    {
        //void (*pokFunc)(int&) 
        delegate void PotpisMetode(string text);
        // void (*nizPokFunc[3])(int&);
        event PotpisMetode Obavijesti;


        public frmDogadjaji()
        {
            InitializeComponent();
        }


        string KreirajEmail(int broj)
        {
            return "Email: PODRAZUMIJENI SADRZAJ";
        }
        bool Parni(int broj)//1
        {
            return broj % 2 == 0;
        }
        private void frmDogadjaji_Load(object sender, EventArgs e)
        {

            Func<int, string> pokFunc = KreirajEmail;
            Func<int, bool> filter = Parni;

            int[]niz = new int[] { 1, 2, 3, 4, 5, 21,66 };
            var parni1 = niz.Where(Parni);//2,4,66
            var parni2 = niz.Where(filter);//2,4,66
            var parni3 = niz.Where(broj => broj % 2 == 0);//2,4,66
        }

        void PosaljiEmail(string text)
        {
            PosaljiSadrzaj("Email: " + text);
        }
        void PosaljiSMS(string text)
        {
            PosaljiSadrzaj("SMS: " + text);
        }
        void PosaljiNaDLWMS(string text)
        {
            PosaljiSadrzaj("DLWMS: " + text);
        }
        const string crt = "-----------------------------------";

        private void PosaljiSadrzaj(string sadrzaj)
        {
            txtIspis.Text += Environment.NewLine + crt + Environment.NewLine;

            for (int i = 0; i < sadrzaj.Length; i++)
            {
                txtIspis.Text += sadrzaj[i];
                Task.Delay(70).Wait();  
            }
        }

        private void PretplatiMetodu(CheckBox checkBox, PotpisMetode metoda)
        {
            if (checkBox.Checked)
                Obavijesti += metoda;
            else
                Obavijesti -= metoda;
        }

        private void cbEmail_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbEmail, PosaljiEmail);
        }

        private void cbSMS_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbSMS, PosaljiSMS);
        }

        private void cbDLWMS_CheckedChanged(object sender, EventArgs e)
        {
            PretplatiMetodu(cbDLWMS, PosaljiNaDLWMS);
        }

        private void btnObavijesti_Click(object sender, EventArgs e)
        {
            Obavijesti(txtObavijest.Text);
        }
    }
}
