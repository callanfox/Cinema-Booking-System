namespace GalaxyCinemas
{
    partial class ExportDataForm
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
            this.btnSelectExportMovies = new System.Windows.Forms.Button();
            this.btnExportMoviesStart = new System.Windows.Forms.Button();
            this.btnMovieExportStop = new System.Windows.Forms.Button();
            this.txtFileMovie = new System.Windows.Forms.TextBox();
            this.btnSelectExportSessions = new System.Windows.Forms.Button();
            this.btnExportSessionsStart = new System.Windows.Forms.Button();
            this.btnExportSessionStop = new System.Windows.Forms.Button();
            this.txtFileSession = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtFileBooking = new System.Windows.Forms.TextBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExportBookings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectExportMovies
            // 
            this.btnSelectExportMovies.Location = new System.Drawing.Point(38, 381);
            this.btnSelectExportMovies.Name = "btnSelectExportMovies";
            this.btnSelectExportMovies.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportMovies.TabIndex = 0;
            this.btnSelectExportMovies.Text = "Select File for Exporting Movies";
            this.btnSelectExportMovies.UseVisualStyleBackColor = true;
            this.btnSelectExportMovies.Visible = false;
            // 
            // btnExportMoviesStart
            // 
            this.btnExportMoviesStart.Location = new System.Drawing.Point(38, 436);
            this.btnExportMoviesStart.Name = "btnExportMoviesStart";
            this.btnExportMoviesStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportMoviesStart.TabIndex = 1;
            this.btnExportMoviesStart.Text = "Start";
            this.btnExportMoviesStart.UseVisualStyleBackColor = true;
            this.btnExportMoviesStart.Visible = false;
            // 
            // btnMovieExportStop
            // 
            this.btnMovieExportStop.Location = new System.Drawing.Point(38, 436);
            this.btnMovieExportStop.Name = "btnMovieExportStop";
            this.btnMovieExportStop.Size = new System.Drawing.Size(75, 23);
            this.btnMovieExportStop.TabIndex = 2;
            this.btnMovieExportStop.Text = "Stop";
            this.btnMovieExportStop.UseVisualStyleBackColor = true;
            this.btnMovieExportStop.Visible = false;
            // 
            // txtFileMovie
            // 
            this.txtFileMovie.Location = new System.Drawing.Point(38, 410);
            this.txtFileMovie.Name = "txtFileMovie";
            this.txtFileMovie.Size = new System.Drawing.Size(242, 20);
            this.txtFileMovie.TabIndex = 3;
            this.txtFileMovie.Visible = false;
            // 
            // btnSelectExportSessions
            // 
            this.btnSelectExportSessions.Location = new System.Drawing.Point(38, 498);
            this.btnSelectExportSessions.Name = "btnSelectExportSessions";
            this.btnSelectExportSessions.Size = new System.Drawing.Size(179, 23);
            this.btnSelectExportSessions.TabIndex = 4;
            this.btnSelectExportSessions.Text = "Select File for Exporting Sessions";
            this.btnSelectExportSessions.UseVisualStyleBackColor = true;
            this.btnSelectExportSessions.Visible = false;
            // 
            // btnExportSessionsStart
            // 
            this.btnExportSessionsStart.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionsStart.Name = "btnExportSessionsStart";
            this.btnExportSessionsStart.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionsStart.TabIndex = 5;
            this.btnExportSessionsStart.Text = "Start";
            this.btnExportSessionsStart.UseVisualStyleBackColor = true;
            this.btnExportSessionsStart.Visible = false;
            // 
            // btnExportSessionStop
            // 
            this.btnExportSessionStop.Location = new System.Drawing.Point(38, 553);
            this.btnExportSessionStop.Name = "btnExportSessionStop";
            this.btnExportSessionStop.Size = new System.Drawing.Size(75, 23);
            this.btnExportSessionStop.TabIndex = 6;
            this.btnExportSessionStop.Text = "Stop";
            this.btnExportSessionStop.UseVisualStyleBackColor = true;
            this.btnExportSessionStop.Visible = false;
            // 
            // txtFileSession
            // 
            this.txtFileSession.Location = new System.Drawing.Point(38, 527);
            this.txtFileSession.Name = "txtFileSession";
            this.txtFileSession.Size = new System.Drawing.Size(242, 20);
            this.txtFileSession.TabIndex = 7;
            this.txtFileSession.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(322, 419);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 527);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.Filter = "XML|*.xml";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblSaveLocation.Location = new System.Drawing.Point(36, 27);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(90, 15);
            this.lblSaveLocation.TabIndex = 10;
            this.lblSaveLocation.Text = "Save Location:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblTo.Location = new System.Drawing.Point(379, 109);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 15);
            this.lblTo.TabIndex = 11;
            this.lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblFrom.Location = new System.Drawing.Point(87, 109);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(39, 15);
            this.lblFrom.TabIndex = 12;
            this.lblFrom.Text = "From:";
            // 
            // txtFileBooking
            // 
            this.txtFileBooking.Font = new System.Drawing.Font("Arial", 8.75F);
            this.txtFileBooking.Location = new System.Drawing.Point(133, 24);
            this.txtFileBooking.Name = "txtFileBooking";
            this.txtFileBooking.Size = new System.Drawing.Size(359, 21);
            this.txtFileBooking.TabIndex = 13;
            this.txtFileBooking.TextChanged += new System.EventHandler(this.txtFileBooking_TextChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 8.75F);
            this.dtpFrom.Location = new System.Drawing.Point(133, 106);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 21);
            this.dtpFrom.TabIndex = 14;
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial", 8.75F);
            this.dtpTo.Location = new System.Drawing.Point(408, 105);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 21);
            this.dtpTo.TabIndex = 15;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.Location = new System.Drawing.Point(533, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(533, 167);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExportBookings
            // 
            this.btnExportBookings.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnExportBookings.Location = new System.Drawing.Point(204, 167);
            this.btnExportBookings.Name = "btnExportBookings";
            this.btnExportBookings.Size = new System.Drawing.Size(129, 23);
            this.btnExportBookings.TabIndex = 18;
            this.btnExportBookings.Text = "Export Bookings";
            this.btnExportBookings.UseVisualStyleBackColor = true;
            this.btnExportBookings.Click += new System.EventHandler(this.btnExportBookings_Click);
            // 
            // ExportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(655, 240);
            this.Controls.Add(this.btnExportBookings);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtFileBooking);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtFileSession);
            this.Controls.Add(this.btnExportSessionStop);
            this.Controls.Add(this.btnExportSessionsStart);
            this.Controls.Add(this.btnSelectExportSessions);
            this.Controls.Add(this.txtFileMovie);
            this.Controls.Add(this.btnMovieExportStop);
            this.Controls.Add(this.btnExportMoviesStart);
            this.Controls.Add(this.btnSelectExportMovies);
            this.Name = "ExportDataForm";
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.ExportDataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectExportMovies;
        private System.Windows.Forms.Button btnExportMoviesStart;
        private System.Windows.Forms.Button btnMovieExportStop;
        private System.Windows.Forms.TextBox txtFileMovie;
        private System.Windows.Forms.Button btnSelectExportSessions;
        private System.Windows.Forms.Button btnExportSessionsStart;
        private System.Windows.Forms.Button btnExportSessionStop;
        private System.Windows.Forms.TextBox txtFileSession;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.TextBox txtFileBooking;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSaveLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportBookings;
    }
}