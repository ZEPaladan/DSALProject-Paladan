using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSALProject
{
    internal class pos_dbconnection
    {
        // Declaration of variables for database connections and queries to access from one form to another
        public string pos_connectionString = null;
        public SqlConnection pos_sql_connection;
        public SqlCommand pos_sql_command;
        public DataSet pos_sql_dataset;
        public SqlDataAdapter pos_sql_dataadapter;
        public string pos_sql = null;

        public void pos_connString()
        {
            // Codes to establish connection from C# forms to the SQL Server database
            pos_connectionString = "Data Source = .\\SQLEXPRESS; Initial Catalog = POSDB; User ID = sa; Password = admin";
            pos_sql_connection = new SqlConnection(pos_connectionString);
            pos_sql_connection.ConnectionString = pos_connectionString;
            pos_sql_connection.Open();
        }

        public void pos_cmd()
        {
            // Public function codes that support the MSSQL query
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

        public void pos_sqladapterSelect()
        {
            // Public function codes for mediating between C# Language and the MSSQL SELECT command
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.SelectCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterInsert()
        {
            // Public function codes for mediating between C# language and the MSSQL INSERT command
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterDelete()
        {
            // Public function codes for mediating between C# language and the MSSQL DELETE command
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterUpdate()
        {
            // Public function codes for mediating between C# language and the MSSQL UPDATE command
            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqldatasetSELECT()
        {
            // Codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTbl");
        }

        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "salesTbl");
        }

        public void pos_select()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_pictbl ON pos_nameTbl.pos_id = pos_pictbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_pictbl.pos_id = pos_priceTbl.pos_id";
        }

        public void pos_select_cashier()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_pictbl ON pos_nameTbl.pos_id = pos_pictbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_pictbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = 1";
        }

        public void pos_select_cashieri()
        {
            pos_sql = "SELECT * FROM pos_nameTbl " +
                      "INNER JOIN pos_pictbl ON pos_nameTbl.pos_id = pos_pictbl.pos_id " +
                      "INNER JOIN pos_priceTbl ON pos_pictbl.pos_id = pos_priceTbl.pos_id " +
                      "WHERE pos_nameTbl.pos_id = 2";
        }

        public void pos_select_cashier_display()
        {
            pos_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, pos_terminal_no, account_type " +
                      "FROM pos_empRegTbl " +
                      "INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                      "WHERE account_type = 'Administrator'";
        }

        public void pos_select_cashier_SELECTdisplay()
        {
            pos_sql_dataset = new DataSet();
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }
    }
}

