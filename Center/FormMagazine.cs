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
    public partial class FormMagazine : Form
    {
        public FormMagazine()
        {
            InitializeComponent();
            ShowStatus();
            ShowMagazine();
        }

        private void button1Add_Click(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem != null && textBoxType.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxMiddleName.Text != "")
            {
                MagazineSet magazineSet = new MagazineSet();
                magazineSet.FirstName = textBoxFirstName.Text;
                magazineSet.LastName = textBoxLastName.Text;
                magazineSet.MiddleName = textBoxMiddleName.Text;
                magazineSet.Type = textBoxType.Text;
                magazineSet.IdJobless = Convert.ToInt32(comboBoxStatus.SelectedItem.ToString().Split('.')[0]);
                Program.WFCZN.MagazineSet.Add(magazineSet);
                Program.WFCZN.SaveChanges();
                ShowMagazine();
            }
        }
        void ShowMagazine()
        {
            listViewMagazine.Items.Clear();
            foreach (MagazineSet magazineSet in Program.WFCZN.MagazineSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                     magazineSet.Id.ToString(),  magazineSet.FirstName,  magazineSet.LastName,
                     magazineSet.MiddleName, magazineSet.Type,
                     magazineSet.JoblessSet.Status

                });
                item.Tag = magazineSet;
                listViewMagazine.Items.Add(item);
            }
            listViewMagazine.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void ShowStatus()
        {
            comboBoxStatus.Items.Clear();
            foreach (JoblessSet joblessSet in Program.WFCZN.JoblessSet)
            {
                string[] item = { joblessSet.Id.ToString() + ".", joblessSet.Status};
                comboBoxStatus.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewMagazine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMagazine.SelectedItems.Count == 1)
            {
                MagazineSet magazineSet = listViewMagazine.SelectedItems[0].Tag as MagazineSet;
                textBoxFirstName.Text = magazineSet.FirstName;
                textBoxLastName.Text = magazineSet.LastName;
                textBoxMiddleName.Text = magazineSet.MiddleName;
                textBoxType.Text = magazineSet.Type;
                comboBoxStatus.SelectedIndex = comboBoxStatus.FindString(magazineSet.IdJobless.ToString());
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxType.Text = "";
                comboBoxStatus.Text = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMagazine.SelectedItems.Count == 1)
            {
                MagazineSet magazineSet = listViewMagazine.SelectedItems[0].Tag as MagazineSet;
                magazineSet.FirstName = textBoxFirstName.Text;
                magazineSet.LastName = textBoxLastName.Text;
                magazineSet.MiddleName = textBoxMiddleName.Text;
                magazineSet.Type = textBoxType.Text;
                magazineSet.IdJobless = Convert.ToInt32(comboBoxStatus.SelectedItem.ToString().Split('.')[0]);
                Program.WFCZN.SaveChanges();
                ShowMagazine();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMagazine.SelectedItems.Count == 1)
                {
                    MagazineSet magazineSet = listViewMagazine.SelectedItems[0].Tag as MagazineSet;
                    Program.WFCZN.MagazineSet.Remove(magazineSet);
                    Program.WFCZN.SaveChanges();
                    ShowMagazine();
                }
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxType.Text = "";
                comboBoxStatus.Text = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
