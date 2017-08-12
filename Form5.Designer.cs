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
            this.BookTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BibliotekaDataSet = new Kursovoi.BibliotekaDataSet();
            this.memberTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookTabTableAdapter();
            this.bookCategoryTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookCategoryTabTableAdapter();
            this.tableAdapterManager = new Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.memberTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.MemberTabTableAdapter();
            this.orderTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.OrderTabTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Kursovoi.Properties.Resources._2017_02_15;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1082, 756);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 756);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BookTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}