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
    public partial class Quiz1PrintForm : Form
    {
        public Quiz1PrintForm()
        {
            InitializeComponent();

            listbox_coursenumber.Items.AddRange(listbox_coursenumber.Items);
            listbox_coursecode.Items.AddRange(listbox_coursecode.Items);
            listbox_coursedesc.Items.AddRange(listbox_coursedesc.Items);
            listbox_unitlec.Items.AddRange(listbox_unitlec.Items);
            listbox_unitlab.Items.AddRange(listbox_unitlab.Items);
            listbox_creditunits.Items.AddRange(listbox_creditunits.Items);
            listbox_time.Items.AddRange(listbox_time.Items);
            listbox_day.Items.AddRange(listbox_day.Items);
        }

        private void Quiz1PrintForm_Load(object sender, EventArgs e)
        {

        }
    }
}
