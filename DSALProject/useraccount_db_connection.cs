using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALProject
{
    internal class useraccount_db_connection
    {
        // Declaration of variables for database connections and queries to access from one form to another
        public string useraccount_connectionString = null;
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            useraccount_connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = POSDB; User ID = sa; Password = admin";
            //useraccount_connectionString = "Data Source = C203-33; Initial Catalog = POSDB; user id = SA; password = B1Admin123@";
            useraccount_sql_connection = new SqlConnection(useraccount_connectionString);
            useraccount_sql_connection.ConnectionString = useraccount_connectionString;
            useraccount_sql_connection.Open();
        }

        public void useraccount_cmd()
        {
            // Public function codes that support the MSSQL query
            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }

        public void useraccount_sqladapterSelect()
        {
            // Public function codes for mediating between C# language and the MSSQL SELECT command
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.SelectCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterInsert()
        {
            // Public function codes for mediating between C# language and the MSSQL INSERT command
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterDelete()
        {
            // Public function codes for mediating between C# language and the MSSQL DELETE command
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterUpdate()
        {
            // Public function codes for mediating between C# language and the MSSQL UPDATE command
            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqldatasetSELECT()
        {
            // Codes for mirroring the contents of the database inside MSSQL to C# or Visual Studio
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
        }

        public void useraccount_sqldatasetSELECT_Account()
        {
            // Codes for mirroring the contents of the database inside MSSQL to C# or Visual Studio
            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTb1");
        }
    }
}
