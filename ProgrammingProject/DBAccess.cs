using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
            }

            return rawData;
        }
    }
}
