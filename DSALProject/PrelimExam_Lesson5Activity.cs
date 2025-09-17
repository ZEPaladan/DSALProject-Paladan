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
    public partial class PrelimExam_Lesson5Activity : Form
    {
        public PrelimExam_Lesson5Activity()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrelimExam_Lesson5Activity_Load(object sender, EventArgs e)
        {
            textbox_basicincome_incomepercutoff.Enabled = false;
            textbox_honorariumincome_incomepercutoff.Enabled = false;
            textbox_otherincome_incomepercutoff.Enabled = false;
            textbox_summaryincome_grossincome.Enabled = false;
            textbox_summaryincome_netincome.Enabled = false;
            textbox_regulardeduction_ssscontribution.Enabled = false;
            textbox_regulardeduction_philhealthcontribution.Enabled = false;
            textbox_regulardeduction_pagibigcontribution.Enabled = false;
            textbox_regulardeduction_incometaxcontribution.Enabled = false;
            textbox_deductionsummary_totaldeduction.Enabled = false;
        }

        private void button_grossincome_Click(object sender, EventArgs e)
        {
            int no_of_hours_basicincome, no_of_hours_honorariumincome, no_of_hours_otherincome;
            double rate_per_hour_basicincome, rate_per_hour_honorariumincome, rate_per_hour_otherincome,
                income_per_cutoff_basicincome, income_per_cutoff_honorariumincome, income_per_cutoff_otherincome,
                gross_income;

            no_of_hours_basicincome = Convert.ToInt32(textbox_basicincome_noofhourspercutoff.Text);
            no_of_hours_honorariumincome = Convert.ToInt32(textbox_honorariumincome_noofhourspercutoff.Text);
            no_of_hours_otherincome = Convert.ToInt32(textbox_otherincome_noofhourspercutoff.Text);

            rate_per_hour_basicincome = Convert.ToDouble(textbox_basicincome_rateperhour.Text);
            rate_per_hour_honorariumincome = Convert.ToDouble(textbox_honorariumincome_rateperhour.Text);
            rate_per_hour_otherincome = Convert.ToDouble(textbox_otherincome_rateperhour.Text);

            income_per_cutoff_basicincome = no_of_hours_basicincome * rate_per_hour_basicincome;
            income_per_cutoff_honorariumincome = no_of_hours_honorariumincome * rate_per_hour_honorariumincome;
            income_per_cutoff_otherincome = no_of_hours_otherincome * rate_per_hour_otherincome;

            gross_income = income_per_cutoff_basicincome + income_per_cutoff_honorariumincome + income_per_cutoff_otherincome;

            textbox_basicincome_incomepercutoff.Text = income_per_cutoff_basicincome.ToString("0.00");
            textbox_honorariumincome_incomepercutoff.Text = income_per_cutoff_honorariumincome.ToString("0.00");
            textbox_otherincome_incomepercutoff.Text = income_per_cutoff_otherincome.ToString("0.00");
            textbox_summaryincome_grossincome.Text = gross_income.ToString("0.00");

        }

        private void button_netincome_Click(object sender, EventArgs e)
        {
            double gross_income, sss_contribution, philhealth_contribution, pagibig_contribution = 200.00,
                income_tax_contribution;
            double sss_loan, pagibig_loan, faculty_savings_deposit, faculty_savings_loan, salary_loan, other_loan,
                                total_deduction, net_income;

            gross_income = Convert.ToDouble(textbox_summaryincome_grossincome.Text);

            if (gross_income <= 5249)
            {
                sss_contribution = 760.00;
            }
            else if (gross_income >= 5250 && gross_income <= 5749.99)
            {
                sss_contribution = 835.00;
            }
            else if (gross_income >= 5750 && gross_income <= 6249.99)
            {
                sss_contribution = 910.00;
            }
            else if (gross_income >= 6250 && gross_income <= 6749.99)
            {
                sss_contribution = 985.00;
            }
            else if (gross_income >= 6750 && gross_income <= 7249.99)
            {
                sss_contribution = 1060.00;
            }
            else if (gross_income >= 7250 && gross_income <= 7749.99)
            {
                sss_contribution = 1135.00;
            }
            else if (gross_income >= 7750 && gross_income <= 8249.99)
            {
                sss_contribution = 1210.00;
            }
            else if (gross_income >= 8250 && gross_income <= 8749.99)
            {
                sss_contribution = 1285.00;
            }
            else if (gross_income >= 8750 && gross_income <= 9249.99)
            {
                sss_contribution = 1360.00;
            }
            else if (gross_income >= 9250 && gross_income <= 9749.99)
            {
                sss_contribution = 1435.00;
            }
            else if (gross_income >= 9750 && gross_income <= 10249.99)
            {
                sss_contribution = 1510.00;
            }
            else if (gross_income >= 10250 && gross_income <= 10749.99)
            {
                sss_contribution = 1585.00;
            }
            else if (gross_income >= 10750 && gross_income <= 11249.99)
            {
                sss_contribution = 1660.00;
            }
            else if (gross_income >= 11250 && gross_income <= 11749.99)
            {
                sss_contribution = 1735.00;
            }
            else if (gross_income >= 11750 && gross_income <= 12249.99)
            {
                sss_contribution = 1810.00;
            }
            else if (gross_income >= 12250 && gross_income <= 12749.99)
            {
                sss_contribution = 1885.00;
            }
            else if (gross_income >= 12750 && gross_income <= 13249.99)
            {
                sss_contribution = 1960.00;
            }
            else if (gross_income >= 13250 && gross_income <= 13749.99)
            {
                sss_contribution = 2035.00;
            }
            else if (gross_income >= 13750 && gross_income <= 14249.99)
            {
                sss_contribution = 2110.00;
            }
            else if (gross_income >= 14250 && gross_income <= 14749.99)
            {
                sss_contribution = 2185.00;
            }
            else if (gross_income >= 14750 && gross_income <= 15249.99)
            {
                sss_contribution = 2280.00;
            }
            else if (gross_income >= 15250 && gross_income <= 15749.99)
            {
                sss_contribution = 2355.00;
            }
            else if (gross_income >= 15750 && gross_income <= 16249.99)
            {
                sss_contribution = 2430.00;
            }
            else if (gross_income >= 16250 && gross_income <= 16749.99)
            {
                sss_contribution = 2505.00;
            }
            else if (gross_income >= 16750 && gross_income <= 17249.99)
            {
                sss_contribution = 2580.00;
            }
            else if (gross_income >= 17250 && gross_income <= 17749.99)
            {
                sss_contribution = 2655.00;
            }
            else if (gross_income >= 17750 && gross_income <= 18249.99)
            {
                sss_contribution = 2730.00;
            }
            else if (gross_income >= 18250 && gross_income <= 18749.99)
            {
                sss_contribution = 2805.00;
            }
            else if (gross_income >= 18750 && gross_income <= 19249.99)
            {
                sss_contribution = 2880.00;
            }
            else if (gross_income >= 19250 && gross_income <= 19749.99)
            {
                sss_contribution = 2955.00;
            }
            else if (gross_income >= 19750 && gross_income <= 20249.99)
            {
                sss_contribution = 3030.00;
            }
            else if (gross_income >= 20250 && gross_income <= 20749.99)
            {
                sss_contribution = 3105.00;
            }
            else if (gross_income >= 20750 && gross_income <= 21249.99)
            {
                sss_contribution = 3180.00;
            }
            else if (gross_income >= 21250 && gross_income <= 21749.99)
            {
                sss_contribution = 3255.00;
            }
            else if (gross_income >= 21750 && gross_income <= 22249.99)
            {
                sss_contribution = 3330.00;
            }
            else if (gross_income >= 22250 && gross_income <= 22749.99)
            {
                sss_contribution = 3405.00;
            }
            else if (gross_income >= 22750 && gross_income <= 23249.99)
            {
                sss_contribution = 3480.00;
            }
            else if (gross_income >= 23250 && gross_income <= 23749.99)
            {
                sss_contribution = 3555.00;
            }
            else if (gross_income >= 23750 && gross_income <= 24249.99)
            {
                sss_contribution = 3630.00;
            }
            else if (gross_income >= 24250 && gross_income <= 24749.99)
            {
                sss_contribution = 3705.00;
            }
            else if (gross_income >= 24750 && gross_income <= 25249.99)
            {
                sss_contribution = 3780.00;
            }
            else if (gross_income >= 25250 && gross_income <= 25749.99)
            {
                sss_contribution = 3855.00;
            }
            else if (gross_income >= 25750 && gross_income <= 26249.99)
            {
                sss_contribution = 3930.00;
            }
            else if (gross_income >= 26250 && gross_income <= 26749.99)
            {
                sss_contribution = 4005.00;
            }
            else if (gross_income >= 26750 && gross_income <= 27249.99)
            {
                sss_contribution = 4080.00;
            }
            else if (gross_income >= 27250 && gross_income <= 27749.99)
            {
                sss_contribution = 4155.00;
            }
            else if (gross_income >= 27750 && gross_income <= 28249.99)
            {
                sss_contribution = 4230.00;
            }
            else if (gross_income >= 28250 && gross_income <= 28749.99)
            {
                sss_contribution = 4305.00;
            }
            else if (gross_income >= 28750 && gross_income <= 29249.99)
            {
                sss_contribution = 4380.00;
            }
            else if (gross_income >= 29250 && gross_income <= 29749.99)
            {
                sss_contribution = 4455.00;
            }
            else if (gross_income >= 29750 && gross_income <= 30249.99)
            {
                sss_contribution = 4530.00;
            }
            else if (gross_income >= 30250 && gross_income <= 30749.99)
            {
                sss_contribution = 4605.00;
            }
            else if (gross_income >= 30750 && gross_income <= 31249.99)
            {
                sss_contribution = 4680.00;
            }
            else if (gross_income >= 31250 && gross_income <= 31749.99)
            {
                sss_contribution = 4755.00;
            }
            else if (gross_income >= 31750 && gross_income <= 32249.99)
            {
                sss_contribution = 4830.00;
            }
            else if (gross_income >= 32250 && gross_income <= 32749.99)
            {
                sss_contribution = 4905.00;
            }
            else if (gross_income >= 32750 && gross_income <= 33249.99)
            {
                sss_contribution = 4980.00;
            }
            else if (gross_income >= 33250 && gross_income <= 33749.99)
            {
                sss_contribution = 5055.00;
            }
            else if (gross_income >= 33750 && gross_income <= 34249.99)
            {
                sss_contribution = 5130.00;
            }
            else if (gross_income >= 34250 && gross_income <= 34749.99)
            {
                sss_contribution = 5205.00;
            }
            else
            {
                sss_contribution = 5280.00;
            }

            philhealth_contribution = gross_income * 0.05;

            if (gross_income <= 250000)
            {
                income_tax_contribution = 0;
            }
            else if (gross_income <= 400000)
            {
                income_tax_contribution = 0.15 * (gross_income - 250000);
            }
            else if (gross_income <= 800000)
            {
                income_tax_contribution = 22500 + 0.20 * (gross_income - 400000);
            }
            else if (gross_income <= 2000000)
            {
                income_tax_contribution = 102500 + 0.25 * (gross_income - 800000);
            }
            else if (gross_income <= 8000000)
            {
                income_tax_contribution = 402500 + 0.30 * (gross_income - 2000000);
            }
            else
            {
                income_tax_contribution = 2202500 + 0.35 * (gross_income - 8000000);
            }

            sss_loan = Convert.ToDouble(textbox_otherdeduction_sssloan.Text);
            pagibig_loan = Convert.ToDouble(textbox_otherdeduction_pagibigloan.Text);
            faculty_savings_deposit = Convert.ToDouble(textbox_otherdeduction_facultysavingsdeposit.Text);
            faculty_savings_loan = Convert.ToDouble(textbox_otherdeduction_facultysavingsloan.Text);
            salary_loan = Convert.ToDouble(textbox_otherdeduction_salaryloan.Text);
            other_loan = Convert.ToDouble(textbox_otherdeduction_otherloan.Text);

            total_deduction = sss_contribution + philhealth_contribution + pagibig_contribution + income_tax_contribution +
                sss_loan + pagibig_loan + faculty_savings_deposit + faculty_savings_loan + salary_loan + other_loan;
            
            net_income = gross_income - total_deduction;

            textbox_regulardeduction_ssscontribution.Text = sss_contribution.ToString("0.00");
            textbox_regulardeduction_philhealthcontribution.Text = philhealth_contribution.ToString("0.00");
            textbox_regulardeduction_pagibigcontribution.Text = pagibig_contribution.ToString("0.00");
            textbox_regulardeduction_incometaxcontribution.Text = income_tax_contribution.ToString("0.00");
            
            textbox_deductionsummary_totaldeduction.Text = total_deduction.ToString("0.00");
            
            textbox_summaryincome_netincome.Text = net_income.ToString("0.00");

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            textbox_employeenumber.Clear();
            textbox_department.Clear();
            textbox_firstname.Clear();
            textbox_middlename.Clear();
            textbox_surname.Clear();
            textbox_civilstatus.Clear();
            textbox_qualifieddependentsstatus.Clear();
            textbox_employeestatus.Clear();
            textbox_designation.Clear();

            textbox_basicincome_noofhourspercutoff.Clear();
            textbox_basicincome_rateperhour.Clear();
            textbox_basicincome_incomepercutoff.Clear();

            textbox_honorariumincome_noofhourspercutoff.Clear();
            textbox_honorariumincome_rateperhour.Clear();
            textbox_honorariumincome_incomepercutoff.Clear();

            textbox_otherincome_noofhourspercutoff.Clear();
            textbox_otherincome_rateperhour.Clear();
            textbox_otherincome_incomepercutoff.Clear();

            textbox_summaryincome_grossincome.Clear();
            textbox_summaryincome_netincome.Clear();

            textbox_regulardeduction_ssscontribution.Clear();
            textbox_regulardeduction_philhealthcontribution.Clear();
            textbox_regulardeduction_pagibigcontribution.Clear();
            textbox_regulardeduction_incometaxcontribution.Clear();

            textbox_otherdeduction_sssloan.Clear();
            textbox_otherdeduction_pagibigloan.Clear();
            textbox_otherdeduction_facultysavingsdeposit.Clear();
            textbox_otherdeduction_facultysavingsloan.Clear();
            textbox_otherdeduction_salaryloan.Clear();
            textbox_otherdeduction_otherloan.Clear();

            textbox_deductionsummary_totaldeduction.Clear();
            
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            PrelimExam_Lesson5Activity_PrintForm printForm = new PrelimExam_Lesson5Activity_PrintForm();

            printForm.textbox_company.Text = "Lyceum of the Philippines University - Cavite";
            printForm.textbox_employeecode.Text = textbox_employeenumber.Text;
            printForm.textbox_department.Text = textbox_department.Text;
            printForm.textbox_employeename.Text = textbox_firstname.Text + " " + textbox_middlename.Text + " " + textbox_surname.Text;
            printForm.textbox_payperiod.Text = datetimepicker_paydate.Text;
            printForm.textbox_cutoff.Text = datetimepicker_paydate.Text;

            printForm.textbox_basicincome.Text = textbox_basicincome_incomepercutoff.Text;
            printForm.textbox_overtime.Text = textbox_otherincome_incomepercutoff.Text;
            printForm.textbox_honorarium.Text = textbox_honorariumincome_incomepercutoff.Text;
            printForm.textbox_honorariumadjustment.Text = "0.00";
            printForm.textbox_substitution.Text = "0.00";
            printForm.textbox_tardy.Text = "0.00";

            printForm.textbox_withholdingtax.Text = textbox_regulardeduction_incometaxcontribution.Text;
            printForm.textbox_ssscontribution.Text = textbox_regulardeduction_ssscontribution.Text;
            printForm.textbox_philhealthcontribution.Text = textbox_regulardeduction_philhealthcontribution.Text;
            printForm.textbox_hdmfcontribution.Text = textbox_regulardeduction_pagibigcontribution.Text;
            printForm.textbox_ssswispcontribution.Text = "750.00";

            printForm.textbox_earnings.Text = textbox_summaryincome_grossincome.Text;
            printForm.textbox_deductions.Text = textbox_deductionsummary_totaldeduction.Text;
            printForm.textbox_overtime_2.Text = textbox_otherincome_incomepercutoff.Text;

            printForm.textbox_grossearnings.Text = textbox_summaryincome_grossincome.Text;
            printForm.textbox_deductions_2.Text = textbox_deductionsummary_totaldeduction.Text;
            printForm.textbox_netpay.Text = textbox_summaryincome_netincome.Text;

            printForm.Show();



        }
    }
}
