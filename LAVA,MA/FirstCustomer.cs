using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LAVA_MA
{
    public partial class FirstCustomer : UserControl
    {
        public FirstCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new BestSellerAllowAccess().ShowDialog();
        }
    }
}
