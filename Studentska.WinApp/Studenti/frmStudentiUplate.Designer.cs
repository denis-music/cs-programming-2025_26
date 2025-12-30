namespace Studentska.WinApp.Studenti
{
    partial class frmStudentiUplate
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
            cmbAkademskaGodina = new ComboBox();
            cmbVrstaUplate = new ComboBox();
            dtpDatumUplate = new DateTimePicker();
            txtIznos = new TextBox();
            btnDodaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvUplateStudenta = new DataGridView();
            VrstaUplate = new DataGridViewTextBoxColumn();
            AkademskaGodina = new DataGridViewTextBoxColumn();
            DatumUplate = new DataGridViewTextBoxColumn();
            Iznos = new DataGridViewTextBoxColumn();
            Obrisi = new DataGridViewButtonColumn();
            pbSlika = new PictureBox();
            lblImePrezime = new Label();
            lblIndeks = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUplateStudenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).BeginInit();
            SuspendLayout();
            // 
            // cmbAkademskaGodina
            // 
            cmbAkademskaGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAkademskaGodina.FormattingEnabled = true;
            cmbAkademskaGodina.Location = new Point(213, 145);
            cmbAkademskaGodina.Name = "cmbAkademskaGodina";
            cmbAkademskaGodina.Size = new Size(146, 23);
            cmbAkademskaGodina.TabIndex = 0;
            // 
            // cmbVrstaUplate
            // 
            cmbVrstaUplate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVrstaUplate.FormattingEnabled = true;
            cmbVrstaUplate.Location = new Point(12, 144);
            cmbVrstaUplate.Name = "cmbVrstaUplate";
            cmbVrstaUplate.Size = new Size(195, 23);
            cmbVrstaUplate.TabIndex = 1;
            // 
            // dtpDatumUplate
            // 
            dtpDatumUplate.Location = new Point(471, 145);
            dtpDatumUplate.Name = "dtpDatumUplate";
            dtpDatumUplate.Size = new Size(200, 23);
            dtpDatumUplate.TabIndex = 2;
            // 
            // txtIznos
            // 
            txtIznos.Location = new Point(365, 145);
            txtIznos.Name = "txtIznos";
            txtIznos.Size = new Size(100, 23);
            txtIznos.TabIndex = 3;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(677, 144);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(99, 23);
            btnDodaj.TabIndex = 4;
            btnDodaj.Text = "Dodaj uplatu";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 127);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 5;
            label1.Text = "Akademska godina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 6;
            label2.Text = "Vrsta uplate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(365, 126);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 7;
            label3.Text = "Iznos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 127);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 8;
            label4.Text = "Datum uplate";
            // 
            // dgvUplateStudenta
            // 
            dgvUplateStudenta.AllowUserToAddRows = false;
            dgvUplateStudenta.AllowUserToDeleteRows = false;
            dgvUplateStudenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUplateStudenta.Columns.AddRange(new DataGridViewColumn[] { VrstaUplate, AkademskaGodina, DatumUplate, Iznos, Obrisi });
            dgvUplateStudenta.Location = new Point(12, 174);
            dgvUplateStudenta.Name = "dgvUplateStudenta";
            dgvUplateStudenta.ReadOnly = true;
            dgvUplateStudenta.Size = new Size(764, 264);
            dgvUplateStudenta.TabIndex = 9;
            // 
            // VrstaUplate
            // 
            VrstaUplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            VrstaUplate.DataPropertyName = "VrstaUplate";
            VrstaUplate.HeaderText = "Vrsta uplate";
            VrstaUplate.Name = "VrstaUplate";
            VrstaUplate.ReadOnly = true;
            // 
            // AkademskaGodina
            // 
            AkademskaGodina.DataPropertyName = "AkademskaGodina";
            AkademskaGodina.HeaderText = "Akademska godina";
            AkademskaGodina.Name = "AkademskaGodina";
            AkademskaGodina.ReadOnly = true;
            // 
            // DatumUplate
            // 
            DatumUplate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumUplate.DataPropertyName = "DatumUplate";
            DatumUplate.HeaderText = "Datum uplate";
            DatumUplate.Name = "DatumUplate";
            DatumUplate.ReadOnly = true;
            // 
            // Iznos
            // 
            Iznos.DataPropertyName = "Iznos";
            Iznos.HeaderText = "Iznos";
            Iznos.Name = "Iznos";
            Iznos.ReadOnly = true;
            // 
            // Obrisi
            // 
            Obrisi.HeaderText = "Obriši";
            Obrisi.Name = "Obrisi";
            Obrisi.ReadOnly = true;
            // 
            // pbSlika
            // 
            pbSlika.Location = new Point(12, 12);
            pbSlika.Name = "pbSlika";
            pbSlika.Size = new Size(100, 111);
            pbSlika.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSlika.TabIndex = 10;
            pbSlika.TabStop = false;
            // 
            // lblImePrezime
            // 
            lblImePrezime.AutoSize = true;
            lblImePrezime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblImePrezime.Location = new Point(118, 49);
            lblImePrezime.Name = "lblImePrezime";
            lblImePrezime.Size = new Size(127, 21);
            lblImePrezime.TabIndex = 11;
            lblImePrezime.Text = "Goran Škondrić";
            // 
            // lblIndeks
            // 
            lblIndeks.AutoSize = true;
            lblIndeks.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblIndeks.Location = new Point(118, 12);
            lblIndeks.Name = "lblIndeks";
            lblIndeks.Size = new Size(139, 37);
            lblIndeks.TabIndex = 12;
            lblIndeks.Text = "IB150051";
            // 
            // frmStudentiUplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndeks);
            Controls.Add(lblImePrezime);
            Controls.Add(pbSlika);
            Controls.Add(dgvUplateStudenta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Controls.Add(txtIznos);
            Controls.Add(dtpDatumUplate);
            Controls.Add(cmbVrstaUplate);
            Controls.Add(cmbAkademskaGodina);
            Name = "frmStudentiUplate";
            Text = "Uplate studenata";
            Load += frmStudentiUplate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUplateStudenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSlika).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAkademskaGodina;
        private ComboBox cmbVrstaUplate;
        private DateTimePicker dtpDatumUplate;
        private TextBox txtIznos;
        private Button btnDodaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvUplateStudenta;
        private PictureBox pbSlika;
        private Label lblImePrezime;
        private Label lblIndeks;
        private DataGridViewTextBoxColumn VrstaUplate;
        private DataGridViewTextBoxColumn AkademskaGodina;
        private DataGridViewTextBoxColumn DatumUplate;
        private DataGridViewTextBoxColumn Iznos;
        private DataGridViewButtonColumn Obrisi;
    }
}