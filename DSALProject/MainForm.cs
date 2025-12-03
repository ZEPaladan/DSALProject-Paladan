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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Set the form as MDI container
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pOSAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS_Admin posAdmin = new POS_Admin();
            posAdmin.MdiParent = this;
            posAdmin.Show();
        }

        private void pOSFoodOrderingApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POSFoodOrderingApplication foodOrdering = new POSFoodOrderingApplication();
            foodOrdering.MdiParent = this;
            foodOrdering.Show();
        }

        private void pOSCashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POSFoodOrderingApplication foodOrdering = new POSFoodOrderingApplication();
            foodOrdering.MdiParent = this;
            foodOrdering.Show();
        }

        private void payrollDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollDatabase payrollDB = new PayrollDatabase();
            payrollDB.MdiParent = this;
            payrollDB.Show();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRegistration empReg = new EmployeeRegistration();
            empReg.MdiParent = this;
            empReg.Show();
        }

        private void userAccountRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccount userAcc = new UserAccount();
            userAcc.MdiParent = this;
            userAcc.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReports salesReports = new SalesReports();
            salesReports.MdiParent = this;
            salesReports.Show();
        }

        private void employeeReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeReports empReports = new EmployeeReports();
            empReports.MdiParent = this;
            empReports.Show();
        }

        private void payrollReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PayrollReports payrollReports = new PayrollReports();
            payrollReports.MdiParent = this;
            payrollReports.Show();
        }

        private void userAccountReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserAccountReports userReports = new UserAccountReports();
            userReports.MdiParent = this;
            userReports.Show();
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
    }
}
