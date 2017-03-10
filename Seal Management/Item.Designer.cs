namespace Seal_Management
{
    partial class Item
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcompany = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtqnty = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.comid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idup = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.upcompany = new System.Windows.Forms.TextBox();
            this.priceup = new System.Windows.Forms.TextBox();
            this.upqnty = new System.Windows.Forms.TextBox();
            this.upname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.itemlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salea_ManagementDataSet = new Seal_Management.Salea_ManagementDataSet();
            this.itemlistTableAdapter = new Seal_Management.Salea_ManagementDataSetTableAdapters.itemlistTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salea_ManagementDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcompany);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.txtqnty);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(95, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(133, 20);
            this.txtid.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company";
            // 
            // txtcompany
            // 
            this.txtcompany.Location = new System.Drawing.Point(95, 189);
            this.txtcompany.Name = "txtcompany";
            this.txtcompany.Size = new System.Drawing.Size(133, 20);
            this.txtcompany.TabIndex = 7;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(95, 148);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(133, 20);
            this.txtprice.TabIndex = 6;
            // 
            // txtqnty
            // 
            this.txtqnty.Location = new System.Drawing.Point(95, 107);
            this.txtqnty.Name = "txtqnty";
            this.txtqnty.Size = new System.Drawing.Size(133, 20);
            this.txtqnty.TabIndex = 5;
            // 
            // txtname
            // 
            this.txtname.AcceptsTab = true;
            this.txtname.Location = new System.Drawing.Point(95, 64);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(133, 20);
            this.txtname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qnty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 168);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.comid);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete Item";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(153, 19);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comid
            // 
            this.comid.FormattingEnabled = true;
            this.comid.Location = new System.Drawing.Point(73, 19);
            this.comid.Name = "comid";
            this.comid.Size = new System.Drawing.Size(48, 21);
            this.comid.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Get Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idup);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.upcompany);
            this.groupBox4.Controls.Add(this.priceup);
            this.groupBox4.Controls.Add(this.upqnty);
            this.groupBox4.Controls.Add(this.upname);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(285, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 192);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Updata Item";
            // 
            // idup
            // 
            this.idup.Location = new System.Drawing.Point(161, 19);
            this.idup.Name = "idup";
            this.idup.ReadOnly = true;
            this.idup.Size = new System.Drawing.Size(133, 20);
            this.idup.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.CausesValidation = false;
            this.label9.Location = new System.Drawing.Point(119, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(194, 154);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 23);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Company";
            // 
            // upcompany
            // 
            this.upcompany.Location = new System.Drawing.Point(79, 72);
            this.upcompany.Name = "upcompany";
            this.upcompany.Size = new System.Drawing.Size(133, 20);
            this.upcompany.TabIndex = 18;
            // 
            // priceup
            // 
            this.priceup.Location = new System.Drawing.Point(270, 72);
            this.priceup.Name = "priceup";
            this.priceup.Size = new System.Drawing.Size(133, 20);
            this.priceup.TabIndex = 17;
            // 
            // upqnty
            // 
            this.upqnty.Location = new System.Drawing.Point(270, 119);
            this.upqnty.Name = "upqnty";
            this.upqnty.Size = new System.Drawing.Size(133, 20);
            this.upqnty.TabIndex = 16;
            // 
            // upname
            // 
            this.upname.Location = new System.Drawing.Point(79, 119);
            this.upname.Name = "upname";
            this.upname.Size = new System.Drawing.Size(133, 20);
            this.upname.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Qnty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Price";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Item Name";
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(267, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(579, 188);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Table show";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 460);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Item";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Item_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salea_ManagementDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Salea_ManagementDataSet salea_ManagementDataSet;
        private System.Windows.Forms.BindingSource itemlistBindingSource;
        private Salea_ManagementDataSetTableAdapters.itemlistTableAdapter itemlistTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcompany;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtqnty;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ComboBox comid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox upcompany;
        private System.Windows.Forms.TextBox priceup;
        private System.Windows.Forms.TextBox upqnty;
        private System.Windows.Forms.TextBox upname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}