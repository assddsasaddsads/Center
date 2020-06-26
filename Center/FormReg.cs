using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Center
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
            {
                Users users = new Users();
                users.Login = textBoxLogin.Text;
                users.Password = textBoxPassword.Text;
                Program.WFCZN.Users.Add(users);
                Program.WFCZN.SaveChanges();
            }
        }
    }
}
