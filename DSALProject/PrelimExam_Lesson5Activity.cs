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
    }
}
