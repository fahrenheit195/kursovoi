using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Kursovoi.BibliotekaDataSetTableAdapters;


namespace Kursovoi
{
    public partial class Form2 : Form
    {
        TableAdapterManager manager = new TableAdapterManager();
        public Form2()
        {
            InitializeComponent();
            manager.BookTabTableAdapter = new BookTabTableAdapter();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.OrderTab' table. You can move, or remove it, as needed.
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.BookCategoryTab' table. You can move, or remove it, as needed.
            this.bookCategoryTabTableAdapter.Fill(this.bibliotekaDataSet.BookCategoryTab);
        }
        private void error()
        {
            MessageBox.Show("Проверьте правильность вводимых данных", "Error");
            SystemSounds.Beep.Play();
        }

        private void addBook()
        {
            var f1 = Application.OpenForms["Form1"] as Form1;
            try
            {
                manager.BookTabTableAdapter.Insert(textBox1.Text, int.Parse(comboBox1.SelectedValue.ToString())/*здесь можно для отличия испоьлзовать comboBox1.SelectedIndex+1*/,
                                 textBox2.Text, int.Parse(textBox3.Text), decimal.Parse(textBox4.Text));
                f1.bookTabTableAdapter.Fill(f1.bibliotekaDataSet.BookTab);
            }
            catch
            {
                error();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
