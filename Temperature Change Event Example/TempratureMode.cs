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
    public partial class TempratureMode : Form
    {
        int timeSC, timeSec, timeMin;
        bool IsActive;
        public delegate void DataBackEventHandler(object sender, double res,double current,double old);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        private void guna2Button3_Click(object sender, EventArgs e) // start
        {
            IsActive = true;
           txtold.Text =lblsec.Text;
            txtcurent.Text = "";

        }

        private void guna2Button2_Click(object sender, EventArgs e) // restart
        {
            IsActive=false;
            ResetTime ();

        }

        private void guna2Button1_Click(object sender, EventArgs e) // stop
        {
            IsActive = false;
            txtcurent.Text=lblsec.Text;

        }

        public TempratureMode()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(IsActive)
            {
                timeSC++;
                if(timeSC>=100)
                {
                    timeSec++;
                    timeSC = 0;
                    if(timeSec>=60)
                    {
                        timeSec = 0;
                        timeMin++;
                    }
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            lblcs.Text = string.Format("{0:00}", timeSC);
           // lblmin.Text = string.Format("{0:00}", timeMin);
            lblsec.Text = string.Format("{0:00}", timeSec);


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double current= int.Parse(txtcurent.Text);
            double old = int.Parse(txtold.Text);
            double res = current - old;

            DataBack?.Invoke(this, res,current,old);
            // after adding refrence of tempratur project
            //Thermostat thermostat = new Thermostat();
            // Display display = new Display();

            //display.Subscribe(thermostat);
            //thermostat.OldTemperature =Convert.ToDouble( txtold.Text);
            //thermostat.currentTemperature = Convert.ToDouble(txtcurent.Text);

            //thermostat.SetTemperature(thermostat.currentTemperature); // 
            //thermostat.OnTemperatureChanged(thermostat.OldTemperature, thermostat.currentTemperature);
            
        }

        private void ResetTime()
        {
            timeSC = 0;
            timeSec = 0;
            timeMin = 0;
            txtold.Text = "";
            txtcurent.Text = "";

        }
        private void TempratureMode_Load(object sender, EventArgs e)
        {
            ResetTime();
            IsActive = false;
        }
    }
}
