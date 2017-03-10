using System;
using System.Windows.Forms;
// add the liabrary 
using System.Data.SqlClient;
using System.Data; 


namespace Seal_Management
{
    public partial class Form1 : Form
    {
        // this instance help us to access the database
        public SqlConnection connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Salea Management;Integrated Security=True;Pooling=False");
        // used to get the command 
        public SqlCommand command;
        
        // init form1
        public Form1()
        {
            InitializeComponent();
            
        }

        // login button for log in the form 
        private void btnlog_Click(object sender, EventArgs e)
        {
            // this is used to access the name and user pass
            String name, pass;
            // get the name 
            name = txtuser.Text;
            // get pass word
            pass = txtpass.Text;
            // if both are empty
            if (name == "" && pass == "")
            {
                // show this message
                MessageBox.Show("Provide Correct User Name And Password");
            }
            try
            {
                //Create SqlConnection
                command = new SqlCommand("Select * from Login where Name=@name and Password=@password", connection);
                // match the parameters of the database
                command.Parameters.AddWithValue("@name", txtuser.Text);
                command.Parameters.AddWithValue("@password", txtpass.Text);
                // open the connection for exe the command
                connection.Open();
                // used of the adapter 
                SqlDataAdapter adapt = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                // fill the data by the set 
                adapt.Fill(ds);
                // close the conection
                connection.Close();
                // count the row in table 
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    // start the timer 
                    // for progress bar
                    this.timer1.Start();
                }
                else
                {
                    // this will show when the user wrong enter the pass
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                // show the error mes
                MessageBox.Show(ex.Message);
            }
        }
  
        // timmer is used like a thread 
        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment method used for increment the value into the progress bar
            this.progressBar1.Increment(1);
            // match the condition if it's equal to 100 than stop the timer 
            if (progressBar1.Value == 100) { 
                // stop the timer
                timer1.Stop();
                // hide the this login window 
                this.Hide();
                // object of the Home page
                // parameter of the parent has the connection of the database
                Parent mdi = new Parent(connection);
                // this will show the home page
                mdi.Show();

            }
            
        }

        // this button close the application and also the close the connection
        private void btnexit_Click(object sender, EventArgs e)
        {
            // close the app and data base
            connection.Close();
            // this one statement is used for the whole application exite
            Application.Exit();
        }

       
    }
}
