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
    public partial class Lesson3Example3_PrintForm : Form
    {
        public Lesson3Example3_PrintForm()
        {
            InitializeComponent();

            listbox_printdisplay.Items.AddRange(listbox_printdisplay.Items);
        }

        public void listbox_printdisplay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
