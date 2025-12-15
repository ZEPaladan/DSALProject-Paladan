using DSALProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSALProject
{
    public partial class EmployeeRegistration : Form
    {
        string picpath;
        Image pic;
        employee_dbconnection dbcon = new employee_dbconnection();
        public EmployeeRegistration()
        {
            dbcon.employee_connString();
            InitializeComponent();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                textbox_picpath.Hide();
                pic = Resources.blank_image;
                dbcon.employee_sql = "SELECT * FROM pos_empRegTbl";
                dbcon.employee_cmd();
                dbcon.employee_sqladapterSelect();
                dbcon.employee_sqldatasetSELECT();
                dataGridView1.DataSource = dbcon.employee_sql_dataset.Tables[0];

                // Gender ComboBox
                combobox_gender.Items.Add("Male");
                combobox_gender.Items.Add("Female");
                combobox_gender.Items.Add("Other");

                // Status ComboBox
                combobox_status.Items.Add("Single");
                combobox_status.Items.Add("Married");
                combobox_status.Items.Add("Widowed");
                combobox_status.Items.Add("Divorced");
                combobox_status.Items.Add("Separated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void cleartextboxes()
        {
            textbox_picpath.Clear();

            textbox_employeenumber.Clear();
            textbox_firstname.Clear();
            textbox_middlename.Clear();
            textbox_surname.Clear();
            textbox_age.Clear();
            combobox_gender.SelectedIndex = -1;
            textbox_sssnumber.Clear();
            textbox_tinnumber.Clear();
            textbox_philhealthnumber.Clear();
            textbox_philhealthnumber.Clear();
            textbox_pagibignumber.Clear();
            combobox_status.SelectedIndex = -1;
            textbox_height.Clear();
            textbox_weight.Clear();

            textbox_yearofstay.Clear();
            textbox_housenumber.Clear();
            textbox_subdivisionname.Clear();
            textbox_phasenumber.Clear();
            textbox_street.Clear();
            textbox_barangay.Clear();
            textbox_municipality.Clear();
            textbox_city.Clear();
            textbox_country.Clear();
            textbox_statusprovince.Clear();
            textbox_zipcode.Clear();

            textbox_elementaryschool.Clear();
            textbox_elemaddress.Clear();
            datetimepicker_elemyeargraduated.Value = DateTime.Now;
            textbox_elemawards.Clear();

            textbox_juniorhighschool.Clear();
            textbox_jhsaddress.Clear();
            datetimepicker_jhsyeargraduated.Value = DateTime.Now;
            textbox_jhsawards.Clear();

            textbox_seniorhighschool.Clear();
            textbox_shsaddress.Clear();
            textbox_track.Clear();
            datetimepicker_shsyeargraduated.Value = DateTime.Now;
            textbox_shsawards.Clear();

            textbox_collegeschool.Clear();
            textbox_collegeaddress.Clear();
            textbox_course.Clear();
            datetimepicker_collegeyeargraduated.Value = DateTime.Now;
            textbox_collegeawards.Clear();
            textbox_others.Clear();

            textbox_position.Clear();
            textbox_employeestatus.Clear();
            datetimepicker_datehired.Value = DateTime.Now;
            textbox_department.Clear();
            textbox_noofdependents.Clear();

            pictureBox1.Image = Resources.blank_image;
        }

        private void button_browse_Click(object sender, EventArgs e)
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

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.employee_connString();

                // Search employee by ID
                dbcon.employee_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + textbox_employeenumber.Text + "'";
                dbcon.employee_cmd();
                dbcon.employee_sqladapterSelect();
                dbcon.employee_sqldatasetSELECT();

                // Check if any record is found
                if (dbcon.employee_sql_dataset.Tables[0].Rows.Count > 0)
                {
                    DataRow row = dbcon.employee_sql_dataset.Tables[0].Rows[0];

                    textbox_firstname.Text = row["emp_fname"].ToString();
                    textbox_middlename.Text = row["emp_mname"].ToString();
                    textbox_surname.Text = row["emp_surname"].ToString();
                    textbox_age.Text = row["emp_age"].ToString();
                    combobox_gender.Text = row["emp_gender"].ToString();
                    textbox_sssnumber.Text = row["emp_sss_no"].ToString();
                    textbox_tinnumber.Text = row["emp_tin_no"].ToString();
                    textbox_philhealthnumber.Text = row["emp_philhealth_no"].ToString();
                    textbox_pagibignumber.Text = row["emp_pagibig_no"].ToString();
                    combobox_status.Text = row["emp_status"].ToString();
                    textbox_height.Text = row["emp_height"].ToString();
                    textbox_weight.Text = row["emp_weight"].ToString();
                    textbox_yearofstay.Text = row["add_yrs_stay"].ToString();
                    textbox_housenumber.Text = row["add_house_no"].ToString();
                    textbox_subdivisionname.Text = row["add_sub_name"].ToString();
                    textbox_phasenumber.Text = row["add_phase_no"].ToString();
                    textbox_street.Text = row["add_street"].ToString();
                    textbox_barangay.Text = row["add_barangay"].ToString();
                    textbox_municipality.Text = row["add_municipality"].ToString();
                    textbox_city.Text = row["add_city"].ToString();
                    textbox_statusprovince.Text = row["add_state_province"].ToString();
                    textbox_country.Text = row["add_country"].ToString();
                    textbox_zipcode.Text = row["add_zipcode"].ToString();
                    textbox_elementaryschool.Text = row["elem_name"].ToString();
                    textbox_elemaddress.Text = row["elem_address"].ToString();
                    datetimepicker_elemyeargraduated.Value = Convert.ToDateTime(row["elem_yr_grad"]);
                    textbox_elemawards.Text = row["elem_award"].ToString();
                    textbox_juniorhighschool.Text = row["junior_high_name"].ToString();
                    textbox_jhsaddress.Text = row["junior_high_address"].ToString();
                    datetimepicker_jhsyeargraduated.Value = Convert.ToDateTime(row["junior_high_yr_grad"]);
                    textbox_jhsawards.Text = row["junior_high_award"].ToString();
                    textbox_seniorhighschool.Text = row["senior_high_name"].ToString();
                    textbox_shsaddress.Text = row["senior_high_address"].ToString();
                    datetimepicker_shsyeargraduated.Value = Convert.ToDateTime(row["senior_high_yr_grad"]);
                    textbox_shsawards.Text = row["senior_high_award"].ToString();
                    textbox_track.Text = row["track"].ToString();
                    textbox_collegeschool.Text = row["college_school_name"].ToString();
                    textbox_collegeaddress.Text = row["college_address"].ToString();
                    textbox_course.Text = row["college_course"].ToString();
                    datetimepicker_collegeyeargraduated.Value = Convert.ToDateTime(row["college_yr_grad"]);
                    textbox_collegeawards.Text = row["college_award"].ToString();
                    textbox_others.Text = row["others"].ToString();
                    textbox_position.Text = row["position"].ToString();
                    textbox_employeestatus.Text = row["emp_work_status"].ToString();
                    datetimepicker_datehired.Value = Convert.ToDateTime(row["emp_date_hired"]);
                    textbox_department.Text = row["emp_department"].ToString();
                    textbox_noofdependents.Text = row["emp_no_of_dependents"].ToString();
                    textbox_picpath.Text = row["picpath"].ToString();

                    // Load picture if path exists
                    if (!string.IsNullOrEmpty(textbox_picpath.Text) && System.IO.File.Exists(textbox_picpath.Text))
                    {
                        pictureBox1.Image = Image.FromFile(textbox_picpath.Text);
                    }
                    else
                    {
                        pictureBox1.Image = null; // Clear image if not found
                    }

                    // Show data in DataGridView
                    dataGridView1.DataSource = dbcon.employee_sql_dataset.Tables[0];
                }
                else
                {
                    MessageBox.Show("No employee found with this ID.");
                    cleartextboxes();
                    pictureBox1.Image = null;
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.employee_connString();

                dbcon.employee_sql =
                "INSERT INTO pos_empRegTbl (" +
                "emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, " +
                "emp_sss_no, emp_tin_no, emp_philhealth_no, emp_pagibig_no, emp_status, " +
                "emp_height, emp_weight, add_yrs_stay, add_house_no, add_sub_name, " +
                "add_phase_no, add_street, add_barangay, add_municipality, add_city, " +
                "add_state_province, add_country, add_zipcode, " +
                "elem_name, elem_address, elem_yr_grad, elem_award, " +
                "junior_high_name, junior_high_address, junior_high_yr_grad, junior_high_award, " +
                "senior_high_name, senior_high_address, senior_high_yr_grad, senior_high_award, " +
                "track, college_school_name, college_address, college_yr_grad, college_award, college_course, " +
                "others, position, emp_work_status, emp_date_hired, emp_department, " +
                "emp_no_of_dependents, picpath) " +

                "VALUES ('" +
                textbox_employeenumber.Text + "','" +
                textbox_firstname.Text + "','" +
                textbox_middlename.Text + "','" +
                textbox_surname.Text + "','" +
                textbox_age.Text + "','" +
                combobox_gender.Text + "','" +
                textbox_sssnumber.Text + "','" +
                textbox_tinnumber.Text + "','" +
                textbox_philhealthnumber.Text + "','" +
                textbox_pagibignumber.Text + "','" +
                combobox_status.Text + "','" +
                textbox_height.Text + "','" +
                textbox_weight.Text + "','" +
                textbox_yearofstay.Text + "','" +
                textbox_housenumber.Text + "','" +
                textbox_subdivisionname.Text + "','" +
                textbox_phasenumber.Text + "','" +
                textbox_street.Text + "','" +
                textbox_barangay.Text + "','" +
                textbox_municipality.Text + "','" +
                textbox_city.Text + "','" +
                textbox_statusprovince.Text + "','" +
                textbox_country.Text + "','" +
                textbox_zipcode.Text + "','" +
                textbox_elementaryschool.Text + "','" +
                textbox_elemaddress.Text + "','" +
                datetimepicker_elemyeargraduated.Value.ToString("yyyy-MM-dd") + "','" +
                textbox_elemawards.Text + "','" +
                textbox_juniorhighschool.Text + "','" +
                textbox_jhsaddress.Text + "','" +
                datetimepicker_jhsyeargraduated.Value.ToString("yyyy-MM-dd") + "','" +
                textbox_jhsawards.Text + "','" +
                textbox_seniorhighschool.Text + "','" +
                textbox_shsaddress.Text + "','" +
                datetimepicker_shsyeargraduated.Value.ToString("yyyy-MM-dd") + "','" +
                textbox_shsawards.Text + "','" +
                textbox_track.Text + "','" +
                textbox_collegeschool.Text + "','" +
                textbox_collegeaddress.Text + "','" +
                datetimepicker_collegeyeargraduated.Value.ToString("yyyy-MM-dd") + "','" +
                textbox_collegeawards.Text + "','" +
                textbox_course.Text + "','" +
                textbox_others.Text + "','" +
                textbox_position.Text + "','" +
                textbox_employeestatus.Text + "','" +
                datetimepicker_datehired.Value.ToString("yyyy-MM-dd") + "','" +
                textbox_department.Text + "','" +
                textbox_noofdependents.Text + "','" +
                textbox_picpath.Text +
                "')";

                dbcon.employee_cmd();
                dbcon.employee_sqladapterInsert();

                // Refresh table
                dbcon.employee_sql = "SELECT * FROM pos_empRegTbl";
                dbcon.employee_cmd();
                dbcon.employee_sqladapterSelect();
                dbcon.employee_sqldatasetSELECT();

                dataGridView1.DataSource = dbcon.employee_sql_dataset.Tables[0];

                cleartextboxes();

                MessageBox.Show("Employee record added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.employee_connString();

                dbcon.employee_sql =
                "UPDATE pos_empRegTbl SET " +
                "emp_fname = '" + textbox_firstname.Text + "', " +
                "emp_mname = '" + textbox_middlename.Text + "', " +
                "emp_surname = '" + textbox_surname.Text + "', " +
                "emp_age = '" + textbox_age.Text + "', " +
                "emp_gender = '" + combobox_gender.Text + "', " +
                "emp_sss_no = '" + textbox_sssnumber.Text + "', " +
                "emp_tin_no = '" + textbox_tinnumber.Text + "', " +
                "emp_philhealth_no = '" + textbox_philhealthnumber.Text + "', " +
                "emp_pagibig_no = '" + textbox_pagibignumber.Text + "', " +
                "emp_status = '" + combobox_status.Text + "', " +
                "emp_height = '" + textbox_height.Text + "', " +
                "emp_weight = '" + textbox_weight.Text + "', " +
                "add_yrs_stay = '" + textbox_yearofstay.Text + "', " +
                "add_house_no = '" + textbox_housenumber.Text + "', " +
                "add_sub_name = '" + textbox_subdivisionname.Text + "', " +
                "add_phase_no = '" + textbox_phasenumber.Text + "', " +
                "add_street = '" + textbox_street.Text + "', " +
                "add_barangay = '" + textbox_barangay.Text + "', " +
                "add_municipality = '" + textbox_municipality.Text + "', " +
                "add_city = '" + textbox_city.Text + "', " +
                "add_state_province = '" + textbox_statusprovince.Text + "', " +
                "add_country = '" + textbox_country.Text + "', " +
                "add_zipcode = '" + textbox_zipcode.Text + "', " +
                "elem_name = '" + textbox_elementaryschool.Text + "', " +
                "elem_address = '" + textbox_elemaddress.Text + "', " +
                "elem_yr_grad = '" + datetimepicker_elemyeargraduated.Value.ToString("yyyy-MM-dd") + "', " +
                "elem_award = '" + textbox_elemawards.Text + "', " +
                "junior_high_name = '" + textbox_juniorhighschool.Text + "', " +
                "junior_high_address = '" + textbox_jhsaddress.Text + "', " +
                "junior_high_yr_grad = '" + datetimepicker_jhsyeargraduated.Value.ToString("yyyy-MM-dd") + "', " +
                "junior_high_award = '" + textbox_jhsawards.Text + "', " +
                "senior_high_name = '" + textbox_seniorhighschool.Text + "', " +
                "senior_high_address = '" + textbox_shsaddress.Text + "', " +
                "senior_high_yr_grad = '" + datetimepicker_shsyeargraduated.Value.ToString("yyyy-MM-dd") + "', " +
                "senior_high_award = '" + textbox_shsawards.Text + "', " +
                "track = '" + textbox_track.Text + "', " +
                "college_school_name = '" + textbox_collegeschool.Text + "', " +
                "college_address = '" + textbox_collegeaddress.Text + "', " +
                "college_yr_grad = '" + datetimepicker_collegeyeargraduated.Value.ToString("yyyy-MM-dd") + "', " +
                "college_award = '" + textbox_collegeawards.Text + "', " +
                "college_course = '" + textbox_course.Text + "', " +
                "others = '" + textbox_others.Text + "', " +
                "position = '" + textbox_position.Text + "', " +
                "emp_work_status = '" + textbox_employeestatus.Text + "', " +
                "emp_date_hired = '" + datetimepicker_datehired.Value.ToString("yyyy-MM-dd") + "', " +
                "emp_department = '" + textbox_department.Text + "', " +
                "emp_no_of_dependents = '" + textbox_noofdependents.Text + "', " +
                "picpath = '" + textbox_picpath.Text + "' " +
                "WHERE emp_id = '" + textbox_employeenumber.Text + "'";

                dbcon.employee_cmd();
                dbcon.employee_sqladapterUpdate();

                // Refresh table
                dbcon.employee_sql = "SELECT * FROM pos_empRegTbl";
                dbcon.employee_cmd();
                dbcon.employee_sqladapterSelect();
                dbcon.employee_sqldatasetSELECT();

                dataGridView1.DataSource = dbcon.employee_sql_dataset.Tables[0];

                cleartextboxes();

                MessageBox.Show("Employee record updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dbcon.employee_connString();

                // DELETE query based on employee ID
                dbcon.employee_sql =
                "DELETE FROM pos_empRegTbl " +
                "WHERE emp_id = '" + textbox_employeenumber.Text + "'";

                dbcon.employee_cmd();
                dbcon.employee_sqladapterDelete();

                // Refresh table after deletion
                dbcon.employee_sql = "SELECT * FROM pos_empRegTbl";
                dbcon.employee_cmd();
                dbcon.employee_sqladapterSelect();
                dbcon.employee_sqldatasetSELECT();

                dataGridView1.DataSource = dbcon.employee_sql_dataset.Tables[0];

                cleartextboxes();

                MessageBox.Show("Employee record deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
