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
    public partial class Form1 : Form
    {
        TableAdapterManager manager = new TableAdapterManager();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        Form5 f5 = new Form5();
        public Form1()
        {
            InitializeComponent();
            manager.BookTabTableAdapter = new BookTabTableAdapter();
            manager.MemberTabTableAdapter = new MemberTabTableAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataSet.BookTab' table. You can move, or remove it, as needed.
            this.bookTabTableAdapter.Fill(this.bibliotekaDataSet.BookTab);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.BookCategoryTab' table. You can move, or remove it, as needed.
            this.bookCategoryTabTableAdapter.Fill(this.bibliotekaDataSet.BookCategoryTab);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.OrderDays' table. You can move, or remove it, as needed.
            this.orderDaysTableAdapter.Fill(this.bibliotekaDataSet.OrderDays);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.OrderTab' table. You can move, or remove it, as needed.
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
            // TODO: This line of code loads data into the 'bibliotekaDataSet.MemberTab' table. You can move, or remove it, as needed.
            this.memberTabTableAdapter.Fill(this.bibliotekaDataSet.MemberTab);

            bibliotekaDataSet.BookTab.ЖанрColumn.Expression = "Parent.BookCategoryName";
            bibliotekaDataSet.OrderTab.ФамилияColumn.Expression = "Parent(MemberTabOrderTab).MemberLastName";
            bibliotekaDataSet.OrderTab.ИмяColumn.Expression = "Parent(MemberTabOrderTab).MemberFirstName";
            bibliotekaDataSet.OrderTab.КнигаColumn.Expression = "Parent(BookTabOrderTab).BookName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.ShowDialog();
        }

        private void reset()
        {
            this.bookTabTableAdapter.Fill(this.bibliotekaDataSet.BookTab);
            this.memberTabTableAdapter.Fill(this.bibliotekaDataSet.MemberTab);
            this.orderDaysTableAdapter.Fill(this.bibliotekaDataSet.OrderDays);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int BookID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            manager.BookTabTableAdapter.DeleteQuery(BookID);
            this.bookTabTableAdapter.Fill(this.bibliotekaDataSet.BookTab);
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Validate();
            this.bookTabBindingSource.EndEdit();
            this.bookTabTableAdapter.Update(this.bibliotekaDataSet.BookTab);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MemberID = Convert.ToInt32(memberTabDataGridView.Rows[memberTabDataGridView.CurrentRow.Index].Cells[0].Value);
            manager.MemberTabTableAdapter.DeleteQuery(MemberID);
            this.memberTabTableAdapter.Fill(this.bibliotekaDataSet.MemberTab);
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int OrderID = Convert.ToInt32(orderTabDataGridView.Rows[orderTabDataGridView.CurrentRow.Index].Cells[0].Value);
            manager.OrderTabTableAdapter.DeleteQuery(OrderID);
            this.orderTabTableAdapter.Fill(this.bibliotekaDataSet.OrderTab);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                look_book();
            }
            catch
            {
                error();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                look_member();
            }
            catch
            {
                error();
            }
        }

        private void look_member()
        {
            string famil = "%" + textBox4.Text + "%";
            string adr = "%" + textBox3.Text + "%";
            if (checkBox4.Checked == true && checkBox3.Checked == true)
            {
                manager.MemberTabTableAdapter.FillBy_both(bibliotekaDataSet.MemberTab, famil, adr);
            }
            else
            {
                if (checkBox4.Checked == true)
                {
                    manager.MemberTabTableAdapter.FillBy_fam(bibliotekaDataSet.MemberTab, famil);
                }
                else
                {
                    manager.MemberTabTableAdapter.FillBy_ad(bibliotekaDataSet.MemberTab, adr);
                }
            }
        }

        private void look_book()
        {
            string nazv = "%" + textBox1.Text + "%";
            string auth = "%" + textBox2.Text + "%";
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                manager.BookTabTableAdapter.FillBy_both(bibliotekaDataSet.BookTab, nazv, auth);
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    manager.BookTabTableAdapter.FillBy_Nazv(bibliotekaDataSet.BookTab, nazv);
                }
                else
                {
                    manager.BookTabTableAdapter.FillBy_Auth(bibliotekaDataSet.BookTab, auth);
                }
            }
        }

        private void error()
        {
            MessageBox.Show("Проверьте правильность вводимых данных", "Error");
            SystemSounds.Beep.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message with Help file.",
                                   "Help Caption", MessageBoxButtons.OK,
                                   MessageBoxIcon.Question);
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upDate.upd = 1;
            f5.ShowDialog();
        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upDate.upd = 2;
            f5.ShowDialog();
        }

        private void выданоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            upDate.upd = 3;
            f5.ShowDialog();
        }
    }
}
