using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DSALProject
{
    public partial class UserAccount : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public UserAccount()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {
            try
            {
                // Disable editing for personal info fields
                textbox_firstname.Enabled = false;
                textbox_middlename.Enabled = false;
                textbox_lastname.Enabled = false;
                textbox_designation.Enabled = false;

                // Load user accounts
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position,
                   user_id, username, password, user_status, account_type, picpath
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                // --- Placeholder setup ---
                SetPlaceholder(textbox_firstname, "First Name");
                SetPlaceholder(textbox_middlename, "Middle Name");
                SetPlaceholder(textbox_lastname, "Last Name");
                SetPlaceholder(textbox_password, "Password", isPassword: true);
                SetPlaceholder(textbox_confirmpassword, "Confirm Password", isPassword: true);
                SetPlaceholder(textbox_username, "Username");

                // --- ComboBox options ---
                combobox_status.Items.Clear();
                combobox_status.Items.Add("Regular");
                combobox_status.Items.Add("Part-time");
                combobox_status.Items.Add("Contractual");

                combobox_accounttype.Items.Clear();
                combobox_accounttype.Items.Add("Administrator");
                combobox_accounttype.Items.Add("Cashier1");
                    combobox_accounttype.Items.Add("Cashier2");
                combobox_accounttype.Items.Add("HR Staff");
                combobox_accounttype.Items.Add("Accounting Staff");
                combobox_accounttype.Items.Add("IT Staff");

                // Optional: set default selection
                combobox_status.SelectedIndex = -1;       // nothing selected by default
                combobox_accounttype.SelectedIndex = -1;  // nothing selected by default


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading user accounts:\n" + ex.Message);
            }
        }
        private void cleartextboxes()
        {
            textbox_employeeid.Clear();
            textbox_userid.Clear();
            textbox_firstname.Clear();
            textbox_middlename.Clear();
            textbox_lastname.Clear();
            textbox_designation.Clear();
            textbox_username.Clear();
            textbox_password.Clear();
            textbox_confirmpassword.Clear();
            combobox_status.Text = "";
            combobox_accounttype.Text = "";
            pictureBox1.Image = null;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = $@"
            SELECT emp_id, emp_fname, emp_mname, emp_surname, position, picpath
            FROM pos_empRegTbl
            WHERE emp_id = '{textbox_employeeid.Text}'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    textbox_firstname.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0]["emp_fname"].ToString();
                    textbox_middlename.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0]["emp_mname"].ToString();
                    textbox_lastname.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0]["emp_surname"].ToString();
                    textbox_designation.Text = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0]["position"].ToString();

                    string picPath = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0]["picpath"].ToString();
                    if (File.Exists(picPath))
                        pictureBox1.Image = Image.FromFile(picPath);
                }
                else
                {
                    MessageBox.Show("No record found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching user:\n" + ex.Message);
            }
        }

        private void button_searchforupdate_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = $@"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position, picpath,
                   user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id
            WHERE user_id = '{textbox_userid.Text}'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();

                if (useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    var row = useraccount_db_connect.useraccount_sql_dataset.Tables[0].Rows[0];
                    textbox_firstname.Text = row["emp_fname"].ToString();
                    textbox_middlename.Text = row["emp_mname"].ToString();
                    textbox_lastname.Text = row["emp_surname"].ToString();
                    textbox_designation.Text = row["position"].ToString();
                    textbox_userid.Text = row["user_id"].ToString();
                    textbox_username.Text = row["username"].ToString();
                    textbox_password.Text = row["password"].ToString();
                    textbox_confirmpassword.Text = row["password"].ToString();
                    combobox_status.Text = row["user_status"].ToString();
                    combobox_accounttype.Text = row["account_type"].ToString();

                    string picPath = row["picpath"].ToString();
                    if (File.Exists(picPath))
                        pictureBox1.Image = Image.FromFile(picPath);
                }
                else
                {
                    MessageBox.Show("No record found for update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching for update:\n" + ex.Message);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = $@"
            UPDATE useraccountTbl
            SET account_type = '{combobox_accounttype.Text}',
                username = '{textbox_username.Text}',
                password = '{textbox_password.Text}',
                confirm_password = '{textbox_confirmpassword.Text}',
                user_status = '{combobox_status.Text}'
            WHERE user_id = '{textbox_userid.Text}'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();

                // Refresh DataGridView
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position,
                   user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                MessageBox.Show("User account updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating user account:\n" + ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = $@"
            DELETE FROM useraccountTbl WHERE user_id = '{textbox_userid.Text}'";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterDelete();

                // Refresh DataGridView
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position,
                   user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                cleartextboxes();
                MessageBox.Show("User account deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting user account:\n" + ex.Message);
            }
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = $@"
            INSERT INTO useraccountTbl (user_id, account_type, username, password, confirm_password, user_status, emp_id)
            VALUES ('{textbox_userid.Text}', '{combobox_accounttype.Text}', '{textbox_username.Text}', 
                    '{textbox_password.Text}', '{textbox_confirmpassword.Text}', '{combobox_status.Text}', '{textbox_employeeid.Text}')";

                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterInsert();

                // Refresh DataGridView
                useraccount_db_connect.useraccount_sql = @"
            SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, position,
                   user_id, username, password, user_status, account_type
            FROM pos_empRegTbl
            INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";
                useraccount_db_connect.useraccount_cmd();
                useraccount_db_connect.useraccount_sqladapterSelect();
                useraccount_db_connect.useraccount_sqldatasetSELECT();
                dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];

                MessageBox.Show("User account submitted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while submitting user account:\n" + ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetPlaceholder(TextBox tb, string placeholder, bool isPassword = false)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;
            tb.Tag = isPassword; // store whether this is a password field
            tb.UseSystemPasswordChar = false; // show text for placeholder

            tb.Enter += (s, e) => {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                    if (isPassword) tb.UseSystemPasswordChar = true;
                }
            };

            tb.Leave += (s, e) => {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                    if (isPassword) tb.UseSystemPasswordChar = false;
                }
            };
        }
    }
}
