using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Change_Event_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double res; double current; double old;
        public Form1(double result,double current,double old)
        {
            InitializeComponent();
            this.res = result;
            this.current = current;
            this.old = old;

        }
        private void Form2_DataBack(object sender, double current,double old,double res)
        {
            // Handle the data received from Form2
            lblcurrent.Text = current.ToString();
            lblold.Text = old.ToString();
            lblres.Text = res.ToString();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblcurrent.Text = current.ToString()+" C";
            lblold.Text = old.ToString() + " C";
            lblres.Text = res.ToString() + " C";

        }

        double c_to_k(double temp)
        {
            double result = temp + 273.15;
            return result;
        }
        double c_to_f(double temp)
        {
            double result = (temp * 9 / 5) + 32;
            return result;
        }
        double k_to_f(double temp)
        {
            double result = (temp - 273.15) * 9 / 5 + 32;
            return result;
        }
        double k_to_c(double temp)
        {
            double result = temp - 273.15;
            return result;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
        double res=  c_to_f(Convert.ToDouble(lblres.Text));
            lblf.Text = res.ToString()+ " F";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
            lblk.Text = c_to_k(Convert.ToDouble(lblres.Text)).ToString() + " k" ;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            lblC.Text = lblres.Text+" C";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            TempratureMode frm=new TempratureMode();
            frm.DataBack += Form2_DataBack;
            frm.ShowDialog();
            

        }
    }
}
