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

        private void button2_Click(object sender, EventArgs e)
        {
            basic_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_basicpay.Text);
            basic_rate = Convert.ToDouble(textbox_rateperhour_basicpay.Text);
            basic_netincome = basic_numhrs * basic_rate;
            textbox_incomepercutoff.Text = basic_netincome.ToString("n");

            hono_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_honorarium.Text);
            hono_rate = Convert.ToDouble(textbox_rateperhour_honorarium.Text);
            hono_netincome = hono_numhrs * hono_rate;
            textbox_totalhonorariumpay.Text = hono_netincome.ToString("n");

            other_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_otherincome.Text);
            other_rate = Convert.ToDouble(textbox_rateperhour_otherincome.Text);
            other_netincome = other_numhrs * other_rate;
            textbox_totalincomepay.Text = other_netincome.ToString("n");

            grossincome = basic_netincome + hono_netincome + other_netincome;
            textbox_grossincome.Text = grossincome.ToString("n");

            sss_contrib = Convert.ToDouble(textbox_ssscontribution.Text);
            pagibig_contrib = Convert.ToDouble(textbox_pagibigcontribution.Text);
            philhealth_contrib = Convert.ToDouble(textbox_philhealthcontribution.Text);
            tax_contrib = Convert.ToDouble(textbox_taxcontribution.Text);
            sss_loan = Convert.ToDouble(textbox_sssloan.Text);
            pagibig_loan = Convert.ToDouble(textbox_pagibigloan.Text);
            salary_loan = Convert.ToDouble(textbox_salaryloan.Text);
            faculty_sav_loan = Convert.ToDouble(textbox_facultysavingsloan.Text);
            salary_savings = Convert.ToDouble(textbox_facultysavingsdeposit.Text);
            other_deduction = Convert.ToDouble(textbox_others.Text);

            total_contrib = sss_contrib + pagibig_contrib + philhealth_contrib + tax_contrib;
            total_loan = sss_loan + pagibig_loan + salary_loan + faculty_sav_loan + salary_savings + other_deduction;
            total_deduction = total_contrib + total_loan;
            textbox_totaldeduction.Text = total_deduction.ToString("n");

            netincome = grossincome - total_deduction;
            textbox_netincome.Text = netincome.ToString("n");
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
