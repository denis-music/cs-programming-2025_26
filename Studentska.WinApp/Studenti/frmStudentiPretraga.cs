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
    public partial class frmStudentiPretraga : Form
    {
        StudentServis _studentServis = new StudentServis();
        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
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

        private void UcitajPodatke(List<Student> ? dataSource = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = dataSource ?? _studentServis.GetAll();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            if (new frmStudentiAddEdit().ShowDialog() == DialogResult.OK)
                UcitajPodatke();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            if (odabraniStudent != null)
            {
                if (new frmStudentiAddEdit(odabraniStudent).ShowDialog() == DialogResult.OK)
                    UcitajPodatke();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilter.Text.ToLower();

            var rezultatPretrage = (from student in _studentServis.GetAll()
                                    where student.Ime.ToLower().Contains(filter) ||
                                            student.Prezime.ToLower().Contains(filter) ||
                                            student.Indeks.ToLower().Contains(filter)
                                    select student).ToList();
            UcitajPodatke(rezultatPretrage);
        }
    }
}
