using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK0301_5
{
    public partial class MainDataForm : Form
    {
        private const string helpfile = "help.chm";
        public MainDataForm()
        {
            InitializeComponent();
        }

        private void MainDataForm_Load(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            passwordForm.ShowDialog();

            this.Text = Properties.Settings.Default.MainFormName;

        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void MainDataForm_Activated(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.MainFormName;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.TableOfContents;
            Help.ShowHelp(this, helpfile, navigator);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
