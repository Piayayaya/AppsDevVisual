using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class AnyaControl : UserControl
    {
        public AnyaControl()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dashboardControl1.Show();
            dashboardControl1.BringToFront();
            
        }

        private void dashboardControl1_Load(object sender, EventArgs e)
        {
            dashboardControl1.Hide();
        }
    }
}
