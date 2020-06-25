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
    public partial class FormJobless : Form
    {
        public FormJobless()
        {
            InitializeComponent();
            ShowJobless();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            JoblessSet joblessSet = new JoblessSet();
            joblessSet.FirstName = textBoxFirstName.Text;
            joblessSet.LastName = textBoxLastName.Text;
            joblessSet.MiddleName = textBoxMiddleName.Text;
            joblessSet.Phone = textBoxPhone.Text;
            joblessSet.Status = textBoxStatus.Text;
            Program.WFCZN.JoblessSet.Add(joblessSet);
            Program.WFCZN.SaveChanges();
            ShowJobless();
        }
        void ShowJobless()
        {
            listViewJobless.Items.Clear();
            foreach (JoblessSet joblessSet in Program.WFCZN.JoblessSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    joblessSet.Id.ToString(), joblessSet.FirstName, joblessSet.LastName,joblessSet.MiddleName,
                    joblessSet.Phone, joblessSet.Status
                });
                item.Tag = joblessSet;
                listViewJobless.Items.Add(item);
            }
            listViewJobless.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            JoblessSet joblessSet = listViewJobless.SelectedItems[0].Tag as JoblessSet;
            joblessSet.FirstName = textBoxFirstName.Text;
            joblessSet.LastName = textBoxLastName.Text;
            joblessSet.MiddleName = textBoxMiddleName.Text;
            joblessSet.Phone = textBoxPhone.Text;
            joblessSet.Status = textBoxStatus.Text;
            Program.WFCZN.SaveChanges();
            ShowJobless();

        }

        private void listViewJobless_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewJobless.SelectedItems.Count == 1)
            {
                JoblessSet joblessSet = listViewJobless.SelectedItems[0].Tag as JoblessSet;
                textBoxFirstName.Text = joblessSet.FirstName;
                textBoxLastName.Text = joblessSet.LastName;
                textBoxMiddleName.Text = joblessSet.MiddleName;
                textBoxPhone.Text = joblessSet.Phone;
                textBoxStatus.Text = joblessSet.Status;
            }
            else
            {
                textBoxFirstName.Text ="";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxStatus.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewJobless.SelectedItems.Count == 1)
                {
                    JoblessSet joblessSet = listViewJobless.SelectedItems[0].Tag as JoblessSet;
                    Program.WFCZN.JoblessSet.Remove(joblessSet);
                    Program.WFCZN.SaveChanges();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxPhone.Text = "";
                textBoxStatus.Text = "";
                ShowJobless();
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
