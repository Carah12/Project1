using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace ProgrammingProject
{
    class DBAccess
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbo.Encryption;Integrated Security=True
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        public DBAccess()
        {
            connection.DataSource = @"(localdb)\MSSQLLocalDB";
            connection.InitialCatalog = "dbo.Encryption";
            connection.IntegratedSecurity = true;
        }
        public DataSet ReadData(string tableName)
        {
            DataSet rawData = new DataSet();
            
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                string qry = string.Format("SELECT * FROM {0}", tableName);
                SqlCommand command = new SqlCommand(qry, conn);
                command.Parameters.AddWithValue("btlUser", tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.FillSchema(rawData, SchemaType.Source, tableName);
                adapter.Fill(rawData, tableName);
                command.ExecuteNonQuery();

                conn.Close();
            }
            

            return rawData;
        }

        public void InsertUser(ArrayList data)
        {
            SqlConnection conn = new SqlConnection(connection.ToString());
            conn.Open();
            SqlCommand command = new SqlCommand("ProcInsert", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@name", data[0]);
            command.Parameters.AddWithValue("@surname", data[1]);
            command.Parameters.AddWithValue("@age", data[2]);
            command.Parameters.AddWithValue("@rank", data[3]);
            command.Parameters.AddWithValue("@idNumber", data[4]);
            command.Parameters.AddWithValue("@username", data[5]);
            command.Parameters.AddWithValue("@password", data[6]);
            command.Parameters.AddWithValue("@isAdmin", data[7]);
            command.ExecuteNonQuery();

            conn.Close();
        }
    }
}
