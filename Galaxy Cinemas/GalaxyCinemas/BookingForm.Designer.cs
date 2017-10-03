namespace GalaxyCinemas
{
    partial class BookingForm
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.cboSession = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpSessionDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSpecialName = new System.Windows.Forms.Label();
            this.lblOriginalPrice = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(29, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboMovie
            // 
            this.cboMovie.DisplayMember = "Title";
            this.cboMovie.Font = new System.Drawing.Font("Arial", 8.75F);
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Location = new System.Drawing.Point(162, 24);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(400, 23);
            this.cboMovie.TabIndex = 2;
            this.cboMovie.ValueMember = "ID";
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            this.cboMovie.Validating += new System.ComponentModel.CancelEventHandler(this.cboMovie_Validating);
            // 
            // cboSession
            // 
            this.cboSession.Font = new System.Drawing.Font("Arial", 8.75F);
            this.cboSession.FormattingEnabled = true;
            this.cboSession.Location = new System.Drawing.Point(162, 106);
            this.cboSession.Name = "cboSession";
            this.cboSession.Size = new System.Drawing.Size(121, 23);
            this.cboSession.TabIndex = 3;
            this.cboSession.SelectedIndexChanged += new System.EventHandler(this.cboSession_SelectedIndexChanged);
            this.cboSession.Validating += new System.ComponentModel.CancelEventHandler(this.cboSession_Validating);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 8.75F);
            this.txtQuantity.Location = new System.Drawing.Point(162, 149);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(27, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Movie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(27, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Session Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Special";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(27, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Final Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Session Date";
            // 
            // dtpSessionDate
            // 
            this.dtpSessionDate.Font = new System.Drawing.Font("Arial", 8.75F);
            this.dtpSessionDate.Location = new System.Drawing.Point(162, 68);
            this.dtpSessionDate.MinDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.dtpSessionDate.Name = "dtpSessionDate";
            this.dtpSessionDate.Size = new System.Drawing.Size(200, 21);
            this.dtpSessionDate.TabIndex = 17;
            this.dtpSessionDate.ValueChanged += new System.EventHandler(this.dtpSessionDate_ValueChanged);
            this.dtpSessionDate.Validating += new System.ComponentModel.CancelEventHandler(this.SessionDateTimePicker_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(27, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Original Price";
            // 
            // lblSpecialName
            // 
            this.lblSpecialName.AutoSize = true;
            this.lblSpecialName.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.lblSpecialName.Location = new System.Drawing.Point(162, 197);
            this.lblSpecialName.Name = "lblSpecialName";
            this.lblSpecialName.Size = new System.Drawing.Size(0, 15);
            this.lblSpecialName.TabIndex = 24;
            // 
            // lblOriginalPrice
            // 
            this.lblOriginalPrice.AutoSize = true;
            this.lblOriginalPrice.Font = new System.Drawing.Font("Arial", 8.75F);
            this.lblOriginalPrice.Location = new System.Drawing.Point(162, 240);
            this.lblOriginalPrice.Name = "lblOriginalPrice";
            this.lblOriginalPrice.Size = new System.Drawing.Size(0, 15);
            this.lblOriginalPrice.TabIndex = 25;
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(162, 285);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 15);
            this.lblFinalPrice.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(487, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Back";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 393);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.lblOriginalPrice);
            this.Controls.Add(this.lblSpecialName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpSessionDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cboSession);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.btnSubmit);
            this.Name = "BookingForm";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.ComboBox cboSession;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpSessionDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSpecialName;
        private System.Windows.Forms.Label lblOriginalPrice;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnClose;
    }
}

