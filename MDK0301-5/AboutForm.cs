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
    public partial class AboutForm : Form
    {
        private int rabbitClick = 0;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rabbitClick++;
            clickLabel.Text = rabbitClick.ToString();
            if (rabbitClick == 13) {
                EasterEgg easterEgg = new EasterEgg();
                easterEgg.ShowDialog();
            }
        }
    }
}
