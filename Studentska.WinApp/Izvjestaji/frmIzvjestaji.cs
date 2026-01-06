using Microsoft.Reporting.WinForms;

using Studentska.WinApp.Studenti;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Studentska.WinApp.Studenti.frmStudentiUplate;



namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private frmStudentiUplate.dtoStudentUplate podaci;       

        public frmIzvjestaji(dtoStudentUplate studentUplate)
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
            this.podaci = studentUplate;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            var parametri = new ReportParameterCollection();
            parametri.Add(new ReportParameter("Indeks", podaci.Student.Indeks));
            parametri.Add(new ReportParameter("ImePrezime", podaci.Student.ToShortString()));
            parametri.Add(new ReportParameter("Slika", Convert.ToBase64String(podaci.Student.Slika)));
            parametri.Add(new ReportParameter("OdgovornaOsoba", "dr.sc Nina Bijedić"));


            var tblStudentiUplate = new dsIzvjestaji.StudentiUplateDataTable();
            for(int i = 0; i < podaci.Uplate.Count; i++)
            {
                var redUplata = tblStudentiUplate.NewStudentiUplateRow();
                redUplata.Rb = (i + 1).ToString();
                redUplata.AkademskaGodina = podaci.Uplate[i].AkademskaGodina.Naziv;
                redUplata.VrstaUplate = podaci.Uplate[i].VrstaUplate.Naziv;
                redUplata.DatumUplate = podaci.Uplate[i].DatumUplate.ToString("dd.MM.yyyy");
                redUplata.Iznos = podaci.Uplate[i].Iznos.ToString();
                tblStudentiUplate.AddStudentiUplateRow(redUplata);
            }

            var rds = new ReportDataSource();
            rds.Name = "Podaci";
            rds.Value = tblStudentiUplate;

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(parametri);
            reportViewer1.RefreshReport();
        }
    }
}
