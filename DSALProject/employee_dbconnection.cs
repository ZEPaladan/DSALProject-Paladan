using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DSALProject
{
   

    internal class employee_dbconnection
    {
        public string employee_connectionstring = null;
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;

        public void employee_connString()
        {
            employee_sql_connection = new SqlConnection();
            employee_connectionstring = "Data Source = .\\SQLEXPRESS; Initial Catalog = SampleDatabaseDb; User ID = sa; Password = admin";
            employee_sql_connection = new SqlConnection(employee_connectionstring);
            employee_sql_connection.ConnectionString = employee_connectionstring;
            employee_sql_connection.Open();
        }

        public void employee_cmd()
        {
            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }
        public void employee_sqladapterSelect() // public function codes for mediating between C# Language and the MSSQL SELECT command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.SelectCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterInsert() // public function codes for mediating between C# language and the MSSQL INSERT Command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterDelete() // public function codes for mediating between C# language and the MSSQL DELETE command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterUpdate() // public function codes for mediating between C# language and the MSSQL UPDATE command
        {
            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqldatasetSELECT() // codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
        {
            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }

    }
}
