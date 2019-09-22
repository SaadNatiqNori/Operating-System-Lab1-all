using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Subject Name
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "The practical part of the subject of operating system".ToString();
        }
        //Current Time
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime time = System.DateTime.Now;
            label3.Text = time.ToString("HH:mm:ss tt");
        }
        //Current Day
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime day = System.DateTime.Now;
            label4.Text = day.ToString("dd/mm/yy");
        }
        //Computer Name
        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = Environment.MachineName.ToString();
        }
        //Environment Version
        private void button5_Click(object sender, EventArgs e)
        {
            var eversion = Environment.Version;
            label6.Text = eversion.ToString();
        }
        //Windows Platform
        private void button6_Click(object sender, EventArgs e)
        {
            var windows_platform = Environment.OSVersion;
            label7.Text = windows_platform.ToString();
        }
        //OS Version Platform
        private void button7_Click(object sender, EventArgs e)
        {
            var os_platform = Environment.OSVersion.Platform;
            label8.Text = os_platform.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        //Addresing ...
        private void button8_Click(object sender, EventArgs e)
        {
            var lim = Convert.ToInt32(textBox1.Text);
            var rel = Convert.ToInt32(textBox2.Text);
            var log = Convert.ToInt32(textBox3.Text);
            int result;

            if (log < lim)
            {
                result = log + rel;
                textBox4.Text = result.ToString();
                textBox4.ForeColor = Color.Green;
                MessageBox.Show("The physical address is (" + result.ToString() + ")","Success" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                textBox4.Text = "Trpa: Error Addresing".ToString();
                textBox4.ForeColor = Color.Red;
                label12.Text = "".ToString();
                MessageBox.Show("Error", "Trpa: Error Addresing", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        //Exit Button
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
