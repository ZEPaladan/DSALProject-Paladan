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
using DSALProject.Properties;

namespace DSALProject
{
    public partial class Lesson13Example1 : Form
    {
        String picpath;
        String connectionString = null;
        SqlConnection connection;
        SqlCommand command;
        DataSet dset;
        SqlDataAdapter adaptersql;
        string sql = null;
       
        public Lesson13Example1()
        {
            connectionString = "Data Source = C203-33; Initial Catalog = SampleDatabaseDb; user id = SA; password = B1Admin123@";
            connection = new SqlConnection(connectionString);

            InitializeComponent();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "DELETE FROM studentTb1 WHERE stud_id = '" + textbox_studentnumber.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.DeleteCommand = command;
            command.ExecuteNonQuery();
            
            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            dataGridView1.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\default image.png");

            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\default image.png");
            textbox_studentnumber.Clear();
            textbox_picturebox.Clear();
            textbox_studentname.Clear();
            textbox_department.Clear();
        }

        private void Lesson13Example1_Load(object sender, EventArgs e)
        {
            connection.Open();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            dataGridView1.DataSource = dset.Tables[0];

            textbox_picturebox.Hide();

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\default image.png");
            textbox_studentnumber.Clear();
            textbox_picturebox.Clear();
            textbox_studentname.Clear();
            textbox_department.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "UPDATE studentTb1 SET student_name = '" + textbox_studentname.Text + "', department = '" + textbox_department.Text + "', picpath = '" + textbox_picturebox.Text + "' WHERE stud_id = '" + textbox_studentnumber.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.UpdateCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");
            dataGridView1.DataSource = dset.Tables[0];

            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\default image.png");
            textbox_studentnumber.Clear();
            textbox_studentname.Clear();
            textbox_department.Clear();
            textbox_picturebox.Clear();
            connection.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "INSERT INTO studentTb1 (stud_id, student_name, department, picpath) VALUES " + "('" + textbox_studentnumber.Text + "', '" + textbox_studentname.Text + "', '" + textbox_department.Text + "', '" + textbox_picturebox.Text + "')";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.InsertCommand = command;
            command.ExecuteNonQuery();

            sql = "SELECT * FROM studentTb1";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            dataGridView1.DataSource = dset.Tables[0];
            pictureBox1.Image = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\default image.png");

            textbox_studentnumber.Clear();
            textbox_studentname.Clear();
            textbox_department.Clear();
            textbox_picturebox.Clear();

            connection.Close()
            ;
        }

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

        private void button_search_Click(object sender, EventArgs e)
        {
            connection.Open();
            sql = "SELECT * FROM studentTb1 WHERE stud_id = '" + textbox_studentnumber.Text + "'";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.Text;

            adaptersql = new SqlDataAdapter();
            adaptersql.SelectCommand = command;
            command.ExecuteNonQuery();

            dset = new DataSet();
            adaptersql.Fill(dset, "studentTb1");

            dataGridView1.DataSource = dset.Tables[0];
            textbox_studentname.Text = dset.Tables[0].Rows[0][1].ToString();
            textbox_department.Text = dset.Tables[0].Rows[0][2].ToString();
            textbox_picturebox.Text = dset.Tables[0].Rows[0][3].ToString();
            pictureBox1.Image = Image.FromFile(textbox_picturebox.Text);
        }
    }
}
