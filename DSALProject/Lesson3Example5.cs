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
    public partial class Lesson3Example5 : Form
    {
        private double basic_netincome = 0.00, basic_numhrs = 0.00,
            basic_rate = 0.00, hono_netincome = 0.00, hono_numhrs = 0.00,
            hono_rate = 0.00, other_netincome = 0.00, other_numhrs = 0.00,
            other_rate = 0.00;

        private void button3_Click(object sender, EventArgs e)
        {
            textbox_employeenumber.Clear();
            textbox_firstname.Clear();
            textbox_middlename.Clear();
            textbox_surname.Clear();
            textbox_civilstatus.Clear();
            textbox_designation.Clear();
            textbox_numberofdependents.Clear();
            textbox_employeestatus.Clear();
            textbox_department.Clear();
            textbox_noofhourspercutoff_basicpay.Clear();
            textbox_rateperhour_basicpay.Clear();
            textbox_incomepercutoff.Clear();
            textbox_noofhourspercutoff_honorarium.Clear();
            textbox_rateperhour_honorarium.Clear();
            textbox_totalhonorariumpay.Clear();
            textbox_noofhourspercutoff_otherincome.Clear();
            textbox_rateperhour_otherincome.Clear();
            textbox_totalincomepay.Clear();
            textbox_netincome.Clear();
            textbox_grossincome.Clear();
            textbox_ssscontribution.Clear();
            textbox_pagibigcontribution.Clear();
            textbox_philhealthcontribution.Clear();
            textbox_taxcontribution.Clear();
            textbox_sssloan.Clear();
            textbox_pagibigloan.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textbox_incomepercutoff_TextChanged(object sender, EventArgs e)
        {
            basic_numhrs  = Convert.ToDouble(textbox_noofhourspercutoff_basicpay.Text);
            basic_rate = Convert.ToDouble(textbox_rateperhour_basicpay.Text);
            basic_netincome = basic_numhrs * basic_rate;
            textbox_incomepercutoff.Text = basic_netincome.ToString("n");
        }

        private void textbox_totalhonorariumpay_TextChanged(object sender, EventArgs e)
        {
            hono_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_honorarium.Text);
            hono_rate = Convert.ToDouble(textbox_rateperhour_honorarium.Text);
            hono_netincome = hono_numhrs * hono_rate;
            textbox_totalhonorariumpay.Text = hono_netincome.ToString("n");
        }

        private void textbox_totalincomepay_TextChanged(object sender, EventArgs e)
        {
            other_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_otherincome.Text);
            other_rate = Convert.ToDouble(textbox_rateperhour_otherincome.Text);
            other_netincome = other_numhrs * other_rate;
            textbox_totalincomepay.Text = other_netincome.ToString("n");
        }

        private void textbox_noofhourspercutoff_otherincome_TextChanged(object sender, EventArgs e)
        {
            
            

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
            else 
            {
                MessageBox.Show("No other loan option selected.");
            }
        }

        private void textbox_others_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lesson3Example5_PrintForm print1 = new Lesson3Example5_PrintForm();
            print1.listbox_payslipview.Items.AddRange(this.listbox_payslipview.Items);
            print1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
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
            listbox_payslipview.Items.Add("SSS Contribution: " + sss_contrib);
            listbox_payslipview.Items.Add("Pag-IBIG Contribution: " + textbox_pagibigcontribution.Text);
            listbox_payslipview.Items.Add("PhilHealth Contribution: " + philhealth_contrib);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the values for hours worked and rates for each income type (default 0 if blank)
                double basic_numhrs = string.IsNullOrWhiteSpace(textbox_noofhourspercutoff_basicpay.Text) ? 0 : Convert.ToDouble(textbox_noofhourspercutoff_basicpay.Text);
                double basic_rate = string.IsNullOrWhiteSpace(textbox_rateperhour_basicpay.Text) ? 0 : Convert.ToDouble(textbox_rateperhour_basicpay.Text);
                double hono_numhrs = string.IsNullOrWhiteSpace(textbox_noofhourspercutoff_honorarium.Text) ? 0 : Convert.ToDouble(textbox_noofhourspercutoff_honorarium.Text);
                double hono_rate = string.IsNullOrWhiteSpace(textbox_rateperhour_honorarium.Text) ? 0 : Convert.ToDouble(textbox_rateperhour_honorarium.Text);
                double other_numhrs = string.IsNullOrWhiteSpace(textbox_noofhourspercutoff_otherincome.Text) ? 0 : Convert.ToDouble(textbox_noofhourspercutoff_otherincome.Text);
                double other_rate = string.IsNullOrWhiteSpace(textbox_rateperhour_otherincome.Text) ? 0 : Convert.ToDouble(textbox_rateperhour_otherincome.Text);

                // Calculate net income for each
                basic_netincome = basic_numhrs * basic_rate;
                hono_netincome = hono_numhrs * hono_rate;
                other_netincome = other_numhrs * other_rate;

                // Set the textboxes for the individual income types
                textbox_incomepercutoff.Text = basic_netincome.ToString("n");
                textbox_totalhonorariumpay.Text = hono_netincome.ToString("n");
                textbox_totalincomepay.Text = other_netincome.ToString("n");

                // Calculate gross income
                grossincome = basic_netincome + hono_netincome + other_netincome;
                textbox_grossincome.Text = grossincome.ToString("n");

                // Contributions and deductions
                sss_contrib = CalculateSSSContribution(grossincome);
                pagibig_contrib = 100.00; // fixed Pag-IBIG
                philhealth_contrib = CalculatePhilHealthContribution(grossincome);
                tax_contrib = CalculateTaxContribution(grossincome);

                // Show contributions in textboxes
                textbox_ssscontribution.Text = sss_contrib.ToString("n");
                textbox_pagibigcontribution.Text = pagibig_contrib.ToString("n");
                textbox_philhealthcontribution.Text = philhealth_contrib.ToString("n");
                textbox_taxcontribution.Text = tax_contrib.ToString("n");

                // Loans and other deductions (default 0 if blank)
                sss_loan = string.IsNullOrWhiteSpace(textbox_sssloan.Text) ? 0 : Convert.ToDouble(textbox_sssloan.Text);
                pagibig_loan = string.IsNullOrWhiteSpace(textbox_pagibigloan.Text) ? 0 : Convert.ToDouble(textbox_pagibigloan.Text);
                salary_loan = string.IsNullOrWhiteSpace(textbox_salaryloan.Text) ? 0 : Convert.ToDouble(textbox_salaryloan.Text);
                faculty_sav_loan = string.IsNullOrWhiteSpace(textbox_facultysavingsloan.Text) ? 0 : Convert.ToDouble(textbox_facultysavingsloan.Text);
                salary_savings = string.IsNullOrWhiteSpace(textbox_facultysavingsdeposit.Text) ? 0 : Convert.ToDouble(textbox_facultysavingsdeposit.Text);
                other_deduction = string.IsNullOrWhiteSpace(textbox_others.Text) ? 0 : Convert.ToDouble(textbox_others.Text);

                // Total contributions and deductions
                total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
                total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
                total_deduction = total_contrib + total_loan;

                // Display deductions
                textbox_totaldeduction.Text = total_deduction.ToString("n");

                // Calculate net income
                netincome = grossincome - total_deduction;
                textbox_netincome.Text = netincome.ToString("n");
            }
            catch
            {
                MessageBox.Show("Invalid data entry");
            }
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private double CalculatePhilHealthContribution(double grossincome)
        {
            if (grossincome <= 10000) return 137.50;
            else if (grossincome <= 11000) return 151.25;
            else if (grossincome <= 12000) return 165.00;
            else if (grossincome <= 13000) return 178.75;
            else if (grossincome <= 14000) return 192.50;
            else if (grossincome <= 15000) return 206.25;
            else if (grossincome <= 16000) return 220.00;
            else if (grossincome <= 17000) return 233.75;
            else if (grossincome <= 18000) return 247.50;
            else if (grossincome <= 19000) return 261.25;
            else if (grossincome <= 20000) return 275.00;
            else if (grossincome <= 21000) return 288.75;
            else if (grossincome <= 22000) return 302.50;
            else if (grossincome <= 23000) return 316.25;
            else if (grossincome <= 24000) return 330.00;
            else if (grossincome <= 25000) return 343.75;
            else if (grossincome <= 26000) return 357.50;
            else if (grossincome <= 27000) return 371.25;
            else if (grossincome <= 28000) return 385.00;
            else if (grossincome <= 29000) return 398.75;
            else if (grossincome <= 30000) return 412.50;
            else if (grossincome <= 31000) return 426.25;
            else if (grossincome <= 32000) return 440.00;
            else if (grossincome <= 33000) return 453.75;
            else if (grossincome <= 34000) return 467.50;
            else if (grossincome <= 35000) return 481.25;
            else if (grossincome <= 36000) return 495.00;
            else if (grossincome <= 37000) return 508.75;
            else if (grossincome <= 38000) return 522.50;
            else if (grossincome <= 39000) return 536.25;
            else if (grossincome <= 39999.99) return 543.13;
            else return 550.00;
        }

        private double CalculateSSSContribution(double grossincome)
        {
            if (grossincome < 1000) return 0.00;
            else if (grossincome <= 1249.99) return 36.30;
            else if (grossincome <= 1749.99) return 54.50;
            else if (grossincome <= 2249.99) return 72.70;
            else if (grossincome <= 2749.99) return 90.80;
            else if (grossincome <= 3249.99) return 109.00;
            else if (grossincome <= 3749.99) return 127.20;
            else if (grossincome <= 4249.99) return 145.30;
            else if (grossincome <= 4749.99) return 163.50;
            else if (grossincome <= 5249.99) return 181.70;
            else if (grossincome <= 5749.99) return 199.80;
            else if (grossincome <= 6249.99) return 218.00;
            else if (grossincome <= 6749.99) return 236.20;
            else if (grossincome <= 7249.99) return 254.30;
            else if (grossincome <= 7749.99) return 272.50;
            else if (grossincome <= 8249.99) return 290.70;
            else if (grossincome <= 8749.99) return 308.80;
            else if (grossincome <= 9249.99) return 327.00;
            else if (grossincome <= 9749.99) return 345.20;
            else if (grossincome <= 10249.99) return 363.30;
            else if (grossincome <= 10749.99) return 381.50;
            else if (grossincome <= 11249.99) return 399.70;
            else if (grossincome <= 11749.99) return 417.80;
            else if (grossincome <= 12249.99) return 436.00;
            else if (grossincome <= 12749.99) return 454.20;
            else if (grossincome <= 13249.99) return 472.30;
            else if (grossincome <= 13749.99) return 490.50;
            else if (grossincome <= 14249.99) return 508.70;
            else if (grossincome <= 14749.99) return 526.80;
            else if (grossincome <= 15249.99) return 545.00;
            else return 581.30; // Max contribution for gross income > 15250
        }

        private double CalculateTaxContribution(double grossincome)
        {
            double tax = 0;
            if (grossincome <= 20833.33) return 0.00; // 250,000 annual ÷ 12
            else if (grossincome <= 33333.33) tax = (((grossincome * 12) - 250000) * 0.20) / 12;
            else if (grossincome <= 66666.67) tax = ((30000 + ((grossincome * 12) - 400000) * 0.25) / 12);
            else if (grossincome <= 166666.67) tax = ((130000 + ((grossincome * 12) - 800000) * 0.30) / 12);
            else if (grossincome <= 666666.67) tax = ((490000 + ((grossincome * 12) - 2000000) * 0.32) / 12);
            else tax = ((2410000 + ((grossincome * 12) - 8000000) * 0.35) / 12);
            return tax;
        }



        private double netincome = 0.00, grossincome = 0.00, sss_contrib = 0.00,
            pagibig_contrib = 0.00, philhealth_contrib = 0.00, tax_contrib = 0.00;
        private double sss_loan = 0.00, pagibig_loan = 0.00, salary_loan = 0.00,
            salary_savings = 0.00, faculty_sav_loan = 0.00, other_deduction = 0.00,
            total_deduction = 0.00, total_contrib = 0.00, total_loan = 0.00;
        public Lesson3Example5()
        {
            InitializeComponent();

            textbox_incomepercutoff.Enabled = false;
            textbox_totalhonorariumpay.Enabled = false;
            textbox_totalincomepay.Enabled = false;
            textbox_netincome.Enabled = false;
            textbox_grossincome.Enabled = false;
            textbox_totaldeduction.Enabled = false;

            textbox_ssscontribution.Enabled = false;
            textbox_pagibigcontribution.Enabled = false;
            textbox_philhealthcontribution.Enabled = false;
            textbox_taxcontribution.Enabled = false;

            textbox_ssscontribution.Text = "0.00";
            textbox_pagibigcontribution.Text = "0.00";
            textbox_philhealthcontribution.Text = "0.00";
            textbox_taxcontribution.Text = "0.00";
            textbox_sssloan.Text = "0.00";
            textbox_pagibigloan.Text = "0.00";
            textbox_facultysavingsdeposit.Text = "0.00";
            textbox_facultysavingsloan.Text = "0.00";
            textbox_salaryloan.Text = "0.00";
            combobox_others.Text = "Select other deduction";
            combobox_others.Items.Add("Others 1");
            combobox_others.Items.Add("Others 2");
            combobox_others.Items.Add("Others 3");
            combobox_others.Items.Add("Others 4");

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void Lesson3Example5_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}
