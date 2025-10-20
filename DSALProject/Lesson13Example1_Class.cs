using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DSALProject
{

    public partial class Lesson13Example1_Class : Form
    {
        SQL_Class sql;
        string picpath = "";

        // Constructor
        public Lesson13Example1_Class()
        {
            InitializeComponent();
            sql = new SQL_Class();
            sql.InitializeSQLConnection();
        }
        // Event Handlers
        // Save Button Click
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT INTO studentTbl (student_id, student_name, department, picpath) " +
                               $"VALUES ('{textbox_studentnumber.Text}', '{textbox_studentname.Text}', '{textbox_department.Text}', '{textbox_picturebox.Text}')";
                sql.ExecuteSQLCommand(query);

                DataSet ds = sql.GetDataSet("SELECT * FROM studentTbl");
                dataGridView1.DataSource = ds.Tables[0];
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // PictureBox Click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files(*.png)|*.png|JPG Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                picpath = dialog.FileName.ToString();
                pictureBox1.ImageLocation = picpath;
                textbox_picturebox.Text = picpath;
            }
        }
        // Clear Fields Method
        private void ClearFields()
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");
            textbox_studentnumber.Clear();
            textbox_studentname.Clear();
            textbox_department.Clear();
            textbox_picturebox.Clear();
        }
        // Search Button Click
        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT * FROM studentTbl WHERE student_id = '{textbox_studentnumber.Text}'";
                DataSet ds = sql.GetDataSet(query);
                dataGridView1.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    textbox_studentname.Text = row["student_name"].ToString();
                    textbox_department.Text = row["department"].ToString();
                    textbox_picturebox.Text = row["picpath"].ToString();
                    pictureBox1.Image = Image.FromFile(row["picpath"].ToString());
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Delete Button Click
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM studentTbl WHERE student_id = '{textbox_studentnumber.Text}'";
                sql.ExecuteSQLCommand(query);

                DataSet ds = sql.GetDataSet("SELECT * FROM studentTbl");
                dataGridView1.DataSource = ds.Tables[0];

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Form Load Event

        private void Lesson13Example1_Class_Load(object sender, EventArgs e)
        {
           
            textbox_picturebox.Hide();
            pictureBox1.Image = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");
            DataSet ds = sql.GetDataSet("SELECT * FROM studentTbl");
            dataGridView1.DataSource = ds.Tables[0];
        }
        // Edit Button Click
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"UPDATE studentTbl SET student_name = '{textbox_studentname.Text}', department = '{textbox_department.Text}', picpath = '{textbox_picturebox.Text}' WHERE student_id = '{textbox_studentnumber.Text}'";
                sql.ExecuteSQLCommand(query);

                DataSet ds = sql.GetDataSet("SELECT * FROM studentTbl");
                dataGridView1.DataSource = ds.Tables[0];

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Cancel Button Click
        private void button_cancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        // New Button Click
        private void button_new_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
