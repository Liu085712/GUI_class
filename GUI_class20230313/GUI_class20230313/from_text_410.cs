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
            string str = textBox1.Text;
            int input = Int32.Parse(str);
            label2.Text = (input + 10).ToString();
            //MessageBox.Show(str);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
