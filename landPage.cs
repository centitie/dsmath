using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace DSFinalProject
{
    public partial class landPage : KryptonForm
    {
        public landPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar.Hide();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            ProgressBar.Show();
            startbtn.Text = "Loading...";
        }

        private void appName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar.Increment(3);

            if(ProgressBar.Value >= ProgressBar.Maximum) 
            {
                timer1.Stop();
                this.Hide();
                mainPage m = new mainPage();
                m.Show();
            }
        }

        private void BTNENTER_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();

            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            members m = new members();
            m.Show();

            this.Hide();
        }
    }
}
