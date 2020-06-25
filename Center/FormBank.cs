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
    public partial class FormBank : Form
    {
        public FormBank()
        {
            InitializeComponent();
            ShowEmployer();
            ShowBank();
            ShowStaff();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            if (comboBoxEmployer.SelectedItem != null && textBoxJob.Text != "" && textBoxIncome.Text != "" && textBoxNeed.Text != "" && textBoxArranget.Text != "" && comboBoxStaff.SelectedItem !=null)
            {
                BankSet bankSet = new BankSet();
                bankSet.Job = textBoxJob.Text;
                bankSet.Need = textBoxNeed.Text;
                bankSet.Income = textBoxIncome.Text;
                bankSet.Arranget = textBoxArranget.Text;
                bankSet.IdEmployer = Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
                bankSet.IdStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                Program.WFCZN.BankSet.Add(bankSet);
                Program.WFCZN.SaveChanges();
                ShowBank();
            }

        }
        void ShowBank()
        {
            listViewBank.Items.Clear();
            foreach (BankSet bankSet in Program.WFCZN.BankSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bankSet.Id.ToString(), bankSet.Job, bankSet.Need,bankSet.Income,
                    bankSet.Arranget, bankSet.EmployerSet.LastName + " " + bankSet.EmployerSet.FirstName + " " + bankSet.EmployerSet.MiddleName,
                    bankSet.StaffSet.LastName + " " + bankSet.StaffSet.FirstName + " " + bankSet.StaffSet.MiddleName
                });
                item.Tag = bankSet;
                listViewBank.Items.Add(item);
            }
            listViewBank.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowEmployer()
        {
            comboBoxEmployer.Items.Clear();
            foreach (EmployerSet employerSet in Program.WFCZN.EmployerSet)
            {
                string[] item = { employerSet.Id.ToString() + ".", employerSet.FirstName,
                employerSet.LastName, employerSet.MiddleName};
                comboBoxEmployer.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
            bankSet.Job = textBoxJob.Text;
            bankSet.Need = textBoxNeed.Text;
            bankSet.Income = textBoxIncome.Text;
            bankSet.Arranget = textBoxArranget.Text;
            bankSet.IdEmployer = Convert.ToInt32(comboBoxEmployer.SelectedItem.ToString().Split('.')[0]);
            ShowBank();

        }

        private void listViewBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBank.SelectedItems.Count == 1)
            {
                BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
                textBoxJob.Text = bankSet.Job;
                textBoxNeed.Text = bankSet.Need;
                textBoxIncome.Text = bankSet.Income;
                textBoxArranget.Text = bankSet.Arranget;
                comboBoxEmployer.SelectedIndex = comboBoxEmployer.FindString(bankSet.IdEmployer.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(bankSet.IdStaff.ToString());
            }
            else
            {
                textBoxJob.Text = "";
                textBoxNeed.Text = "";
                textBoxIncome.Text = "";
                textBoxArranget.Text = "";
                comboBoxEmployer.Text = null;
                comboBoxStaff.Text = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBank.SelectedItems.Count == 1)
                {
                    BankSet bankSet = listViewBank.SelectedItems[0].Tag as BankSet;
                    Program.WFCZN.BankSet.Remove(bankSet);
                    Program.WFCZN.SaveChanges();
                    ShowBank();


                }
                textBoxJob.Text = "";
                textBoxNeed.Text = "";
                textBoxIncome.Text = "";
                textBoxArranget.Text = "";
                comboBoxEmployer.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowStaff()
        {
            comboBoxStaff.Items.Clear();
            foreach (StaffSet staffSet in Program.WFCZN.StaffSet)
            {
                string[] item = { staffSet.Id.ToString() + ".", staffSet.FirstName,
                staffSet.LastName, staffSet.MiddleName};
                comboBoxStaff.Items.Add(string.Join(" ", item));
            }
        }
    }
}
