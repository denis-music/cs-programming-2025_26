namespace Studentska.WinApp.Studenti
{
    partial class frmStudentiAddEdit
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
            components = new System.ComponentModel.Container();
            btnSacuvaj = new Button();
            pbSlika = new PictureBox();
            ofdSlika = new OpenFileDialog();
            label6 = new Label();
            dtpDatumRodjenja = new DateTimePicker();
            cbAktivan = new CheckBox();
            txtLozinka = new TextBox();
            label4 = new Label();
            txtIndeks = new TextBox();
            label5 = new Label();
            txtPrezime = new TextBox();
            label3 = new Label();
            txtIme = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            cmbSpol = new ComboBox();
            cmbDrzave = new ComboBox();
            label8 = new Label();
            cmbGrad = new ComboBox();
            label9 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(493, 234);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(105, 23);
            btnSacuvaj.TabIndex = 15;
            btnSacuvaj.Text = "Sačuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // pbSlika
            // 
            pbSlika.BorderStyle = BorderStyle.FixedSingle;
            pbSlika.Location = new Point(11, 45);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(180, 212);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 14;
            pbSlika.TabStop = false;
            pbSlika.Click += pbSlika_Click;
            // 
            // ofdSlika
            // 
            ofdSlika.FileName = "openFileDialog1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 73);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 27;
            label6.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(202, 93);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(193, 23);
            dtpDatumRodjenja.TabIndex = 26;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(202, 218);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 25;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(405, 141);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(193, 23);
            txtLozinka.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 121);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 23;
            label4.Text = "Lozinka:";
            // 
            // txtIndeks
            // 
            txtIndeks.Location = new Point(202, 141);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(193, 23);
            txtIndeks.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(202, 121);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 21;
            label5.Text = "Broj indeksa:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(405, 45);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(193, 23);
            txtPrezime.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 25);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 19;
            label3.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(202, 45);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(193, 23);
            txtIme.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 25);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 17;
            label2.Text = "Ime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "Slika:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 73);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 28;
            label7.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(405, 93);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(193, 23);
            cmbSpol.TabIndex = 29;
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(202, 189);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(193, 23);
            cmbDrzave.TabIndex = 31;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 171);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 30;
            label8.Text = "Država:";
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(405, 189);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(193, 23);
            cmbGrad.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 171);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 32;
            label9.Text = "Grad:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmStudentiAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 274);
            Controls.Add(cmbGrad);
            Controls.Add(label9);
            Controls.Add(cmbDrzave);
            Controls.Add(label8);
            Controls.Add(cmbSpol);
            Controls.Add(label7);
            Controls.Add(btnSacuvaj);
            Controls.Add(pbSlika);
            Controls.Add(label6);
            Controls.Add(dtpDatumRodjenja);
            Controls.Add(cbAktivan);
            Controls.Add(txtLozinka);
            Controls.Add(label4);
            Controls.Add(txtIndeks);
            Controls.Add(label5);
            Controls.Add(txtPrezime);
            Controls.Add(label3);
            Controls.Add(txtIme);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentiAddEdit";
            Text = "Podaci o studentu";
            Load += frmStudentiAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSacuvaj;
        private PictureBox pbSlika;
        private OpenFileDialog ofdSlika;
        private Label label6;
        private DateTimePicker dtpDatumRodjenja;
        private CheckBox cbAktivan;
        private TextBox txtLozinka;
        private Label label4;
        private TextBox txtIndeks;
        private Label label5;
        private TextBox txtPrezime;
        private Label label3;
        private TextBox txtIme;
        private Label label2;
        private Label label1;
        private Label label7;
        private ComboBox cmbSpol;
        private ComboBox cmbDrzave;
        private Label label8;
        private ComboBox cmbGrad;
        private Label label9;
        private ErrorProvider err;
    }
}