namespace ProjectDentiste.Personnes
{
    partial class ctrlPersonInfo
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
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Label();
            this.btnRemoveImage = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.errorProviderPerson = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtNationalNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MypbImage = new System.Windows.Forms.PictureBox();
            this.MyPb1 = new System.Windows.Forms.PictureBox();
            this.MyPB6 = new System.Windows.Forms.PictureBox();
            this.MyPbDate = new System.Windows.Forms.PictureBox();
            this.MyPbAddress = new System.Windows.Forms.PictureBox();
            this.MyPbEmail = new System.Windows.Forms.PictureBox();
            this.MyPb3 = new System.Windows.Forms.PictureBox();
            this.MyPb2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MypbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPB6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPersonID
            // 
            this.txtPersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPersonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonID.Enabled = false;
            this.txtPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonID.ForeColor = System.Drawing.Color.Black;
            this.txtPersonID.Location = new System.Drawing.Point(179, 17);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(135, 23);
            this.txtPersonID.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(430, 101);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 18);
            this.label22.TabIndex = 164;
            this.label22.Text = "Date Of Birth";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.Location = new System.Drawing.Point(575, 135);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 22);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhone_Validating);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAddress.Location = new System.Drawing.Point(174, 199);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(328, 48);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(176, 159);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(227, 34);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFirstName.Location = new System.Drawing.Point(179, 93);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(224, 22);
            this.txtFirstName.TabIndex = 2;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(54, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 20);
            this.label20.TabIndex = 162;
            this.label20.Text = "FirstName";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(54, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 20);
            this.label19.TabIndex = 160;
            this.label19.Text = "LastName";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(54, 172);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 157;
            this.label17.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(54, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 156;
            this.label16.Text = "Address";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(454, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 18);
            this.label13.TabIndex = 153;
            this.label13.Text = "Phone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(62, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 20);
            this.label11.TabIndex = 151;
            this.label11.Text = "PersonID";
            // 
            // btnAddImage
            // 
            this.btnAddImage.AutoSize = true;
            this.btnAddImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddImage.Location = new System.Drawing.Point(891, 206);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(88, 20);
            this.btnAddImage.TabIndex = 8;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.AutoSize = true;
            this.btnRemoveImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRemoveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoveImage.Location = new System.Drawing.Point(882, 239);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(122, 20);
            this.btnRemoveImage.TabIndex = 9;
            this.btnRemoveImage.Text = "Remove Image";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLastName.Location = new System.Drawing.Point(176, 127);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(227, 22);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Location = new System.Drawing.Point(591, 96);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dtDateOfBirth.TabIndex = 6;
            // 
            // errorProviderPerson
            // 
            this.errorProviderPerson.ContainerControl = this;
            // 
            // txtNationalNumber
            // 
            this.txtNationalNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNationalNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNationalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNationalNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNationalNumber.Location = new System.Drawing.Point(179, 57);
            this.txtNationalNumber.Multiline = true;
            this.txtNationalNumber.Name = "txtNationalNumber";
            this.txtNationalNumber.Size = new System.Drawing.Size(135, 22);
            this.txtNationalNumber.TabIndex = 1;
            this.txtNationalNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtNationalNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 179;
            this.label1.Text = "NO-Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // MypbImage
            // 
            this.MypbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MypbImage.Location = new System.Drawing.Point(826, 17);
            this.MypbImage.Name = "MypbImage";
            this.MypbImage.Size = new System.Drawing.Size(216, 175);
            this.MypbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MypbImage.TabIndex = 176;
            this.MypbImage.TabStop = false;
            // 
            // MyPb1
            // 
            this.MyPb1.Image = global::ProjectDentiste.Properties.Resources.Person_32;
            this.MyPb1.Location = new System.Drawing.Point(13, 11);
            this.MyPb1.Name = "MyPb1";
            this.MyPb1.Size = new System.Drawing.Size(31, 26);
            this.MyPb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPb1.TabIndex = 173;
            this.MyPb1.TabStop = false;
            // 
            // MyPB6
            // 
            this.MyPB6.Image = global::ProjectDentiste.Properties.Resources.Phone_32;
            this.MyPB6.Location = new System.Drawing.Point(525, 135);
            this.MyPB6.Name = "MyPB6";
            this.MyPB6.Size = new System.Drawing.Size(32, 23);
            this.MyPB6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPB6.TabIndex = 171;
            this.MyPB6.TabStop = false;
            // 
            // MyPbDate
            // 
            this.MyPbDate.Image = global::ProjectDentiste.Properties.Resources.Calculator1;
            this.MyPbDate.Location = new System.Drawing.Point(525, 93);
            this.MyPbDate.Name = "MyPbDate";
            this.MyPbDate.Size = new System.Drawing.Size(32, 29);
            this.MyPbDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPbDate.TabIndex = 170;
            this.MyPbDate.TabStop = false;
            // 
            // MyPbAddress
            // 
            this.MyPbAddress.Image = global::ProjectDentiste.Properties.Resources.Adress;
            this.MyPbAddress.Location = new System.Drawing.Point(12, 206);
            this.MyPbAddress.Name = "MyPbAddress";
            this.MyPbAddress.Size = new System.Drawing.Size(32, 34);
            this.MyPbAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPbAddress.TabIndex = 169;
            this.MyPbAddress.TabStop = false;
            // 
            // MyPbEmail
            // 
            this.MyPbEmail.Image = global::ProjectDentiste.Properties.Resources.Email_32;
            this.MyPbEmail.Location = new System.Drawing.Point(12, 164);
            this.MyPbEmail.Name = "MyPbEmail";
            this.MyPbEmail.Size = new System.Drawing.Size(32, 34);
            this.MyPbEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPbEmail.TabIndex = 168;
            this.MyPbEmail.TabStop = false;
            // 
            // MyPb3
            // 
            this.MyPb3.Image = global::ProjectDentiste.Properties.Resources.Application;
            this.MyPb3.Location = new System.Drawing.Point(12, 125);
            this.MyPb3.Name = "MyPb3";
            this.MyPb3.Size = new System.Drawing.Size(32, 34);
            this.MyPb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPb3.TabIndex = 166;
            this.MyPb3.TabStop = false;
            // 
            // MyPb2
            // 
            this.MyPb2.Location = new System.Drawing.Point(12, 85);
            this.MyPb2.Name = "MyPb2";
            this.MyPb2.Size = new System.Drawing.Size(32, 34);
            this.MyPb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPb2.TabIndex = 165;
            this.MyPb2.TabStop = false;
            // 
            // ctrlPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNationalNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnRemoveImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.MypbImage);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.MyPb1);
            this.Controls.Add(this.MyPB6);
            this.Controls.Add(this.MyPbDate);
            this.Controls.Add(this.MyPbAddress);
            this.Controls.Add(this.MyPbEmail);
            this.Controls.Add(this.MyPb3);
            this.Controls.Add(this.MyPb2);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Name = "ctrlPersonInfo";
            this.Size = new System.Drawing.Size(1085, 280);
            this.Load += new System.EventHandler(this.ctrlPersonInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MypbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPB6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPbEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox MypbImage;
        public System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.PictureBox MyPb1;
        private System.Windows.Forms.PictureBox MyPB6;
        private System.Windows.Forms.PictureBox MyPbDate;
        private System.Windows.Forms.PictureBox MyPbAddress;
        private System.Windows.Forms.PictureBox MyPbEmail;
        private System.Windows.Forms.PictureBox MyPb3;
        private System.Windows.Forms.PictureBox MyPb2;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label btnAddImage;
        private System.Windows.Forms.Label btnRemoveImage;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.DateTimePicker dtDateOfBirth;
        public System.Windows.Forms.ErrorProvider errorProviderPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtNationalNumber;
        private System.Windows.Forms.Label label1;
    }
}
