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
    public partial class from_text_410 : Form
    {
        public from_text_410()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Int32.Parse(textBox2.Text);
            int f = c * 9 / 5 + 32;
            label3.Text = f.ToString() + "度F";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
