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
    public partial class FormEmployer : Form
    {
        public FormEmployer()
        {
            InitializeComponent();
            ShowEmployer();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            EmployerSet employerSet = new EmployerSet();
            employerSet.FirstName = textBoxFirstName.Text;
            employerSet.LastName = textBoxLastName.Text;
            employerSet.MiddleName = textBoxMiddleName.Text;
            employerSet.Phone = textBoxPhone.Text;
            employerSet.Email = textBoxEmail.Text;
            Program.WFCZN.EmployerSet.Add(employerSet);
            Program.WFCZN.SaveChanges();
            ShowEmployer();
        }
        void ShowEmployer()
        {
            listViewEmployer.Items.Clear();
            foreach(EmployerSet employerSet in Program.WFCZN.EmployerSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    employerSet.Id.ToString(), employerSet.FirstName, employerSet.LastName,
                    employerSet.MiddleName, employerSet.Phone, employerSet.Email
                });
                item.Tag = employerSet;
                listViewEmployer.Items.Add(item);
            }
            listViewEmployer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewEmployer.SelectedItems.Count ==1)
            {
                EmployerSet employerSet = listViewEmployer.SelectedItems[0].Tag as EmployerSet;
                employerSet.FirstName = textBoxFirstName.Text;
                employerSet.LastName = textBoxLastName.Text;
                employerSet.MiddleName = textBoxMiddleName.Text;
                employerSet.Phone = textBoxPhone.Text;
                employerSet.Email = textBoxEmail.Text;
                Program.WFCZN.SaveChanges();
                ShowEmployer();
            }
        }

        private void listViewEmployer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployer.SelectedItems.Count ==1)
            {
                EmployerSet employerSet = listViewEmployer.SelectedItems[0].Tag as EmployerSet;
                textBoxFirstName.Text = employerSet.FirstName;
                textBoxLastName.Text = employerSet.LastName;
                textBoxMiddleName.Text = employerSet.MiddleName;
                textBoxPhone.Text = employerSet.Phone;
                textBoxEmail.Text = employerSet.Email;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewEmployer.SelectedItems.Count ==1)
                {
                    EmployerSet employerSet = listViewEmployer.SelectedItems[0].Tag as EmployerSet;
                    Program.WFCZN.EmployerSet.Remove(employerSet);
                    Program.WFCZN.SaveChanges();
                    ShowEmployer();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
