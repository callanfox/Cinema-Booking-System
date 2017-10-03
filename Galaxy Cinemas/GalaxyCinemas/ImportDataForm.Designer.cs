namespace GalaxyCinemas
{
    partial class ImportDataForm
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
            this.btnMovieImportStart = new System.Windows.Forms.Button();
            this.btnMovieImportStop = new System.Windows.Forms.Button();
            this.btnSelectMovieFile = new System.Windows.Forms.Button();
            this.opnFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtMovieFileName = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSessionFileName = new System.Windows.Forms.TextBox();
            this.btnSelectSessionFile = new System.Windows.Forms.Button();
            this.btnSessionImportStart = new System.Windows.Forms.Button();
            this.btnSessionImportStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMovieImportStart
            // 
            this.btnMovieImportStart.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnMovieImportStart.Location = new System.Drawing.Point(295, 99);
            this.btnMovieImportStart.Name = "btnMovieImportStart";
            this.btnMovieImportStart.Size = new System.Drawing.Size(75, 23);
            this.btnMovieImportStart.TabIndex = 0;
            this.btnMovieImportStart.Text = "Import";
            this.btnMovieImportStart.UseVisualStyleBackColor = true;
            this.btnMovieImportStart.Click += new System.EventHandler(this.btnMovieImportStart_Click);
            // 
            // btnMovieImportStop
            // 
            this.btnMovieImportStop.CausesValidation = false;
            this.btnMovieImportStop.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnMovieImportStop.Location = new System.Drawing.Point(295, 99);
            this.btnMovieImportStop.Name = "btnMovieImportStop";
            this.btnMovieImportStop.Size = new System.Drawing.Size(75, 23);
            this.btnMovieImportStop.TabIndex = 1;
            this.btnMovieImportStop.Text = "Stop";
            this.btnMovieImportStop.UseVisualStyleBackColor = true;
            this.btnMovieImportStop.Visible = false;
            this.btnMovieImportStop.Click += new System.EventHandler(this.btnMovieImportStop_Click);
            // 
            // btnSelectMovieFile
            // 
            this.btnSelectMovieFile.CausesValidation = false;
            this.btnSelectMovieFile.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectMovieFile.Location = new System.Drawing.Point(48, 44);
            this.btnSelectMovieFile.Name = "btnSelectMovieFile";
            this.btnSelectMovieFile.Size = new System.Drawing.Size(152, 23);
            this.btnSelectMovieFile.TabIndex = 3;
            this.btnSelectMovieFile.Text = "Select Movie File";
            this.btnSelectMovieFile.UseVisualStyleBackColor = true;
            this.btnSelectMovieFile.Click += new System.EventHandler(this.btnSelectMovieFile_Click);
            // 
            // txtMovieFileName
            // 
            this.txtMovieFileName.Location = new System.Drawing.Point(48, 73);
            this.txtMovieFileName.Name = "txtMovieFileName";
            this.txtMovieFileName.Size = new System.Drawing.Size(322, 20);
            this.txtMovieFileName.TabIndex = 4;
            this.txtMovieFileName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMovieFileName_Validating);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(86, 362);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(244, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSessionFileName
            // 
            this.txtSessionFileName.Location = new System.Drawing.Point(48, 234);
            this.txtSessionFileName.Name = "txtSessionFileName";
            this.txtSessionFileName.Size = new System.Drawing.Size(322, 20);
            this.txtSessionFileName.TabIndex = 7;
            // 
            // btnSelectSessionFile
            // 
            this.btnSelectSessionFile.CausesValidation = false;
            this.btnSelectSessionFile.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSelectSessionFile.Location = new System.Drawing.Point(48, 205);
            this.btnSelectSessionFile.Name = "btnSelectSessionFile";
            this.btnSelectSessionFile.Size = new System.Drawing.Size(152, 23);
            this.btnSelectSessionFile.TabIndex = 6;
            this.btnSelectSessionFile.Text = "Select Session File";
            this.btnSelectSessionFile.UseVisualStyleBackColor = true;
            this.btnSelectSessionFile.Click += new System.EventHandler(this.btnSelectSessionFile_Click);
            // 
            // btnSessionImportStart
            // 
            this.btnSessionImportStart.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSessionImportStart.Location = new System.Drawing.Point(295, 260);
            this.btnSessionImportStart.Name = "btnSessionImportStart";
            this.btnSessionImportStart.Size = new System.Drawing.Size(75, 23);
            this.btnSessionImportStart.TabIndex = 8;
            this.btnSessionImportStart.Text = "Import";
            this.btnSessionImportStart.UseVisualStyleBackColor = true;
            this.btnSessionImportStart.Click += new System.EventHandler(this.btnSessionImportStart_Click);
            // 
            // btnSessionImportStop
            // 
            this.btnSessionImportStop.CausesValidation = false;
            this.btnSessionImportStop.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSessionImportStop.Location = new System.Drawing.Point(295, 260);
            this.btnSessionImportStop.Name = "btnSessionImportStop";
            this.btnSessionImportStop.Size = new System.Drawing.Size(75, 23);
            this.btnSessionImportStop.TabIndex = 9;
            this.btnSessionImportStop.Text = "Stop";
            this.btnSessionImportStop.UseVisualStyleBackColor = true;
            this.btnSessionImportStop.Visible = false;
            this.btnSessionImportStop.Click += new System.EventHandler(this.btnSessionImportStop_Click);
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 401);
            this.Controls.Add(this.btnSessionImportStop);
            this.Controls.Add(this.btnSessionImportStart);
            this.Controls.Add(this.txtSessionFileName);
            this.Controls.Add(this.btnSelectSessionFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.txtMovieFileName);
            this.Controls.Add(this.btnSelectMovieFile);
            this.Controls.Add(this.btnMovieImportStop);
            this.Controls.Add(this.btnMovieImportStart);
            this.Name = "ImportDataForm";
            this.Text = "Import";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovieImportStart;
        private System.Windows.Forms.Button btnMovieImportStop;
        private System.Windows.Forms.Button btnSelectMovieFile;
        private System.Windows.Forms.OpenFileDialog opnFileDialog;
        private System.Windows.Forms.TextBox txtMovieFileName;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSessionImportStart;
        private System.Windows.Forms.TextBox txtSessionFileName;
        private System.Windows.Forms.Button btnSelectSessionFile;
        private System.Windows.Forms.Button btnSessionImportStop;
    }
}