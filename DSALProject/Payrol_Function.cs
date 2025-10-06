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
    public partial class Payrol_Function : Form
    {
        public Payrol_Function()
        {
            InitializeComponent();

            Disabled_Textbox();
            Combobox_items();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Payrol_Function_Load(object sender, EventArgs e)
        {

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // function to disable textboxes
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

        //combobox selection
        private void combobox_others_SelectedIndexChanged_1(object sender, EventArgs e)
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
        //function to calculate income
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

        private void textbox_incomepercutoff_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textbox_rateperhour_basicpay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_noofhourspercutoff_basicpay_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_basicpay, textbox_noofhourspercutoff_basicpay, textbox_incomepercutoff);
        }

        private void textbox_totalhonorariumpay_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textbox_totalincomepay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_noofhourspercutoff_honorarium_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_honorarium, textbox_noofhourspercutoff_honorarium, textbox_totalhonorariumpay);
        }

        private void textbox_noofhourspercutoff_otherincome_TextChanged(object sender, EventArgs e)
        {
            CalculateIncome(textbox_rateperhour_otherincome, textbox_noofhourspercutoff_otherincome, textbox_totalincomepay);
        }
        //function for gross income calculation
        private void GrossIncomeCalculation()
        {
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

        //function for contribution calculation
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
                    taxContribution = ((((grossIncome * 24) - 250000) * 0.20)/24);
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
        //function for other deductions calculation
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

        // Calculate button click event
        private void button_calculate_Click(object sender, EventArgs e)
        {
            GrossIncomeCalculation();
                        ContributionCalculation();
            OtherDeductionsCalculation();

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
        //browse files button
        private void browsefiles(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            browsefiles(sender, e);
        }
        //print payslip function
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
    }
}
