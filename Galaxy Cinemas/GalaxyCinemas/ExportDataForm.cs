using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using Common.Business_Objects;

namespace GalaxyCinemas
{   [Serializable]
    public partial class ExportDataForm : Form
    {
        public ExportDataForm()
        {
            InitializeComponent();
            this.FormClosing += ExportDataForm_FormClosing;
        }

        /// <summary>
        /// Allows user to browse to a save location for the XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectExportBooking_Click(object sender, EventArgs e)
        {
            txtFileBooking.Focus(); // Set focus on this field. Moving focus will force validation of the value.
        }

        /// <summary>
        /// Export bookings to XML file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        /// <summary>
        /// Serialize bookings to XML file.
        /// </summary>
        /// <param name="list"></param>
        private void Serialise(List<Booking> list, string filename)
        { 
           
           XmlSerializer serializer = new XmlSerializer(typeof(List<Booking>));
           using (TextWriter writer = new StringWriter())
           {

               serializer.Serialize(writer, list);

           }
        }
    


        /// <summary>
        /// Closes the form and goes back to main menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        #region Form validation

        /// <summary>
        /// Check all form fields are valid. This works even if they haven't clicked into every field.
        /// </summary>
        /// <returns></returns>
        private bool IsFormValid()
        {
            foreach (Control control in Controls)
            {
                // Set focus on control
                control.Focus();
                // Validate causes the control's Validating event to be fired,
                // if CausesValidation is True
                if (!Validate())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Validate the filename.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFileBooking_Validating(object sender, CancelEventArgs e)
        {
            // Check if file path is valid.
            bool pathValid = true;
            try
            {
                FileInfo fi = new FileInfo(txtFileBooking.Text);
                pathValid = fi.Directory.Exists;
            }
            catch (Exception)
            {
                pathValid = false;
            }

            if (!pathValid)
            {
                errorProvider.SetError(txtFileBooking, "Please choose a valid path to export to");
                e.Cancel = true; // Don't allow moving to the next field.
            }
            else errorProvider.SetError(txtFileBooking, ""); // Clear error if all fine.
        }

        /// <summary>
        /// Validate the to date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpTo_Validating(object sender, CancelEventArgs e)
        {
            if (dtpTo.Value.Date < dtpFrom.Value.Date)
            {
                errorProvider.SetError(dtpTo, "The 'to' date must be greater than or equal to the 'from' date");
                e.Cancel = true; // Don't allow moving to the next field.
            }
            else errorProvider.SetError(dtpTo, ""); // Clear error if all fine.
        }

        private void ExportDataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Don't allow validation to prevent closing.
            e.Cancel = false;
        }

        #endregion

        private void ExportDataForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            txtFileBooking.Text = saveFileDialog.FileName.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportBookings_Click(object sender, EventArgs e)
        {
            if (IsFormValid() == false)
            {
                return;
            }
            else 
            {
                try 
                {    
                    List<Booking> bookings = DataLayer.DataLayer.GetBookingsInDateRange(dtpFrom.Value, dtpTo.Value);
                    Serialise(bookings, txtFileBooking.ToString());
                    MessageBox.Show(bookings.Count + " bookings were successfully exported.", "Successful Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("An error occurred while booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtFileBooking_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
