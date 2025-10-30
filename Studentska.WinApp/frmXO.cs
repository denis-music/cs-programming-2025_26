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
    public partial class frmXO : Form
    {
        public frmXO()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pozdrav iz XO aplikacije!");
        }

        public int Brojac { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);
        }

        private void RegistrujPotez(object sender)
        {
            if (sender is Button button && button.Text == "")
            {
                if (Brojac % 2 == 0)
                    button.Text = "X";
                else
                    button.Text = "O";

                if (KrajIgre()){
                    MessageBox.Show($"Pobedio je igrac {button.Text}!");
                 //   ResetujIgru();
                }

                Brojac++;
            }

        }

        private bool KrajIgre()
        {
            return ProvjeriRedove() || ProvjeriKolone() || ProvjeriDijagonale();
        }

        private bool ProvjeriDijagonale()
        {
            return ProvjeriPobjedu(button1, button5, button9) ||
                ProvjeriPobjedu(button3, button5, button7);
        }

        private bool ProvjeriKolone()
        {
            return ProvjeriPobjedu(button1, button4, button7) ||
                ProvjeriPobjedu(button2, button5, button8) ||
                ProvjeriPobjedu(button3, button6, button9);
        }

        private bool ProvjeriRedove()
        {
            return ProvjeriPobjedu(button1, button2, button3) ||
                ProvjeriPobjedu(button4, button5, button6) ||
                ProvjeriPobjedu(button7, button8, button9);
        }

        private bool ProvjeriPobjedu(Button button1, Button button2, Button button3)
        {
            bool pobjeda = button1.Text!="" && button1.Text==button2.Text && button2.Text==button3.Text;
            if(pobjeda)
                button1.BackColor = button2.BackColor = button3.BackColor = Color.LightGreen;

            return pobjeda;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrujPotez(sender);

        }
    }
}
