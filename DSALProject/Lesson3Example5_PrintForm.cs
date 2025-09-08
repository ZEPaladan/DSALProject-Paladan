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
    public partial class Lesson3Example5_PrintForm : Form
    {
        public Lesson3Example5_PrintForm()
        {
            InitializeComponent();

            listbox_payslipview.Items.AddRange(listbox_payslipview.Items);
        }

        private void Lesson3Example5_PrintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
