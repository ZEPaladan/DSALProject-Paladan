using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // Needed for ConfigurationManager

namespace DSALProject
{
    internal class useraccount_db_connection
    {
        public SqlConnection useraccount_sql_connection;
        public SqlCommand useraccount_sql_command;
        public DataSet useraccount_sql_dataset;
        public SqlDataAdapter useraccount_sql_dataadapter;
        public string useraccount_sql = null;

        public void useraccount_connString()
        {
            string connStr = ConfigurationManager.ConnectionStrings["POSDB"].ConnectionString;

            if (useraccount_sql_connection == null)
                useraccount_sql_connection = new SqlConnection(connStr);

            if (useraccount_sql_connection.State != ConnectionState.Open)
                useraccount_sql_connection.Open();
        }

        public void useraccount_cmd()
        {
            if (string.IsNullOrWhiteSpace(useraccount_sql))
                throw new InvalidOperationException("useraccount_sql is null or empty.");

            if (useraccount_sql_connection == null || useraccount_sql_connection.State != ConnectionState.Open)
                useraccount_connString();

            useraccount_sql_command = new SqlCommand(useraccount_sql, useraccount_sql_connection);
            useraccount_sql_command.CommandType = CommandType.Text;
        }

        public void useraccount_sqladapterSelect()
        {
            if (useraccount_sql_command == null)
                useraccount_cmd();

            useraccount_sql_dataadapter = new SqlDataAdapter(useraccount_sql_command);
        }

        public void useraccount_sqladapterInsert()
        {
            if (useraccount_sql_command == null)
                useraccount_cmd();

            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.InsertCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterDelete()
        {
            if (useraccount_sql_command == null)
                useraccount_cmd();

            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.DeleteCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqladapterUpdate()
        {
            if (useraccount_sql_command == null)
                useraccount_cmd();

            useraccount_sql_dataadapter = new SqlDataAdapter();
            useraccount_sql_dataadapter.UpdateCommand = useraccount_sql_command;
            useraccount_sql_command.ExecuteNonQuery();
        }

        public void useraccount_sqldatasetSELECT()
        {
            if (useraccount_sql_dataadapter == null)
                useraccount_sqladapterSelect();

            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "pos_empRegTbl");
        }

        public void useraccount_sqldatasetSELECT_Account()
        {
            if (useraccount_sql_dataadapter == null)
                useraccount_sqladapterSelect();

            useraccount_sql_dataset = new DataSet();
            useraccount_sql_dataadapter.Fill(useraccount_sql_dataset, "useraccountTb1");
        }
    }
}
