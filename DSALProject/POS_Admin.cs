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
    public partial class POS_Admin : Form
    {
        pos_dbconnection posdb_connect = new pos_dbconnection();
        private string picpath;
        private Image pic;

        public POS_Admin()
        {
            posdb_connect.pos_connString();
            InitializeComponent();
        }

        private void Lesson14Activity1_Load(object sender, EventArgs e)
        {
            try
            {
                //pic = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\blank_image.jpg");
                //pic = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");
                pic = Resources.blank_image;

                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                pictureBox3.Image = pic;
                pictureBox4.Image = pic;
                pictureBox5.Image = pic;
                pictureBox6.Image = pic;
                pictureBox7.Image = pic;
                pictureBox8.Image = pic;
                pictureBox9.Image = pic;
                pictureBox10.Image = pic;
                pictureBox11.Image = pic;
                pictureBox12.Image = pic;
                pictureBox13.Image = pic;
                pictureBox14.Image = pic;
                pictureBox15.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox18.Image = pic;
                pictureBox19.Image = pic;
                pictureBox20.Image = pic;

                textbox_picpath1.Hide();
                textbox_picpath2.Hide();
                textbox_picpath3.Hide();
                textbox_picpath4.Hide();
                textbox_picpath5.Hide();
                textbox_picpath6.Hide();
                textbox_picpath7.Hide();
                textbox_picpath8.Hide();
                textbox_picpath9.Hide();
                textbox_picpath10.Hide();
                textbox_picpath11.Hide();
                textbox_picpath12.Hide();
                textbox_picpath13.Hide();
                textbox_picpath14.Hide();
                textbox_picpath15.Hide();
                textbox_picpath16.Hide();
                textbox_picpath17.Hide();
                textbox_picpath18.Hide();
                textbox_picpath19.Hide();
                textbox_picpath20.Hide();
                
                combobox_posidno.Items.Add("1");
                combobox_posidno.Items.Add("2");
                combobox_posidno.Items.Add("3");

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void cleartextboxes()
        {
            try
            {
                //pic = Image.FromFile("C:\\Users\\C203-33\\source\\repos\\ZEPaladan\\DSALProject-Paladan\\DSALProject\\Resources\\blank_image.jpg");
                //pic = Image.FromFile("C:\\Users\\NewPC\\source\\repos\\DSALProject\\DSALProject\\Resources\\blank_image.jpg");
                pic = Resources.blank_image;

                textbox_picpath1.Clear();
                textbox_picpath2.Clear();
                textbox_picpath3.Clear();
                textbox_picpath4.Clear();
                textbox_picpath5.Clear();
                textbox_picpath6.Clear();
                textbox_picpath7.Clear();
                textbox_picpath8.Clear();
                textbox_picpath9.Clear();
                textbox_picpath10.Clear();
                textbox_picpath11.Clear();
                textbox_picpath12.Clear();
                textbox_picpath13.Clear();
                textbox_picpath14.Clear();
                textbox_picpath15.Clear();
                textbox_picpath16.Clear();
                textbox_picpath17.Clear();
                textbox_picpath18.Clear();
                textbox_picpath19.Clear();
                textbox_picpath20.Clear();

                pictureBox1.Image = pic;
                pictureBox2.Image = pic;
                pictureBox3.Image = pic;
                pictureBox4.Image = pic;
                pictureBox5.Image = pic;
                pictureBox6.Image = pic;
                pictureBox7.Image = pic;
                pictureBox8.Image = pic;
                pictureBox9.Image = pic;
                pictureBox10.Image = pic;
                pictureBox11.Image = pic;
                pictureBox12.Image = pic;
                pictureBox13.Image = pic;
                pictureBox14.Image = pic;
                pictureBox15.Image = pic;
                pictureBox16.Image = pic;
                pictureBox17.Image = pic;
                pictureBox18.Image = pic;
                pictureBox19.Image = pic;
                pictureBox20.Image = pic;

                textbox_price1.Clear();
                textbox_price2.Clear();
                textbox_price3.Clear();
                textbox_price4.Clear();
                textbox_price5.Clear();
                textbox_price6.Clear();
                textbox_price7.Clear();
                textbox_price8.Clear();
                textbox_price9.Clear();
                textbox_price10.Clear();
                textbox_price11.Clear();
                textbox_price12.Clear();
                textbox_price13.Clear();
                textbox_price14.Clear();
                textbox_price15.Clear();
                textbox_price16.Clear();
                textbox_price17.Clear();
                textbox_price18.Clear();
                textbox_price19.Clear();
                textbox_price20.Clear();

                textbox_name1.Clear();
                textbox_name2.Clear();
                textbox_name3.Clear();
                textbox_name4.Clear();
                textbox_name5.Clear();
                textbox_name6.Clear();
                textbox_name7.Clear();
                textbox_name8.Clear();
                textbox_name9.Clear();
                textbox_name10.Clear();
                textbox_name11.Clear();
                textbox_name12.Clear();
                textbox_name13.Clear();
                textbox_name14.Clear();
                textbox_name15.Clear();
                textbox_name16.Clear();
                textbox_name17.Clear();
                textbox_name18.Clear();
                textbox_name19.Clear();
                textbox_name20.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void open_file_image(PictureBox pb, TextBox tb)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Title = "Select Image";
                openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pb.Image = Image.FromFile(openFileDialog1.FileName); // set image
                    picpath = openFileDialog1.FileName; // store path in global variable
                    tb.Text = picpath; // show path in the textbox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No image selected!");
            }
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "INSERT INTO pos_nameTbl (pos_id, name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12, name13, name14, name15, name16, name17, name18, name19, name20) " +
                    "VALUES ('" + combobox_posidno.Text + "', '"
                    + textbox_name1.Text + "', '"
                    + textbox_name2.Text + "', '"
                    + textbox_name3.Text + "', '"
                    + textbox_name4.Text + "', '"
                    + textbox_name5.Text + "', '"
                    + textbox_name6.Text + "', '"
                    + textbox_name7.Text + "', '"
                    + textbox_name8.Text + "', '"
                    + textbox_name9.Text + "', '"
                    + textbox_name10.Text + "', '"
                    + textbox_name11.Text + "', '"
                    + textbox_name12.Text + "', '"
                    + textbox_name13.Text + "', '"
                    + textbox_name14.Text + "', '"
                    + textbox_name15.Text + "', '"
                    + textbox_name16.Text + "', '"
                    + textbox_name17.Text + "', '"
                    + textbox_name18.Text + "', '"
                    + textbox_name19.Text + "', '"
                    + textbox_name20.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_priceTbl (price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12, price13, price14, price15, price16, price17, price18, price19, price20, pos_id) " +
                    "VALUES ('"
                    + textbox_price1.Text + "', '"
                    + textbox_price2.Text + "', '"
                    + textbox_price3.Text + "', '"
                    + textbox_price4.Text + "', '"
                    + textbox_price5.Text + "', '"
                    + textbox_price6.Text + "', '"
                    + textbox_price7.Text + "', '"
                    + textbox_price8.Text + "', '"
                    + textbox_price9.Text + "', '"
                    + textbox_price10.Text + "', '"
                    + textbox_price11.Text + "', '"
                    + textbox_price12.Text + "', '"
                    + textbox_price13.Text + "', '"
                    + textbox_price14.Text + "', '"
                    + textbox_price15.Text + "', '"
                    + textbox_price16.Text + "', '"
                    + textbox_price17.Text + "', '"
                    + textbox_price18.Text + "', '"
                    + textbox_price19.Text + "', '"
                    + textbox_price20.Text + "', '"
                    + combobox_posidno.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_sql = "INSERT INTO pos_picTbl (pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8, pic9, pic10, pic11, pic12, pic13, pic14, pic15, pic16, pic17, pic18, pic19, pic20, pos_id) " +
                    "VALUES ('" + textbox_picpath1.Text + "', '"
                    + textbox_picpath2.Text + "', '"
                    + textbox_picpath3.Text + "', '"
                    + textbox_picpath4.Text + "', '"
                    + textbox_picpath5.Text + "', '"
                    + textbox_picpath6.Text + "', '"
                    + textbox_picpath7.Text + "', '"
                    + textbox_picpath8.Text + "', '"
                    + textbox_picpath9.Text + "', '"
                    + textbox_picpath10.Text + "', '"
                    + textbox_picpath11.Text + "', '"
                    + textbox_picpath12.Text + "', '"
                    + textbox_picpath13.Text + "', '"
                    + textbox_picpath14.Text + "', '"
                    + textbox_picpath15.Text + "', '"
                    + textbox_picpath16.Text + "', '"
                    + textbox_picpath17.Text + "', '"
                    + textbox_picpath18.Text + "', '"
                    + textbox_picpath19.Text + "', '"
                    + textbox_picpath20.Text + "', '"
                    + combobox_posidno.Text + "')";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterInsert();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "SELECT * FROM pos_nameTbl " +
                        "INNER JOIN pos_pictbl ON pos_nameTbl.pos_id = pos_pictbl.pos_id " +
                        "INNER JOIN pos_priceTbl ON pos_pictbl.pos_id = pos_priceTbl.pos_id " +
                        "WHERE pos_nameTbl.pos_id = '" + combobox_posidno.Text + "';";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                textbox_name1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name1"].ToString();
                textbox_name2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name2"].ToString();
                textbox_name3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name3"].ToString();
                textbox_name4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name4"].ToString();
                textbox_name5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name5"].ToString();
                textbox_name6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name6"].ToString();
                textbox_name7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name7"].ToString();
                textbox_name8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name8"].ToString();
                textbox_name9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name9"].ToString();
                textbox_name10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name10"].ToString();
                textbox_name11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name11"].ToString();
                textbox_name12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name12"].ToString();
                textbox_name13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name13"].ToString();
                textbox_name14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name14"].ToString();
                textbox_name15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name15"].ToString();
                textbox_name16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name16"].ToString();
                textbox_name17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name17"].ToString();
                textbox_name18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name18"].ToString();
                textbox_name19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name19"].ToString();
                textbox_name20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["name20"].ToString();
                textbox_picpath1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic1"].ToString();

                pictureBox1.Image = Image.FromFile(textbox_picpath1.Text);

                textbox_picpath2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic2"].ToString();
                pictureBox2.Image = Image.FromFile(textbox_picpath2.Text);

                textbox_picpath3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic3"].ToString();
                pictureBox3.Image = Image.FromFile(textbox_picpath3.Text);

                textbox_picpath4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic4"].ToString();
                pictureBox4.Image = Image.FromFile(textbox_picpath4.Text);

                textbox_picpath5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic5"].ToString();
                pictureBox5.Image = Image.FromFile(textbox_picpath5.Text);

                textbox_picpath6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic6"].ToString();
                pictureBox6.Image = Image.FromFile(textbox_picpath6.Text);

                textbox_picpath7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic7"].ToString();
                pictureBox7.Image = Image.FromFile(textbox_picpath7.Text);

                textbox_picpath8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic8"].ToString();
                pictureBox8.Image = Image.FromFile(textbox_picpath8.Text);

                textbox_picpath9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic9"].ToString();
                pictureBox9.Image = Image.FromFile(textbox_picpath9.Text);

                textbox_picpath10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic10"].ToString();
                pictureBox10.Image = Image.FromFile(textbox_picpath10.Text);

                textbox_picpath11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic11"].ToString();
                pictureBox11.Image = Image.FromFile(textbox_picpath11.Text);

                textbox_picpath12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic12"].ToString();
                pictureBox12.Image = Image.FromFile(textbox_picpath12.Text);

                textbox_picpath13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic13"].ToString();
                pictureBox13.Image = Image.FromFile(textbox_picpath13.Text);

                textbox_picpath14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic14"].ToString();
                pictureBox14.Image = Image.FromFile(textbox_picpath14.Text);

                textbox_picpath15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic15"].ToString();
                pictureBox15.Image = Image.FromFile(textbox_picpath15.Text);

                textbox_picpath16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic16"].ToString();
                pictureBox16.Image = Image.FromFile(textbox_picpath16.Text);

                textbox_picpath17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic17"].ToString();
                pictureBox17.Image = Image.FromFile(textbox_picpath17.Text);

                textbox_picpath18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic18"].ToString();
                pictureBox18.Image = Image.FromFile(textbox_picpath18.Text);

                textbox_picpath19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic19"].ToString();
                pictureBox19.Image = Image.FromFile(textbox_picpath19.Text);

                textbox_picpath20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["pic20"].ToString();
                pictureBox20.Image = Image.FromFile(textbox_picpath20.Text);

                textbox_price1.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price1"].ToString();
                textbox_price2.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price2"].ToString();
                textbox_price3.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price3"].ToString();
                textbox_price4.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price4"].ToString();
                textbox_price5.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price5"].ToString();
                textbox_price6.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price6"].ToString();
                textbox_price7.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price7"].ToString();
                textbox_price8.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price8"].ToString();
                textbox_price9.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price9"].ToString();
                textbox_price10.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price10"].ToString();
                textbox_price11.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price11"].ToString();
                textbox_price12.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price12"].ToString();
                textbox_price13.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price13"].ToString();
                textbox_price14.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price14"].ToString();
                textbox_price15.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price15"].ToString();
                textbox_price16.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price16"].ToString();
                textbox_price17.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price17"].ToString();
                textbox_price18.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price18"].ToString();
                textbox_price19.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price19"].ToString();
                textbox_price20.Text = posdb_connect.pos_sql_dataset.Tables[0].Rows[0]["price20"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "UPDATE pos_nameTbl SET " +
                "name1 = '" + textbox_name1.Text + "', " +
                "name2 = '" + textbox_name2.Text + "', " +
                "name3 = '" + textbox_name3.Text + "', " +
                "name4 = '" + textbox_name4.Text + "', " +
                "name5 = '" + textbox_name5.Text + "', " +
                "name6 = '" + textbox_name6.Text + "', " +
                "name7 = '" + textbox_name7.Text + "', " +
                "name8 = '" + textbox_name8.Text + "', " +
                "name9 = '" + textbox_name9.Text + "', " +
                "name10 = '" + textbox_name10.Text + "', " +
                "name11 = '" + textbox_name11.Text + "', " +
                "name12 = '" + textbox_name12.Text + "', " +
                "name13 = '" + textbox_name13.Text + "', " +
                "name14 = '" + textbox_name14.Text + "', " +
                "name15 = '" + textbox_name15.Text + "', " +
                "name16 = '" + textbox_name16.Text + "', " +
                "name17 = '" + textbox_name17.Text + "', " +
                "name18 = '" + textbox_name18.Text + "', " +
                "name19 = '" + textbox_name19.Text + "', " +
                "name20 = '" + textbox_name20.Text + "' " +
                "WHERE pos_id = '" + combobox_posidno.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_picTbl SET " +
                "pic1 = '" + textbox_picpath1.Text + "', " +
                "pic2 = '" + textbox_picpath2.Text + "', " +
                "pic3 = '" + textbox_picpath3.Text + "', " +
                "pic4 = '" + textbox_picpath4.Text + "', " +
                "pic5 = '" + textbox_picpath5.Text + "', " +
                "pic6 = '" + textbox_picpath6.Text + "', " +
                "pic7 = '" + textbox_picpath7.Text + "', " +
                "pic8 = '" + textbox_picpath8.Text + "', " +
                "pic9 = '" + textbox_picpath9.Text + "', " +
                "pic10 = '" + textbox_picpath10.Text + "', " +
                "pic11 = '" + textbox_picpath11.Text + "', " +
                "pic12 = '" + textbox_picpath12.Text + "', " +
                "pic13 = '" + textbox_picpath13.Text + "', " +
                "pic14 = '" + textbox_picpath14.Text + "', " +
                "pic15 = '" + textbox_picpath15.Text + "', " +
                "pic16 = '" + textbox_picpath16.Text + "', " +
                "pic17 = '" + textbox_picpath17.Text + "', " +
                "pic18 = '" + textbox_picpath18.Text + "', " +
                "pic19 = '" + textbox_picpath19.Text + "', " +
                "pic20 = '" + textbox_picpath20.Text + "' " +
                "WHERE pos_id = '" + combobox_posidno.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_sql = "UPDATE pos_priceTbl SET " +
                "price1 = '" + textbox_price1.Text + "', " +
                "price2 = '" + textbox_price2.Text + "', " +
                "price3 = '" + textbox_price3.Text + "', " +
                "price4 = '" + textbox_price4.Text + "', " +
                "price5 = '" + textbox_price5.Text + "', " +
                "price6 = '" + textbox_price6.Text + "', " +
                "price7 = '" + textbox_price7.Text + "', " +
                "price8 = '" + textbox_price8.Text + "', " +
                "price9 = '" + textbox_price9.Text + "', " +
                "price10 = '" + textbox_price10.Text + "', " +
                "price11 = '" + textbox_price11.Text + "', " +
                "price12 = '" + textbox_price12.Text + "', " +
                "price13 = '" + textbox_price13.Text + "', " +
                "price14 = '" + textbox_price14.Text + "', " +
                "price15 = '" + textbox_price15.Text + "', " +
                "price16 = '" + textbox_price16.Text + "', " +
                "price17 = '" + textbox_price17.Text + "', " +
                "price18 = '" + textbox_price18.Text + "', " +
                "price19 = '" + textbox_price19.Text + "', " +
                "price20 = '" + textbox_price20.Text + "' " +
                "WHERE pos_id = '" + combobox_posidno.Text + "'";

                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterUpdate();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                posdb_connect.pos_sql = "DELETE FROM pos_priceTbl WHERE pos_priceTbl.pos_id = '" + combobox_posidno.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();
                posdb_connect.pos_sql = "DELETE FROM pos_picTbl WHERE pos_picTbl.pos_id = '" + combobox_posidno.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();
                posdb_connect.pos_sql = "DELETE FROM pos_nameTbl WHERE pos_nameTbl.pos_id = '" + combobox_posidno.Text + "'";
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterDelete();

                posdb_connect.pos_select();
                posdb_connect.pos_cmd();
                posdb_connect.pos_sqladapterSelect();
                posdb_connect.pos_sqldatasetSELECT();
                dataGridView1.DataSource = posdb_connect.pos_sql_dataset.Tables[0];
                cleartextboxes();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_newcancel_Click(object sender, EventArgs e)
        {
            cleartextboxes();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox2, textbox_picpath2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox1, textbox_picpath1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox4, textbox_picpath4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox3, textbox_picpath3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox5, textbox_picpath5);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox10, textbox_picpath10);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox9, textbox_picpath9);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox8, textbox_picpath8);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox7, textbox_picpath7);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox6, textbox_picpath6);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox20, textbox_picpath20);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox19, textbox_picpath19);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox18, textbox_picpath18);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox17, textbox_picpath17);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox16, textbox_picpath16);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox15, textbox_picpath15);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox14, textbox_picpath14);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox13, textbox_picpath13);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox12, textbox_picpath12);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            open_file_image(pictureBox11, textbox_picpath11);
        }

        private void combobox_posidno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
