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
            this.IsMdiContainer = true; // Ensure this form acts as an MDI container
        }

        private void Lesson5Example1_AdminForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Fullscreen
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the admin form
        }

        private void pOSIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Point of Sale form (non-MDI)
            Lesson3Example2 posForm = new Lesson3Example2();
            posForm.MdiParent = this; // Optional: make it MDI if needed
            posForm.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Food Ordering form
            Lesson3Example3 foodOrderingForm = new Lesson3Example3();
            foodOrderingForm.MdiParent = this;
            foodOrderingForm.Show();
        }

        private void payrolApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Payroll form
            Payrol_Function payrollForm = new Payrol_Function();
            payrollForm.MdiParent = this;
            payrollForm.Show();
        }

        private void simplePOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open Simple POS form
            POS1_FunctionForm simplePOSForm = new POS1_FunctionForm();
            simplePOSForm.MdiParent = this;
            simplePOSForm.Show();
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

        // Optional: remove if not used
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // No implementation yet
        }
    }
}

