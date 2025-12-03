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
    public partial class LoginForm : Form
    {
        private string username1, password1, user_level;
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnection login_db_connect = new loginDb_dbconnection();
        public LoginForm()
        {
            InitializeComponent();
            login_db_connect.login_connString();
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            try
            {
                login_db_connect.login_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no " +
                    "FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                    "WHERE username='" + textbox_username.Text + "' AND password='" + textbox_password.Text + "'";

                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                if (login_db_connect.login_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["username"].ToString();
                    password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["password"].ToString();
                    user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["account_type"].ToString();

                    if ((username1 == textbox_username.Text) && (password1 == textbox_password.Text))
                    {
                        Form myform = null;

                        switch (user_level)
                        {
                            case "Administrator":
                                MessageBox.Show("Access granted");
                                myform = new MainForm();
                                ((MainForm)myform).EmployeeID = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                                ((MainForm)myform).EmployeeName =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"].ToString() + " " +
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"].ToString();
                                ((MainForm)myform).TerminalNo =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                                ((MainForm)myform).LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                break;

                            case "Cashier1":
                                MessageBox.Show("Access granted");
                                myform = new POSFoodOrderingApplication();
                                ((MainForm)myform).EmployeeID = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                                ((MainForm)myform).EmployeeName =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"].ToString() + " " +
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"].ToString();
                                ((MainForm)myform).TerminalNo =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                                ((MainForm)myform).LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                                break;
                                

                            case "Cashier2":
                                MessageBox.Show("Access granted");
                                myform = new POSOrderingApplication();
                                // Optional: set labels for terminal, employee info
                                ((POSOrderingApplication)myform).EmployeeID = login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                                ((POSOrderingApplication)myform).EmployeeName =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"].ToString() + " " +
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"].ToString();
                                ((POSOrderingApplication)myform).TerminalNo =
                                    login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                                ((POSOrderingApplication)myform).LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                                break;

                            case "HR Staff":
                                MessageBox.Show("Access granted");
                                myform = new EmployeeRegistration();
                                ((EmployeeRegistration)myform).button_delete.Enabled = false;
                                break;

                            case "Accounting Staff":
                                MessageBox.Show("Access granted");
                                myform = new PayrollDatabase();
                                ((PayrollDatabase)myform).button_searchedit.Hide();
                                ((PayrollDatabase)myform).button_edit.Hide();
                                ((PayrollDatabase)myform).button_delete.Hide();
                                break;

                            case "IT Staff":
                                MessageBox.Show("Access granted");
                                myform = new UserAccount();
                                ((UserAccount)myform).button_searchforupdate.Hide();
                                ((UserAccount)myform).button_update.Hide();
                                ((UserAccount)myform).button_delete.Hide();
                                break;

                            default:
                                MessageBox.Show("Access Denied");
                                cleartextboxes();
                                return;
                        }

                        cleartextboxes();
                        myform.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    cleartextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred. Please contact your administrator!\n\n" + ex.Message);
                cleartextboxes();
            }
        }

        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void cleartextboxes()
        {
            textbox_username.Clear();
            textbox_username.Focus();
            textbox_password.Clear();
        }
    }
}
