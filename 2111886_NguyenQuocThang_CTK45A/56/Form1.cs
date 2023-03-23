using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _56
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

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNam.Checked)
            {
                MessageBox.Show("Giới tính bạn là :" + rdNam.Text);
            }
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdNu.Checked)
            {
                MessageBox.Show("Giới tính bạn là :" + rdNu.Text);
            }
        }
    }
}
