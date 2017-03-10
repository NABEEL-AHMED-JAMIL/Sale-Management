namespace Seal_Management
{
    partial class ADD
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
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.txtitemcost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salea_ManagementDataSet = new Seal_Management.Salea_ManagementDataSet();
            this.itemlistTableAdapter = new Seal_Management.Salea_ManagementDataSetTableAdapters.itemlistTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salea_ManagementDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Name";
            // 
            // txtitemname
            // 
            this.txtitemname.Location = new System.Drawing.Point(125, 34);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.Size = new System.Drawing.Size(116, 20);
            this.txtitemname.TabIndex = 1;
            // 
            // txtitemcost
            // 
            this.txtitemcost.Location = new System.Drawing.Point(125, 75);
            this.txtitemcost.Name = "txtitemcost";
            this.txtitemcost.Size = new System.Drawing.Size(116, 20);
            this.txtitemcost.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Company";
            // 
            // txtcompany
            // 
            this.txtcompany.Location = new System.Drawing.Point(125, 166);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(116, 20);
            this.txtcompany.TabIndex = 6;
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(125, 120);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(116, 20);
            this.txtqty.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantatiy ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtitemname);
            this.groupBox1.Controls.Add(this.txtcompany);
            this.groupBox1.Controls.Add(this.txtitemcost);
            this.groupBox1.Controls.Add(this.txtqty);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 263);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(102, 213);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 8;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Location = new System.Drawing.Point(14, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Select item for Delete";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(34, 115);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(104, 23);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete item";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemnameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemlistBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 231);
            this.dataGridView1.TabIndex = 10;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "itemid";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // itemnameDataGridViewTextBoxColumn
            // 
            this.itemnameDataGridViewTextBoxColumn.DataPropertyName = "itemname";
            this.itemnameDataGridViewTextBoxColumn.HeaderText = "itemname";
            this.itemnameDataGridViewTextBoxColumn.Name = "itemnameDataGridViewTextBoxColumn";
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "company";
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // itemlistBindingSource
            // 
            this.itemlistBindingSource.DataMember = "itemlist";
            this.itemlistBindingSource.DataSource = this.salea_ManagementDataSet;
            // 
            // salea_ManagementDataSet
            // 
            this.salea_ManagementDataSet.DataSetName = "Salea_ManagementDataSet";
            this.salea_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemlistTableAdapter
            // 
            this.itemlistTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(333, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 256);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table Status";
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 504);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ADD";
            this.Text = "Add item";
            this.Load += new System.EventHandler(this.ADD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salea_ManagementDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtitemcost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Salea_ManagementDataSet salea_ManagementDataSet;
        private System.Windows.Forms.BindingSource itemlistBindingSource;
        private Salea_ManagementDataSetTableAdapters.itemlistTableAdapter itemlistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}