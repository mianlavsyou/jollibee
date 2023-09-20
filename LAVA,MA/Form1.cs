using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LAVA_MA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnBestSellers.Height;
            SidePanel.Top = btnBestSellers.Top;
            firstCustomer1.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBestSellers.Height;
            SidePanel.Top = btnBestSellers.Top;
            firstCustomer1.BringToFront();
        }

        private void btnDinein_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnNewProduct.Height;
            SidePanel.Top = btnNewProduct.Top;
            second1.BringToFront();
            
        }

        private void second1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnSuperMeals.Height;
            SidePanel.Top = btnSuperMeals.Top;
            nine1.BringToFront();
        }

        private void btnFamilyMeals_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnFamilyMeals.Height;
            SidePanel.Top = btnFamilyMeals.Top;
            third1.BringToFront();
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBreakfast.Height;
            SidePanel.Top = btnBreakfast.Top;
            fourth1.BringToFront();
        }

        private void btnChickenJoy_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnChickenJoy.Height;
            SidePanel.Top = btnChickenJoy.Top;
            fifth1.BringToFront();
        }

        private void btnBurgers_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBurgers.Height;
            SidePanel.Top = btnBurgers.Top;
            six1.BringToFront();
        }

        private void btnJollySpaghetti_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnJollySpaghetti.Height;
            SidePanel.Top = btnJollySpaghetti.Top;
            seven1.BringToFront();
        }

        private void btnBurgerSteak_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnBurgerSteak.Height;
            SidePanel.Top = btnBurgerSteak.Top;
            eight1.BringToFront();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            new facebook().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
