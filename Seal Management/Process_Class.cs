using System;
using System.Data.SqlClient;

namespace Seal_Management
{
    class Process_Class
    {
        public SqlConnection connection;
        
        public Process_Class(SqlConnection connection) {
            this.connection = connection;
        }
        //
        // open connection and set the sql_Cammand       
        public SqlCommand getCommand(String query) 
        {          
            // open the connection   
            connection.Open();    
            return new SqlCommand(query, connection); 
        }  
        // close the connection 
        public void closeConnection() {   
            //  
            connection.Close();   
        } 
        //
    
    }
}
