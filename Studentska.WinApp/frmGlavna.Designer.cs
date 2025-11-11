namespace Studentska.WinApp
{
    partial class frmGlavna
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            odjavaToolStripMenuItem = new ToolStripMenuItem();
            krajRadaToolStripMenuItem = new ToolStripMenuItem();
            igreToolStripMenuItem = new ToolStripMenuItem();
            xOToolStripMenuItem = new ToolStripMenuItem();
            korisniciToolStripMenuItem = new ToolStripMenuItem();
            noviKorisnikToolStripMenuItem = new ToolStripMenuItem();
            pretragaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, igreToolStripMenuItem, korisniciToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { odjavaToolStripMenuItem, krajRadaToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // odjavaToolStripMenuItem
            // 
            odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            odjavaToolStripMenuItem.Size = new Size(120, 22);
            odjavaToolStripMenuItem.Text = "Odjava";
            odjavaToolStripMenuItem.Click += odjavaToolStripMenuItem_Click;
            // 
            // krajRadaToolStripMenuItem
            // 
            krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            krajRadaToolStripMenuItem.Size = new Size(120, 22);
            krajRadaToolStripMenuItem.Text = "Kraj rada";
            krajRadaToolStripMenuItem.Click += krajRadaToolStripMenuItem_Click;
            // 
            // igreToolStripMenuItem
            // 
            igreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xOToolStripMenuItem });
            igreToolStripMenuItem.Name = "igreToolStripMenuItem";
            igreToolStripMenuItem.Size = new Size(39, 20);
            igreToolStripMenuItem.Text = "Igre";
            // 
            // xOToolStripMenuItem
            // 
            xOToolStripMenuItem.Name = "xOToolStripMenuItem";
            xOToolStripMenuItem.Size = new Size(90, 22);
            xOToolStripMenuItem.Text = "XO";
            xOToolStripMenuItem.Click += xOToolStripMenuItem_Click;
            // 
            // korisniciToolStripMenuItem
            // 
            korisniciToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noviKorisnikToolStripMenuItem, pretragaToolStripMenuItem });
            korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            korisniciToolStripMenuItem.Size = new Size(64, 20);
            korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // noviKorisnikToolStripMenuItem
            // 
            noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            noviKorisnikToolStripMenuItem.Size = new Size(180, 22);
            noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            // 
            // pretragaToolStripMenuItem
            // 
            pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            pretragaToolStripMenuItem.Size = new Size(180, 22);
            pretragaToolStripMenuItem.Text = "Pretraga";
            pretragaToolStripMenuItem.Click += pretragaToolStripMenuItem_Click;
            // 
            // frmGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmGlavna";
            Text = "Studentska App :: v.0.1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem igreToolStripMenuItem;
        private ToolStripMenuItem xOToolStripMenuItem;
        private ToolStripMenuItem odjavaToolStripMenuItem;
        private ToolStripMenuItem krajRadaToolStripMenuItem;
        private ToolStripMenuItem korisniciToolStripMenuItem;
        private ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private ToolStripMenuItem pretragaToolStripMenuItem;
    }
}