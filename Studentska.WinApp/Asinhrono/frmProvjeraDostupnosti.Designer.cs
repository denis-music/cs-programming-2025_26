namespace Studentska.WinApp.Asinhrono
{
    partial class frmProvjeraDostupnosti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbHost = new ComboBox();
            cmbBrojZahtjeva = new ComboBox();
            btnPing = new Button();
            btnUcitajPodatke = new Button();
            txtIspis = new TextBox();
            SuspendLayout();
            // 
            // cmbHost
            // 
            cmbHost.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHost.FormattingEnabled = true;
            cmbHost.Items.AddRange(new object[] { "www.google.com", "www.microsoft.com", "www.hp.com" });
            cmbHost.Location = new Point(12, 33);
            cmbHost.Name = "cmbHost";
            cmbHost.Size = new Size(173, 23);
            cmbHost.TabIndex = 0;
            // 
            // cmbBrojZahtjeva
            // 
            cmbBrojZahtjeva.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrojZahtjeva.FormattingEnabled = true;
            cmbBrojZahtjeva.Items.AddRange(new object[] { "10", "30", "50", "100" });
            cmbBrojZahtjeva.Location = new Point(191, 34);
            cmbBrojZahtjeva.Name = "cmbBrojZahtjeva";
            cmbBrojZahtjeva.Size = new Size(96, 23);
            cmbBrojZahtjeva.TabIndex = 1;
            // 
            // btnPing
            // 
            btnPing.Location = new Point(293, 34);
            btnPing.Name = "btnPing";
            btnPing.Size = new Size(75, 23);
            btnPing.TabIndex = 2;
            btnPing.Text = "Ping";
            btnPing.UseVisualStyleBackColor = true;
            btnPing.Click += btnPing_ClickAsync;
            // 
            // btnUcitajPodatke
            // 
            btnUcitajPodatke.Location = new Point(431, 34);
            btnUcitajPodatke.Name = "btnUcitajPodatke";
            btnUcitajPodatke.Size = new Size(96, 23);
            btnUcitajPodatke.TabIndex = 3;
            btnUcitajPodatke.Text = "Učitaj podatke";
            btnUcitajPodatke.UseVisualStyleBackColor = true;
            btnUcitajPodatke.Click += btnUcitajPodatke_Click;
            // 
            // txtIspis
            // 
            txtIspis.Location = new Point(12, 62);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.Size = new Size(515, 344);
            txtIspis.TabIndex = 4;
            // 
            // frmProvjeraDostupnosti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 417);
            Controls.Add(txtIspis);
            Controls.Add(btnUcitajPodatke);
            Controls.Add(btnPing);
            Controls.Add(cmbBrojZahtjeva);
            Controls.Add(cmbHost);
            Name = "frmProvjeraDostupnosti";
            Text = "Provjera dostupnosti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbHost;
        private ComboBox cmbBrojZahtjeva;
        private Button btnPing;
        private Button btnUcitajPodatke;
        private TextBox txtIspis;
    }
}