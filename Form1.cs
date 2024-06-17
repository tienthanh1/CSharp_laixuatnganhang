using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_laixuatnganhang
{
    public partial class txtketqua : Form
    {
        public txtketqua()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double sotien = double.Parse(txtsotien.Text);
            double laisuat = double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            int sonam = int.Parse(txtsonam.Text);
            for (int i = 1; i <= 20; i++)
            {
                tienlai = sotien * laisuat;
                lsbketqua.Items.Add("Năm: " + i + "số tiền là: " + tienlai);
                sotien += tienlai;
            }

        }

        private void lsbketqua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
