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
    public partial class Class424 : Form
    {
        public Class424()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int add1 = 0, add2 = 0;
            try
            {
                add1 = Int32.Parse(textBox1.Text);
                add2 = Int32.Parse(textBox2.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally 
            {
              
            }
            label3.Text = (add1 + add2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int add3 = 0, add4 = 0;
            try
            {
                add3 = Int32.Parse(textBox3.Text);
                add4 = Int32.Parse(textBox4.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {
             
            }

            label6.Text = (add3 - add4).ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int add5 = 0, add6 = 0;
            try
            {
                add5 = Int32.Parse(textBox5.Text);
                add6 = Int32.Parse(textBox6.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {

            }
             label9.Text = (add5 * add6).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int add7 = 0, add8 = 0;
            try
            {
                add7 = Int32.Parse(textBox7.Text);
                add8 = Int32.Parse(textBox8.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("請輸入數字");
            }
            finally
            {

            }
            label12.Text = (add7 / add8).ToString();
        }
    }
}
