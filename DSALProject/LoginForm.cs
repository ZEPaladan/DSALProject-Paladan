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
           
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_username.Text == "newemp" && textbox_password.Text == "newemp")
                {
                    MessageBox.Show("Access granted");

                    MainForm adminForm = new MainForm();
                    adminForm.EmployeeID = "0";  // dummy ID
                    adminForm.EmployeeName = "Default Admin";
                    adminForm.TerminalNo = "1";
                    adminForm.LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    cleartextboxes();
                    adminForm.Show();
                    this.Hide();
                    return; // Skip the rest
                }
                // 🔹 Connect to database SAFELY (not in constructor)
                login_db_connect.login_connString();

                // 🔹 SQL query
                login_db_connect.login_sql =
                    "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no " +
                    "FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id " +
                    "WHERE username='" + textbox_username.Text + "' AND password='" + textbox_password.Text + "'";

                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                if (login_db_connect.login_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    string user_level =
                        login_db_connect.login_sql_dataset.Tables[0].Rows[0]["account_type"].ToString();

                    Form myform = null;

                    switch (user_level)
                    {
                        case "Administrator":
                            MessageBox.Show("Access granted");

                            MainForm adminForm = new MainForm();
                            adminForm.EmployeeID =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                            adminForm.EmployeeName =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"] + " " +
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"];
                            adminForm.TerminalNo =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                            adminForm.LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            myform = adminForm;
                            break;

                        case "Cashier1":
                            MessageBox.Show("Access granted");

                            POSFoodOrderingApplication cashier1 = new POSFoodOrderingApplication();
                            cashier1.EmployeeID =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                            cashier1.EmployeeName =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"] + " " +
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"];
                            cashier1.TerminalNo =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                            cashier1.LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            myform = cashier1;
                            break;

                        case "Cashier2":
                            MessageBox.Show("Access granted");

                            POSOrderingApplication cashier2 = new POSOrderingApplication();
                            cashier2.EmployeeID =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_id"].ToString();
                            cashier2.EmployeeName =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_fname"] + " " +
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["emp_surname"];
                            cashier2.TerminalNo =
                                login_db_connect.login_sql_dataset.Tables[0].Rows[0]["pos_terminal_no"].ToString();
                            cashier2.LoginDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                            myform = cashier2;
                            break;

                        case "HR Staff":
                            MessageBox.Show("Access granted");

                            EmployeeRegistration hrForm = new EmployeeRegistration();
                            hrForm.button_delete.Enabled = false;
                            myform = hrForm;
                            break;

                        case "Accounting Staff":
                            MessageBox.Show("Access granted");

                            PayrollDatabase payrollForm = new PayrollDatabase();
                            payrollForm.button_searchedit.Hide();
                            payrollForm.button_edit.Hide();
                            payrollForm.button_delete.Hide();
                            myform = payrollForm;
                            break;

                        case "IT Staff":
                            MessageBox.Show("Access granted");

                            UserAccount itForm = new UserAccount();
                            itForm.button_searchforupdate.Hide();
                            itForm.button_update.Hide();
                            itForm.button_delete.Hide();
                            myform = itForm;
                            break;

                        default:
                            MessageBox.Show("Access denied");
                            cleartextboxes();
                            return;
                    }

                    cleartextboxes();
                    myform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    cleartextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
