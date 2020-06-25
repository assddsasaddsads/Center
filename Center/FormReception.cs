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
    public partial class FormReception : Form
    {
        public FormReception()
        {
            InitializeComponent();
            ShowJobless();
            ShowStaff();
            ShowReception();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            if (comboBoxStaff.SelectedItem != null && textBoxType.Text != "" && textBoxDate.Text != "" && comboBoxJobless.SelectedItem != null)
            {
                ReceptionSet receptionSet = new ReceptionSet();
                receptionSet.Type = textBoxType.Text;
                receptionSet.Date = textBoxDate.Text;
                receptionSet.IdJobless = Convert.ToInt32(comboBoxJobless.SelectedItem.ToString().Split('.')[0]);
                receptionSet.IdStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
                Program.WFCZN.ReceptionSet.Add(receptionSet);
                Program.WFCZN.SaveChanges();
                ShowJobless();
            }
        }
        void ShowJobless()
            {
                comboBoxJobless.Items.Clear();
                foreach (JoblessSet joblessSet in Program.WFCZN.JoblessSet)
                {
                    string[] item = { joblessSet.Id.ToString() + ".", joblessSet.FirstName,
                joblessSet.LastName, joblessSet.MiddleName};
                    comboBoxJobless.Items.Add(string.Join(" ", item));
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

        private void listViewReception_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewReception.SelectedItems.Count == 1)
            {
                ReceptionSet receptionSet = listViewReception.SelectedItems[0].Tag as ReceptionSet;
                textBoxType.Text = receptionSet.Type;
                textBoxDate.Text = receptionSet.Date;
                comboBoxJobless.SelectedIndex = comboBoxJobless.FindString(receptionSet.IdJobless.ToString());
                comboBoxStaff.SelectedIndex = comboBoxStaff.FindString(receptionSet.IdStaff.ToString());
            }
            else
            {
                textBoxType.Text = "";
                textBoxDate.Text = "";
                comboBoxJobless.Text = null;
                comboBoxStaff.Text = null;
            }
        }
        void ShowReception()
        {
            listViewReception.Items.Clear();
            foreach (ReceptionSet receptionSet in Program.WFCZN.ReceptionSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    receptionSet.Id.ToString(), receptionSet.Type, receptionSet.Date,
                    receptionSet.JoblessSet.LastName + " " + receptionSet.JoblessSet.FirstName + " " + receptionSet.JoblessSet.MiddleName,
                    receptionSet.StaffSet.LastName + " " + receptionSet.StaffSet.FirstName + " " + receptionSet.StaffSet.MiddleName
                    
                });
                item.Tag = receptionSet;
                listViewReception.Items.Add(item);
            }
            listViewReception.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ReceptionSet receptionSet = listViewReception.SelectedItems[0].Tag as ReceptionSet;
            receptionSet.Type = textBoxType.Text;
            receptionSet.Date = textBoxDate.Text;
            receptionSet.IdJobless = Convert.ToInt32(comboBoxJobless.SelectedItem.ToString().Split('.')[0]);
            receptionSet.IdStaff = Convert.ToInt32(comboBoxStaff.SelectedItem.ToString().Split('.')[0]);
            Program.WFCZN.SaveChanges();
            ShowReception();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewReception.SelectedItems.Count == 1)
                {
                    ReceptionSet receptionSet = listViewReception.SelectedItems[0].Tag as ReceptionSet;
                    Program.WFCZN.ReceptionSet.Remove(receptionSet);
                    Program.WFCZN.SaveChanges();
                    ShowReception();


                }
                textBoxDate.Text = "";
                textBoxType.Text = "";
                comboBoxJobless.SelectedItem = null;
                comboBoxStaff.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
