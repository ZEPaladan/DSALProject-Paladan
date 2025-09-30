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
    public partial class Lesson5Example1_AdminForm : Form
    {
        public Lesson5Example1_AdminForm()
        {
            InitializeComponent();
        }

        private void Lesson5Example1_AdminForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;   // Fullscreen size
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling of the point of sale form

            Lesson3Example2 lesson3Example2 = new Lesson3Example2();
            
            
           
            lesson3Example2.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling of the food ordering application form
            Lesson3Example3 lesson3Example3 = new Lesson3Example3();
         
           
            lesson3Example3.Show();
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling of the payrol form
            Lesson3Example5 lesson3Example5 = new Lesson3Example5();
           
            
            lesson3Example5.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling of the lesson 2 activity 1 form
            Lesson2Activity1 lesson2Activity1 = new Lesson2Activity1();
           
           
            lesson2Activity1.Show();
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
