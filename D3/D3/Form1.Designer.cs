namespace D3
{
    partial class Form1
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
            this.nameq = new System.Windows.Forms.Label();
            this.surnameq = new System.Windows.Forms.Label();
            this.mailq = new System.Windows.Forms.Label();
            this.phoneq = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameq
            // 
            this.nameq.AutoSize = true;
            this.nameq.Location = new System.Drawing.Point(37, 50);
            this.nameq.Name = "nameq";
            this.nameq.Size = new System.Drawing.Size(33, 13);
            this.nameq.TabIndex = 0;
            this.nameq.Text = "name";
            // 
            // surnameq
            // 
            this.surnameq.AutoSize = true;
            this.surnameq.Location = new System.Drawing.Point(37, 90);
            this.surnameq.Name = "surnameq";
            this.surnameq.Size = new System.Drawing.Size(47, 13);
            this.surnameq.TabIndex = 1;
            this.surnameq.Text = "surname";
            // 
            // mailq
            // 
            this.mailq.AutoSize = true;
            this.mailq.Location = new System.Drawing.Point(37, 129);
            this.mailq.Name = "mailq";
            this.mailq.Size = new System.Drawing.Size(25, 13);
            this.mailq.TabIndex = 2;
            this.mailq.Text = "mail";
            // 
            // phoneq
            // 
            this.phoneq.AutoSize = true;
            this.phoneq.Location = new System.Drawing.Point(37, 168);
            this.phoneq.Name = "phoneq";
            this.phoneq.Size = new System.Drawing.Size(37, 13);
            this.phoneq.TabIndex = 3;
            this.phoneq.Text = "phone";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(40, 67);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(40, 106);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 5;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(40, 145);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mail.TabIndex = 6;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(40, 184);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(180, 67);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 134);
            this.listBox1.TabIndex = 8;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(180, 208);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(422, 23);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(180, 238);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(422, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(180, 268);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(422, 23);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(632, 145);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(179, 40);
            this.Export.TabIndex = 12;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(632, 191);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(179, 40);
            this.Import.TabIndex = 13;
            this.Import.Text = "Import";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите название файла(без .txt): ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(632, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 316);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.phoneq);
            this.Controls.Add(this.mailq);
            this.Controls.Add(this.surnameq);
            this.Controls.Add(this.nameq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameq;
        private System.Windows.Forms.Label surnameq;
        private System.Windows.Forms.Label mailq;
        private System.Windows.Forms.Label phoneq;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

