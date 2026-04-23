namespace ProjectDentiste.Patients
{
    partial class frmPatientImage
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
            this.pbPatientImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPatientImage
            // 
            this.pbPatientImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPatientImage.Image = global::ProjectDentiste.Properties.Resources.Aucune_image_disponible;
            this.pbPatientImage.Location = new System.Drawing.Point(0, 0);
            this.pbPatientImage.Name = "pbPatientImage";
            this.pbPatientImage.Size = new System.Drawing.Size(239, 206);
            this.pbPatientImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPatientImage.TabIndex = 1;
            this.pbPatientImage.TabStop = false;
            // 
            // frmPatientImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 206);
            this.Controls.Add(this.pbPatientImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatientImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmPatientImage";
            ((System.ComponentModel.ISupportInitialize)(this.pbPatientImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPatientImage;
    }
}