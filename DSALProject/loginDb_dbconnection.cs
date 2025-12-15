using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // Make sure you have System.Configuration referenced

namespace DSALProject
{
    internal class loginDb_dbconnection
    {
        public SqlConnection login_sql_connection;
        public SqlCommand login_sql_command;
        public DataSet login_sql_dataset;
        public SqlDataAdapter login_sql_dataadapter;
        public string login_sql = null;

        // Connect to database using connection string from App.config
        public void login_connString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["POSDB"].ConnectionString;
            login_sql_connection = new SqlConnection(connStr);
            login_sql_connection.Open();
        }

        public void login_cmd()
        {
            if (login_sql_connection == null || login_sql_connection.State != ConnectionState.Open)
                login_connString();

            login_sql_command = new SqlCommand(login_sql, login_sql_connection);
            login_sql_command.CommandType = CommandType.Text;
        }

        public void login_sqladapterSelect()
        {
            if (login_sql_command == null)
                login_cmd();

            login_sql_dataadapter = new SqlDataAdapter(login_sql_command);
        }

        public void login_sqladapterInsert()
        {
            if (login_sql_command == null)
                login_cmd();

            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.InsertCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterDelete()
        {
            if (login_sql_command == null)
                login_cmd();

            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.DeleteCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqladapterUpdate()
        {
            if (login_sql_command == null)
                login_cmd();

            login_sql_dataadapter = new SqlDataAdapter();
            login_sql_dataadapter.UpdateCommand = login_sql_command;
            login_sql_command.ExecuteNonQuery();
        }

        public void login_sqldatasetSELECT()
        {
            if (login_sql_dataadapter == null)
                login_sqladapterSelect();

            login_sql_dataset = new DataSet();
            login_sql_dataadapter.Fill(login_sql_dataset, "pos_empRegTbl");
        }
    }
}
