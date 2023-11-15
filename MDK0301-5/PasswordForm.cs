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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void PasswordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (!Koniki.checkPassword(loginBox.Text, passwordBox.Text)) 
                { Application.Exit(); }                            
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (Koniki.checkPassword(loginBox.Text, passwordBox.Text)) 
            { this.Close(); } 
            else { MessageBox.Show("Неверный логин или пароль. Обратитесь к системному адмнистратору");}
        }
    }
}
