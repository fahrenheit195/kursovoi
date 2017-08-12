namespace Kursovoi
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bookCategoryTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new Kursovoi.BibliotekaDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.bookTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookTabTableAdapter();
            this.bookTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookCategoryTabTableAdapter();
            this.memberTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.MemberTabTableAdapter();
            this.orderTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.OrderTabTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Автор";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 91);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год издания";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоимость";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Жанр";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bookCategoryTabBindingSource;
            this.comboBox1.DisplayMember = "BookCategoryName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "BookCategoryID";
            // 
            // bookCategoryTabBindingSource
            // 
            this.bookCategoryTabBindingSource.DataMember = "BookCategoryTab";
            this.bookCategoryTabBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookCategoryTabTableAdapter = null;
            this.tableAdapterManager.BookTabTableAdapter = this.bookTabTableAdapter;
            this.tableAdapterManager.MemberTabTableAdapter = null;
            this.tableAdapterManager.OrderTabTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookTabTableAdapter
            // 
            this.bookTabTableAdapter.ClearBeforeFill = true;
            // 
            // bookTabBindingSource
            // 
            this.bookTabBindingSource.DataMember = "BookTab";
            // 
            // bookCategoryTabTableAdapter
            // 
            this.bookCategoryTabTableAdapter.ClearBeforeFill = true;
            // 
            // memberTabBindingSource
            // 
            this.memberTabBindingSource.DataMember = "MemberTab";
            this.memberTabBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // memberTabTableAdapter
            // 
            this.memberTabTableAdapter.ClearBeforeFill = true;
            // 
            // orderTabBindingSource
            // 
            this.orderTabBindingSource.DataMember = "OrderTab";
            this.orderTabBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // orderTabTableAdapter
            // 
            this.orderTabTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private BibliotekaDataSet bibliotekaDataSet;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        protected BibliotekaDataSetTableAdapters.BookTabTableAdapter bookTabTableAdapter;
        private System.Windows.Forms.BindingSource bookTabBindingSource;
        private System.Windows.Forms.BindingSource bookCategoryTabBindingSource;
        private BibliotekaDataSetTableAdapters.BookCategoryTabTableAdapter bookCategoryTabTableAdapter;
        private System.Windows.Forms.BindingSource memberTabBindingSource;
        private BibliotekaDataSetTableAdapters.MemberTabTableAdapter memberTabTableAdapter;
        private System.Windows.Forms.BindingSource orderTabBindingSource;
        private BibliotekaDataSetTableAdapters.OrderTabTableAdapter orderTabTableAdapter;
    }
}