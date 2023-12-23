using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace D3
{
    public partial class Form2 : Form
    {
        private string newStr;
        public string NewStr
        {
            get { return newStr; }
        }
        public Form2(string str)
        {
            InitializeComponent();
            AddText(str);
            textBox_Name.TextChanged += TextBox_TextChanged;
            textBox_Surname.TextChanged += TextBox_TextChanged;
            textBox_Mail.TextChanged += TextBox_TextChanged;
            textBox_Phone.TextChanged += TextBox_TextChanged;
        }
        private void AddText(string str)
        {
            string name, phone, surname, mail;
            string[] parts = str.Split(new char[] { ';', ':' });
            name = parts[1].Trim();
            surname = parts[3].Trim();
            mail = parts[5].Trim();
            phone = parts[7].Trim();
            textBox_Name.Text = name;
            textBox_Surname.Text = surname;
            textBox_Mail.Text = mail;
            textBox_Phone.Text = phone;
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            newStr = $"name: {textBox_Name.Text}; surname: {textBox_Surname.Text}; mail: {textBox_Mail.Text}; phone: {textBox_Phone.Text}";
        }
    }
}
