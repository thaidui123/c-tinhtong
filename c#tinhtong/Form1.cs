using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_tinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1,so2 ,ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 + so2;

            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 - so2;
            
            if (so2 == 0)
            {
                MessageBox.Show("khong the chia cho 0", "thông báo lỗi", MessageBoxButtons.OKCancel);
            }
            else
            {
                txtKQ.Text = ketqua.ToString();
            }  
                
           
        }
    }  
    
  
}
