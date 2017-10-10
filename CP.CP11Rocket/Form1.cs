using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP.CP11Rocket
{
    public partial class Form1 : Form
    {
        int time = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timCountDown_Tick(object sender, EventArgs e)
        {
            time--; 
            if (time == 0)
            {
                timCountDown.Enabled = false;
                timRocketUp.Enabled = true;
            }
            lblCountDown.Text = "Time: " + time;
        }

        private void timRocketUp_Tick(object sender, EventArgs e)
        {
            pbRocket.Top = pbRocket.Top - 3;
        }
    }
}
