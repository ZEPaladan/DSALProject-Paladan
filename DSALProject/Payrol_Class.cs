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
    public partial class Payrol_Class : Form
    {
        public Payrol_Class()
        {
            InitializeComponent();

            POS1_Functions.DisableTextboxes(textbox_incomepercutoff, textbox_totalhonorariumpay, textbox_totalincomepay, textbox_grossincome, textbox_netincome, 
                textbox_ssscontribution, textbox_pagibigcontribution, textbox_philhealthcontribution, textbox_taxcontribution, textbox_totaldeduction);

            Payrol.ComboBoxValues(combobox_others);
        }

        private void Payrol_Class_Load(object sender, EventArgs e)
        {

        }

        private void textbox_incomepercutoff_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_noofhourspercutoff_basicpay_TextChanged(object sender, EventArgs e)
        {
            Payrol.CalculateIncome(textbox_rateperhour_basicpay, textbox_noofhourspercutoff_basicpay, textbox_incomepercutoff);
        }

        private void textbox_noofhourspercutoff_honorarium_TextChanged(object sender, EventArgs e)
        {
            Payrol.CalculateIncome(textbox_rateperhour_honorarium, textbox_noofhourspercutoff_honorarium, textbox_totalhonorariumpay);
        }

        private void textbox_noofhourspercutoff_otherincome_TextChanged(object sender, EventArgs e)
        {
            Payrol.CalculateIncome(textbox_rateperhour_otherincome, textbox_noofhourspercutoff_otherincome, textbox_totalincomepay);
        }

        private void combobox_others_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payrol.ComboBoxOthersLoan(combobox_others, textbox_others);
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            Payrol.CalculateGrossIncomeandContributions(
                textbox_incomepercutoff, textbox_totalhonorariumpay, textbox_totalincomepay,  // income inputs
                textbox_grossincome, textbox_netincome, textbox_totaldeduction, // gross/net/total deduction
                textbox_ssscontribution, textbox_philhealthcontribution, textbox_pagibigcontribution, textbox_taxcontribution, // contributions
                textbox_sssloan, textbox_pagibigloan, textbox_facultysavingsdeposit, textbox_facultysavingsloan, textbox_salaryloan, textbox_others // loans
                );
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            TextBox[] payrollTextBoxes = {
                textbox_civilstatus, textbox_designation, textbox_employeenumber,
                textbox_employeestatus, textbox_facultysavingsdeposit, textbox_facultysavingsloan,
                textbox_firstname, textbox_grossincome, textbox_incomepercutoff,
                textbox_middlename, textbox_netincome, textbox_noofhourspercutoff_basicpay,
                textbox_noofhourspercutoff_honorarium, textbox_noofhourspercutoff_otherincome,
                textbox_numberofdependents, textbox_others, textbox_pagibigcontribution,
                textbox_pagibigloan, textbox_philhealthcontribution, textbox_rateperhour_basicpay,
                textbox_rateperhour_honorarium, textbox_rateperhour_otherincome,
                textbox_salaryloan, textbox_ssscontribution, textbox_sssloan,
                textbox_surname, textbox_taxcontribution, textbox_totaldeduction,
                textbox_totalhonorariumpay, textbox_totalincomepay, textbox_department
            };
            Payrol.ClearAll(payrollTextBoxes, combobox_others, listbox_payslipview, pictureBox1);
        }

        private void button_previewpaymentdetails_Click(object sender, EventArgs e)
        {
            TextBox[] payrollTextBoxes = {
            textbox_employeenumber, textbox_firstname, textbox_middlename, textbox_surname,
            textbox_designation, textbox_employeestatus, textbox_department, // Employee info

            textbox_noofhourspercutoff_basicpay, textbox_rateperhour_basicpay, textbox_incomepercutoff, // Basic Pay
            textbox_noofhourspercutoff_honorarium, textbox_rateperhour_honorarium, textbox_totalhonorariumpay, // Honorarium
            textbox_noofhourspercutoff_otherincome, textbox_rateperhour_otherincome, textbox_totalincomepay, // Other Income

            textbox_ssscontribution, textbox_pagibigcontribution, textbox_philhealthcontribution, textbox_taxcontribution, // Contributions
            textbox_sssloan, textbox_pagibigloan, textbox_facultysavingsdeposit, textbox_facultysavingsloan, textbox_salaryloan, textbox_others, // Loans
            textbox_totaldeduction, textbox_grossincome, textbox_netincome // Totals
};

            Payrol.PayslipPreview(listbox_payslipview, payrollTextBoxes, datetimepicker_paydate);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            TextBox[] payrollTextBoxes = {
                textbox_civilstatus, textbox_designation, textbox_employeenumber,
                textbox_employeestatus, textbox_facultysavingsdeposit, textbox_facultysavingsloan,
                textbox_firstname, textbox_grossincome, textbox_incomepercutoff,
                textbox_middlename, textbox_netincome, textbox_noofhourspercutoff_basicpay,
                textbox_noofhourspercutoff_honorarium, textbox_noofhourspercutoff_otherincome,
                textbox_numberofdependents, textbox_others, textbox_pagibigcontribution,
                textbox_pagibigloan, textbox_philhealthcontribution, textbox_rateperhour_basicpay,
                textbox_rateperhour_honorarium, textbox_rateperhour_otherincome,
                textbox_salaryloan, textbox_ssscontribution, textbox_sssloan,
                textbox_surname, textbox_taxcontribution, textbox_totaldeduction,
                textbox_totalhonorariumpay, textbox_totalincomepay, textbox_department
            };
            Payrol.ClearAll(payrollTextBoxes, combobox_others, listbox_payslipview, pictureBox1);
        }

        private void button_printpayslip_Click(object sender, EventArgs e)
        {
            Payrol.PrintPayslip(listbox_payslipview);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payrol.BrowseImage(pictureBox1);
        }
    }
}
