namespace Studentska.WinApp
{
    partial class frmDogadjaji
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
            txtObavijest = new TextBox();
            label1 = new Label();
            cbEmail = new CheckBox();
            cbSMS = new CheckBox();
            cbDLWMS = new CheckBox();
            txtIspis = new TextBox();
            btnObavijesti = new Button();
            SuspendLayout();
            // 
            // txtObavijest
            // 
            txtObavijest.Location = new Point(12, 46);
            txtObavijest.Multiline = true;
            txtObavijest.Name = "txtObavijest";
            txtObavijest.Size = new Size(354, 106);
            txtObavijest.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 25);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Sadržaj obavijesti:";
            // 
            // cbEmail
            // 
            cbEmail.AutoSize = true;
            cbEmail.Location = new Point(372, 48);
            cbEmail.Name = "cbEmail";
            cbEmail.Size = new Size(55, 19);
            cbEmail.TabIndex = 2;
            cbEmail.Text = "Email";
            cbEmail.UseVisualStyleBackColor = true;
            cbEmail.CheckedChanged += cbEmail_CheckedChanged;
            // 
            // cbSMS
            // 
            cbSMS.AutoSize = true;
            cbSMS.Location = new Point(372, 73);
            cbSMS.Name = "cbSMS";
            cbSMS.Size = new Size(49, 19);
            cbSMS.TabIndex = 3;
            cbSMS.Text = "SMS";
            cbSMS.UseVisualStyleBackColor = true;
            cbSMS.CheckedChanged += cbSMS_CheckedChanged;
            // 
            // cbDLWMS
            // 
            cbDLWMS.AutoSize = true;
            cbDLWMS.Location = new Point(372, 98);
            cbDLWMS.Name = "cbDLWMS";
            cbDLWMS.Size = new Size(67, 19);
            cbDLWMS.TabIndex = 4;
            cbDLWMS.Text = "DLWMS";
            cbDLWMS.UseVisualStyleBackColor = true;
            cbDLWMS.CheckedChanged += cbDLWMS_CheckedChanged;
            // 
            // txtIspis
            // 
            txtIspis.Location = new Point(12, 158);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.Size = new Size(519, 106);
            txtIspis.TabIndex = 5;
            // 
            // btnObavijesti
            // 
            btnObavijesti.Location = new Point(372, 129);
            btnObavijesti.Name = "btnObavijesti";
            btnObavijesti.Size = new Size(159, 23);
            btnObavijesti.TabIndex = 6;
            btnObavijesti.Text = "Posalji obavijesti";
            btnObavijesti.UseVisualStyleBackColor = true;
            btnObavijesti.Click += btnObavijesti_Click;
            // 
            // frmDogadjaji
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 272);
            Controls.Add(btnObavijesti);
            Controls.Add(txtIspis);
            Controls.Add(cbDLWMS);
            Controls.Add(cbSMS);
            Controls.Add(cbEmail);
            Controls.Add(label1);
            Controls.Add(txtObavijest);
            Name = "frmDogadjaji";
            Text = "frmDogadjaji";
            Load += frmDogadjaji_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObavijest;
        private Label label1;
        private CheckBox cbEmail;
        private CheckBox cbSMS;
        private CheckBox cbDLWMS;
        private TextBox txtIspis;
        private Button btnObavijesti;
    }
}