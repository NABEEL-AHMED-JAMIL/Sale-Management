using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Seal_Management
{
    public partial class Parent : Form
    {
        // 
        SqlConnection connection;
        Item item;
        Main main;
        public Parent(SqlConnection connection)
        {
            //  
            InitializeComponent();

            this.connection = connection;
            item = new Item(connection);
            main = new Main(connection);
            

        }
      
        private void Parent_Load(object sender, EventArgs e)
        {
           
            main.MdiParent = this;
            main.Dock = DockStyle.Fill;
            main.Show();
        }

        private void mainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            item.Hide();
        }
        Form1 form1;
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // the mdi form is hide 
            this.Hide();
            // and the logform is one
            form1 = new Form1();
            // show the log form 
            form1.Show();
        }

        private void itemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //
            item.MdiParent = this;
            item.Dock = DockStyle.Fill;
            item.Show();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // show about
            About about = new About();
            // show the file
            about.Show();
        }
        //
        

  
        
    }
}
