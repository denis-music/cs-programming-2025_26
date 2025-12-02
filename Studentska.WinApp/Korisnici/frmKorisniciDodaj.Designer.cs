namespace Studentska.WinApp
{
    partial class frmKorisniciDodaj
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
            pbSlika = new PictureBox();
            btnSacuvaj = new Button();
            ofdSlika = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            label3 = new Label();
            txtLozinka = new TextBox();
            label4 = new Label();
            txtKorisnickoIme = new TextBox();
            label5 = new Label();
            cbAktivan = new CheckBox();
            dtpDatumRodjenja = new DateTimePicker();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(12, 32);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(169, 188);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 0;
            pbSlika.TabStop = false;
            pbSlika.Click += pictureBox1_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(485, 197);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(105, 23);
            btnSacuvaj.TabIndex = 1;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Slika:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 32);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(198, 50);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(193, 23);
            txtIme.TabIndex = 4;
            txtIme.TextChanged += txtIme_TextChanged;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(397, 50);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(193, 23);
            txtPrezime.TabIndex = 6;
            txtPrezime.TextChanged += txtPrezime_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(397, 32);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Prezime:";
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(397, 154);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(193, 23);
            txtLozinka.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 136);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Lozinka:";
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Location = new Point(198, 154);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(193, 23);
            txtKorisnickoIme.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 136);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Korisničko ime:";
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(198, 190);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 11;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(198, 101);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(392, 23);
            dtpDatumRodjenja.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 83);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 13;
            label6.Text = "Datum rođenja:";
            // 
            // frmKorisniciDodaj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 236);
            Controls.Add(label6);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(cbAktivan);
            Controls.Add(txtLozinka);
            Controls.Add(label4);
            Controls.Add(txtKorisnickoIme);
            Controls.Add(label5);
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(txtIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Name = "frmKorisniciDodaj";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o korisniku";
            Load += frmKorisniciDodaj_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbSlika;
        private Button btnSacuvaj;
        private OpenFileDialog ofdSlika;
        private Label label1;
        private Label label2;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Label label3;
        private TextBox txtLozinka;
        private Label label4;
        private TextBox txtKorisnickoIme;
        private Label label5;
        private CheckBox cbAktivan;
        private DateTimePicker dtpDatumRodjenja;
        private Label label6;
    }
}