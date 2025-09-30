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

            try
            {
                other_numhrs = Convert.ToDouble(textbox_noofhourspercutoff_otherincome.Text);
                other_rate = Convert.ToDouble(textbox_rateperhour_otherincome.Text);
                other_netincome = other_numhrs * other_rate;
                grossincome = basic_netincome + hono_netincome + other_netincome;
                textbox_grossincome.Text = grossincome.ToString("n");
                textbox_pagibigcontribution.Text = "100.00";

                //philhealth contribution based on the gross income
                if (grossincome <= 10000)
                {
                    textbox_philhealthcontribution.Text = "137.50";
                }
                else if (grossincome > 10000 && grossincome <= 11000)
                {
                    textbox_philhealthcontribution.Text = "151.25";
                }
                else if (grossincome > 11000 && grossincome <= 12000)
                {
                    textbox_philhealthcontribution.Text = "165.00";
                }
                else if (grossincome > 12000 && grossincome <= 13000)
                {
                    textbox_philhealthcontribution.Text = "178.75";
                }
                else if (grossincome > 13000 && grossincome <= 14000)
                {
                    textbox_philhealthcontribution.Text = "192.50";
                }
                else if (grossincome > 14000 && grossincome <= 15000)
                {
                    textbox_philhealthcontribution.Text = "206.25";
                }
                else if (grossincome > 15000 && grossincome <= 16000)
                {
                    textbox_philhealthcontribution.Text = "220.00";
                }
                else if (grossincome > 16000 && grossincome <= 17000)
                {
                    textbox_philhealthcontribution.Text = "233.75";
                }
                else if (grossincome > 17000 && grossincome <= 18000)
                {
                    textbox_philhealthcontribution.Text = "247.50";
                }
                else if (grossincome > 18000 && grossincome <= 19000)
                {
                    textbox_philhealthcontribution.Text = "261.25";
                }
                else if (grossincome > 19000 && grossincome <= 20000)
                {
                    textbox_philhealthcontribution.Text = "275.00";
                }
                else if (grossincome > 20000 && grossincome <= 21000)
                {
                    textbox_philhealthcontribution.Text = "288.75";
                }
                else if (grossincome > 21000 && grossincome <= 22000)
                {
                    textbox_philhealthcontribution.Text = "302.50";
                }
                else if (grossincome > 22000 && grossincome <= 23000)
                {
                    textbox_philhealthcontribution.Text = "316.25";
                }
                else if (grossincome > 23000 && grossincome <= 24000)
                {
                    textbox_philhealthcontribution.Text = "330.00";
                }
                else if (grossincome > 24000 && grossincome <= 25000)
                {
                    textbox_philhealthcontribution.Text = "343.75";
                }
                else if (grossincome > 25000 && grossincome <= 26000)
                {
                    textbox_philhealthcontribution.Text = "357.50";
                }
                else if (grossincome > 26000 && grossincome <= 27000)
                {
                    textbox_philhealthcontribution.Text = "371.25";
                }
                else if (grossincome > 27000 && grossincome <= 28000)
                {
                    textbox_philhealthcontribution.Text = "385.00";
                }
                else if (grossincome > 28000 && grossincome <= 29000)
                {
                    textbox_philhealthcontribution.Text = "398.75";
                }
                else if (grossincome > 29000 && grossincome <= 30000)
                {
                    textbox_philhealthcontribution.Text = "412.50";
                }
                else if (grossincome > 30000 && grossincome <= 31000)
                {
                    textbox_philhealthcontribution.Text = "426.25";
                }
                else if (grossincome > 31000 && grossincome <= 32000)
                {
                    textbox_philhealthcontribution.Text = "440.00";
                }
                else if (grossincome > 32000 && grossincome <= 33000)
                {
                    textbox_philhealthcontribution.Text = "453.75";
                }
                else if (grossincome > 33000 && grossincome <= 34000)
                {
                    textbox_philhealthcontribution.Text = "467.50";
                }
                else if (grossincome > 34000 && grossincome <= 35000)
                {
                    textbox_philhealthcontribution.Text = "481.25";
                }
                else if (grossincome > 35000 && grossincome <= 36000)
                {
                    textbox_philhealthcontribution.Text = "495.00";
                }
                else if (grossincome > 36000 && grossincome <= 37000)
                {
                    textbox_philhealthcontribution.Text = "508.75";
                }
                else if (grossincome > 37000 && grossincome <= 38000)
                {
                    textbox_philhealthcontribution.Text = "522.50";
                }
                else if (grossincome > 38000 && grossincome <= 39000)
                {
                    textbox_philhealthcontribution.Text = "536.25";
                }
                else if (grossincome > 39000 && grossincome <= 39999.99)
                {
                    textbox_philhealthcontribution.Text = "543.13";
                }
                else
                {
                    textbox_philhealthcontribution.Text = "550.00";
                }

                //sss contribution
                if (grossincome < 1000)
                {
                    textbox_ssscontribution.Text = "0.00";
                }
                else if (grossincome > 1000 && grossincome <= 1249.99)
                {
                    textbox_ssscontribution.Text = "36.30";
                }
                else if (grossincome > 1250 && grossincome <= 1749.99)
                {
                    textbox_ssscontribution.Text = "54.50";
                }
                else if (grossincome > 1750 && grossincome <= 2249.99)
                {
                    textbox_ssscontribution.Text = "72.70";
                }
                else if (grossincome > 2250 && grossincome <= 2749.99)
                {
                    textbox_ssscontribution.Text = "90.80";
                }
                else if (grossincome > 2750 && grossincome <= 3249.99)
                {
                    textbox_ssscontribution.Text = "109.00";
                }
                else if (grossincome > 3250 && grossincome <= 3749.99)
                {
                    textbox_ssscontribution.Text = "127.20";
                }
                else if (grossincome > 3750 && grossincome <= 4249.99)
                {
                    textbox_ssscontribution.Text = "145.30";
                }
                else if (grossincome > 4250 && grossincome <= 4749.99)
                {
                    textbox_ssscontribution.Text = "163.50";
                }
                else if (grossincome > 4750 && grossincome <= 5249.99)
                {
                    textbox_ssscontribution.Text = "181.70";
                }
                else if (grossincome > 5250 && grossincome <= 5749.99)
                {
                    textbox_ssscontribution.Text = "199.80";
                }
                else if (grossincome > 5750 && grossincome <= 6249.99)
                {
                    textbox_ssscontribution.Text = "218.00";
                }
                else if (grossincome > 6250 && grossincome <= 6749.99)
                {
                    textbox_ssscontribution.Text = "236.20";
                }
                else if (grossincome > 6750 && grossincome <= 7249.99)
                {
                    textbox_ssscontribution.Text = "254.30";
                }
                else if (grossincome > 7250 && grossincome <= 7749.99)
                {
                    textbox_ssscontribution.Text = "272.50";
                }
                else if (grossincome > 7750 && grossincome <= 8249.99)
                {
                    textbox_ssscontribution.Text = "290.70";
                }
                else if (grossincome > 8250 && grossincome <= 8749.99)
                {
                    textbox_ssscontribution.Text = "308.80";
                }
                else if (grossincome > 8750 && grossincome <= 9249.99)
                {
                    textbox_ssscontribution.Text = "327.00";
                }
                else if (grossincome > 9250 && grossincome <= 9749.99)
                {
                    textbox_ssscontribution.Text = "345.20";
                }
                else if (grossincome > 9750 && grossincome <= 10249.99)
                {
                    textbox_ssscontribution.Text = "363.30";
                }
                else if (grossincome > 10250 && grossincome <= 10749.99)
                {
                    textbox_ssscontribution.Text = "381.50";
                }
                else if (grossincome > 10750 && grossincome <= 11249.99)
                {
                    textbox_ssscontribution.Text = "399.70";
                }
                else if (grossincome > 11250 && grossincome <= 11749.99)
                {
                    textbox_ssscontribution.Text = "417.80";
                }
                else if (grossincome > 11750 && grossincome <= 12249.99)
                {
                    textbox_ssscontribution.Text = "436.00";
                }
                else if (grossincome > 12250 && grossincome <= 12749.99)
                {
                    textbox_ssscontribution.Text = "454.20";
                }
                else if (grossincome > 12750 && grossincome <= 13249.99)
                {
                    textbox_ssscontribution.Text = "472.30";
                }
                else if (grossincome > 13250 && grossincome <= 13749.99)
                {
                    textbox_ssscontribution.Text = "490.50";
                }
                else if (grossincome > 13750 && grossincome <= 14249.99)
                {
                    textbox_ssscontribution.Text = "508.70";
                }
                else if (grossincome > 14250 && grossincome <= 14749.99)
                {
                    textbox_ssscontribution.Text = "526.80";
                }
                else if (grossincome > 14750 && grossincome <= 15249.99)
                {
                    textbox_ssscontribution.Text = "545.00";
                }
                else if (grossincome > 15250 && grossincome <= 15749.99)
                {
                    textbox_ssscontribution.Text = "563.20";
                }
                else
                {
                    textbox_ssscontribution.Text = "581.30";
                }

                //tax contribution
                double tax = 0;

                if (grossincome <= 20833.33) // 250,000 annual ÷ 12
                {
                    textbox_taxcontribution.Text = "0.00";
                }
                else if (grossincome > 20833.33 && grossincome <= 33333.33) // 250k–400k
                {
                    tax = ((((grossincome * 12) - 250000) * 0.20) / 12);
                    textbox_taxcontribution.Text = tax.ToString("n");
                }
                else if (grossincome > 33333.33 && grossincome <= 66666.67) // 400k–800k
                {
                    tax = ((30000 + ((grossincome * 12) - 400000) * 0.25) / 12);
                    textbox_taxcontribution.Text = tax.ToString("n");
                }
                else if (grossincome > 66666.67 && grossincome <= 166666.67) // 800k–2M
                {
                    tax = ((130000 + ((grossincome * 12) - 800000) * 0.30) / 12);
                    textbox_taxcontribution.Text = tax.ToString("n");
                }
                else if (grossincome > 166666.67 && grossincome <= 666666.67) // 2M–8M
                {
                    tax = ((490000 + ((grossincome * 12) - 2000000) * 0.32) / 12);
                    textbox_taxcontribution.Text = tax.ToString("n");
                }
                else // above 8M
                {
                    tax = ((2410000 + ((grossincome * 12) - 8000000) * 0.35) / 12);
                    textbox_taxcontribution.Text = tax.ToString("n");
                }
            }
            catch
            {
                MessageBox.Show("Invalid data entry.");
                textbox_noofhourspercutoff_otherincome.Clear();
                textbox_noofhourspercutoff_otherincome.Focus();
            }
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
