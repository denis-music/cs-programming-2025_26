namespace Studentska.WinApp.Studenti
{
    partial class frmStudentiPredmeti
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
            cmbPredmet = new ComboBox();
            label1 = new Label();
            cmbOcjena = new ComboBox();
            label2 = new Label();
            dtpDatumPolaganja = new DateTimePicker();
            label3 = new Label();
            btnDodajPolozeni = new Button();
            dgvPolozeniPredmeti = new DataGridView();
            Predmet = new DataGridViewTextBoxColumn();
            Ocjena = new DataGridViewTextBoxColumn();
            DatumPolaganja = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).BeginInit();
            SuspendLayout();
            // 
            // cmbPredmet
            // 
            cmbPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPredmet.FormattingEnabled = true;
            cmbPredmet.Location = new Point(14, 134);
            cmbPredmet.Name = "cmbPredmet";
            cmbPredmet.Size = new Size(238, 23);
            cmbPredmet.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 116);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Predmet:";
            // 
            // cmbOcjena
            // 
            cmbOcjena.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOcjena.FormattingEnabled = true;
            cmbOcjena.Items.AddRange(new object[] { "6", "7", "8", "9", "10" });
            cmbOcjena.Location = new Point(258, 134);
            cmbOcjena.Name = "cmbOcjena";
            cmbOcjena.Size = new Size(60, 23);
            cmbOcjena.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 116);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Ocjena:";
            // 
            // dtpDatumPolaganja
            // 
            dtpDatumPolaganja.Location = new Point(324, 134);
            dtpDatumPolaganja.Name = "dtpDatumPolaganja";
            dtpDatumPolaganja.Size = new Size(232, 23);
            dtpDatumPolaganja.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 116);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 5;
            label3.Text = "Datum polaganja:";
            // 
            // btnDodajPolozeni
            // 
            btnDodajPolozeni.Location = new Point(562, 133);
            btnDodajPolozeni.Name = "btnDodajPolozeni";
            btnDodajPolozeni.Size = new Size(75, 23);
            btnDodajPolozeni.TabIndex = 6;
            btnDodajPolozeni.Text = "Dodaj";
            btnDodajPolozeni.UseVisualStyleBackColor = true;
            btnDodajPolozeni.Click += btnDodajPolozeni_Click;
            // 
            // dgvPolozeniPredmeti
            // 
            dgvPolozeniPredmeti.AllowUserToAddRows = false;
            dgvPolozeniPredmeti.AllowUserToDeleteRows = false;
            dgvPolozeniPredmeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPolozeniPredmeti.Columns.AddRange(new DataGridViewColumn[] { Predmet, Ocjena, DatumPolaganja });
            dgvPolozeniPredmeti.Location = new Point(12, 163);
            dgvPolozeniPredmeti.Name = "dgvPolozeniPredmeti";
            dgvPolozeniPredmeti.ReadOnly = true;
            dgvPolozeniPredmeti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPolozeniPredmeti.Size = new Size(625, 243);
            dgvPolozeniPredmeti.TabIndex = 7;
            // 
            // Predmet
            // 
            Predmet.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Predmet.DataPropertyName = "Predmet";
            Predmet.HeaderText = "Predmet";
            Predmet.Name = "Predmet";
            Predmet.ReadOnly = true;
            // 
            // Ocjena
            // 
            Ocjena.DataPropertyName = "Ocjena";
            Ocjena.HeaderText = "Ocjena";
            Ocjena.Name = "Ocjena";
            Ocjena.ReadOnly = true;
            // 
            // DatumPolaganja
            // 
            DatumPolaganja.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DatumPolaganja.DataPropertyName = "DatumPolaganja";
            DatumPolaganja.HeaderText = "Datum polaganja";
            DatumPolaganja.Name = "DatumPolaganja";
            DatumPolaganja.ReadOnly = true;
            // 
            // frmStudentiPredmeti
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 422);
            Controls.Add(dgvPolozeniPredmeti);
            Controls.Add(btnDodajPolozeni);
            Controls.Add(label3);
            Controls.Add(dtpDatumPolaganja);
            Controls.Add(label2);
            Controls.Add(cmbOcjena);
            Controls.Add(label1);
            Controls.Add(cmbPredmet);
            Name = "frmStudentiPredmeti";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Polozeni predmeti";
            Load += frmStudentiPredmeti_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPolozeniPredmeti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbPredmet;
        private Label label1;
        private ComboBox cmbOcjena;
        private Label label2;
        private DateTimePicker dtpDatumPolaganja;
        private Label label3;
        private Button btnDodajPolozeni;
        private DataGridView dgvPolozeniPredmeti;
        private DataGridViewTextBoxColumn Predmet;
        private DataGridViewTextBoxColumn Ocjena;
        private DataGridViewTextBoxColumn DatumPolaganja;
    }
}