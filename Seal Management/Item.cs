using System;
using System.Windows.Forms;
// add the sql lab in the class
using System.Data.SqlClient;
namespace Seal_Management
{
    // item store form 
    public partial class Item : Form
    {
        // this class is used for connection open and close 
        // query process
        Process_Class proccess;
        // this is command instance that get the value from the process class after the calling fun
        public SqlCommand command;
        // sql connection class
        public SqlConnection connection;
        // used for read the data from the database
        public SqlDataReader reader;
        // string for create the query for exe..
        public String query;

      
       
        // constructor of the item class get the connection from the login form 
        public Item(SqlConnection connection)
        {
            // init the item form compounet 
            InitializeComponent();
            // try protect the code through the exception
            try
            {
                // this assgin the connection to this class instance
                this.connection = connection;
                //-----------
                //-----------
                // prcess class object
                proccess = new Process_Class(connection);
                // this will sholw the fill table on the window
                showTable();
                // query for get the next id for adding into the new item
                query = "select isnull(max(itemid+1),0) as itemid from itemlist";
                // this is used for foucs on the txtname 
                txtname.Focus();
                // send this query to the command    
                command = proccess.getCommand(query);
                // cammand execute
                reader = command.ExecuteReader();
                // reading the data from the reader 
                if (reader.Read())
                {
                    // add the value of id into the text
                    txtid.Text = reader["itemid"].ToString();
                }
                // close the connection
                proccess.closeConnection();
            }// this catch protect the exception and not stop the working of the code 
            catch (Exception Exception) {
                // message of the exception
                MessageBox.Show(Exception.Message);
                //
                proccess.closeConnection();
            }
        }
        // load is functino of this class
        private void Item_Load(object sender, EventArgs e)
        {
            // show the table
            showTable();
            // this will fill the combo box
            fill_combo();
        }
        // method for fill the box of combo
        public void fill_combo()
        {
            //
            try
            {
                // query for get the all item id's  for the database
                query = "select itemid from itemlist";
                // exe the command 
                command = proccess.getCommand(query);
                // read the data from the datareader
                reader = command.ExecuteReader();
                // used the loop to fill the box
                while (reader.Read())
                {
                    // add id's into the box
                    comid.Items.Add(reader["itemid"].ToString());
                  
                }
                // close the connection
                proccess.closeConnection();
            }// this will save the code from the error 
            catch (Exception Exception)
            {
                // show the mssage of error
                MessageBox.Show(Exception.Message);
                //
                proccess.closeConnection();
            }
        }
        // New Insertion new query         
        int Id_plus = 1;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //// call the function for the adding the item 
            try {
                // query for inserting the new item into the database
                query = "Insert into itemlist(itemid,itemname,qty,price,company)values('" + txtid.Text + "','" + txtname.Text + "','" + txtqnty.Text + "','" + txtprice.Text + "','" + txtcompany.Text + "')";
                // exe the query 
                command = proccess.getCommand(query);
                // check the status of the result 
                if (command.ExecuteNonQuery() > 0)
                {
                    // show message   
                    MessageBox.Show("The result is store");
                    // showing the table
                    showTable();
                    // increment the id 
                    Id_plus += Convert.ToInt16(txtid.Text);

                }
                // close the connection 
                proccess.closeConnection();
                // add the new it into the combobox
                comid.Items.Add(txtid.Text);
                // show the new id on the txt box
                txtid.Text = Id_plus.ToString();
                // set the id = 1
                Id_plus = 1;
                // get focus on the id txt
                txtid.Focus();
                // clear all the form txt
                txtcompany.Clear();
                txtprice.Clear();
                txtqnty.Clear();
                txtname.Clear();
                
            }// this will save the code from the error
            catch(Exception Exception){
                // show the message
                MessageBox.Show(Exception.Message);
                //
                proccess.closeConnection();
            }
           
        }
        // method of the show table
        public void showTable()
        {
            try {
                // query for select all the item from the database
                  query = "Select * from itemlist";
                  //data adapter is like a array 
                  SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                  // this will the object of the table that we are seeing on the window
                  System.Data.DataTable dataTable = new System.Data.DataTable(); 
                  // this will fill the table with the array adapter 
                  dataAdapter.Fill(dataTable); 
                  // and table give to the grid view 
                  dataGridView1.DataSource = dataTable;
            }// this will save the code from the error
            catch (Exception Exception) {
                // show the message
                MessageBox.Show(Exception.Message);
                proccess.closeConnection();
            }
        } 
        // gridview method is help us to get the item when we click on the cell of the table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // try block 
            try {
                // when the user click on the any cell the metho is call
                // after that the data grid view row is check the which row is click
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                // after that get the all item from this row and assing to the text box
                // id value from the cell assign to the id txt box
                idup.Text = row.Cells["itemid"].Value.ToString();
                // name value from the cell assign to the name txt box
                upname.Text = row.Cells["itemname"].Value.ToString();
                // Quanty value from the cell assign to the qty txt box
                upqnty.Text = row.Cells["qty"].Value.ToString();
                // Price value from the cell assign to the price txt box
                priceup.Text = row.Cells["price"].Value.ToString();
                // company value from the cell assign to the company txt box
                upcompany.Text = row.Cells["company"].Value.ToString();
                
            }// this will save the code from the error
            catch (Exception Exception) {
                // shwo the error mssage
                MessageBox.Show(Exception.Message); 
            }
            
        }

     
        // button for delete the item from the database
        private void btndelete_Click(object sender, EventArgs e)
        {
            // try block
            try
            {
                // query for delete the item from the databse by used of id
                query = "delete from itemlist where itemid =" + comid.Text;
                // exe the command 
                command = proccess.getCommand(query);
                // exe the non query 
                if (command.ExecuteNonQuery() > 0)
                {
                    // show message for result is delete
                    MessageBox.Show("The result is dalete");
                    // show the table after the delete the item
                    showTable();
                    // remove the id from the id box
                    comid.Items.Remove(comid.Text.ToString());
                    //

                }
                // close the connection
                proccess.closeConnection();
                

            }// this will save the code from error
            catch (Exception Exception)
            {
                // show the error message
                MessageBox.Show(Exception.Message);
                //
                proccess.closeConnection();
            }
             
        }
        // button for update the item into database
        private void btnupdate_Click(object sender, EventArgs e)
        {
            // try block
            try
            {
                // query for update item into the database 
                query = "update itemlist set itemname = '" + upname.Text + "',qty = '" + upqnty.Text + "',price ='" +
                priceup.Text + "',company='" + upcompany.Text + "' where itemid =" + idup.Text;
                // exe the command
                command = proccess.getCommand(query);
                // exe the non query
                if (command.ExecuteNonQuery() > 0)
                {
                    // show message   
                    MessageBox.Show("The result is update");
                    // show table after the update
                    showTable();
                }
                // close the connection
                proccess.closeConnection();
            }
            catch (Exception Exception)
            {
                MessageBox.Show(Exception.Message);
            }
            
        }

    }
}
