namespace ProjectDentiste.Allergies
{
    partial class frmAllergies
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAllergyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmplyeID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgGetAllAlergies = new System.Windows.Forms.DataGridView();
            this.contextMenuAllergies = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateAllergyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbtTitre = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dtAddedAT = new System.Windows.Forms.DateTimePicker();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGetAllAlergies)).BeginInit();
            this.contextMenuAllergies.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(40, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allergy Name:";
            // 
            // txtAllergyName
            // 
            this.txtAllergyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAllergyName.DefaultText = "";
            this.txtAllergyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAllergyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAllergyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAllergyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAllergyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAllergyName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAllergyName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAllergyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAllergyName.Location = new System.Drawing.Point(187, 112);
            this.txtAllergyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAllergyName.Name = "txtAllergyName";
            this.txtAllergyName.PlaceholderText = "";
            this.txtAllergyName.SelectedText = "";
            this.txtAllergyName.Size = new System.Drawing.Size(229, 30);
            this.txtAllergyName.TabIndex = 1;
            // 
            // txtEmplyeID
            // 
            this.txtEmplyeID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmplyeID.DefaultText = "";
            this.txtEmplyeID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmplyeID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmplyeID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmplyeID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmplyeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmplyeID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmplyeID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmplyeID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmplyeID.Location = new System.Drawing.Point(187, 198);
            this.txtEmplyeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmplyeID.Name = "txtEmplyeID";
            this.txtEmplyeID.PlaceholderText = "";
            this.txtEmplyeID.SelectedText = "";
            this.txtEmplyeID.Size = new System.Drawing.Size(229, 30);
            this.txtEmplyeID.TabIndex = 5;
            // 
            // dgGetAllAlergies
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dgGetAllAlergies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgGetAllAlergies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGetAllAlergies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgGetAllAlergies.BackgroundColor = System.Drawing.Color.White;
            this.dgGetAllAlergies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGetAllAlergies.ContextMenuStrip = this.contextMenuAllergies;
            this.dgGetAllAlergies.Location = new System.Drawing.Point(0, 246);
            this.dgGetAllAlergies.Name = "dgGetAllAlergies";
            this.dgGetAllAlergies.RowHeadersWidth = 51;
            this.dgGetAllAlergies.RowTemplate.Height = 24;
            this.dgGetAllAlergies.Size = new System.Drawing.Size(694, 340);
            this.dgGetAllAlergies.TabIndex = 8;
            this.dgGetAllAlergies.DoubleClick += new System.EventHandler(this.dgGetAllAlergies_DoubleClick);
            // 
            // contextMenuAllergies
            // 
            this.contextMenuAllergies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuAllergies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateAllergyToolStripMenuItem});
            this.contextMenuAllergies.Name = "contextMenuAllergies";
            this.contextMenuAllergies.Size = new System.Drawing.Size(179, 28);
            // 
            // updateAllergyToolStripMenuItem
            // 
            this.updateAllergyToolStripMenuItem.Name = "updateAllergyToolStripMenuItem";
            this.updateAllergyToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.updateAllergyToolStripMenuItem.Text = "Update Allergy";
            this.updateAllergyToolStripMenuItem.Click += new System.EventHandler(this.updateAllergyToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(40, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Added AT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(40, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "EmployeID:";
            // 
            // lbtTitre
            // 
            this.lbtTitre.AutoSize = true;
            this.lbtTitre.Font = new System.Drawing.Font("Segoe Print", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtTitre.ForeColor = System.Drawing.Color.Navy;
            this.lbtTitre.Location = new System.Drawing.Point(261, 9);
            this.lbtTitre.Name = "lbtTitre";
            this.lbtTitre.Size = new System.Drawing.Size(230, 84);
            this.lbtTitre.TabIndex = 16;
            this.lbtTitre.Text = "Allergies";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(70, 601);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(143, 42);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Add";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dtAddedAT
            // 
            this.dtAddedAT.Location = new System.Drawing.Point(187, 152);
            this.dtAddedAT.Name = "dtAddedAT";
            this.dtAddedAT.Size = new System.Drawing.Size(229, 22);
            this.dtAddedAT.TabIndex = 18;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(451, 601);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(148, 42);
            this.btnDone.TabIndex = 19;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.BlueViolet;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(261, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 42);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAllergies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(694, 659);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dtAddedAT);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lbtTitre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgGetAllAlergies);
            this.Controls.Add(this.txtEmplyeID);
            this.Controls.Add(this.txtAllergyName);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAllergies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAllergies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGetAllAlergies)).EndInit();
            this.contextMenuAllergies.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbtTitre;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2TextBox txtAllergyName;
        public Guna.UI2.WinForms.Guna2TextBox txtEmplyeID;
        public System.Windows.Forms.DataGridView dgGetAllAlergies;
        private System.Windows.Forms.DateTimePicker dtAddedAT;
        private System.Windows.Forms.Button btnDone;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuAllergies;
        private System.Windows.Forms.ToolStripMenuItem updateAllergyToolStripMenuItem;
    }
}