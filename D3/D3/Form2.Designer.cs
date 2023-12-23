namespace D3
{
    partial class Form2
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
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.phoneq = new System.Windows.Forms.Label();
            this.mailq = new System.Windows.Forms.Label();
            this.surnameq = new System.Windows.Forms.Label();
            this.nameq = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(28, 164);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 15;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(28, 125);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mail.TabIndex = 14;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(28, 86);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Surname.TabIndex = 13;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(28, 47);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox_Name.TabIndex = 12;
            // 
            // phoneq
            // 
            this.phoneq.AutoSize = true;
            this.phoneq.Location = new System.Drawing.Point(25, 148);
            this.phoneq.Name = "phoneq";
            this.phoneq.Size = new System.Drawing.Size(37, 13);
            this.phoneq.TabIndex = 11;
            this.phoneq.Text = "phone";
            // 
            // mailq
            // 
            this.mailq.AutoSize = true;
            this.mailq.Location = new System.Drawing.Point(25, 109);
            this.mailq.Name = "mailq";
            this.mailq.Size = new System.Drawing.Size(25, 13);
            this.mailq.TabIndex = 10;
            this.mailq.Text = "mail";
            // 
            // surnameq
            // 
            this.surnameq.AutoSize = true;
            this.surnameq.Location = new System.Drawing.Point(25, 70);
            this.surnameq.Name = "surnameq";
            this.surnameq.Size = new System.Drawing.Size(47, 13);
            this.surnameq.TabIndex = 9;
            this.surnameq.Text = "surname";
            // 
            // nameq
            // 
            this.nameq.AutoSize = true;
            this.nameq.Location = new System.Drawing.Point(25, 30);
            this.nameq.Name = "nameq";
            this.nameq.Size = new System.Drawing.Size(33, 13);
            this.nameq.TabIndex = 8;
            this.nameq.Text = "name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.phoneq);
            this.Controls.Add(this.mailq);
            this.Controls.Add(this.surnameq);
            this.Controls.Add(this.nameq);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label phoneq;
        private System.Windows.Forms.Label mailq;
        private System.Windows.Forms.Label surnameq;
        private System.Windows.Forms.Label nameq;
        private System.Windows.Forms.Button button1;
    }
}