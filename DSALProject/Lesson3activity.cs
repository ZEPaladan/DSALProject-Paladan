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
     
    public partial class Lesson3activity : Form
    {
        double lecture_fee = 1500.00, lab_fee = 2500.00, cisco_fee = 4500.00, exambooklet_fee = 450.00,
        sap_fee = 2000.00, downpayment = 8000.00;

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_clearstudentinformation_Click(object sender, EventArgs e)
        {
            textbox_studentname.Clear();
            textbox_studentnumber.Clear();
            combobox_program.SelectedIndex = -1;
            combobox_yearlevel.SelectedIndex = -1;
            combobox_scholar.SelectedIndex = -1;
            combobox_mode.SelectedIndex = -1;

        }

        private void button_clearschedleofcourses_Click(object sender, EventArgs e)
        {
            textbox_coursecode1.Clear();
            textbox_coursecode2.Clear();
            textbox_coursecode3.Clear();
            textbox_coursecode4.Clear();
            textbox_coursecode5.Clear();
            textbox_coursecode6.Clear();
            textbox_coursecode7.Clear();

            textbox_section1.Clear();
            textbox_section2.Clear();
            textbox_section3.Clear();
            textbox_section4.Clear();
            textbox_section5.Clear();
            textbox_section6.Clear();
            textbox_section7.Clear();

            textbox_description1.Clear();
            textbox_description2.Clear();
            textbox_description3.Clear();
            textbox_description4.Clear();
            textbox_description5.Clear();
            textbox_description6.Clear();
            textbox_description7.Clear();

            textbox_lecunits1.Text = "0";
            textbox_lecunits2.Text = "0";
            textbox_lecunits3.Text = "0";
            textbox_lecunits4.Text = "0";
            textbox_lecunits5.Text = "0";
            textbox_lecunits6.Text = "0";
            textbox_lecunits7.Text = "0";

            textbox_labunits1.Text = "0";
            textbox_labunits2.Text = "0";
            textbox_labunits3.Text = "0";
            textbox_labunits4.Text = "0";
            textbox_labunits5.Text = "0";
            textbox_labunits6.Text = "0";
            textbox_labunits7.Text = "0";

            textbox_credunits1.Text = "0";
            textbox_credunits2.Text = "0";
            textbox_credunits3.Text = "0";
            textbox_credunits4.Text = "0";
            textbox_credunits5.Text = "0";
            textbox_credunits6.Text = "0";
            textbox_credunits7.Text = "0";

            textbox_totalcreditunits.Text = "0";

            textbox_time1.Clear();
            textbox_time2.Clear();
            textbox_time3.Clear();
            textbox_time4.Clear();
            textbox_time5.Clear();
            textbox_time6.Clear();
            textbox_time7.Clear();

            textbox_day1.Clear();
            textbox_day2.Clear();
            textbox_day3.Clear();
            textbox_day4.Clear();
            textbox_day5.Clear();
            textbox_day6.Clear();
            textbox_day7.Clear();

            textbox_room1.Clear();
            textbox_room2.Clear();
            textbox_room3.Clear();
            textbox_room4.Clear();
            textbox_room5.Clear();
            textbox_room6.Clear();
            textbox_room7.Clear();
        }

        private void button_computefees_Click(object sender, EventArgs e)
        {
            int lecunits1, lecunits2, lecunits3, lecunits4, lecunits5, lecunits6, lecunits7, total_lec_units;
            int labunits1, labunits2, labunits3, labunits4, labunits5, labunits6, labunits7, total_lab_units;
            int credunits1, credunits2, credunits3, credunits4, credunits5, credunits6, credunits7;
            int totalcredunits;

            double total_tuition_fee, total_misc_fee, total_tuition_and_fees, com_lab_fee, installment, tuition_reduced_with_downpayment;

            lecunits1 = Convert.ToInt32(textbox_lecunits1.Text);
            lecunits2 = Convert.ToInt32(textbox_lecunits2.Text);
            lecunits3 = Convert.ToInt32(textbox_lecunits3.Text);
            lecunits4 = Convert.ToInt32(textbox_lecunits4.Text);
            lecunits5 = Convert.ToInt32(textbox_lecunits5.Text);
            lecunits6 = Convert.ToInt32(textbox_lecunits6.Text);
            lecunits7 = Convert.ToInt32(textbox_lecunits7.Text);

            total_lec_units = lecunits1 + lecunits2 + lecunits3 + lecunits4 + lecunits5 + lecunits6 + lecunits7;

            labunits1 = Convert.ToInt32(textbox_labunits1.Text);
            labunits2 = Convert.ToInt32(textbox_labunits2.Text);
            labunits3 = Convert.ToInt32(textbox_labunits3.Text);
            labunits4 = Convert.ToInt32(textbox_labunits4.Text);
            labunits5 = Convert.ToInt32(textbox_labunits5.Text);
            labunits6 = Convert.ToInt32(textbox_labunits6.Text);
            labunits7 = Convert.ToInt32(textbox_labunits7.Text);

            total_lab_units = labunits1 + labunits2 + labunits3 + labunits4 + labunits5 + labunits6 + labunits7;

            credunits1 = lecunits1 + labunits1;
            credunits2 = lecunits2 + labunits2;
            credunits3 = lecunits3 + labunits3;
            credunits4 = lecunits4 + labunits4;
            credunits5 = lecunits5 + labunits5;
            credunits6 = lecunits6 + labunits6;
            credunits7 = lecunits7 + labunits7;

            textbox_credunits1.Text = Convert.ToString(credunits1);
            textbox_credunits2.Text = Convert.ToString(credunits2);
            textbox_credunits3.Text = Convert.ToString(credunits3);
            textbox_credunits4.Text = Convert.ToString(credunits4);
            textbox_credunits5.Text = Convert.ToString(credunits5);
            textbox_credunits6.Text = Convert.ToString(credunits6);
            textbox_credunits7.Text = Convert.ToString(credunits7);

            totalcredunits = credunits1 + credunits2 + credunits3 + credunits4 + credunits5 + credunits6 + credunits7;

            textbox_totalcreditunits.Text = Convert.ToString(totalcredunits);

            total_tuition_fee = total_lec_units * lecture_fee;
            com_lab_fee = total_lab_units * lab_fee;

            textbox_totaltuitionfees.Text = Convert.ToString(total_tuition_fee);

            total_misc_fee = com_lab_fee + cisco_fee + exambooklet_fee + sap_fee;

            textbox_totalotherfee.Text = Convert.ToString(total_misc_fee);
            textbox_miscellaneousfees.Text = Convert.ToString(total_misc_fee);

            textbox_comlabfee.Text = Convert.ToString(com_lab_fee);
            textbox_ciscolabfee.Text = Convert.ToString(cisco_fee);
            textbox_exambookletfee.Text = Convert.ToString(exambooklet_fee);
            textbox_sapfee.Text = Convert.ToString(sap_fee);

            total_tuition_and_fees = total_tuition_fee + total_misc_fee;
            textbox_totaltuitionandfees.Text = Convert.ToString(total_tuition_and_fees);

            tuition_reduced_with_downpayment = total_tuition_and_fees - downpayment;
            textbox_downpayment.Text = Convert.ToString(downpayment);

            installment = tuition_reduced_with_downpayment / 3;
            textbox_firstinstallment.Text = Convert.ToString(installment);
            textbox_secondinstallment.Text = Convert.ToString(installment);
            textbox_thirdinstallment.Text = Convert.ToString(installment);

            textbox_amountdue.Text = Convert.ToString(tuition_reduced_with_downpayment);

            textbox_grandtotal.Text = Convert.ToString(total_tuition_and_fees);
            textbox_discount.Text = "";





        }


        public Lesson3activity()
        {
            InitializeComponent();

            textbox_credunits1.Enabled = false;
            textbox_credunits2.Enabled = false;
            textbox_credunits3.Enabled = false;
            textbox_credunits4.Enabled = false;
            textbox_credunits5.Enabled = false;
            textbox_credunits6.Enabled = false;
            textbox_credunits7.Enabled = false;
            textbox_totalcreditunits.Enabled = false;
            textbox_totaltuitionfees.Enabled = false;
            textbox_totalotherfee.Enabled = false;
            textbox_comlabfee.Enabled = false;
            textbox_ciscolabfee.Enabled = false;
            textbox_exambookletfee.Enabled = false;
            textbox_sapfee.Enabled = false;
            textbox_miscellaneousfees.Enabled = false;
            textbox_totaltuitionandfees.Enabled = false;
            textbox_installmentcharge.Enabled = false;
            textbox_downpayment.Enabled = false;
            textbox_firstinstallment.Enabled = false;
            textbox_secondinstallment.Enabled = false;
            textbox_thirdinstallment.Enabled = false;
            textbox_amountdue.Enabled = false;
            textbox_grandtotal.Enabled = false;
            textbox_discount.Enabled = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lesson3activity_Load(object sender, EventArgs e)
        {
            combobox_program.Items.Add("BS Information Technology");
            combobox_program.Items.Add("BS Computer Engineering");
            combobox_program.Items.Add("BS Electrical Engineering");
            combobox_program.Items.Add("BS Computer Science");
            combobox_program.Items.Add("BS Mechanical Engineering");
            combobox_program.Items.Add("BS Industrial Engineering");

            combobox_yearlevel.Items.Add("1st Year");
            combobox_yearlevel.Items.Add("2nd Year");
            combobox_yearlevel.Items.Add("3rd Year");
            combobox_yearlevel.Items.Add("4th Year");

            combobox_scholar.Items.Add("Yes");
            combobox_scholar.Items.Add("No");

            combobox_mode.Items.Add("Mode 1");
            combobox_mode.Items.Add("Mode 2");
            combobox_mode.Items.Add("Mode 3");

            textbox_lecunits1.Text = "0";
            textbox_lecunits2.Text = "0";
            textbox_lecunits3.Text = "0";
            textbox_lecunits4.Text = "0";
            textbox_lecunits5.Text = "0";
            textbox_lecunits6.Text = "0";
            textbox_lecunits7.Text = "0";

            textbox_labunits1.Text = "0";
            textbox_labunits2.Text = "0";
            textbox_labunits3.Text = "0";
            textbox_labunits4.Text = "0";
            textbox_labunits5.Text = "0";
            textbox_labunits6.Text = "0";
            textbox_labunits7.Text = "0";

            textbox_credunits1.Text = "0";
            textbox_credunits2.Text = "0";
            textbox_credunits3.Text = "0";
            textbox_credunits4.Text = "0";
            textbox_credunits5.Text = "0";
            textbox_credunits6.Text = "0";
            textbox_credunits7.Text = "0";

            textbox_totalcreditunits.Text = "0";



        }
    }
}
