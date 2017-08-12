namespace Kursovoi
{
    partial class Form4
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
            this.memberTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSet = new Kursovoi.BibliotekaDataSet();
            this.orderDaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.OrderTabTableAdapter();
            this.tableAdapterManager = new Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager();
            this.memberTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.MemberTabTableAdapter();
            this.orderDaysTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.OrderDaysTableAdapter();
            this.memberTabOrderTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bookTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTabTableAdapter = new Kursovoi.BibliotekaDataSetTableAdapters.BookTabTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDaysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabOrderTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTabBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTabBindingSource
            // 
            this.memberTabBindingSource.DataMember = "MemberTab";
            this.memberTabBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSet
            // 
            this.bibliotekaDataSet.DataSetName = "BibliotekaDataSet";
            this.bibliotekaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDaysBindingSource
            // 
            this.orderDaysBindingSource.DataMember = "OrderDays";
            this.orderDaysBindingSource.DataSource = this.bibliotekaDataSet;
            // 
            // bibliotekaDataSetBindingSource
            // 
            this.bibliotekaDataSetBindingSource.DataSource = this.bibliotekaDataSet;
            this.bibliotekaDataSetBindingSource.Position = 0;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookCategoryTabTableAdapter = null;
            this.tableAdapterManager.BookTabTableAdapter = null;
            this.tableAdapterManager.MemberTabTableAdapter = null;
            this.tableAdapterManager.OrderTabTableAdapter = this.orderTabTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kursovoi.BibliotekaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberTabTableAdapter
            // 
            this.memberTabTableAdapter.ClearBeforeFill = true;
            // 
            // orderDaysTableAdapter
            // 
            this.orderDaysTableAdapter.ClearBeforeFill = true;
            // 
            // memberTabOrderTabBindingSource
            // 
            this.memberTabOrderTabBindingSource.DataMember = "MemberTabOrderTab";
            this.memberTabOrderTabBindingSource.DataSource = this.memberTabBindingSource;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.memberTabBindingSource;
            this.comboBox2.DisplayMember = "FIO";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 38);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.ValueMember = "MemberID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberTabBindingSource, "MemberID", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.numericUpDown1.Location = new System.Drawing.Point(101, 12);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.bookTabBindingSource;
            this.comboBox1.DisplayMember = "BookName";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "BookID";
            // 
            // bookTabBindingSource
            // 
            this.bookTabBindingSource.DataMember = "BookTab";
            this.bookTabBindingSource.DataSource = this.bibliotekaDataSetBindingSource;
            // 
            // bookTabTableAdapter
            // 
            this.bookTabTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(101, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID читателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Книга";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата возврата";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookTabBindingSource, "BookCost", true));
            this.textBox1.Location = new System.Drawing.Point(101, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Стоимость книги";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 177);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDaysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberTabOrderTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookTabBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BibliotekaDataSet bibliotekaDataSet;
        private System.Windows.Forms.BindingSource orderTabBindingSource;
        private BibliotekaDataSetTableAdapters.OrderTabTableAdapter orderTabTableAdapter;
        private BibliotekaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource memberTabBindingSource;
        private BibliotekaDataSetTableAdapters.MemberTabTableAdapter memberTabTableAdapter;
        private System.Windows.Forms.BindingSource bibliotekaDataSetBindingSource;
        private System.Windows.Forms.BindingSource orderDaysBindingSource;
        private BibliotekaDataSetTableAdapters.OrderDaysTableAdapter orderDaysTableAdapter;
        private System.Windows.Forms.BindingSource memberTabOrderTabBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bookTabBindingSource;
        private BibliotekaDataSetTableAdapters.BookTabTableAdapter bookTabTableAdapter;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}