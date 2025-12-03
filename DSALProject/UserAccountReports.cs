using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSALProject
{
    public partial class UserAccountReports : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public UserAccountReports()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void UserAccountReports_Load(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                   position, user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!\n" + ex.Message);
            }
        }
        private void useraccount_select()
        {
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        // Method to clear combo box and textbox
        private void cleartextboxes()
        {
            combobox_options.Text = "";
            textbox_options.Clear();
            combobox_options.Focus();
        }

        // Clear only textbox and focus
        private void cleartextboxes1()
        {
            textbox_options.Clear();
            textbox_options.Focus();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = textbox_options.Text;

                if (combobox_options.Text == "user_id")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE user_id = '{searchValue}'";
                }
                else if (combobox_options.Text == "employee_number")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE pos_empRegTbl.emp_id = '{searchValue}'";
                }
                else if (combobox_options.Text == "surname")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE emp_surname = '{searchValue}'";
                }
                else if (combobox_options.Text == "firstname")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE emp_fname = '{searchValue}'";
                }
                else if (combobox_options.Text == "active")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE user_status = 'Active'";
                }
                else if (combobox_options.Text == "deactivate")
                {
                    useraccount_db_connect.useraccount_sql = $@"
                SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                       position, user_id, username, password, user_status, account_type
                FROM pos_empRegTbl
                INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
                WHERE user_status = 'Deactivate'";
                }
                else
                {
                    MessageBox.Show("No Available Record Found!");
                    return;
                }

                useraccount_select();
                cleartextboxes1();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!\n" + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department,
                   position, user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_select();
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!\n" + ex.Message);
            }
        }
    }
}
