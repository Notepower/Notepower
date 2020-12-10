using System;
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
    public partial class Form1 : Form
    {
        public int a;
        public int b;
        
        public Form1()
        {
            InitializeComponent();
          
        }
      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(txtA.Text);
            b = Convert.ToInt16(txtB.Text);
            txtKQ.Text =(a + b).ToString();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(txtA.Text);
            b = Convert.ToInt16(txtB.Text);
            txtKQ.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt16(txtA.Text);
            b = Convert.ToInt16(txtB.Text);
            txtKQ.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
             a = Convert.ToInt16(txtA.Text);
            b = Convert.ToInt16(txtB.Text);
            txtKQ.Text = ((float)a / b).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtA_Leave(object sender, EventArgs e)
        {
            short a;
            bool Check = Int16.TryParse(txtA.Text, out a);
            if (Check == false)

                if (MessageBox.Show("Loi Dinh Dang\nBan co nhap lai khong ", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    txtA.Clear();

                    txtA.Focus();
                }
           
        }
            
            private void txtB_Leave(object sender, EventArgs e)
        {
            short b;
            bool Check = Int16.TryParse(txtB.Text, out b);
            if (Check == false)

                if (MessageBox.Show("Loi Dinh Dang\nBan co nhap lai khong ", "Thong Bao", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    txtB.Clear();

                    txtB.Focus();
                }
        }
    }
}
