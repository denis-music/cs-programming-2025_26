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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentiAddEdit));
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
            tabControl1 = new TabControl();
            tpPodaciOStudentu = new TabPage();
            btnToSlika = new Button();
            tpSlika = new TabPage();
            btnToUloge = new Button();
            label10 = new Label();
            tpUloge = new TabPage();
            label11 = new Label();
            clbUloge = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            tabControl1.SuspendLayout();
            tpPodaciOStudentu.SuspendLayout();
            tpSlika.SuspendLayout();
            tpUloge.SuspendLayout();
            SuspendLayout();
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(321, 231);
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
            pbSlika.Location = new Point(20, 33);
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
            label6.Location = new Point(20, 72);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 27;
            label6.Text = "Datum rođenja:";
            // 
            // dtpDatumRodjenja
            // 
            dtpDatumRodjenja.Location = new Point(20, 92);
            dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            dtpDatumRodjenja.Size = new Size(193, 23);
            dtpDatumRodjenja.TabIndex = 26;
            // 
            // cbAktivan
            // 
            cbAktivan.AutoSize = true;
            cbAktivan.Location = new Point(20, 217);
            cbAktivan.Name = "cbAktivan";
            cbAktivan.Size = new Size(66, 19);
            cbAktivan.TabIndex = 25;
            cbAktivan.Text = "Aktivan";
            cbAktivan.UseVisualStyleBackColor = true;
            // 
            // txtLozinka
            // 
            txtLozinka.Location = new Point(223, 140);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.Size = new Size(193, 23);
            txtLozinka.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 120);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 23;
            label4.Text = "Lozinka:";
            // 
            // txtIndeks
            // 
            txtIndeks.Location = new Point(20, 140);
            txtIndeks.Name = "txtIndeks";
            txtIndeks.Size = new Size(193, 23);
            txtIndeks.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 120);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 21;
            label5.Text = "Broj indeksa:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(223, 44);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(193, 23);
            txtPrezime.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 24);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 19;
            label3.Text = "Prezime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(20, 44);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(193, 23);
            txtIme.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 17;
            label2.Text = "Ime:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 16;
            label1.Text = "Slika:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 72);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 28;
            label7.Text = "Spol:";
            // 
            // cmbSpol
            // 
            cmbSpol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpol.FormattingEnabled = true;
            cmbSpol.Location = new Point(223, 92);
            cmbSpol.Name = "cmbSpol";
            cmbSpol.Size = new Size(193, 23);
            cmbSpol.TabIndex = 29;
            // 
            // cmbDrzave
            // 
            cmbDrzave.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDrzave.FormattingEnabled = true;
            cmbDrzave.Location = new Point(20, 188);
            cmbDrzave.Name = "cmbDrzave";
            cmbDrzave.Size = new Size(193, 23);
            cmbDrzave.TabIndex = 31;
            cmbDrzave.SelectedIndexChanged += cmbDrzave_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 170);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 30;
            label8.Text = "Država:";
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(223, 188);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(193, 23);
            cmbGrad.TabIndex = 33;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 170);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 32;
            label9.Text = "Grad:";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpPodaciOStudentu);
            tabControl1.Controls.Add(tpSlika);
            tabControl1.Controls.Add(tpUloge);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(451, 288);
            tabControl1.TabIndex = 34;
            // 
            // tpPodaciOStudentu
            // 
            tpPodaciOStudentu.Controls.Add(btnToSlika);
            tpPodaciOStudentu.Controls.Add(cmbDrzave);
            tpPodaciOStudentu.Controls.Add(cmbGrad);
            tpPodaciOStudentu.Controls.Add(label2);
            tpPodaciOStudentu.Controls.Add(label9);
            tpPodaciOStudentu.Controls.Add(txtIme);
            tpPodaciOStudentu.Controls.Add(label3);
            tpPodaciOStudentu.Controls.Add(label8);
            tpPodaciOStudentu.Controls.Add(txtPrezime);
            tpPodaciOStudentu.Controls.Add(cmbSpol);
            tpPodaciOStudentu.Controls.Add(label5);
            tpPodaciOStudentu.Controls.Add(label7);
            tpPodaciOStudentu.Controls.Add(txtIndeks);
            tpPodaciOStudentu.Controls.Add(label4);
            tpPodaciOStudentu.Controls.Add(txtLozinka);
            tpPodaciOStudentu.Controls.Add(label6);
            tpPodaciOStudentu.Controls.Add(cbAktivan);
            tpPodaciOStudentu.Controls.Add(dtpDatumRodjenja);
            tpPodaciOStudentu.Location = new Point(4, 24);
            tpPodaciOStudentu.Name = "tpPodaciOStudentu";
            tpPodaciOStudentu.Padding = new Padding(3);
            tpPodaciOStudentu.Size = new Size(443, 260);
            tpPodaciOStudentu.TabIndex = 0;
            tpPodaciOStudentu.Text = "Podaci o studentu";
            tpPodaciOStudentu.UseVisualStyleBackColor = true;
            // 
            // btnToSlika
            // 
            btnToSlika.Location = new Point(311, 217);
            btnToSlika.Name = "btnToSlika";
            btnToSlika.Size = new Size(105, 23);
            btnToSlika.TabIndex = 35;
            btnToSlika.Text = "Dalje >>";
            btnToSlika.UseVisualStyleBackColor = true;
            btnToSlika.Click += btnToSlika_Click;
            // 
            // tpSlika
            // 
            tpSlika.Controls.Add(btnToUloge);
            tpSlika.Controls.Add(label10);
            tpSlika.Controls.Add(pbSlika);
            tpSlika.Controls.Add(label1);
            tpSlika.Location = new Point(4, 24);
            tpSlika.Name = "tpSlika";
            tpSlika.Padding = new Padding(3);
            tpSlika.Size = new Size(443, 260);
            tpSlika.TabIndex = 1;
            tpSlika.Text = "Slika studenta";
            tpSlika.UseVisualStyleBackColor = true;
            // 
            // btnToUloge
            // 
            btnToUloge.Location = new Point(332, 222);
            btnToUloge.Name = "btnToUloge";
            btnToUloge.Size = new Size(105, 23);
            btnToUloge.TabIndex = 36;
            btnToUloge.Text = "Dalje >>";
            btnToUloge.UseVisualStyleBackColor = true;
            btnToUloge.Click += btnToUloge_Click;
            // 
            // label10
            // 
            label10.Location = new Point(206, 33);
            label10.Name = "label10";
            label10.Size = new Size(231, 145);
            label10.TabIndex = 17;
            label10.Text = resources.GetString("label10.Text");
            // 
            // tpUloge
            // 
            tpUloge.Controls.Add(label11);
            tpUloge.Controls.Add(clbUloge);
            tpUloge.Controls.Add(btnSacuvaj);
            tpUloge.Location = new Point(4, 24);
            tpUloge.Name = "tpUloge";
            tpUloge.Padding = new Padding(3);
            tpUloge.Size = new Size(443, 260);
            tpUloge.TabIndex = 2;
            tpUloge.Text = "Uloge studenta";
            tpUloge.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 31);
            label11.Name = "label11";
            label11.Size = new Size(246, 15);
            label11.TabIndex = 17;
            label11.Text = "Odaberite uloge koje su dodijeljene studentu:";
            // 
            // clbUloge
            // 
            clbUloge.CheckOnClick = true;
            clbUloge.FormattingEnabled = true;
            clbUloge.Location = new Point(19, 49);
            clbUloge.Name = "clbUloge";
            clbUloge.Size = new Size(407, 166);
            clbUloge.TabIndex = 0;
            // 
            // frmStudentiAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 311);
            Controls.Add(tabControl1);
            Name = "frmStudentiAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o studentu";
            Load += frmStudentiAddEdit_Load;
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            tabControl1.ResumeLayout(false);
            tpPodaciOStudentu.ResumeLayout(false);
            tpPodaciOStudentu.PerformLayout();
            tpSlika.ResumeLayout(false);
            tpSlika.PerformLayout();
            tpUloge.ResumeLayout(false);
            tpUloge.PerformLayout();
            ResumeLayout(false);
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
        private TabControl tabControl1;
        private TabPage tpPodaciOStudentu;
        private Button btnToSlika;
        private TabPage tpSlika;
        private Button btnToUloge;
        private Label label10;
        private TabPage tpUloge;
        private Label label11;
        private CheckedListBox clbUloge;
    }
}