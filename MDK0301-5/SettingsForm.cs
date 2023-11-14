using MDK0301_5.Properties;
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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            FormNameBox.Text = Properties.Settings.Default.MainFormName;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MainFormName = FormNameBox.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
