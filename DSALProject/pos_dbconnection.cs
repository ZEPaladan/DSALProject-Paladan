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
            //pos_connectionString = "Data Source = C203-33; Initial Catalog = POSDB; user id = SA; password = B1Admin123@";
            if (pos_sql_connection == null)
            {
                pos_sql_connection = new SqlConnection(pos_connectionString);
            }
            pos_sql_connection.ConnectionString = pos_connectionString;
            if (pos_sql_connection.State != ConnectionState.Open)
            {
                pos_sql_connection.Open();
            }
        }

        public void pos_cmd()
        {
            // Validate SQL text
            if (string.IsNullOrWhiteSpace(pos_sql))
            {
                throw new InvalidOperationException("pos_sql is null or empty. Call a pos_select... method before pos_cmd().");
            }

            // Ensure connection exists and is open
            if (pos_sql_connection == null || pos_sql_connection.State != ConnectionState.Open)
            {
                pos_connString(); // will create/open the connection
            }

            // Create command bound to a valid, open connection
            pos_sql_command = new SqlCommand(pos_sql, pos_sql_connection);
            pos_sql_command.CommandType = CommandType.Text;
        }

        public void pos_sqladapterSelect()
        {
            // For SELECT: create an adapter using the command. Do NOT call ExecuteNonQuery for SELECT.
            if (pos_sql_command == null)
            {
                pos_cmd();
            }

            if (pos_sql_command.Connection == null || pos_sql_command.Connection.State != ConnectionState.Open)
            {
                pos_connString();
                pos_sql_command.Connection = pos_sql_connection;
            }

            pos_sql_dataadapter = new SqlDataAdapter(pos_sql_command);
            // Data will be retrieved by pos_sqldatasetSELECT via Fill(...)
        }

        public void pos_sqladapterInsert()
        {
            // For INSERT: ensure command and connection are ready, then execute non-query.
            if (pos_sql_command == null)
            {
                pos_cmd();
            }

            if (pos_sql_command.Connection == null || pos_sql_command.Connection.State != ConnectionState.Open)
            {
                pos_connString();
                pos_sql_command.Connection = pos_sql_connection;
            }

            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.InsertCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterDelete()
        {
            if (pos_sql_command == null)
            {
                pos_cmd();
            }

            if (pos_sql_command.Connection == null || pos_sql_command.Connection.State != ConnectionState.Open)
            {
                pos_connString();
                pos_sql_command.Connection = pos_sql_connection;
            }

            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.DeleteCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqladapterUpdate()
        {
            if (pos_sql_command == null)
            {
                pos_cmd();
            }

            if (pos_sql_command.Connection == null || pos_sql_command.Connection.State != ConnectionState.Open)
            {
                pos_connString();
                pos_sql_command.Connection = pos_sql_connection;
            }

            pos_sql_dataadapter = new SqlDataAdapter();
            pos_sql_dataadapter.UpdateCommand = pos_sql_command;
            pos_sql_command.ExecuteNonQuery();
        }

        public void pos_sqldatasetSELECT()
        {
            // Codes for mirroring the contents of the database inside the MSSQL going to C# or Visual Studio
            pos_sql_dataset = new DataSet();

            if (pos_sql_dataadapter == null)
            {
                // make sure adapter exists and is wired
                pos_sqladapterSelect();
            }

            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_nameTbl");
        }

        public void pos_sqldatasetSELECTSALES()
        {
            pos_sql_dataset = new DataSet();

            if (pos_sql_dataadapter == null)
            {
                pos_sqladapterSelect();
            }

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
            if (pos_sql_dataadapter == null)
            {
                pos_sqladapterSelect();
            }
            pos_sql_dataadapter.Fill(pos_sql_dataset, "pos_empRegTbl");
        }
    }
}

