using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stp_gui.Properties;

namespace stp_gui
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            stpDirTextBox.Text = Settings.Default.stpdir;
        }

        private void selectStpDirButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.SelectedPath = stpDirTextBox.Text;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    stpDirTextBox.Text = dlg.SelectedPath;
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Settings.Default.stpdir = stpDirTextBox.Text;
            Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
