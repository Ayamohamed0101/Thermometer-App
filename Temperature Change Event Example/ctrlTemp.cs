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
    public partial class ctrlTemp : UserControl
    {
        public class TemperatureChangedEventArgs : EventArgs
        {
            public double OldTemperature { get; }
            public double NewTemperature { get; }
            public double Diffrence { get; }


            public TemperatureChangedEventArgs(double OldTemperature, double NewTemperature)
            {
                this.OldTemperature = OldTemperature;
                this.NewTemperature = NewTemperature;
                this.Diffrence = NewTemperature - OldTemperature;
            }
        }

      
            public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

            public double OldTemperature;
            public double currentTemperature;//0

            public void SetTemperature(double newTemperature)
            {

                if (newTemperature != currentTemperature)
                {
                    OldTemperature = currentTemperature;
                    currentTemperature = newTemperature;
                    OnTemperatureChanged(OldTemperature, currentTemperature);
                }
            }

            public void OnTemperatureChanged(double OldTemperature, double currentTemperature)
            {
                OnTemperatureChanged(new TemperatureChangedEventArgs(OldTemperature, currentTemperature));
            }

            protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
            {
                TemperatureChanged?.Invoke(this, e);
            }
         


        
      

        public ctrlTemp()
        {
            InitializeComponent();
        }
        int timeSC, timeSec, timeMin;
        bool IsActive;
        //public event Action<int> OnTempratureChanged;
        //// Create a protected method to raise the event with a parameter
        //protected virtual void PersonSelected(int LicenseID)
        //{
        //    Action<int> handler = OnTempratureChanged;
        //    if (handler != null)
        //    {
        //        handler(LicenseID); // Raise the event with the parameter
        //    }
        //}

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            IsActive = true;
            txtold.Text = lblsec.Text;
            txtcurent.Text = "";
        }
        private void DrawTime()
        {
            lblcs.Text = string.Format("{0:00}", timeSC);
            // lblmin.Text = string.Format("{0:00}", timeMin);
            lblsec.Text = string.Format("{0:00}", timeSec);


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            IsActive = false;
            ResetTime();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            double Val1, Val2;
            Val1 = Convert.ToDouble(txtcurent.Text);
            Val2 = Convert.ToDouble(txtold.Text);


            //   lblResult.Text = Result.ToString();

            if ( TemperatureChanged != null)
            {
                OnTemperatureChanged( Val1, Val2);
            }
            // after adding refrence of tempratur project
            //Thermostat thermostat = new Thermostat();
            //Display display = new Display();

            //display.Subscribe(thermostat);
            //thermostat.OldTemperature = Convert.ToDouble(txtold.Text);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (IsActive)
            {
                timeSC++;
                if (timeSC >= 100)
                {
                    timeSec++;
                    timeSC = 0;
                    if (timeSec >= 60)
                    {
                        timeSec = 0;
                        timeMin++;
                    }
                }
            }
            DrawTime();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            IsActive = false;
            txtcurent.Text = lblsec.Text;
        }

        private void ctrlTemp_Load(object sender, EventArgs e)
        {
            ResetTime();
            IsActive = false;
        }
    }
}
