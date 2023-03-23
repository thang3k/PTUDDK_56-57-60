using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48
{
    public partial class frmDemoComboBox : Form
    {
        public frmDemoComboBox()
        {
            InitializeComponent();
        }

        private void frmDemoComboBox_Load(object sender, EventArgs e)
        {
            string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
            this.cbbNgoaiNgu.DataSource = datas;
        }

        private void cbbNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(this.cbbNgoaiNgu.SelectedItem.ToString());
        }
    }
}
