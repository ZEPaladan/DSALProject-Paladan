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
    public partial class SalesReports : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        public SalesReports()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void SalesReports_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate combobox_options with search choices
                combobox_options.Items.Clear();
                combobox_options.Items.Add("transaction_id");
                combobox_options.Items.Add("terminal_number");
                combobox_options.Items.Add("date_and_time");
                combobox_options.Items.Add("product_name");
                combobox_options.Items.Add("employee_number");

                combobox_options.Text = "Select search option";

                // Load all sales records
                posdb_connect.pos_sql = "SELECT * FROM salesTbl";
                pos_select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading sales records:\n" + ex.Message);
            }
        }
        private void pos_select()
        {
            try
            {
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECTSALES();

                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving sales records:\n" + ex.Message);
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

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "";

                if (combobox_options.Text == "transaction_id")
                {
                    sql = $"SELECT * FROM salesTbl WHERE transaction_id = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "terminal_number")
                {
                    sql = $"SELECT * FROM salesTbl WHERE terminal_no = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "date_and_time")
                {
                    sql = $"SELECT * FROM salesTbl WHERE time_date = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "product_name")
                {
                    sql = $"SELECT * FROM salesTbl WHERE product_name = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "employee_number")
                {
                    sql = $"SELECT * FROM salesTbl WHERE emp_id = '{textbox_options.Text}'";
                }
                else
                {
                    MessageBox.Show("Please select a valid search option!");
                    return;
                }

                posdb_connect.pos_sql = sql;
                pos_select();
                cleartextboxes1();

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching sales records:\n" + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM salesTbl";
                pos_select();
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while returning to full sales report:\n" + ex.Message);
            }
        }
    }
}
