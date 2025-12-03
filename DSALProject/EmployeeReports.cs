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
    public partial class EmployeeReports : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public EmployeeReports()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }
        private void payrol_select()
        {
            try
            {
                payrol_db_connect.payrol_cmd();
                payrol_db_connect.payrol_sqladapterSelect();
                payrol_db_connect.payrol_sqldatasetSELECT();

                dataGridView1.DataSource = payrol_db_connect.payrol_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while selecting records:\n" + ex.Message);
            }
        }
        private void cleartextboxes()
        {
            combobox_options.Text = "";
            textbox_options.Clear();
            combobox_options.Focus();
        }

        private void cleartextboxes1()
        {
            textbox_options.Clear();
            textbox_options.Focus();
        }


        private void EmployeeReports_Load(object sender, EventArgs e)
        {
            try
            {
                combobox_options.Items.Add("employee_number");
                combobox_options.Items.Add("surname");
                combobox_options.Items.Add("firstname");
                combobox_options.Items.Add("department");
                combobox_options.Items.Add("designation");
                combobox_options.Items.Add("zipcode");
                combobox_options.Items.Add("province");
                combobox_options.Items.Add("city");

                // Optional: set default text
                combobox_options.Text = "Select search option";

                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
                payrol_select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading form:\n" + ex.Message);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (combobox_options.Text == "employee_number")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "surname")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE emp_surname = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "firstname")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE emp_fname = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "department")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE emp_department = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "designation")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE position = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "zipcode")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "province")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE add_state_province = '" + textbox_options.Text + "'";
                }
                else if (combobox_options.Text == "city")
                {
                    payrol_db_connect.payrol_sql =
                        "SELECT * FROM pos_empRegTbl WHERE add_city = '" + textbox_options.Text + "'";
                }
                else
                {
                    MessageBox.Show("Please select a valid search option!");
                    return;
                }

                payrol_select();
                cleartextboxes1();

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching records:\n" + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql = "SELECT * FROM pos_empRegTbl";
                payrol_select();
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while returning to full list:\n" + ex.Message);
            }
        }
    }
}
