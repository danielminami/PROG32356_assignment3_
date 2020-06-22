using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG32356_assignment3
{
    public partial class Form1 : Form
    {
        private readonly string invalidInput = "Enter a valid number.";
        private readonly string emptyInput = "Enter a number to convert.";
        private readonly string negativeTime = "Can not convert negative times.";
        private string output = string.Empty;
        public Form1()
        {
            InitializeComponent();

            footBtn.Checked = true;
            poundBtn.Checked = true;
            celsiusBtn.Checked = true;
            minBtn.Checked = true;
        }

        private void LengthConvertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lengthTextBox.Text))
            {

                if (double.TryParse(lengthTextBox.Text, out double number))
                {
                    var length = new Length();
                    output = footBtn.Checked ? length.FootToMeter(number).ToString() + " m" : length.MeterToFoot(number).ToString() + " ft";
                }
                else
                {
                    output = invalidInput;
                }
            }
            else
            {
                output = emptyInput;
            }
            lengthOutput.Text = output;
        }

        private void WeightConvertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(weightTextBox.Text))
            {
                if (double.TryParse(weightTextBox.Text, out double number))
                {
                    var weight = new Weight();
                    output = poundBtn.Checked ? weight.PoundToKilogram(number).ToString() + " kg" : weight.KilogramToPound(number).ToString() + " lb";
                }
                else
                {
                    output = invalidInput;
                }
            }
            else
            {
                output = emptyInput;
            }
            weightOutput.Text = output;
        }

        private void TempConvertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tempTextBox.Text))
            {
                if (double.TryParse(tempTextBox.Text, out double number))
                {
                    var temperature = new Temperature();
                    output = celsiusBtn.Checked ? temperature.CelsiusToFahrenheit(number).ToString() + " F" : temperature.FahrenheitToCelsius(number).ToString() + " C";
                }
                else
                {
                    output = invalidInput;
                }
            }
            else
            {
                output = emptyInput;
            }
            tempOutput.Text = output;
        }

        private void TimeConvertBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(timeTextBox.Text))
            {
                if (double.TryParse(timeTextBox.Text, out double number))
                {
                    var time = new Time();
                    output = minBtn.Checked ? time.MinuteToHour(number).ToString() + " hours" : time.HourToMinute(number).ToString() + " min";
                }
                else
                {
                    output = invalidInput;
                }
            }
            else
            {
                output = emptyInput;
            }
            timeOutput.Text = output;
        }
    }
}
