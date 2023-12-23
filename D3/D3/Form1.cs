using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3
{
    public partial class Form1 : Form
    {
        Person person = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.Name = textBox_Name.Text;
            person.Surname = textBox_Surname.Text;
            person.Mail = textBox_Mail.Text;
            person.Phone = textBox_Phone.Text;
            if(person.Name == "" || person.Surname == "" || person.Mail == "" || person.Phone == "")
            {
                MessageBox.Show("Добавьте данные"); 
            }
            else
            {
                listBox1.Items.Add($"name: {person.Name}; surname: {person.Surname}; mail: {person.Mail}; phone: {person.Phone}");
            }
            textBox_Name.Text = "";
            textBox_Surname.Text = "";
            textBox_Mail.Text = "";
            textBox_Phone.Text = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Для удаления выберите пользователя");
            }
            else
                listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Для редактирования выберите пользователя");
            }
            else
            {
                string element = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(listBox1.SelectedItem);
                Form2 form = new Form2(element);
                form.ShowDialog();
                listBox1.Items.Add(form.NewStr);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите название файла");
            }
            else
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(textBox1.Text + ".txt", false))
                    {
                        foreach (var item in listBox1.Items)
                        {
                            writer.WriteLine(item.ToString());
                        }
                        MessageBox.Show("Данные успешно экспортированы в файл.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при экспорте данных в файл: {ex.Message}");
                }
            }
            textBox1.Text = "";
        }
        private void Import_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите название файла");
            }
            else
            {
                try
                {
                    if (File.Exists(textBox1.Text + ".txt"))
                    {
                        string[] lines = File.ReadAllLines(textBox1.Text + ".txt");
                        listBox1.Items.Clear();
                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }
                        MessageBox.Show("Данные успешно импортированы из файла.");
                    }
                    else
                    {
                        MessageBox.Show("Файл не существует.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при импорте данных из файла: {ex.Message}");
                }
                textBox1.Text = "";
            }
        }
    }
}
