namespace Studentska.WinApp
{
    partial class frmKorisniciPretraga
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
            dgvKorisnici = new DataGridView();
            btnDodajKorisnika = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).BeginInit();
            SuspendLayout();
            // 
            // dgvKorisnici
            // 
            dgvKorisnici.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKorisnici.Location = new Point(12, 65);
            dgvKorisnici.Name = "dgvKorisnici";
            dgvKorisnici.Size = new Size(776, 264);
            dgvKorisnici.TabIndex = 0;
            // 
            // btnDodajKorisnika
            // 
            btnDodajKorisnika.Location = new Point(682, 36);
            btnDodajKorisnika.Name = "btnDodajKorisnika";
            btnDodajKorisnika.Size = new Size(106, 23);
            btnDodajKorisnika.TabIndex = 1;
            btnDodajKorisnika.Text = "Dodaj korisnika";
            btnDodajKorisnika.UseVisualStyleBackColor = true;
            btnDodajKorisnika.Click += btnDodajKorisnika_Click;
            // 
            // frmKorisniciPretraga
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 346);
            Controls.Add(btnDodajKorisnika);
            Controls.Add(dgvKorisnici);
            Name = "frmKorisniciPretraga";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pretraga korisnika";
            Load += frmKorisniciPretraga_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKorisnici).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKorisnici;
        private Button btnDodajKorisnika;
    }
}