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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void ctrlTemp1_OnTempratureChanged(int obj)
        {
           // double Result = obj.

           // MessageBox.Show("Differense " +  obj);
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void ctrlTemp1_TemperatureChanged(object sender, ctrlTemp.TemperatureChangedEventArgs e)
        {
            double Result = e.NewTemperature - e.OldTemperature;
            Form1 frm = new Form1(Result,e.NewTemperature,e.OldTemperature);
            frm.ShowDialog();
           // MessageBox.Show("Differense " + Result);
        }

        private void ctrlTemp1_Load(object sender, EventArgs e)
        {

        }
    }
}
