using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Common;

namespace GalaxyCinemas
{
    public partial class MainForm : Form
    {
        private List<ISpecialPlugin> specialPlugins = new List<ISpecialPlugin>();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath);

                foreach (FileInfo file in dir.GetFiles("Plugin*.dll"))
                {
                    string name = Path.GetFileNameWithoutExtension(file.Name);


                    Assembly pluginAssembly = Assembly.Load(name);

                    var plugins = from type in pluginAssembly.GetTypes()
                                  where typeof(ISpecialPlugin).IsAssignableFrom(type) && !type.IsInterface
                                  select type;

                    foreach (Type pluginType in plugins)
                    {
                        ISpecialPlugin plugin = Activator.CreateInstance(pluginType) as ISpecialPlugin;
                        specialPlugins.Add(plugin);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while loading special price plugins.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // To ensure the main form has focus after a child form is closed.
            this.Focus();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportDataForm idf = new ImportDataForm();
            idf.FormClosed += ChildFormClosed;
            idf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenBookingForm_Click_1(object sender, EventArgs e)
        {
            BookingForm bf = new BookingForm(specialPlugins);
            bf.FormClosed += ChildFormClosed;
            bf.Show();
        }

        private void btnExportDataForm_Click(object sender, EventArgs e)
        {
            ExportDataForm edf = new ExportDataForm();
            edf.FormClosed += ChildFormClosed;
            edf.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
