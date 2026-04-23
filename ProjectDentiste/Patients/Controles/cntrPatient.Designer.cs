namespace ProjectDentiste.Patients.Controles
{
    partial class cntrPatient
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNoteGenerale = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDentistID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.MyPbMale = new System.Windows.Forms.PictureBox();
            this.MyPbEmail = new System.Windows.Forms.PictureBox();
            this.MyPb3 = new System.Windows.Forms.PictureBox();
            this.MyPb2 = new System.Windows.Forms.PictureBox();
            this.DateDeCreation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNumeroDeDossier = new System.Windows.Forms.TextBox();
            this.errorProviderPatient = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MyPbMale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNoteGenerale
            // 
            this.txtNoteGenerale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNoteGenerale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoteGenerale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoteGenerale.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNoteGenerale.Location = new System.Drawing.Point(498, 55);
            this.txtNoteGenerale.Multiline = true;
            this.txtNoteGenerale.Name = "txtNoteGenerale";
            this.txtNoteGenerale.Size = new System.Drawing.Size(293, 138);
            this.txtNoteGenerale.TabIndex = 186;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(58, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 20);
            this.label20.TabIndex = 187;
            this.label20.Text = "Folder number:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(63, 66);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 20);
            this.label19.TabIndex = 185;
            this.label19.Text = "Created AT:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(586, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 20);
            this.label17.TabIndex = 182;
            this.label17.Text = "General Notes:";
            // 
            // txtDentistID
            // 
            this.txtDentistID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDentistID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDentistID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDentistID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDentistID.Location = new System.Drawing.Point(229, 113);
            this.txtDentistID.Name = "txtDentistID";
            this.txtDentistID.Size = new System.Drawing.Size(120, 21);
            this.txtDentistID.TabIndex = 3;
            this.txtDentistID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDentistID_KeyPress);
            this.txtDentistID.Validating += new System.ComponentModel.CancelEventHandler(this.txtDentistID_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(63, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 20);
            this.label18.TabIndex = 200;
            this.label18.Text = "DentistID:";
            // 
            // MyPbMale
            // 
            this.MyPbMale.Location = new System.Drawing.Point(10, 113);
            this.MyPbMale.Name = "MyPbMale";
            this.MyPbMale.Size = new System.Drawing.Size(32, 27);
            this.MyPbMale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPbMale.TabIndex = 201;
            this.MyPbMale.TabStop = false;
            // 
            // MyPbEmail
            // 
            this.MyPbEmail.Location = new System.Drawing.Point(537, 16);
            this.MyPbEmail.Name = "MyPbEmail";
            this.MyPbEmail.Size = new System.Drawing.Size(32, 34);
            this.MyPbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPbEmail.TabIndex = 193;
            this.MyPbEmail.TabStop = false;
            // 
            // MyPb3
            // 
            this.MyPb3.Location = new System.Drawing.Point(10, 66);
            this.MyPb3.Name = "MyPb3";
            this.MyPb3.Size = new System.Drawing.Size(32, 27);
            this.MyPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPb3.TabIndex = 191;
            this.MyPb3.TabStop = false;
            // 
            // MyPb2
            // 
            this.MyPb2.Location = new System.Drawing.Point(10, 26);
            this.MyPb2.Name = "MyPb2";
            this.MyPb2.Size = new System.Drawing.Size(32, 27);
            this.MyPb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPb2.TabIndex = 190;
            this.MyPb2.TabStop = false;
            // 
            // DateDeCreation
            // 
            this.DateDeCreation.Checked = true;
            this.DateDeCreation.Enabled = false;
            this.DateDeCreation.FillColor = System.Drawing.Color.Lavender;
            this.DateDeCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.DateDeCreation.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateDeCreation.Location = new System.Drawing.Point(229, 62);
            this.DateDeCreation.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateDeCreation.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateDeCreation.Name = "DateDeCreation";
            this.DateDeCreation.Size = new System.Drawing.Size(259, 24);
            this.DateDeCreation.TabIndex = 2;
            this.DateDeCreation.Value = new System.DateTime(2026, 3, 6, 10, 54, 43, 920);
            // 
            // txtNumeroDeDossier
            // 
            this.txtNumeroDeDossier.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNumeroDeDossier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroDeDossier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDeDossier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNumeroDeDossier.Location = new System.Drawing.Point(247, 21);
            this.txtNumeroDeDossier.Multiline = true;
            this.txtNumeroDeDossier.Name = "txtNumeroDeDossier";
            this.txtNumeroDeDossier.Size = new System.Drawing.Size(155, 29);
            this.txtNumeroDeDossier.TabIndex = 1;
            this.txtNumeroDeDossier.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumeroDeDossier_Validating);
            // 
            // errorProviderPatient
            // 
            this.errorProviderPatient.ContainerControl = this;
            // 
            // cntrPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.DateDeCreation);
            this.Controls.Add(this.txtDentistID);
            this.Controls.Add(this.MyPbMale);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.MyPbEmail);
            this.Controls.Add(this.MyPb3);
            this.Controls.Add(this.MyPb2);
            this.Controls.Add(this.txtNoteGenerale);
            this.Controls.Add(this.txtNumeroDeDossier);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Name = "cntrPatient";
            this.Size = new System.Drawing.Size(831, 234);
            ((System.ComponentModel.ISupportInitialize)(this.MyPbMale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MyPbEmail;
        private System.Windows.Forms.PictureBox MyPb3;
        private System.Windows.Forms.PictureBox MyPb2;
        public System.Windows.Forms.TextBox txtNoteGenerale;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txtDentistID;
        private System.Windows.Forms.PictureBox MyPbMale;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox txtNumeroDeDossier;
        public Guna.UI2.WinForms.Guna2DateTimePicker DateDeCreation;
        private System.Windows.Forms.ErrorProvider errorProviderPatient;
    }
}
