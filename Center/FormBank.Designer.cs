namespace Center
{
    partial class FormBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewBank = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button1Add = new System.Windows.Forms.Button();
            this.labelJob = new System.Windows.Forms.Label();
            this.textBoxJob = new System.Windows.Forms.TextBox();
            this.labelNeed = new System.Windows.Forms.Label();
            this.textBoxNeed = new System.Windows.Forms.TextBox();
            this.labelIncome = new System.Windows.Forms.Label();
            this.textBoxIncome = new System.Windows.Forms.TextBox();
            this.labelArranget = new System.Windows.Forms.Label();
            this.textBoxArranget = new System.Windows.Forms.TextBox();
            this.labelEmployer = new System.Windows.Forms.Label();
            this.comboBoxEmployer = new System.Windows.Forms.ComboBox();
            this.comboBoxStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewBank
            // 
            this.listViewBank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewBank.FullRowSelect = true;
            this.listViewBank.GridLines = true;
            this.listViewBank.HideSelection = false;
            this.listViewBank.Location = new System.Drawing.Point(164, 105);
            this.listViewBank.MultiSelect = false;
            this.listViewBank.Name = "listViewBank";
            this.listViewBank.Size = new System.Drawing.Size(435, 225);
            this.listViewBank.TabIndex = 14;
            this.listViewBank.UseCompatibleStateImageBehavior = false;
            this.listViewBank.View = System.Windows.Forms.View.Details;
            this.listViewBank.SelectedIndexChanged += new System.EventHandler(this.listViewBank_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Профессия";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Требуется";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Доход";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Устроено";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Работодатель";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ФИО сотрудника";
            // 
            // buttonDel
            // 
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Location = new System.Drawing.Point(509, 336);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(90, 33);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEdit.Location = new System.Drawing.Point(410, 336);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(90, 33);
            this.buttonEdit.TabIndex = 16;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1Add
            // 
            this.button1Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1Add.Location = new System.Drawing.Point(311, 336);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(90, 33);
            this.button1Add.TabIndex = 15;
            this.button1Add.Text = "Создать";
            this.button1Add.UseVisualStyleBackColor = true;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(6, 174);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(65, 13);
            this.labelJob.TabIndex = 19;
            this.labelJob.Text = "Профессия";
            // 
            // textBoxJob
            // 
            this.textBoxJob.Location = new System.Drawing.Point(9, 190);
            this.textBoxJob.Name = "textBoxJob";
            this.textBoxJob.Size = new System.Drawing.Size(146, 20);
            this.textBoxJob.TabIndex = 18;
            // 
            // labelNeed
            // 
            this.labelNeed.AutoSize = true;
            this.labelNeed.Location = new System.Drawing.Point(6, 215);
            this.labelNeed.Name = "labelNeed";
            this.labelNeed.Size = new System.Drawing.Size(60, 13);
            this.labelNeed.TabIndex = 21;
            this.labelNeed.Text = "Требуется";
            // 
            // textBoxNeed
            // 
            this.textBoxNeed.Location = new System.Drawing.Point(9, 231);
            this.textBoxNeed.Name = "textBoxNeed";
            this.textBoxNeed.Size = new System.Drawing.Size(146, 20);
            this.textBoxNeed.TabIndex = 20;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(6, 252);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(39, 13);
            this.labelIncome.TabIndex = 23;
            this.labelIncome.Text = "Доход";
            // 
            // textBoxIncome
            // 
            this.textBoxIncome.Location = new System.Drawing.Point(9, 268);
            this.textBoxIncome.Name = "textBoxIncome";
            this.textBoxIncome.Size = new System.Drawing.Size(146, 20);
            this.textBoxIncome.TabIndex = 22;
            // 
            // labelArranget
            // 
            this.labelArranget.AutoSize = true;
            this.labelArranget.Location = new System.Drawing.Point(6, 292);
            this.labelArranget.Name = "labelArranget";
            this.labelArranget.Size = new System.Drawing.Size(56, 13);
            this.labelArranget.TabIndex = 25;
            this.labelArranget.Text = "Устроено";
            // 
            // textBoxArranget
            // 
            this.textBoxArranget.Location = new System.Drawing.Point(9, 308);
            this.textBoxArranget.Name = "textBoxArranget";
            this.textBoxArranget.Size = new System.Drawing.Size(146, 20);
            this.textBoxArranget.TabIndex = 24;
            // 
            // labelEmployer
            // 
            this.labelEmployer.AutoSize = true;
            this.labelEmployer.Location = new System.Drawing.Point(6, 129);
            this.labelEmployer.Name = "labelEmployer";
            this.labelEmployer.Size = new System.Drawing.Size(78, 13);
            this.labelEmployer.TabIndex = 26;
            this.labelEmployer.Text = "Работодатель";
            // 
            // comboBoxEmployer
            // 
            this.comboBoxEmployer.FormattingEnabled = true;
            this.comboBoxEmployer.Location = new System.Drawing.Point(9, 147);
            this.comboBoxEmployer.Name = "comboBoxEmployer";
            this.comboBoxEmployer.Size = new System.Drawing.Size(146, 21);
            this.comboBoxEmployer.TabIndex = 27;
            // 
            // comboBoxStaff
            // 
            this.comboBoxStaff.FormattingEnabled = true;
            this.comboBoxStaff.Location = new System.Drawing.Point(9, 105);
            this.comboBoxStaff.Name = "comboBoxStaff";
            this.comboBoxStaff.Size = new System.Drawing.Size(146, 21);
            this.comboBoxStaff.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Сотрудник, который предоставил вакансию ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Center.Properties.Resources.Без_имени_1;
            this.pictureBox1.Location = new System.Drawing.Point(78, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStaff);
            this.Controls.Add(this.comboBoxEmployer);
            this.Controls.Add(this.labelEmployer);
            this.Controls.Add(this.labelArranget);
            this.Controls.Add(this.textBoxArranget);
            this.Controls.Add(this.labelIncome);
            this.Controls.Add(this.textBoxIncome);
            this.Controls.Add(this.labelNeed);
            this.Controls.Add(this.textBoxNeed);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.textBoxJob);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.button1Add);
            this.Controls.Add(this.listViewBank);
            this.Name = "FormBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вакансии";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewBank;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox textBoxJob;
        private System.Windows.Forms.Label labelNeed;
        private System.Windows.Forms.TextBox textBoxNeed;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.TextBox textBoxIncome;
        private System.Windows.Forms.Label labelArranget;
        private System.Windows.Forms.TextBox textBoxArranget;
        private System.Windows.Forms.Label labelEmployer;
        private System.Windows.Forms.ComboBox comboBoxEmployer;
        private System.Windows.Forms.ComboBox comboBoxStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}