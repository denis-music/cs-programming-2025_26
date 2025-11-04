namespace Studentska.WinApp
{
    partial class frmPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrijava));
            txtKorisnickoIme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLozinka = new TextBox();
            btnPrijava = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // txtKorisnickoIme
            // 
            txtKorisnickoIme.Font = new Font("Segoe UI", 15F);
            txtKorisnickoIme.Location = new Point(423, 130);
            txtKorisnickoIme.Name = "txtKorisnickoIme";
            txtKorisnickoIme.Size = new Size(244, 34);
            txtKorisnickoIme.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(424, 112);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 1;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.CausesValidation = false;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(424, 164);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 3;
            label2.Text = "Lozinka:";
            // 
            // txtLozinka
            // 
            txtLozinka.Font = new Font("Segoe UI", 15F);
            txtLozinka.Location = new Point(423, 182);
            txtLozinka.Name = "txtLozinka";
            txtLozinka.PasswordChar = '*';
            txtLozinka.Size = new Size(244, 34);
            txtLozinka.TabIndex = 2;
            // 
            // btnPrijava
            // 
            btnPrijava.BackColor = Color.White;
            btnPrijava.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrijava.Location = new Point(584, 226);
            btnPrijava.Name = "btnPrijava";
            btnPrijava.Size = new Size(83, 33);
            btnPrijava.TabIndex = 4;
            btnPrijava.Text = "Prijava";
            btnPrijava.UseVisualStyleBackColor = false;
            btnPrijava.Click += btnPrijava_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(695, 298);
            Controls.Add(btnPrijava);
            Controls.Add(label2);
            Controls.Add(txtLozinka);
            Controls.Add(label1);
            Controls.Add(txtKorisnickoIme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrijava";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrijava";
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKorisnickoIme;
        private Label label1;
        private Label label2;
        private TextBox txtLozinka;
        private Button btnPrijava;
        private ErrorProvider err;
    }
}