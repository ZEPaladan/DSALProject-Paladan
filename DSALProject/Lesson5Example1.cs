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
    public partial class Lesson5Example1 : Form
    {
        public Lesson5Example1()
        {
            InitializeComponent();
        }

        private void Lesson5Example1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            textbox_username.Focus();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //user account validation

            if (textbox_username.Text == "ehdrickpaladan" && textbox_password.Text == "admin")
            {
                MessageBox.Show("Welcome to the admin page.");
                Lesson5Example1_AdminForm adminForm = new Lesson5Example1_AdminForm();
                adminForm.ShowDialog();
                textbox_username.Clear();
                textbox_password.Clear();
                
            }
            else if (textbox_username.Text == "pointofsale" && textbox_password.Text == "admin")
            {
                MessageBox.Show("Welcome to Cashier Point of Sale Page.");
                Lesson3Example2 cashier_pointofsale = new Lesson3Example2();
                cashier_pointofsale.ShowDialog();
                textbox_username.Clear();
                textbox_password.Clear();
            }
            else if (textbox_username.Text == "foodordering" && textbox_password.Text == "admin")
            {
                MessageBox.Show("Welcome to Food Ordering Application.");
                Lesson3Example3 cashier_orderingapplication = new Lesson3Example3();
                cashier_orderingapplication.ShowDialog();
                textbox_username.Clear();
                textbox_password.Clear();
            }
            else if (textbox_username.Text == "payrol" && textbox_password.Text == "admin")
            {
                MessageBox.Show("Welcome to Payrol Page.");
                Lesson3Example5 payrolform = new Lesson3Example5();
                payrolform.ShowDialog();
                textbox_username.Clear();
                textbox_password.Clear();
            }
            else
            {
                MessageBox.Show("Invalid user account. Please contact your administrator.");
                textbox_username.Clear();
                textbox_password.Clear();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
