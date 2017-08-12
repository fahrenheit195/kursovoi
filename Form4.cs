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
    public partial class Form4 : Form
    {
        TableAdapterManager manager = new TableAdapterManager();
        public Form4()
        {
            InitializeComponent();
            manager.OrderTabTableAdapter = new OrderTabTableAdapter();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.BookTab' table. You can move, or remove it, as needed.
            this.bookTabTableAdapter.Fill(this.bibliotekaDataSet.BookTab);
            var f1 = Application.OpenForms["Form1"] as Form1;
            bibliotekaDataSet.MemberTab.FIOColumn.Expression = "MemberFirstName+' '+MemberLastName+' '+MemberPatronymic";
            // TODO: This line of code loads data into the 'bibliotekaDataSet.OrderDays' table. You can move, or remove it, as needed.
            this.orderDaysTableAdapter.Fill(this.bibliotekaDataSet.OrderDays);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.MemberTab' table. You can move, or remove it, as needed.
            this.memberTabTableAdapter.Fill(this.bibliotekaDataSet.MemberTab);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.OrderTab' table. You can move, or remove it, as needed.
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
        }

        private void error()
        {
            MessageBox.Show("Проверьте правильность вводимых данных", "Error");
            SystemSounds.Beep.Play();
        }
        private void addOrder()
        {
            var f1 = Application.OpenForms["Form1"] as Form1;
            TimeSpan oD = dateTimePicker1.Value - DateTime.Now;
            Double price = double.Parse(textBox1.Text);

            Double oC = price * 0.2;

            TimeSpan OD = oD;

            Double dC = price * 0.5;

            Double oT = (oC*oD.Days)+(dC*OD.Days);

            try
            {
                manager.OrderTabTableAdapter.Insert(int.Parse(comboBox2.SelectedValue.ToString()), int.Parse(comboBox1.SelectedValue.ToString()), DateTime.Now.Date,
                                    dateTimePicker1.Value.Date, oD.Days, decimal.Parse(oC.ToString()), decimal.Parse(oT.ToString()), true, false);
                f1.orderTabTableAdapter.Fill(f1.bibliotekaDataSet.OrderTab);
            }
            catch
            {
                error();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedValue = numericUpDown1.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
   /*         var f1 = Application.OpenForms["Form1"] as Form1;
            int bookId = int.Parse(comboBox1.SelectedValue.ToString());
            manager.BookTabTableAdapter.BookIssue(bookId);
            f1.bookTabTableAdapter.Fill(f1.bibliotekaDataSet.BookTab); */
            addOrder();
        }
    }
}
