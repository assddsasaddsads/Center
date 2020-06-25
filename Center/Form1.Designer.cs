namespace Center
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonEmployer = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonBank = new System.Windows.Forms.Button();
            this.buttonJobless = new System.Windows.Forms.Button();
            this.buttonReception = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEmployer
            // 
            this.buttonEmployer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEmployer.Location = new System.Drawing.Point(12, 104);
            this.buttonEmployer.Name = "buttonEmployer";
            this.buttonEmployer.Size = new System.Drawing.Size(221, 42);
            this.buttonEmployer.TabIndex = 0;
            this.buttonEmployer.Text = "Работодатели";
            this.buttonEmployer.UseVisualStyleBackColor = false;
            this.buttonEmployer.Click += new System.EventHandler(this.buttonEmployer_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStaff.Location = new System.Drawing.Point(12, 152);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(221, 42);
            this.buttonStaff.TabIndex = 1;
            this.buttonStaff.Text = "Персонал";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonBank
            // 
            this.buttonBank.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBank.Location = new System.Drawing.Point(12, 200);
            this.buttonBank.Name = "buttonBank";
            this.buttonBank.Size = new System.Drawing.Size(221, 42);
            this.buttonBank.TabIndex = 2;
            this.buttonBank.Text = "Вакансии";
            this.buttonBank.UseVisualStyleBackColor = false;
            this.buttonBank.Click += new System.EventHandler(this.buttonBank_Click);
            // 
            // buttonJobless
            // 
            this.buttonJobless.BackColor = System.Drawing.SystemColors.Control;
            this.buttonJobless.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonJobless.Location = new System.Drawing.Point(12, 248);
            this.buttonJobless.Name = "buttonJobless";
            this.buttonJobless.Size = new System.Drawing.Size(221, 42);
            this.buttonJobless.TabIndex = 3;
            this.buttonJobless.Text = "Безработные";
            this.buttonJobless.UseVisualStyleBackColor = false;
            this.buttonJobless.Click += new System.EventHandler(this.buttonJobless_Click);
            // 
            // buttonReception
            // 
            this.buttonReception.BackColor = System.Drawing.SystemColors.Control;
            this.buttonReception.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReception.Location = new System.Drawing.Point(12, 296);
            this.buttonReception.Name = "buttonReception";
            this.buttonReception.Size = new System.Drawing.Size(221, 42);
            this.buttonReception.TabIndex = 4;
            this.buttonReception.Text = "Прием граждан";
            this.buttonReception.UseVisualStyleBackColor = false;
            this.buttonReception.Click += new System.EventHandler(this.buttonReception_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Журнал выплат";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Center.Properties.Resources.Без_имени_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReception);
            this.Controls.Add(this.buttonJobless);
            this.Controls.Add(this.buttonBank);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.buttonEmployer);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEmployer;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonBank;
        private System.Windows.Forms.Button buttonJobless;
        private System.Windows.Forms.Button buttonReception;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

