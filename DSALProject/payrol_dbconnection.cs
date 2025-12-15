using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // Make sure System.Configuration is referenced

namespace DSALProject
{
    internal class payrol_dbconnection
    {
        public SqlConnection payrol_sql_connection;
        public SqlCommand payrol_sql_command;
        public DataSet payrol_sql_dataset;
        public SqlDataAdapter payrol_sql_dataadapter;
        public string payrol_sql = null;

        // Connect to database using connection string from App.config
        public void payrol_connString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["POSDB"].ConnectionString;
            payrol_sql_connection = new SqlConnection(connStr);
            payrol_sql_connection.Open();
        }

        public void payrol_cmd()
        {
            if (payrol_sql_connection == null || payrol_sql_connection.State != ConnectionState.Open)
                payrol_connString();

            payrol_sql_command = new SqlCommand(payrol_sql, payrol_sql_connection);
            payrol_sql_command.CommandType = CommandType.Text;
        }

        public void payrol_sqladapterSelect()
        {
            if (payrol_sql_command == null)
                payrol_cmd();

            payrol_sql_dataadapter = new SqlDataAdapter(payrol_sql_command);
        }

        public void payrol_sqladapterInsert()
        {
            if (payrol_sql_command == null)
                payrol_cmd();

            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.InsertCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqladapterDelete()
        {
            if (payrol_sql_command == null)
                payrol_cmd();

            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.DeleteCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqladapterUpdate()
        {
            if (payrol_sql_command == null)
                payrol_cmd();

            payrol_sql_dataadapter = new SqlDataAdapter();
            payrol_sql_dataadapter.UpdateCommand = payrol_sql_command;
            payrol_sql_command.ExecuteNonQuery();
        }

        public void payrol_sqldatasetSELECT()
        {
            if (payrol_sql_dataadapter == null)
                payrol_sqladapterSelect();

            payrol_sql_dataset = new DataSet();
            payrol_sql_dataadapter.Fill(payrol_sql_dataset, "pos_empRegTbl");
        }
    }
}
