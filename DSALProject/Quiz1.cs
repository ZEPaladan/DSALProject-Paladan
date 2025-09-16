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
    public partial class Quiz1 : Form
    {
        int unitlec, unitlab, creditunits, total_no_of_units, total_no_of_units2;
        double price_per_unit = 1700.00, labfee, total_tuition_fee, 
            total_misc_fee, cisco_fee, exam_booklet_fee, total_tuition_and_fee,
            total_tuition_fee2, total_misc_fee2, labfee2, cisco_fee2, exam_booklet_fee2,
            total_other_school_fees, total_tuition_and_fee2;

        private void button1_Click(object sender, EventArgs e)
        {
            Quiz1PrintForm print = new Quiz1PrintForm();

            print.textbox_coursenumber.Text = this.textbox_coursenumber.Text;
            print.textbox_coursecode.Text = this.textbox_coursecode.Text;
            print.textbox_coursedesc.Text = this.textbox_coursedesc.Text;
            print.textbox_unitlect.Text = this.textbox_unitlecture.Text;
            print.textbox_unitlab.Text = this.textbox_unitlab.Text;
            print.textbox_time.Text = this.textbox_time.Text;
            print.textbox_day.Text = this.textbox_day.Text;
            print.textbox_creditunits.Text = this.textbox_creditunits.Text;
            print.textbox_totalnoofunits.Text = this.textbox_totalnoofunits.Text;
            print.textbox_labfee.Text = this.textbox_labfee.Text;
            print.textbox_totaltuitionfee.Text = this.textbox_totaltuitionfee.Text;
            print.textbox_totalmiscfee.Text = this.textbox_totalmiscfee.Text;
            print.textbox_ciscolabfee.Text = this.textbox_ciscofee.Text;
            print.textbox_exambokletfee.Text = this.textbox_exambookletfee.Text;
            print.textbox_totaltuitionandfee.Text = this.textbox_totaltuitionandfee.Text;



            print.listbox_coursenumber.Items.AddRange(this.listbox_coursenumber.Items);
            print.listbox_coursecode.Items.AddRange(this.listbox_coursecode.Items);
            print.listbox_coursedesc.Items.AddRange(this.listbox_coursedesc.Items);
            print.listbox_unitlec.Items.AddRange(this.listbox_unitlec.Items);
            print.listbox_unitlab.Items.AddRange(this.listbox_unitlab.Items);
            print.listbox_creditunits.Items.AddRange(this.listbox_creditunits.Items);
            print.listbox_time.Items.AddRange(this.listbox_time.Items);
            print.listbox_day.Items.AddRange(this.listbox_day.Items);

            print.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            total_tuition_fee2 += total_tuition_fee;
            total_misc_fee2 += total_misc_fee;
            labfee2 += labfee;
            cisco_fee2 += cisco_fee;
            exam_booklet_fee2 += exam_booklet_fee;
            total_other_school_fees = labfee2 + cisco_fee2 + exam_booklet_fee2;
            total_no_of_units2 += total_no_of_units;
            total_tuition_and_fee2 += total_tuition_and_fee;

            textbox_totaltuitionfee2.Text = total_tuition_fee2.ToString();
            textbox_totalmiscfee2.Text = total_misc_fee2.ToString();
            textbox_computerlabfee.Text = labfee2.ToString();
            textbox_ciscolabfee2.Text = cisco_fee2.ToString();
            textbox_exambookletfee2.Text = exam_booklet_fee2.ToString();
            textbox_totalotherschoolfees.Text = total_other_school_fees.ToString();
            textbox_totalnumberofunits2.Text = total_no_of_units2.ToString();
            textbox_totaltuitionandfee2.Text = total_tuition_and_fee2.ToString();

        }

        private void button_newcancel_Click(object sender, EventArgs e)
        {
            textbox_coursenumber.Clear();
            textbox_coursecode.Clear();
            textbox_coursedesc.Clear();
            textbox_unitlecture.Clear();
            textbox_unitlab.Clear();
            textbox_labfee.Clear();
            textbox_ciscofee.Clear();
            textbox_exambookletfee.Clear();
            textbox_time.Clear();
            textbox_day.Clear();

            textbox_creditunits.Clear();
            textbox_totalnoofunits.Clear();
            textbox_totaltuitionfee.Clear();
            textbox_totalmiscfee.Clear();
            textbox_totaltuitionfee.Clear();
            textbox_totaltuitionandfee.Clear();
        }

        public Quiz1()
        {
            InitializeComponent();

            textbox_creditunits.Enabled = false;
            textbox_totalnoofunits.Enabled = false;
            textbox_totaltuitionfee.Enabled = false;
            textbox_totalmiscfee.Enabled = false;
            textbox_totaltuitionfee.Enabled = false;
            textbox_totaltuitionandfee.Enabled = false;

            textbox_totaltuitionfee2.Enabled = false;
            textbox_totalmiscfee2.Enabled = false;
            textbox_computerlabfee.Enabled = false;
            textbox_ciscolabfee2.Enabled = false;
            textbox_exambookletfee2.Enabled = false;
            textbox_totalotherschoolfees.Enabled = false;
            textbox_totalnumberofunits2.Enabled = false;
            textbox_totaltuitionandfee2.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.png; *.gif; *.bmp"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbox_yearlevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listbox_coursenumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            unitlec = Convert.ToInt32(textbox_unitlecture.Text);
            unitlab = Convert.ToInt32(textbox_unitlab.Text);
            labfee = Convert.ToDouble(textbox_labfee.Text);
            cisco_fee = Convert.ToDouble(textbox_ciscofee.Text);
            exam_booklet_fee = Convert.ToDouble(textbox_exambookletfee.Text);

            creditunits = unitlec + unitlab;
            total_no_of_units = unitlab + unitlec;
            total_tuition_fee = creditunits * price_per_unit;
            total_misc_fee = labfee + cisco_fee + exam_booklet_fee;
            total_tuition_and_fee = total_tuition_fee + total_misc_fee;

            textbox_creditunits.Text = creditunits.ToString();
            textbox_totalnoofunits.Text = total_no_of_units.ToString();
            textbox_totaltuitionfee.Text = total_tuition_fee.ToString();
            textbox_totalmiscfee.Text = total_misc_fee.ToString();
            textbox_totaltuitionandfee.Text = total_tuition_and_fee.ToString();

            listbox_coursenumber.Items.Insert(0, textbox_coursenumber.Text);
            listbox_coursecode.Items.Insert(0, textbox_coursecode.Text);
            listbox_coursedesc.Items.Insert(0, textbox_coursedesc.Text);
            listbox_unitlec.Items.Insert(0, textbox_unitlecture.Text);
            listbox_unitlab.Items.Insert(0, textbox_unitlab.Text);
            listbox_creditunits.Items.Insert(0, textbox_creditunits.Text);
            listbox_time.Items.Insert(0, textbox_time.Text);
            listbox_day.Items.Insert(0, textbox_day.Text);
        }

        private void Quiz1_Load(object sender, EventArgs e)
        {
            cbox_programs.Items.Add("Architecture");
            cbox_programs.Items.Add("Aeronautical Engineering");
            cbox_programs.Items.Add("Civil Engineering");
            cbox_programs.Items.Add("Computer Engineering");
            cbox_programs.Items.Add("Computer Science");
            cbox_programs.Items.Add("Electrical Engineering");
            cbox_programs.Items.Add("Electronics Engineering");
            cbox_programs.Items.Add("Industrial Engineering");
            cbox_programs.Items.Add("Information Technology");
            cbox_programs.Items.Add("Mechanical Engineering");

            cbox_yearlevel.Items.Add("1st Year");
            cbox_yearlevel.Items.Add("2nd Year");
            cbox_yearlevel.Items.Add("3rd Year");
            cbox_yearlevel.Items.Add("4th Year");
        }
    }
}
