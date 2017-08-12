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
    public partial class Form3 : Form
    {
        TableAdapterManager manager = new TableAdapterManager();
        public Form3()
        {
            InitializeComponent();
            manager.MemberTabTableAdapter = new MemberTabTableAdapter();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.MemberTab' table. You can move, or remove it, as needed.
            this.memberTabTableAdapter.Fill(this.bibliotekaDataSet.MemberTab);
        }
        private void error()
        {
            MessageBox.Show("Проверьте правильность вводимых данных", "Error");
            SystemSounds.Beep.Play();
        }
        private void addMember()
        {
            var f1 = Application.OpenForms["Form1"] as Form1;
            try
            {
                manager.MemberTabTableAdapter.Insert(textBox1.Text, textBox5.Text, textBox2.Text,
                                    dateTimePicker1.Value.Date, DateTime.Now.Date, textBox3.Text, decimal.Parse(textBox4.Text));
                f1.memberTabTableAdapter.Fill(f1.bibliotekaDataSet.MemberTab);
            }
            catch
            {
                error();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addMember();
        }

    }
}
