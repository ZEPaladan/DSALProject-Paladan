namespace DSALProject
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.humanResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSFoodOrderingApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOSCashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userAccountReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSToolStripMenuItem,
            this.payrollToolStripMenuItem,
            this.humanResourcesToolStripMenuItem,
            this.userAccountToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pOSToolStripMenuItem
            // 
            this.pOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOSAdminToolStripMenuItem,
            this.pOSFoodOrderingApplicationToolStripMenuItem,
            this.pOSCashierToolStripMenuItem});
            this.pOSToolStripMenuItem.Name = "pOSToolStripMenuItem";
            this.pOSToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.pOSToolStripMenuItem.Text = "POS";
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payrollDatabaseToolStripMenuItem});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // humanResourcesToolStripMenuItem
            // 
            this.humanResourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeRegistrationToolStripMenuItem});
            this.humanResourcesToolStripMenuItem.Name = "humanResourcesToolStripMenuItem";
            this.humanResourcesToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.humanResourcesToolStripMenuItem.Text = "Human Resources";
            // 
            // userAccountToolStripMenuItem
            // 
            this.userAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userAccountRegistrationToolStripMenuItem});
            this.userAccountToolStripMenuItem.Name = "userAccountToolStripMenuItem";
            this.userAccountToolStripMenuItem.Size = new System.Drawing.Size(97, 21);
            this.userAccountToolStripMenuItem.Text = "User Account";
            // 
            // pOSAdminToolStripMenuItem
            // 
            this.pOSAdminToolStripMenuItem.Name = "pOSAdminToolStripMenuItem";
            this.pOSAdminToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.pOSAdminToolStripMenuItem.Text = "POS Admin";
            this.pOSAdminToolStripMenuItem.Click += new System.EventHandler(this.pOSAdminToolStripMenuItem_Click);
            // 
            // pOSFoodOrderingApplicationToolStripMenuItem
            // 
            this.pOSFoodOrderingApplicationToolStripMenuItem.Name = "pOSFoodOrderingApplicationToolStripMenuItem";
            this.pOSFoodOrderingApplicationToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.pOSFoodOrderingApplicationToolStripMenuItem.Text = "POS Food Ordering Application";
            this.pOSFoodOrderingApplicationToolStripMenuItem.Click += new System.EventHandler(this.pOSFoodOrderingApplicationToolStripMenuItem_Click);
            // 
            // pOSCashierToolStripMenuItem
            // 
            this.pOSCashierToolStripMenuItem.Name = "pOSCashierToolStripMenuItem";
            this.pOSCashierToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.pOSCashierToolStripMenuItem.Text = "POS Cashier";
            this.pOSCashierToolStripMenuItem.Click += new System.EventHandler(this.pOSCashierToolStripMenuItem_Click);
            // 
            // payrollDatabaseToolStripMenuItem
            // 
            this.payrollDatabaseToolStripMenuItem.Name = "payrollDatabaseToolStripMenuItem";
            this.payrollDatabaseToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.payrollDatabaseToolStripMenuItem.Text = "Payroll Database";
            this.payrollDatabaseToolStripMenuItem.Click += new System.EventHandler(this.payrollDatabaseToolStripMenuItem_Click);
            // 
            // employeeRegistrationToolStripMenuItem
            // 
            this.employeeRegistrationToolStripMenuItem.Name = "employeeRegistrationToolStripMenuItem";
            this.employeeRegistrationToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.employeeRegistrationToolStripMenuItem.Text = "Employee Registration";
            this.employeeRegistrationToolStripMenuItem.Click += new System.EventHandler(this.employeeRegistrationToolStripMenuItem_Click);
            // 
            // userAccountRegistrationToolStripMenuItem
            // 
            this.userAccountRegistrationToolStripMenuItem.Name = "userAccountRegistrationToolStripMenuItem";
            this.userAccountRegistrationToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.userAccountRegistrationToolStripMenuItem.Text = "User Account Registration";
            this.userAccountRegistrationToolStripMenuItem.Click += new System.EventHandler(this.userAccountRegistrationToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesReportsToolStripMenuItem,
            this.employeeReportsToolStripMenuItem,
            this.payrollReportsToolStripMenuItem,
            this.userAccountReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // salesReportsToolStripMenuItem
            // 
            this.salesReportsToolStripMenuItem.Name = "salesReportsToolStripMenuItem";
            this.salesReportsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.salesReportsToolStripMenuItem.Text = "Sales Reports";
            this.salesReportsToolStripMenuItem.Click += new System.EventHandler(this.salesReportsToolStripMenuItem_Click);
            // 
            // employeeReportsToolStripMenuItem
            // 
            this.employeeReportsToolStripMenuItem.Name = "employeeReportsToolStripMenuItem";
            this.employeeReportsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.employeeReportsToolStripMenuItem.Text = "Employee Reports";
            this.employeeReportsToolStripMenuItem.Click += new System.EventHandler(this.employeeReportsToolStripMenuItem_Click);
            // 
            // payrollReportsToolStripMenuItem
            // 
            this.payrollReportsToolStripMenuItem.Name = "payrollReportsToolStripMenuItem";
            this.payrollReportsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.payrollReportsToolStripMenuItem.Text = "Payroll Reports";
            this.payrollReportsToolStripMenuItem.Click += new System.EventHandler(this.payrollReportsToolStripMenuItem_Click);
            // 
            // userAccountReportsToolStripMenuItem
            // 
            this.userAccountReportsToolStripMenuItem.Name = "userAccountReportsToolStripMenuItem";
            this.userAccountReportsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.userAccountReportsToolStripMenuItem.Text = "User Account Reports";
            this.userAccountReportsToolStripMenuItem.Click += new System.EventHandler(this.userAccountReportsToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.cascadeToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem humanResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSFoodOrderingApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOSCashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userAccountReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}