using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_class20230313
{
    public partial class Class0508 : Form
    {

        int sec = 0;
        public Class0508()
        {
            InitializeComponent();
            Fromtime.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = this.sec + "秒";
            this.sec++;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
