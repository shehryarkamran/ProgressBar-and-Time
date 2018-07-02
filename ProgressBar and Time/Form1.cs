using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_and_Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            timer1.Enabled = true;
            
        }
        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            progressBar1.Value = ticks;
            if(ticks == 40)
            {
                timer1.Enabled = false;
                ticks = 0;
                Form2 obj = new Form2();
                obj.Show();
                progressBar1.Visible = false;
            }
        }
    }
}
