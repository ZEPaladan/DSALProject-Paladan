using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DSALProject
{
    public partial class PayrollDatabase : Form
    {
        payrol_dbconnection payroll_Conn = new payrol_dbconnection();
        payrol_variables payroll_Vars = new payrol_variables();
        string picpath;
        public PayrollDatabase()
        {
            payroll_Conn.payrol_connString();
            InitializeComponent();
        }

        private void PayrollDatabase_Load(object sender, EventArgs e)
        {
            Disabled_Textbox();
            Combobox_items();
            textbox_picpath.Hide();
        }
        private void CalculateIncome(TextBox rateBox, TextBox hoursBox, TextBox resultBox)
        {
            try
            {
                double rate = Convert.ToDouble(rateBox.Text);
                double hours = Convert.ToDouble(hoursBox.Text);

                double income = rate * hours;
                resultBox.Text = income.ToString("n");
            }
            catch (FormatException)
            {
                resultBox.Text = "0.00";
            }
        }
        private void Disabled_Textbox()
        {
            textbox_totalhonorariumpay.Enabled = false;
            textbox_totalincomepay.Enabled = false;
            textbox_incomepercutoff.Enabled = false;

            textbox_grossincome.Enabled = false;
            textbox_netincome.Enabled = false;

            textbox_ssscontribution.Enabled = false;
            textbox_philhealthcontribution.Enabled = false;
            textbox_pagibigcontribution.Enabled = false;
            textbox_taxcontribution.Enabled = false;

            textbox_totaldeduction.Enabled = false;
        }
        //function to add items in combobox
        private void Combobox_items()
        {
            combobox_others.Items.Add("Others 1");
            combobox_others.Items.Add("Others 2");
            combobox_others.Items.Add("Others 3");
            combobox_others.Items.Add("Others 4");
            combobox_others.Items.Add("None");
            combobox_others.Text = "Select other deduction";

        }

        private void combobox_others_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_others.Text == "Others 1")
            {
                textbox_others.Text = "500.00";
            }
            else if (combobox_others.Text == "Others 2")
            {
                textbox_others.Text = "550.00";
            }
            else if (combobox_others.Text == "Others 3")
            {
                textbox_others.Text = "1550.00";
            }
            else if (combobox_others.Text == "Others 4")
            {
                textbox_others.Text = "1250.00";
            }
            else if (combobox_others.Text == "None")
            {
                textbox_others.Text = "0.00";
            }
            else
            {
                MessageBox.Show("No other loan option selected.");
            }
        }

        private void textbox_noofhourspercutoff_basicpay_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_basicpay, textbox_noofhourspercutoff_basicpay, textbox_incomepercutoff);
        }

        private void textbox_noofhourspercutoff_honorarium_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_honorarium, textbox_noofhourspercutoff_honorarium, textbox_totalhonorariumpay);
        }

        private void textbox_noofhourspercutoff_otherincome_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_otherincome, textbox_noofhourspercutoff_otherincome, textbox_totalincomepay);
        }
        private void GrossIncomeCalculation()
        {
            // Check if all required textboxes have values
            if (string.IsNullOrWhiteSpace(textbox_incomepercutoff.Text) ||
                string.IsNullOrWhiteSpace(textbox_totalhonorariumpay.Text) ||
                string.IsNullOrWhiteSpace(textbox_totalincomepay.Text))
            {
                textbox_grossincome.Text = "0.00";
                return;
            }

            try
            {
                double incomePerCutoff = Convert.ToDouble(textbox_incomepercutoff.Text);
                double totalHonorarium = Convert.ToDouble(textbox_totalhonorariumpay.Text);
                double totalOtherIncome = Convert.ToDouble(textbox_totalincomepay.Text);

                double grossIncome = incomePerCutoff + totalHonorarium + totalOtherIncome;

                textbox_grossincome.Text = grossIncome.ToString("n");
            }
            catch (FormatException)
            {
                textbox_grossincome.Text = "0.00";
            }
        }

        private void ContributionCalculation()
        {
            try
            {
                double grossIncome = Convert.ToDouble(textbox_grossincome.Text);
                double sssContribution, taxContribution, philHealthContribution;
                double pagIbigContribution = 100.00;

                // SSS Contribution Calculation
                if (grossIncome < 1000)
                {
                    sssContribution = 0.00;
                }
                else if (grossIncome > 1000 && grossIncome <= 1249.99)
                {
                    sssContribution = 36.30;
                }
                else if (grossIncome >= 1250 && grossIncome <= 1749.99)
                {
                    sssContribution = 54.50;
                }
                else if (grossIncome >= 1750 && grossIncome <= 2249.99)
                {
                    sssContribution = 72.70;
                }
                else if (grossIncome >= 2250 && grossIncome <= 2749.99)
                {
                    sssContribution = 90.80;
                }
                else if (grossIncome >= 2750 && grossIncome <= 3249.99)
                {
                    sssContribution = 109.00;
                }
                else if (grossIncome >= 3250 && grossIncome <= 3749.99)
                {
                    sssContribution = 127.20;
                }
                else if (grossIncome >= 3750 && grossIncome <= 4249.99)
                {
                    sssContribution = 145.30;
                }
                else if (grossIncome >= 4250 && grossIncome <= 4749.99)
                {
                    sssContribution = 163.50;
                }
                else if (grossIncome >= 4750 && grossIncome <= 5249.99)
                {
                    sssContribution = 181.70;
                }
                else if (grossIncome >= 5250 && grossIncome <= 5749.99)
                {
                    sssContribution = 199.80;
                }
                else if (grossIncome >= 5750 && grossIncome <= 6249.99)
                {
                    sssContribution = 218.00;
                }
                else if (grossIncome >= 6250 && grossIncome <= 6749.99)
                {
                    sssContribution = 236.20;
                }
                else if (grossIncome >= 6750 && grossIncome <= 7249.99)
                {
                    sssContribution = 254.30;
                }
                else if (grossIncome >= 7250 && grossIncome <= 7749.99)
                {
                    sssContribution = 272.50;
                }
                else if (grossIncome >= 7750 && grossIncome <= 8249.99)
                {
                    sssContribution = 290.70;
                }
                else if (grossIncome >= 8250 && grossIncome <= 8749.99)
                {
                    sssContribution = 308.80;
                }
                else if (grossIncome >= 8750 && grossIncome <= 9249.99)
                {
                    sssContribution = 327.00;
                }
                else if (grossIncome >= 9250 && grossIncome <= 9749.99)
                {
                    sssContribution = 345.20;
                }
                else if (grossIncome >= 9750 && grossIncome <= 10249.99)
                {
                    sssContribution = 363.30;
                }
                else if (grossIncome >= 10250 && grossIncome <= 10749.99)
                {
                    sssContribution = 381.50;
                }
                else if (grossIncome >= 10750 && grossIncome <= 11249.99)
                {
                    sssContribution = 399.70;
                }
                else if (grossIncome >= 11250 && grossIncome <= 11749.99)
                {
                    sssContribution = 417.80;
                }
                else if (grossIncome >= 11750 && grossIncome <= 12249.99)
                {
                    sssContribution = 436.00;
                }
                else if (grossIncome >= 12250 && grossIncome <= 12749.99)
                {
                    sssContribution = 454.20;
                }
                else if (grossIncome >= 12750 && grossIncome <= 13249.99)
                {
                    sssContribution = 472.30;
                }
                else if (grossIncome >= 13250 && grossIncome <= 13749.99)
                {
                    sssContribution = 490.50;
                }
                else if (grossIncome >= 13750 && grossIncome <= 14249.99)
                {
                    sssContribution = 508.70;
                }
                else if (grossIncome >= 14250 && grossIncome <= 14749.99)
                {
                    sssContribution = 526.80;
                }
                else if (grossIncome >= 14750 && grossIncome <= 15249.99)
                {
                    sssContribution = 545.00;
                }
                else if (grossIncome >= 15250 && grossIncome <= 15749.99)
                {
                    sssContribution = 563.00;
                }
                else
                {
                    sssContribution = 581.30;
                }

                // PhilHealth Contribution Calculation
                if (grossIncome <= 10000)
                {
                    philHealthContribution = 137.50;
                }
                else if (grossIncome > 10000 && grossIncome <= 11000)
                {
                    philHealthContribution = 151.25;
                }
                else if (grossIncome > 11000 && grossIncome <= 12000)
                {
                    philHealthContribution = 165.00;
                }
                else if (grossIncome > 12000 && grossIncome <= 13000)
                {
                    philHealthContribution = 178.75;
                }
                else if (grossIncome > 13000 && grossIncome <= 14000)
                {
                    philHealthContribution = 192.50;
                }
                else if (grossIncome > 14000 && grossIncome <= 15000)
                {
                    philHealthContribution = 206.25;
                }
                else if (grossIncome > 15000 && grossIncome <= 16000)
                {
                    philHealthContribution = 220.00;
                }
                else if (grossIncome > 16000 && grossIncome <= 17000)
                {
                    philHealthContribution = 233.75;
                }
                else if (grossIncome > 17000 && grossIncome <= 18000)
                {
                    philHealthContribution = 247.50;
                }
                else if (grossIncome > 18000 && grossIncome <= 19000)
                {
                    philHealthContribution = 261.25;
                }
                else if (grossIncome > 19000 && grossIncome <= 20000)
                {
                    philHealthContribution = 275.00;
                }
                else if (grossIncome > 20000 && grossIncome <= 21000)
                {
                    philHealthContribution = 288.75;
                }
                else if (grossIncome > 21000 && grossIncome <= 22000)
                {
                    philHealthContribution = 302.50;
                }
                else if (grossIncome > 22000 && grossIncome <= 23000)
                {
                    philHealthContribution = 316.25;
                }
                else if (grossIncome > 23000 && grossIncome <= 24000)
                {
                    philHealthContribution = 330.00;
                }
                else if (grossIncome > 24000 && grossIncome <= 25000)
                {
                    philHealthContribution = 343.75;
                }
                else if (grossIncome > 25000 && grossIncome <= 26000)
                {
                    philHealthContribution = 357.50;
                }
                else if (grossIncome > 26000 && grossIncome <= 27000)
                {
                    philHealthContribution = 371.25;
                }
                else if (grossIncome > 27000 && grossIncome <= 28000)
                {
                    philHealthContribution = 385.00;
                }
                else if (grossIncome > 28000 && grossIncome <= 29000)
                {
                    philHealthContribution = 398.75;
                }
                else if (grossIncome > 29000 && grossIncome <= 30000)
                {
                    philHealthContribution = 412.50;
                }
                else if (grossIncome > 30000 && grossIncome <= 31000)
                {
                    philHealthContribution = 426.25;
                }
                else if (grossIncome > 31000 && grossIncome <= 32000)
                {
                    philHealthContribution = 440.00;
                }
                else if (grossIncome > 32000 && grossIncome <= 33000)
                {
                    philHealthContribution = 453.75;
                }
                else if (grossIncome > 33000 && grossIncome <= 34000)
                {
                    philHealthContribution = 467.50;
                }
                else if (grossIncome > 34000 && grossIncome <= 35000)
                {
                    philHealthContribution = 481.25;
                }
                else if (grossIncome > 35000 && grossIncome <= 36000)
                {
                    philHealthContribution = 495.00;
                }
                else if (grossIncome > 36000 && grossIncome <= 37000)
                {
                    philHealthContribution = 508.75;
                }
                else if (grossIncome > 37000 && grossIncome <= 38000)
                {
                    philHealthContribution = 522.50;
                }
                else if (grossIncome > 38000 && grossIncome <= 39000)
                {
                    philHealthContribution = 536.25;
                }
                else
                {
                    philHealthContribution = 550.00;
                }

                // Tax Contribution Calculation
                if (grossIncome < (25000 / 24))
                {
                    taxContribution = 0.00;
                }
                else if (grossIncome > 10416.67 && grossIncome <= 16666.67)
                {
                    taxContribution = ((((grossIncome * 24) - 250000) * 0.20) / 24);
                }
                else if (grossIncome > 16666.67 && grossIncome <= 33333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 400000) * 0.25) + 30000) / 24;
                }
                else if (grossIncome > 33333.33 && grossIncome <= 83333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 800000) * 0.30) + 82500) / 24;
                }
                else if (grossIncome > 83333.33 && grossIncome <= 208333.33)
                {
                    taxContribution = ((((grossIncome * 24) - 2000000) * 0.32) + 245500) / 24;
                }
                else
                {
                    taxContribution = ((((grossIncome * 24) - 8000000) * 0.35) + 1254500) / 24;
                }

                // Set minimum PhilHealth contribution
                philHealthContribution = 550.00;

                textbox_ssscontribution.Text = sssContribution.ToString("n");
                textbox_philhealthcontribution.Text = philHealthContribution.ToString("n");
                textbox_pagibigcontribution.Text = pagIbigContribution.ToString("n");
                textbox_taxcontribution.Text = taxContribution.ToString("n");


            }
            catch (FormatException)
            {
                textbox_ssscontribution.Text = "0.00";
                textbox_philhealthcontribution.Text = "0.00";
                textbox_pagibigcontribution.Text = "0.00";
                textbox_taxcontribution.Text = "0.00";
            }
        }
        private void OtherDeductionsCalculation()
        {
            try
            {

                double sss = string.IsNullOrWhiteSpace(textbox_ssscontribution.Text) ? 0 :
                    Convert.ToDouble(textbox_ssscontribution.Text);
                double philHealth = string.IsNullOrWhiteSpace(textbox_philhealthcontribution.Text) ? 0 :
                    Convert.ToDouble(textbox_philhealthcontribution.Text);
                double pagIbig = string.IsNullOrWhiteSpace(textbox_pagibigcontribution.Text) ? 0 :
                    Convert.ToDouble(textbox_pagibigcontribution.Text);
                double tax = string.IsNullOrWhiteSpace(textbox_taxcontribution.Text) ? 0 :
                    Convert.ToDouble(textbox_taxcontribution.Text);
                double others = string.IsNullOrWhiteSpace(textbox_others.Text) ? 0 :
                    Convert.ToDouble(textbox_others.Text);
                double sssloan = string.IsNullOrWhiteSpace(textbox_sssloan.Text) ? 0 :
                    Convert.ToDouble(textbox_sssloan.Text);
                double pagibigloan = string.IsNullOrWhiteSpace(textbox_pagibigloan.Text) ? 0 :
                    Convert.ToDouble(textbox_pagibigloan.Text);
                double facultysavingsdeposit = string.IsNullOrWhiteSpace(textbox_facultysavingsdeposit.Text) ? 0 :
                    Convert.ToDouble(textbox_facultysavingsdeposit.Text);
                double facultysavingsloan = string.IsNullOrWhiteSpace(textbox_facultysavingsloan.Text) ? 0 :
                    Convert.ToDouble(textbox_facultysavingsloan.Text);

                // Calculate total deduction
                double totalDeductions = sss + philHealth + pagIbig + tax + others + sssloan + pagibigloan + facultysavingsdeposit + facultysavingsloan;
                textbox_totaldeduction.Text = totalDeductions.ToString("n");

                // Calculate net income
                double grossIncome = string.IsNullOrWhiteSpace(textbox_grossincome.Text) ? 0 : Convert.ToDouble(textbox_grossincome.Text);
                double netIncome = grossIncome - totalDeductions;
                textbox_netincome.Text = netIncome.ToString("n");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for deductions.");
                textbox_totaldeduction.Text = "0.00";
                textbox_netincome.Text = "0.00";
            }
        }

        private void ClearFields()
        {
            textbox_rateperhour_basicpay.Clear();
            textbox_noofhourspercutoff_basicpay.Clear();
            textbox_incomepercutoff.Clear();
            textbox_rateperhour_honorarium.Clear();
            textbox_noofhourspercutoff_honorarium.Clear();
            textbox_totalhonorariumpay.Clear();
            textbox_rateperhour_otherincome.Clear();
            textbox_noofhourspercutoff_otherincome.Clear();
            textbox_totalincomepay.Clear();
            textbox_grossincome.Clear();
            textbox_netincome.Clear();
            textbox_ssscontribution.Clear();
            textbox_philhealthcontribution.Clear();
            textbox_pagibigcontribution.Clear();
            textbox_taxcontribution.Clear();
            textbox_others.Clear();
            combobox_others.Text = "Select other deduction";
            textbox_sssloan.Clear();
            textbox_pagibigloan.Clear();
            textbox_facultysavingsdeposit.Clear();
            textbox_facultysavingsloan.Clear();
            textbox_totaldeduction.Clear();

            textbox_firstname.Clear();
            textbox_surname.Clear();
            textbox_employeenumber.Clear();
            textbox_middlename.Clear();
            textbox_civilstatus.Clear();
            textbox_department.Clear();
            textbox_designation.Clear();
            textbox_employeestatus.Clear();
            textbox_numberofdependents.Clear();
            textbox_picpath.Clear();
            pictureBox1.Image = null;

            listbox_payslipview.Items.Clear();
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void previewpayslip(object sender, EventArgs e)
        {
            listbox_payslipview.Items.Add("Employee Number: " + textbox_employeenumber.Text);
            listbox_payslipview.Items.Add("First Name: " + textbox_firstname.Text);
            listbox_payslipview.Items.Add("Middle Name: " + textbox_middlename.Text);
            listbox_payslipview.Items.Add("Surame: " + textbox_surname.Text);
            listbox_payslipview.Items.Add("Designation: " + textbox_designation.Text);
            listbox_payslipview.Items.Add("Employee Status: " + textbox_employeestatus.Text);
            listbox_payslipview.Items.Add("Department: " + textbox_department.Text);
            listbox_payslipview.Items.Add("Pay Date: " + datetimepicker_paydate.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
            listbox_payslipview.Items.Add("Basic Pay No. of Hours" + textbox_noofhourspercutoff_basicpay.Text);
            listbox_payslipview.Items.Add("Basic Pay Rate per Hour: " + textbox_rateperhour_basicpay.Text);
            listbox_payslipview.Items.Add("Basic Pay Income: " + textbox_incomepercutoff.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
            listbox_payslipview.Items.Add("Honorarium Pay No. of Hours: " + textbox_noofhourspercutoff_honorarium.Text);
            listbox_payslipview.Items.Add("Honorarium Pay Rate per Hour: " + textbox_rateperhour_honorarium.Text);
            listbox_payslipview.Items.Add("Honorarium Pay Income: " + textbox_totalhonorariumpay.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
            listbox_payslipview.Items.Add("Other Income Pay No. of Hours: " + textbox_noofhourspercutoff_otherincome.Text);
            listbox_payslipview.Items.Add("Other Income Pay Rate per Hour: " + textbox_rateperhour_otherincome.Text);
            listbox_payslipview.Items.Add("Other Income: " + textbox_totalincomepay.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
            listbox_payslipview.Items.Add("SSS Contribution: " + textbox_ssscontribution.Text);
            listbox_payslipview.Items.Add("Pag-IBIG Contribution: " + textbox_pagibigcontribution.Text);
            listbox_payslipview.Items.Add("PhilHealth Contribution: " + textbox_philhealthcontribution.Text);
            listbox_payslipview.Items.Add("Tax Contribution: " + textbox_taxcontribution.Text);
            listbox_payslipview.Items.Add("SSS Loan: " + textbox_sssloan.Text);
            listbox_payslipview.Items.Add("Pag-IBIG Loan: " + textbox_pagibigloan.Text);
            listbox_payslipview.Items.Add("Faculty Savings Deposit: " + textbox_facultysavingsdeposit.Text);
            listbox_payslipview.Items.Add("Faculty Savings Loan: " + textbox_facultysavingsloan.Text);
            listbox_payslipview.Items.Add("Salary Loan: " + textbox_salaryloan.Text);
            listbox_payslipview.Items.Add("Other Loan: " + textbox_others.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
            listbox_payslipview.Items.Add("Total Deduction: " + textbox_totaldeduction.Text);
            listbox_payslipview.Items.Add("Gross Income: " + textbox_grossincome.Text);
            listbox_payslipview.Items.Add("Net Income: " + textbox_netincome.Text);
            listbox_payslipview.Items.Add("---------------------------------------------------------------------");
        }
        //print payslip function
        private void printpayslip(object sender, EventArgs e)
        {
            try
            {
                Lesson3Example5_PrintForm print1 = new Lesson3Example5_PrintForm();
                print1.listbox_payslipview.Items.AddRange(this.listbox_payslipview.Items);
                print1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to print the payslip: " + ex.Message);
            }
        }

        private void button_printpayslip_Click(object sender, EventArgs e)
        {
            printpayslip(sender, e);
        }

        private void button_previewpaymentdetails_Click(object sender, EventArgs e)
        {
            previewpayslip(sender, e);
        }
        private void browsefiles(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
                ofd.ShowDialog();
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                picpath = ofd.FileName;
                textbox_picpath.Text = picpath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browsefiles(sender, e);
        }

        private void textbox_incomepercutoff_TextChanged(object sender, EventArgs e)
        {
            GrossIncomeCalculation();
        }

        private void textbox_totalhonorariumpay_TextChanged(object sender, EventArgs e)
        {
            GrossIncomeCalculation();
        }

        private void textbox_totalincomepay_TextChanged(object sender, EventArgs e)
        {
            GrossIncomeCalculation();
        }

        private void textbox_grossincome_TextChanged(object sender, EventArgs e)
        {
            ContributionCalculation();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            OtherDeductionsCalculation();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                payroll_Conn.payrol_sql =
                "INSERT INTO payrolTbl (" +
                "basic_rate_hr, basic_no_of_hrs_cutoff, basic_income_per_cutoff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutoff, honorarium_income_per_cutoff, " +
                "other_rate_hr, other_no_of_hrs_cutoff, other_income_per_cutoff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                "salary_loan, other_loans, total_deductions, gross_income, net_income, " +
                "emp_id, pay_date) " +
                "VALUES (" +
                "'" + textbox_rateperhour_basicpay.Text + "'," +
                "'" + textbox_noofhourspercutoff_basicpay.Text + "'," +
                "'" + textbox_incomepercutoff.Text + "'," +

                "'" + textbox_rateperhour_honorarium.Text + "'," +
                "'" + textbox_noofhourspercutoff_honorarium.Text + "'," +
                "'" + textbox_totalhonorariumpay.Text + "'," +

                "'" + textbox_rateperhour_otherincome.Text + "'," +
                "'" + textbox_noofhourspercutoff_otherincome.Text + "'," +
                "'" + textbox_totalincomepay.Text + "'," +

                "'" + textbox_ssscontribution.Text + "'," +
                "'" + textbox_philhealthcontribution.Text + "'," +
                "'" + textbox_pagibigcontribution.Text + "'," +
                "'" + textbox_taxcontribution.Text + "'," +

                "'" + textbox_sssloan.Text + "'," +
                "'" + textbox_pagibigloan.Text + "'," +
                "'" + textbox_facultysavingsdeposit.Text + "'," +
                "'" + textbox_facultysavingsloan.Text + "'," +

                "'" + textbox_salaryloan.Text + "'," +           // ✔ salary loan fixed
                "'" + textbox_others.Text + "'," +               // other loans
                "'" + textbox_totaldeduction.Text + "'," +
                "'" + textbox_grossincome.Text + "'," +
                "'" + textbox_netincome.Text + "'," +

                "'" + textbox_employeenumber.Text + "'," +
                "'" + datetimepicker_paydate.Text + "'" +
                ")";

                payroll_Conn.payrol_cmd();
                payroll_Conn.payrol_sqladapterInsert();

                ClearFields();
                MessageBox.Show("Record saved successfully!");
            }
            catch (Exception ex)
            {
                // Detailed error message for debugging
                MessageBox.Show("Error while saving record!\n\n" +
                                "Exception Message: " + ex.Message + "\n\n" +
                                "SQL Command: " + payroll_Conn.payrol_sql,
                                "Save Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                payroll_Conn.payrol_sql =
                "UPDATE payrolTbl SET " +
                "basic_rate_hr = '" + textbox_rateperhour_basicpay.Text + "', " +
                "basic_no_of_hrs_cutoff = '" + textbox_noofhourspercutoff_basicpay.Text + "', " +
                "basic_income_per_cutoff = '" + textbox_incomepercutoff.Text + "', " +

                "honorarium_rate_hr = '" + textbox_rateperhour_honorarium.Text + "', " +
                "honorarium_no_of_hrs_cutoff = '" + textbox_noofhourspercutoff_honorarium.Text + "', " +
                "honorarium_income_per_cutoff = '" + textbox_totalhonorariumpay.Text + "', " +

                "other_rate_hr = '" + textbox_rateperhour_otherincome.Text + "', " +
                "other_no_of_hrs_cutoff = '" + textbox_noofhourspercutoff_otherincome.Text + "', " +
                "other_income_per_cutoff = '" + textbox_totalincomepay.Text + "', " +

                "sss_contrib = '" + textbox_ssscontribution.Text + "', " +
                "philhealth_contrib = '" + textbox_philhealthcontribution.Text + "', " +
                "pagibig_contrib = '" + textbox_pagibigcontribution.Text + "', " +
                "tax_contrib = '" + textbox_taxcontribution.Text + "', " +

                "sss_loan = '" + textbox_sssloan.Text + "', " +
                "pagibig_loan = '" + textbox_pagibigloan.Text + "', " +
                "fac_savings_deposit = '" + textbox_facultysavingsdeposit.Text + "', " +
                "fac_savings_loan = '" + textbox_facultysavingsloan.Text + "', " +

                "salary_loan = '" + textbox_salaryloan.Text + "', " +
                "other_loans = '" + textbox_others.Text + "', " +
                "total_deductions = '" + textbox_totaldeduction.Text + "', " +
                "gross_income = '" + textbox_grossincome.Text + "', " +
                "net_income = '" + textbox_netincome.Text + "', " +
                "pay_date = '" + datetimepicker_paydate.Text + "' " +

                "WHERE emp_id = '" + textbox_employeenumber.Text + "'";

                payroll_Conn.payrol_cmd();
                payroll_Conn.payrol_sqladapterUpdate();

                ClearFields();
                MessageBox.Show("Record updated successfully!");
            }
            catch (Exception ex)
            {
                // Show detailed error message with SQL command for easier debugging
                MessageBox.Show("Error while updating record!\n\n" +
                                "Exception Message: " + ex.Message + "\n\n" +
                                "SQL Command: " + payroll_Conn.payrol_sql,
                                "Update Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                // Build SQL query to search employee info from pos_empRegTbl
                payroll_Conn.payrol_sql =
                    "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, position, " +
                    "emp_no_of_dependents, emp_work_status, emp_department, picpath " +
                    "FROM pos_empRegTbl " +
                    "WHERE emp_id = '" + textbox_employeenumber.Text + "'";

                payroll_Conn.payrol_cmd();
                payroll_Conn.payrol_sqladapterSelect();
                payroll_Conn.payrol_sqldatasetSELECT();

                // Check if any record is found
                if (payroll_Conn.payrol_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = payroll_Conn.payrol_sql_dataset.Tables[0].Rows[0];

                    textbox_firstname.Text = row["emp_fname"].ToString();
                    textbox_middlename.Text = row["emp_mname"].ToString();
                    textbox_surname.Text = row["emp_surname"].ToString();
                    textbox_civilstatus.Text = row["emp_status"].ToString();
                    textbox_designation.Text = row["position"].ToString();
                    textbox_numberofdependents.Text = row["emp_no_of_dependents"].ToString();
                    textbox_employeestatus.Text = row["emp_work_status"].ToString();
                    textbox_department.Text = row["emp_department"].ToString();
                    textbox_picpath.Text = row["picpath"].ToString();

                    // Load the picture into PictureBox
                    if (!string.IsNullOrEmpty(textbox_picpath.Text) && File.Exists(textbox_picpath.Text))
                    {
                        pictureBox1.Image = Image.FromFile(textbox_picpath.Text);
                    }
                    else
                    {
                        pictureBox1.Image = null; // Clear picture if not found
                    }
                }
                else
                {
                    MessageBox.Show("Employee not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Detailed error message for debugging
                MessageBox.Show("Error while searching employee!\n\n" +
                                "Exception Message: " + ex.Message + "\n\n" +
                                "SQL Command: " + payroll_Conn.payrol_sql,
                                "Search Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Confirm before deleting
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this record?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Build SQL command to delete record by emp_id
                    payroll_Conn.payrol_sql =
                        "DELETE FROM payrolTbl WHERE emp_id = '" + textbox_employeenumber.Text + "'";

                    payroll_Conn.payrol_cmd();
                    payroll_Conn.payrol_sqladapterDelete();

                    ClearFields();
                    MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Show detailed error message and SQL command
                MessageBox.Show("Error while deleting record!\n\n" +
                                "Exception Message: " + ex.Message + "\n\n" +
                                "SQL Command: " + payroll_Conn.payrol_sql,
                                "Delete Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button_searchedit_Click(object sender, EventArgs e)
        {
            try
            {
                // SQL: Join employee master table with payroll table
                payroll_Conn.payrol_sql =
                    "SELECT e.emp_id, e.emp_fname, e.emp_mname, e.emp_surname, e.emp_status, e.position, " +
                    "e.emp_no_of_dependents, e.emp_work_status, e.emp_department, e.picpath, " +
                    "p.basic_rate_hr, p.basic_no_of_hrs_cutoff, p.basic_income_per_cutoff, " +
                    "p.honorarium_rate_hr, p.honorarium_no_of_hrs_cutoff, p.honorarium_income_per_cutoff, " +
                    "p.other_rate_hr, p.other_no_of_hrs_cutoff, p.other_income_per_cutoff, " +
                    "p.sss_contrib, p.philhealth_contrib, p.pagibig_contrib, p.tax_contrib, " +
                    "p.sss_loan, p.pagibig_loan, p.fac_savings_deposit, p.fac_savings_loan, " +
                    "p.salary_loan, p.other_loans, p.total_deductions, p.gross_income, p.net_income, p.pay_date " +
                    "FROM pos_empRegTbl e " +
                    "INNER JOIN payrolTbl p ON e.emp_id = p.emp_id " +
                    "WHERE p.emp_id = '" + textbox_employeenumber.Text + "' " +
                    "AND p.pay_date = '" + datetimepicker_paydate.Text + "'";

                payroll_Conn.payrol_cmd();
                payroll_Conn.payrol_sqladapterSelect();
                payroll_Conn.payrol_sqldatasetSELECT();

                // Check if record exists
                if (payroll_Conn.payrol_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = payroll_Conn.payrol_sql_dataset.Tables[0].Rows[0];

                    // Employee info
                    textbox_firstname.Text = row["emp_fname"].ToString();
                    textbox_middlename.Text = row["emp_mname"].ToString();
                    textbox_surname.Text = row["emp_surname"].ToString();
                    textbox_civilstatus.Text = row["emp_status"].ToString();
                    textbox_designation.Text = row["position"].ToString();
                    textbox_numberofdependents.Text = row["emp_no_of_dependents"].ToString();
                    textbox_employeestatus.Text = row["emp_work_status"].ToString();
                    textbox_department.Text = row["emp_department"].ToString();
                    textbox_picpath.Text = row["picpath"].ToString();

                    // Load picture
                    if (!string.IsNullOrEmpty(textbox_picpath.Text) && File.Exists(textbox_picpath.Text))
                    {
                        pictureBox1.Image = Image.FromFile(textbox_picpath.Text);
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }

                    // Payroll info
                    textbox_rateperhour_basicpay.Text = row["basic_rate_hr"].ToString();
                    textbox_noofhourspercutoff_basicpay.Text = row["basic_no_of_hrs_cutoff"].ToString();
                    textbox_incomepercutoff.Text = row["basic_income_per_cutoff"].ToString();

                    textbox_rateperhour_honorarium.Text = row["honorarium_rate_hr"].ToString();
                    textbox_noofhourspercutoff_honorarium.Text = row["honorarium_no_of_hrs_cutoff"].ToString();
                    textbox_totalhonorariumpay.Text = row["honorarium_income_per_cutoff"].ToString();

                    textbox_rateperhour_otherincome.Text = row["other_rate_hr"].ToString();
                    textbox_noofhourspercutoff_otherincome.Text = row["other_no_of_hrs_cutoff"].ToString();
                    textbox_totalincomepay.Text = row["other_income_per_cutoff"].ToString();

                    textbox_ssscontribution.Text = row["sss_contrib"].ToString();
                    textbox_philhealthcontribution.Text = row["philhealth_contrib"].ToString();
                    textbox_pagibigcontribution.Text = row["pagibig_contrib"].ToString();
                    textbox_taxcontribution.Text = row["tax_contrib"].ToString();

                    textbox_sssloan.Text = row["sss_loan"].ToString();
                    textbox_pagibigloan.Text = row["pagibig_loan"].ToString();
                    textbox_facultysavingsdeposit.Text = row["fac_savings_deposit"].ToString();
                    textbox_facultysavingsloan.Text = row["fac_savings_loan"].ToString();

                    textbox_salaryloan.Text = row["salary_loan"].ToString();
                    textbox_others.Text = row["other_loans"].ToString();
                    textbox_totaldeduction.Text = row["total_deductions"].ToString();
                    textbox_grossincome.Text = row["gross_income"].ToString();
                    textbox_netincome.Text = row["net_income"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while editing employee compensation!\n\n" +
                                "Exception Message: " + ex.Message + "\n\n" +
                                "SQL Command: " + payroll_Conn.payrol_sql,
                                "Edit Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
