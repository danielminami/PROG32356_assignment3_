using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG32356_assignment3 {
    public partial class Form1 : Form {

        private string errorMessage = "Enter a valid number.";
        private string output = string.Empty;
        public Form1() {
            InitializeComponent();
            footBtn.Checked = true;
            poundBtn.Checked = true;
            celsiusBtn.Checked = true;
            minBtn.Checked = true;
        }

        private void WeightOutput_Click(object sender, EventArgs e)
        {
            if (double.TryParse(weightTextBox.Text, out double number))
            {
                var weight = new Weight();
                output = poundBtn.Checked ? weight.PoundToKilogram(number).ToString() + " kg" : weight.KilogramToPound(number).ToString() + " lb";
            }
            else
            {
                output = errorMessage;
            }

            lengthOutput.Text = output;
        }

        private void TempOutput_Click(object sender, EventArgs e)
        {

            if (double.TryParse(lengthTextBox.Text, out double number))
            {
                var temperature = new Temperature();
                output = celsiusBtn.Checked ? temperature.CelsiusToFahrenheit(number).ToString() + " F" : temperature.FahrenheitToCelsius(number).ToString() + " C";
            }
            else
            {
                output = errorMessage;
            }

            lengthOutput.Text = output;
        }

        private void TimeOutput_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lengthTextBox.Text, out double number))
            {
                var time = new Time();
                output = minBtn.Checked ? time.MinuteToHour(number).ToString() + " hours" : time.HourToMinute(number).ToString() + " min";
            }
            else
            {
                output = errorMessage;
            }

            lengthOutput.Text = output;
        }

        private void LengthConvertBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lengthTextBox.Text, out double number))
            {
                var length = new Length(); 
                output = footBtn.Checked ? string.Format("{0:N2}", length.FootToMeter(number) + " m") : string.Format("{0:N2}", length.MeterToFoot(number) + " ft");
            }
            else
            {
                output = errorMessage;
            }

            lengthOutput.Text = output;
        }

    }
}
