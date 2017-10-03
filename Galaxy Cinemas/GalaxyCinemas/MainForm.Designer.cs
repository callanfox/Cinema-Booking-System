namespace GalaxyCinemas
{
    partial class MainForm
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
            this.btnImport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOpenBookingForm = new System.Windows.Forms.Button();
            this.btnExportDataForm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(129, 138);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(213, 31);
            this.btnImport.TabIndex = 0;
            this.btnImport.Text = "Import Movies and Sessions ";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SketchFlow Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Berlin Sans FB Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(97, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(286, 43);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Galaxy Cinemas";
            // 
            // btnOpenBookingForm
            // 
            this.btnOpenBookingForm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnOpenBookingForm.Location = new System.Drawing.Point(129, 196);
            this.btnOpenBookingForm.Name = "btnOpenBookingForm";
            this.btnOpenBookingForm.Size = new System.Drawing.Size(213, 31);
            this.btnOpenBookingForm.TabIndex = 6;
            this.btnOpenBookingForm.Text = "Make a Booking";
            this.btnOpenBookingForm.UseVisualStyleBackColor = true;
            this.btnOpenBookingForm.Click += new System.EventHandler(this.btnOpenBookingForm_Click_1);
            // 
            // btnExportDataForm
            // 
            this.btnExportDataForm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExportDataForm.Location = new System.Drawing.Point(129, 254);
            this.btnExportDataForm.Name = "btnExportDataForm";
            this.btnExportDataForm.Size = new System.Drawing.Size(213, 31);
            this.btnExportDataForm.TabIndex = 8;
            this.btnExportDataForm.Text = "Export Data";
            this.btnExportDataForm.UseVisualStyleBackColor = true;
            this.btnExportDataForm.Click += new System.EventHandler(this.btnExportDataForm_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(355, 333);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 31);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 417);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportDataForm);
            this.Controls.Add(this.btnOpenBookingForm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnOpenBookingForm_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOpenBookingForm;
        private System.Windows.Forms.Button btnExportDataForm;
        private System.Windows.Forms.Button btnClose;
    }
}