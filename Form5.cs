using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BibliotekaDataSet.OrderTab' table. You can move, or remove it, as needed.
            this.orderTabTableAdapter.Fill(this.BibliotekaDataSet.OrderTab);
            // TODO: This line of code loads data into the 'BibliotekaDataSet.MemberTab' table. You can move, or remove it, as needed.
            this.memberTabTableAdapter.Fill(this.BibliotekaDataSet.MemberTab);
            // TODO: This line of code loads data into the 'BibliotekaDataSet.BookCategoryTab' table. You can move, or remove it, as needed.
            this.bookCategoryTabTableAdapter.Fill(this.BibliotekaDataSet.BookCategoryTab);
            // TODO: This line of code loads data into the 'BibliotekaDataSet.BookTab' table. You can move, or remove it, as needed.
            this.BookTabTableAdapter.Fill(this.BibliotekaDataSet.BookTab);

            BibliotekaDataSet.BookTab.ЖанрColumn.Expression = "Parent.BookCategoryName";
            BibliotekaDataSet.OrderTab.ФамилияColumn.Expression = "Parent(MemberTabOrderTab).MemberLastName";
            BibliotekaDataSet.OrderTab.ИмяColumn.Expression = "Parent(MemberTabOrderTab).MemberFirstName";
            BibliotekaDataSet.OrderTab.КнигаColumn.Expression = "Parent(BookTabOrderTab).BookName";

   /*         switch (upDate.upd)
            {
                case 1:
                   reportViewer1.LocalReport.ReportPath = "C:/Report1.rdlc";
                    this.reportViewer1.RefreshReport();
                    reportViewer1.Visible = true;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = false;
                    break;
                case 2:
                    reportViewer2.LocalReport.ReportPath = "C:/Report2.rdlc";
                    this.reportViewer2.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = true;
                    reportViewer3.Visible = false;
                    break;
                case 3:
                    reportViewer3.LocalReport.ReportPath = "C:/Report3.rdlc";
                    this.reportViewer3.RefreshReport();
                    reportViewer1.Visible = false;
                    reportViewer2.Visible = false;
                    reportViewer3.Visible = true;
                    break;
            } */
        }
    }
}
