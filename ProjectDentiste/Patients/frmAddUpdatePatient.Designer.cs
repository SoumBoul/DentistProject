namespace ProjectDentiste.Patients
{
    partial class frmAddUpdatePatient
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
            this.tabcontro1 = new System.Windows.Forms.TabControl();
            this.Patient = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rbDontHaveMutuelle = new System.Windows.Forms.RadioButton();
            this.rbHasMutuelle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mutuelle = new System.Windows.Forms.TabPage();
            this.tabMedicalRecord = new System.Windows.Forms.TabPage();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lbtTitre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cntrPatient1 = new ProjectDentiste.Patients.Controles.cntrPatient();
            this.ctrlPersonInfo1 = new ProjectDentiste.Personnes.ctrlPersonInfo();
            this.cntrMutuelleInfo1 = new ProjectDentiste.Mutuelle.cntrMutuelleInfo();
            this.cntrMedicalRecords1 = new ProjectDentiste.MedicalRecord.Contols.cntrMedicalRecords();
            this.tabcontro1.SuspendLayout();
            this.Patient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Mutuelle.SuspendLayout();
            this.tabMedicalRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontro1
            // 
            this.tabcontro1.Controls.Add(this.Patient);
            this.tabcontro1.Controls.Add(this.Mutuelle);
            this.tabcontro1.Controls.Add(this.tabMedicalRecord);
            this.tabcontro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcontro1.Location = new System.Drawing.Point(12, 62);
            this.tabcontro1.Name = "tabcontro1";
            this.tabcontro1.SelectedIndex = 0;
            this.tabcontro1.Size = new System.Drawing.Size(1473, 663);
            this.tabcontro1.TabIndex = 0;
            // 
            // Patient
            // 
            this.Patient.BackColor = System.Drawing.Color.RoyalBlue;
            this.Patient.Controls.Add(this.groupBox2);
            this.Patient.Controls.Add(this.groupBox1);
            this.Patient.Location = new System.Drawing.Point(4, 27);
            this.Patient.Name = "Patient";
            this.Patient.Padding = new System.Windows.Forms.Padding(3);
            this.Patient.Size = new System.Drawing.Size(1465, 632);
            this.Patient.TabIndex = 0;
            this.Patient.Text = "Patient";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.rbDontHaveMutuelle);
            this.groupBox2.Controls.Add(this.rbHasMutuelle);
            this.groupBox2.Controls.Add(this.cntrPatient1);
            this.groupBox2.Location = new System.Drawing.Point(11, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1447, 306);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patient Info:";
            // 
            // btnNext
            // 
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Silver;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1317, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 45);
            this.btnNext.TabIndex = 179;
            this.btnNext.Text = "Next  =>";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(1126, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 22);
            this.label11.TabIndex = 178;
            this.label11.Text = "Assurance & Mutuelle:";
            // 
            // rbDontHaveMutuelle
            // 
            this.rbDontHaveMutuelle.AutoSize = true;
            this.rbDontHaveMutuelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDontHaveMutuelle.ForeColor = System.Drawing.Color.Blue;
            this.rbDontHaveMutuelle.Location = new System.Drawing.Point(1201, 141);
            this.rbDontHaveMutuelle.Name = "rbDontHaveMutuelle";
            this.rbDontHaveMutuelle.Size = new System.Drawing.Size(67, 26);
            this.rbDontHaveMutuelle.TabIndex = 10;
            this.rbDontHaveMutuelle.TabStop = true;
            this.rbDontHaveMutuelle.Text = "Non";
            this.rbDontHaveMutuelle.UseVisualStyleBackColor = true;
            this.rbDontHaveMutuelle.Click += new System.EventHandler(this.rbDontHaveMutuelle_Click);
            // 
            // rbHasMutuelle
            // 
            this.rbHasMutuelle.AutoSize = true;
            this.rbHasMutuelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHasMutuelle.ForeColor = System.Drawing.Color.Blue;
            this.rbHasMutuelle.Location = new System.Drawing.Point(1201, 91);
            this.rbHasMutuelle.Name = "rbHasMutuelle";
            this.rbHasMutuelle.Size = new System.Drawing.Size(62, 26);
            this.rbHasMutuelle.TabIndex = 9;
            this.rbHasMutuelle.TabStop = true;
            this.rbHasMutuelle.Text = "Oui";
            this.rbHasMutuelle.UseVisualStyleBackColor = true;
            this.rbHasMutuelle.Click += new System.EventHandler(this.rbHasMutuelle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.ctrlPersonInfo1);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1439, 308);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personne Info:";
            // 
            // Mutuelle
            // 
            this.Mutuelle.Controls.Add(this.cntrMutuelleInfo1);
            this.Mutuelle.Location = new System.Drawing.Point(4, 27);
            this.Mutuelle.Name = "Mutuelle";
            this.Mutuelle.Padding = new System.Windows.Forms.Padding(3);
            this.Mutuelle.Size = new System.Drawing.Size(1465, 632);
            this.Mutuelle.TabIndex = 1;
            this.Mutuelle.Text = "Mutuelle";
            this.Mutuelle.UseVisualStyleBackColor = true;
            // 
            // tabMedicalRecord
            // 
            this.tabMedicalRecord.Controls.Add(this.cntrMedicalRecords1);
            this.tabMedicalRecord.Location = new System.Drawing.Point(4, 27);
            this.tabMedicalRecord.Name = "tabMedicalRecord";
            this.tabMedicalRecord.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicalRecord.Size = new System.Drawing.Size(1465, 632);
            this.tabMedicalRecord.TabIndex = 2;
            this.tabMedicalRecord.Text = "Medical Record";
            this.tabMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(595, 727);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(281, 53);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbtTitre
            // 
            this.lbtTitre.AutoSize = true;
            this.lbtTitre.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtTitre.ForeColor = System.Drawing.Color.Navy;
            this.lbtTitre.Location = new System.Drawing.Point(613, 9);
            this.lbtTitre.Name = "lbtTitre";
            this.lbtTitre.Size = new System.Drawing.Size(276, 71);
            this.lbtTitre.TabIndex = 15;
            this.lbtTitre.Text = "Add Patient";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDentiste.Properties.Resources.CloseBlack;
            this.pictureBox1.Location = new System.Drawing.Point(1430, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cntrPatient1
            // 
            this.cntrPatient1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cntrPatient1.Location = new System.Drawing.Point(14, 25);
            this.cntrPatient1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cntrPatient1.Name = "cntrPatient1";
            this.cntrPatient1.Size = new System.Drawing.Size(1418, 273);
            this.cntrPatient1.TabIndex = 8;
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(14, 28);
            this.ctrlPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.Person = null;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(1418, 272);
            this.ctrlPersonInfo1.TabIndex = 7;
            this.ctrlPersonInfo1.Load += new System.EventHandler(this.ctrlPersonInfo1_Load);
            // 
            // cntrMutuelleInfo1
            // 
            this.cntrMutuelleInfo1.BackColor = System.Drawing.Color.Gainsboro;
            this.cntrMutuelleInfo1.Location = new System.Drawing.Point(32, 49);
            this.cntrMutuelleInfo1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cntrMutuelleInfo1.Name = "cntrMutuelleInfo1";
            this.cntrMutuelleInfo1.Size = new System.Drawing.Size(1119, 306);
            this.cntrMutuelleInfo1.TabIndex = 0;
            // 
            // cntrMedicalRecords1
            // 
            this.cntrMedicalRecords1.BackColor = System.Drawing.Color.Gainsboro;
            this.cntrMedicalRecords1.Location = new System.Drawing.Point(70, 51);
            this.cntrMedicalRecords1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cntrMedicalRecords1.medical = null;
            this.cntrMedicalRecords1.Name = "cntrMedicalRecords1";
            this.cntrMedicalRecords1.Size = new System.Drawing.Size(834, 513);
            this.cntrMedicalRecords1.TabIndex = 0;
            // 
            // frmAddUpdatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1502, 787);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbtTitre);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabcontro1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUpdatePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdatePatient";
            this.tabcontro1.ResumeLayout(false);
            this.Patient.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.Mutuelle.ResumeLayout(false);
            this.tabMedicalRecord.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage Patient;
        private System.Windows.Forms.TabPage Mutuelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbDontHaveMutuelle;
        private System.Windows.Forms.RadioButton rbHasMutuelle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        public System.Windows.Forms.TabControl tabcontro1;
        public System.Windows.Forms.GroupBox groupBox1;
        public Personnes.ctrlPersonInfo ctrlPersonInfo1;
        public Controles.cntrPatient cntrPatient1;
        public System.Windows.Forms.Label lbtTitre;
        private System.Windows.Forms.TabPage tabMedicalRecord;
        private System.Windows.Forms.PictureBox pictureBox1;
       
        private Mutuelle.cntrMutuelleInfo cntrMutuelleInfo1;
        public MedicalRecord.Contols.cntrMedicalRecords cntrMedicalRecords1;
    }
}