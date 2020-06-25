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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void buttonEmployer_Click(object sender, EventArgs e)
        {
            Form formEmployer = new FormEmployer();
            formEmployer.Show();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Form formStaff = new FormStaff();
            formStaff.Show();
        }

        private void buttonBank_Click(object sender, EventArgs e)
        {
            Form formBank = new FormBank();
            formBank.Show();
        }

        private void buttonJobless_Click(object sender, EventArgs e)
        {
            Form formJobless = new FormJobless();
            formJobless.Show();
        }

        private void buttonReception_Click(object sender, EventArgs e)
        {
            Form formReception = new FormReception();
            formReception.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formMagazine = new FormMagazine();
            formMagazine.Show();
        }
    }
}
