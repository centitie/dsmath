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
    public partial class members : KryptonForm
    {
        public members()
        {
            InitializeComponent();
        }

        private void members_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            landPage lp = new landPage();
            lp.Show();

            this.Hide();
        }
    }
}
