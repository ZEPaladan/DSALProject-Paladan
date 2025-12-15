using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DSALProject
{
    internal class employee_dbconnection
    {
        public SqlConnection employee_sql_connection;
        public SqlCommand employee_sql_command;
        public DataSet employee_sql_dataset;
        public SqlDataAdapter employee_sql_dataadapter;
        public string employee_sql = null;

        // Connect to database using connection string from App.config
        public void employee_connString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["POSDB"].ConnectionString;
            employee_sql_connection = new SqlConnection(connStr);
            employee_sql_connection.Open();
        }

        public void employee_cmd()
        {
            if (employee_sql_connection == null || employee_sql_connection.State != ConnectionState.Open)
                employee_connString();

            employee_sql_command = new SqlCommand(employee_sql, employee_sql_connection);
            employee_sql_command.CommandType = CommandType.Text;
        }

        public void employee_sqladapterSelect()
        {
            if (employee_sql_command == null)
                employee_cmd();

            employee_sql_dataadapter = new SqlDataAdapter(employee_sql_command);
        }

        public void employee_sqladapterInsert()
        {
            if (employee_sql_command == null)
                employee_cmd();

            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.InsertCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterDelete()
        {
            if (employee_sql_command == null)
                employee_cmd();

            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.DeleteCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqladapterUpdate()
        {
            if (employee_sql_command == null)
                employee_cmd();

            employee_sql_dataadapter = new SqlDataAdapter();
            employee_sql_dataadapter.UpdateCommand = employee_sql_command;
            employee_sql_command.ExecuteNonQuery();
        }

        public void employee_sqldatasetSELECT()
        {
            if (employee_sql_dataadapter == null)
                employee_sqladapterSelect();

            employee_sql_dataset = new DataSet();
            employee_sql_dataadapter.Fill(employee_sql_dataset, "pos_empRegTbl");
        }
    }
}
