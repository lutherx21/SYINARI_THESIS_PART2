using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_TechShop_Management_System
{
    public partial class Form1 : Form
    {
        int valuep = 3;
        public Form1()
        {
            InitializeComponent();
           
            
        
      

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
       

        }

        private void bunifuCircleProgress1_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           

        }

        private void circularProgressBar1_Load(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            valuep += 1;
            bunifuCircleProgress1.Value = valuep;
            if(bunifuCircleProgress1.Value == 100){
                bunifuCircleProgress1.Value = 0;
                timer1.Stop();
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

    }
}
