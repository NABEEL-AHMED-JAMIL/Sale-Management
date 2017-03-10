using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Seal_Management
{
    public partial class Main : Form
    {
        // instance variable
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        Process_Class proccess;
        String query;
        Item item;
        //
        double total = 0.0;
        //int grandtotal;
        // constructor of the main 
        public Main(SqlConnection connection)
        {
            InitializeComponent();
            // get the connection from the main 
            this.connection = connection;
            // process class
            proccess = new Process_Class(connection);
            //
            item = new Item(connection);
        }
        // main function load all the important douc
        private void Main_Load(object sender, EventArgs e)
        {
            // this will fill the combo Box of on the main screen 
            fill_combo();
        }
                
        // method for fill the box of combo
        public void fill_combo()
        {
            //try block
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
                    iditemsale.Items.Add(reader["itemid"].ToString());
                    // add id's into the box
                    idstockck.Items.Add(reader["itemid"].ToString());

                }
                // close the connection
                proccess.closeConnection();
            }// this will save the code from the error 
            catch (Exception Exception)
            {
                // show the mssage of error
                MessageBox.Show(Exception.Message);
                // close the connection
                proccess.closeConnection();
            }
        }

        // this id' button for check the reamaing stock
        private void idstockck_SelectedIndexChanged(object sender, EventArgs e)
        {
            // this query will show the item info 
            try{
                // qeury exe for get the all items from the database related to the id 
                query = query = "select * from itemlist where itemid = " + idstockck.Text;
                //exe the command
                command = proccess.getCommand(query);    
                // reader used to read the more than one data from the database
                reader = command.ExecuteReader();
                // used the conndtion 
                if (reader.Read()) 
                {        
                    //assign value of the reader to the name and quanty and price or company     
                    name.Text = reader["itemname"].ToString();
                    quanty.Text = reader["qty"].ToString();
                    price.Text = reader["price"].ToString();
                    company.Text = reader["company"].ToString();
                    
                      
                } // close the connection            
                proccess.closeConnection(); 
            }catch(Exception Exception){
                //
                MessageBox.Show(Exception.Message);
                proccess.closeConnection();
            }
            
        }

        // this id' button for sale the product 
        private void iditemsale_SelectedIndexChanged(object sender, EventArgs e)
        {
            // here the query 
            // this query will show the item info 
            try
            {
                // query of slect all think from the data base realted the id 
                query = "select * from itemlist where itemid =" + iditemsale.Text;
                //exe the command
                command = proccess.getCommand(query);
                // reader read the data from the database
                reader = command.ExecuteReader();
                // this used the condition
                if (reader.Read())
                {
                    //set the status of the id related info into the text box's     
                    saleitemname.Text = reader["itemname"].ToString();
                    saleprice.Text = reader["price"].ToString();
                    itemqntysale.Text = "";
                    txttotal.Text = "0.0";
                }
                // close the connection
                proccess.closeConnection();
            }
            catch (Exception Exception)
            {
                // show the error message
                MessageBox.Show(Exception.Message);
                // closet the connection
                proccess.closeConnection();
            }
            
        }
        // this text box is used to select the quanty for user need 
        private void itemqntysale_TextChanged(object sender, EventArgs e)
        {
            try {
                // check the total
                if (itemqntysale.Equals(null))
                {
                    // if ther is no digit message show
                    MessageBox.Show("Add the Quanty");
                    // and set the total zero
                    txttotal.Text = "0.0";
                }// if the if part wrong than else work
                else
                {
                    // get the total 
                    total = Convert.ToInt32(itemqntysale.Text) * Convert.ToDouble(saleprice.Text);
                    // set the toal into the toal
                    txttotal.Text = total.ToString();
                }
            }
            catch (Exception Ex) {
            //    MessageBox.Show("Enter the valied number");
            }
            
            
        }
        //
        int i = 0 ;
        private void addtolist_Click(object sender, EventArgs e)
        {
            // this click add the item into the gridevie
            // add this into the box
            itemdelete.Items.Add(i.ToString());
            dataGridView1.Rows.Add(i++, iditemsale.Text, saleitemname.Text, itemqntysale.Text, saleprice.Text, txttotal.Text);
            // get the all total
            Grandtotal();
            

        }

        // incrment the id 
        String id;
        // this row grid view is used to get the row from the gride
        DataGridViewRow row;
        // this gride view help to select the item and the assign to the txt box
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // get the selected row from the gride view
            row = this.dataGridView1.Rows[e.RowIndex];
            // split the each cells from the selected row
            id = row.Cells["no"].Value.ToString();
            updateid.Text = row.Cells["product_id"].Value.ToString();
            upprduct.Text = row.Cells["name_id"].Value.ToString();
            itemqntyupdate.Text = row.Cells["quanty_id"].Value.ToString();
            upprice.Text = row.Cells["Price_per_id"].Value.ToString();
            uptotal.Text = row.Cells["total_id"].Value.ToString();
            
        }
        // this button help us to update the item product in the seal inventory 
        // if user want to incress his/her product in to the list
        private void itemqntyupdate_TextChanged(object sender, EventArgs e)
        {
            // try block
            try
            {
                // check the total
                if (itemqntyupdate.Equals(null))
                {
                    // show the message
                    MessageBox.Show("Add the Quanty");
                    // show the text box total zero
                    txttotal.Text = "0.0";
                }
                else
                {
                    // update the Total 
                    total = Convert.ToInt32(itemqntyupdate.Text) * Convert.ToDouble(upprice.Text);
                    // set the toal into the toal
                    uptotal.Text = total.ToString();
                }
            }
            catch (Exception Ex)
            {
                //    MessageBox.Show("Enter the valied number");
            }
            
            

        }
        // this button is the update button
        // this will update the new value into the gridview selected row
        private void button1_Click(object sender, EventArgs e)
        {
            // try and catch block
            try {
                row.Cells["no"].Value = id.ToString();
                row.Cells["product_id"].Value = updateid.Text.ToString();  
                row.Cells["name_id"].Value = upprduct.Text;
                row.Cells["quanty_id"].Value = itemqntyupdate.Text;
                row.Cells["Price_per_id"].Value = upprice.Text;
                row.Cells["total_id"].Value =  uptotal.Text;
                // get the grand total
                Grandtotal();
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
                // close the connection
                proccess.closeConnection();
            }
                
        }
        // this button help to delete the item product from the item table
        private void itemdelte_Click(object sender, EventArgs e)
        {
            try {
                  // remove the prdouct row from the datagridview
                  dataGridView1.Rows.RemoveAt(Convert.ToInt32(itemdelete.Text));
                  // delete the item from the box
                  itemdelete.Items.RemoveAt(Convert.ToInt32(itemdelete.Text));
                  // show the grand total  
                  Grandtotal();
            }catch(Exception ex){
                // error message
                MessageBox.Show(ex.Message);
                // close the connection
                proccess.closeConnection();
            }
            
        }

        // print button
        //-------------------------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            // this will used to print the doucment  
            printDocument1.Print();

        }
     
        // this will print the table
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // convert the datagrid view into bitmpa
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);


        }
        //
        object temp = "0.0";
        double priced = 0.0;
        public void Grandtotal() { 
           // used the data reader to show the total 
          // 
            try
            {
                // loop help to calculte the total
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // this will get the one row at a time
                    row = this.dataGridView1.Rows[i];
                    // this will get the cell value of the current row 
                    temp = row.Cells["total_id"].Value.ToString();
                    // convert this row item into to double for calculation process
                    priced += Convert.ToDouble(temp);

                }
                // know assign the total price to the grandtotal var
                grandtotal.Text = priced.ToString();
                // after asgin the value the value priced zero
                priced = 0.0;
                // temp also be zero for used next time 
                temp = "0.0";
            }
            catch (Exception ex) {
                // show error message box
                MessageBox.Show(ex.Message);
                // close the connection
                proccess.closeConnection();
            }

        }
        // method for clear un use able data 
        private void btnclear_Click(object sender, EventArgs e)
        {
            // clear the all the list and up date protion and delete portion
            dataGridView1.Rows.Clear();
            i = 0;
            itemdelete.Items.Clear(); 
            updateid.Text = "";
            upprduct.Text = "";
            itemqntyupdate.Text = "";
            upprice.Text = "";
            uptotal.Text = "";
            grandtotal.Text = "0.0";
        }

        // this will show the payment accept and update the database back-end
        private void btnpaymentok_Click(object sender, EventArgs e)
        {
            try {
                // this will check the total value if the value is zero this will not be get the cahce and do notting
            if (grandtotal.Text.Equals("0.0") || grandtotal.Text.Equals("0"))
            {
                MessageBox.Show("Cashe is zero not be able to receved");
            }
            else {
                // if the total is more than 0 and used this loop
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    // get the each row one by one for the gridview
                    row = this.dataGridView1.Rows[i];
                    // query for update the data base
                    query = "update itemlist set qty = qty + @quanty where itemid = @userid";
                    // this will hlep to make the update possible 
                    command = proccess.getCommand(query);
                    // subtract the sale quanty from the database quanty 
                    command.Parameters.AddWithValue("@quanty", -Convert.ToInt32(row.Cells["quanty_id"].Value.ToString()));
                    // this is for id identifier
                    command.Parameters.AddWithValue("@userid", row.Cells["product_id"].Value.ToString());
                    // exe the query 
                    if (command.ExecuteNonQuery() > 0){
                        // show message                   
                        MessageBox.Show("The result is Update");
                        // show table will update the 
                        this.item.showTable();
                    } 
                    // close the connection
                    proccess.closeConnection(); 
                }
                // message for cashe recived 
                MessageBox.Show("Cashe has Recived....");
 
            }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
                proccess.closeConnection();
            }
            
        }

       
     
    }
}
