namespace Kursovoi
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BookTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BibliotekaDataSet = new Kursovoi.BibliotekaDataSet();
            this.memberTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BookTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookTabTableAdapter();
            this.bookCategoryTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookCategoryTabTableAdapter();
            this.tableAdapterManager = new Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.memberTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.MemberTabTableAdapter();
            this.orderTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.OrderTabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BookTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BookTabBindingSource
            // 
            this.BookTabBindingSource.DataMember = "BookTab";
            this.BookTabBindingSource.DataSource = this.BibliotekaDataSet;
            // 
            // BibliotekaDataSet
            // 
            this.BibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.BibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTabBindingSource
            // 
            this.memberTabBindingSource.DataMember = "MemberTab";
            this.memberTabBindingSource.DataSource = this.BibliotekaDataSet;
            // 
            // orderTabBindingSource
            // 
            this.orderTabBindingSource.DataMember = "OrderTab";
            this.orderTabBindingSource.DataSource = this.BibliotekaDataSet;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BookTabBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursovoi.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1082, 756);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.memberTabBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Kursovoi.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1082, 756);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.orderTabBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "Kursovoi.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(0, 0);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.Size = new System.Drawing.Size(1082, 756);
            this.reportViewer3.TabIndex = 2;
            // 
            // BookTabTableAdapter
            // 
            this.BookTabTableAdapter.ClearBeforeFill = true;
            // 
            // bookCategoryTabBindingSource
            // 
            this.bookCategoryTabBindingSource.DataMember = "BookCategoryTab";
            this.bookCategoryTabBindingSource.DataSource = this.BibliotekaDataSet;
            // 
            // bookCategoryTabTableAdapter
            // 
            this.bookCategoryTabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookCategoryTabTableAdapter = this.bookCategoryTabTableAdapter;
            this.tableAdapterManager.BookTabTableAdapter = this.BookTabTableAdapter;
            this.tableAdapterManager.MemberTabTableAdapter = this.memberTabTableAdapter;
            this.tableAdapterManager.OrderTabTableAdapter = this.orderTabTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberTabTableAdapter
            // 
            this.memberTabTableAdapter.ClearBeforeFill = true;
            // 
            // orderTabTableAdapter
            // 
            this.orderTabTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 756);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource BookTabBindingSource;
        private BibliotekaDataSet BibliotekaDataSet;
        private BibliotekaDataSetTableAdapters.BookTabTableAdapter BookTabTableAdapter;
        private System.Windows.Forms.BindingSource bookCategoryTabBindingSource;
        private BibliotekaDataSetTableAdapters.BookCategoryTabTableAdapter bookCategoryTabTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BibliotekaDataSetTableAdapters.MemberTabTableAdapter memberTabTableAdapter;
        private System.Windows.Forms.BindingSource memberTabBindingSource;
        private BibliotekaDataSetTableAdapters.OrderTabTableAdapter orderTabTableAdapter;
        private System.Windows.Forms.BindingSource orderTabBindingSource;
    }
}