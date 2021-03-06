﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public int a;
        public int b;
        public int c;
        public Form2()
        {
            InitializeComponent();
            txtc.Enabled = false;
            txtkq.Enabled = false;
            MaximizeBox = false;
            timer1.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }
        public void PTB1()
        {
            a = Convert.ToInt16(txta.Text);
            b = Convert.ToInt16(txtb.Text);
            if (a == 0 && b == 0) txtkq.Text = "Phương trình có vô số nghiệm";
            if (a == 0 && b != 0) txtkq.Text = "Phương trình vô nghiệm";
            if (a != 0) txtkq.Text = ((float)-b / a).ToString();

               
        }
        public void PTB2()
        {
            a = Convert.ToInt16(txta.Text);
            b = Convert.ToInt16(txtb.Text);
            c = Convert.ToInt16(txtc.Text);
           
            float delta = b * b - 4 * a *c  ;



            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            if (delta <0) txtkq.Text = "Phương trình vô nghiệm";
            if (delta == 0)
            {
               
                txtkq.Text = "Phương Trình có nghiệm kép x1 = x2 = " + ((float)-b / 2 * a).ToString();
            }
            if (delta > 0)
            {
                txtkq.Text = "Phương Trình có nghiệm x1 = " + x1.ToString() +" " +" và nghiệm x2 = " + x2.ToString();
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rdbpt1_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbpt1.Checked == true)
            {
                txtc.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbpt1_Click(object sender, EventArgs e)
        {
            
            if (rdbpt1.Checked == true)
            {
                MessageBox.Show("Phương trình " + rdbpt1.Text + "\nđang được chọn");
                return;
            }
        }
       

        private void rdbpt2_Click_1(object sender, EventArgs e)
        {
            if (rdbpt2.Checked == true)
            {
                MessageBox.Show("Phương trình " + rdbpt2.Text + "\nđang được chọn");
                return;
            }
        }

        private void rdbpt2_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbpt2.Checked==true)
            {
                txtc.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(txta.Text);
            b = Convert.ToInt16(txtb.Text);
            if(rdbpt1.Checked==true)
            {
                PTB1();
            }
            if (rdbpt2.Checked == true)
            {
                PTB2();
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txta.Clear();
            txtb.Clear();
            txtc.Clear();
            txtkq.Clear();

            txtc.Enabled = false;
        }

        private void txta_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtb_Leave(object sender, EventArgs e)
        {
          

        }

        private void txtc_Leave(object sender, EventArgs e)
        {
            
        }

        private void txta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled=true;
            }
        }

        private void txtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
