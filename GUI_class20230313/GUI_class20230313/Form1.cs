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
    public partial class Form1 : Form
    {
        private Button but_button;

        public Form1()
        {
            InitializeComponent();
        }

        private void but_button_0313_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello_World");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.but_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_button
            // 
            this.but_button.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_button.ForeColor = System.Drawing.Color.Red;
            this.but_button.Location = new System.Drawing.Point(12, 12);
            this.but_button.Name = "but_button";
            this.but_button.Size = new System.Drawing.Size(173, 60);
            this.but_button.TabIndex = 0;
            this.but_button.Text = "按鈕_0313";
            this.but_button.UseVisualStyleBackColor = true;
            this.but_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(704, 384);
            this.Controls.Add(this.but_button);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("HELLO_WORLD");
            Form form_button = new Form_button();
            form_button.Show();
        }
    }
}
