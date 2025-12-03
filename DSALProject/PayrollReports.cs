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
    public partial class PayrollReports : Form
    {
        payrol_dbconnection payrol_db_connect = new payrol_dbconnection();
        public PayrollReports()
        {
            payrol_db_connect.payrol_connString();
            InitializeComponent();
        }

        private void PayrollReports_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate combobox_options with search choices
                combobox_options.Items.Clear();
                combobox_options.Items.Add("employee_number");
                combobox_options.Items.Add("surname");
                combobox_options.Items.Add("firstname");
                combobox_options.Items.Add("gross_income");
                combobox_options.Items.Add("net_income");
                combobox_options.Items.Add("pay_date");

                combobox_options.Text = "Select search option";

                // Load full payroll report
                payrol_db_connect.payrol_sql = @"
            SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                   p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                   p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                   p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                   p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                   p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                   p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
            FROM pos_empRegTbl e
            INNER JOIN payrolTbl p ON e.emp_id = p.emp_id";
                payrol_select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading payroll report:\n" + ex.Message);
            }
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
                MessageBox.Show("Error while retrieving payroll records:\n" + ex.Message);
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

                if (combobox_options.Text == "employee_number")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE e.emp_id = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "surname")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE e.emp_surname = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "firstname")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE e.emp_fname = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "gross_income")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE p.gross_income = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "net_income")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE p.net_income = '{textbox_options.Text}'";
                }
                else if (combobox_options.Text == "pay_date")
                {
                    sql = $@"
                SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                       p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                       p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                       p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                       p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                       p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                       p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
                FROM pos_empRegTbl e
                INNER JOIN payrolTbl p ON e.emp_id = p.emp_id
                WHERE p.pay_date = '{textbox_options.Text}'";
                }
                else
                {
                    MessageBox.Show("Please select a valid search option!");
                    return;
                }

                payrol_db_connect.payrol_sql = sql;
                payrol_select();
                cleartextboxes1();

                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching payroll records:\n" + ex.Message);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            try
            {
                payrol_db_connect.payrol_sql = @"
            SELECT e.emp_fname, e.emp_mname, e.emp_surname, 
                   p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff,
                   p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff,
                   p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff,
                   p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib,
                   p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan,
                   p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date
            FROM pos_empRegTbl e
            INNER JOIN payrolTbl p ON e.emp_id = p.emp_id";
                payrol_select();
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while returning to full payroll report:\n" + ex.Message);
            }
        }
    }
}

