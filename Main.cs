using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Main : Form
    {

        Temperature temperature = new Temperature();
        string flag;
        double dbl;
        bool success;

        public Main()
        {
            InitializeComponent();

            celsiusField.Text = 0.ToString();
            fahrenheitField.Text = 0.ToString();
            kelvinField.Text = 0.ToString();

            flag = "сelsius";
        }

        private void ConvertButtonClick(object sender, EventArgs e)
        {
            if (celsiusField.Text == string.Empty && 
                fahrenheitField.Text == string.Empty &&
                kelvinField.Text == string.Empty)
            {
                MessageBox.Show("Enter temperature");
                return;
            }

            if (Double.TryParse(celsiusField.Text, out dbl) &&
                Double.TryParse(fahrenheitField.Text, out dbl) &&
                Double.TryParse(kelvinField.Text, out dbl))
            {
                if (flag == "сelsius")
                {
                    fahrenheitField.Text = temperature.CelsiuisToFahrenheit().ToString();
                    kelvinField.Text = temperature.CelsiuisToKelvin().ToString();
                }

                if (flag == "fahrenheit")
                {
                    celsiusField.Text = temperature.FahrenheitToCelsiuis().ToString();
                    kelvinField.Text = temperature.FahrenheitToKelvin().ToString();
                }

                if (flag == "kelvin")
                {
                    celsiusField.Text = temperature.KelvinToCelsiuis().ToString();
                    fahrenheitField.Text = temperature.KelvinToFahrenheit().ToString();
                }

                Loger.Log(celsiusField.Text, fahrenheitField.Text, kelvinField.Text);
                
            }
            else
            {
                if (Double.TryParse(celsiusField.Text, out dbl) == false)
                    celsiusField.Text = 0.ToString();

                if (Double.TryParse(fahrenheitField.Text, out dbl) == false)
                    fahrenheitField.Text = 0.ToString();

                if(Double.TryParse(kelvinField.Text, out dbl) == false)
                    kelvinField.Text = 0.ToString();

                MessageBox.Show("Invalid input format");
            }
        }

        private void сelsiusRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                celsiusField.Focus();
                success = Double.TryParse(celsiusField.Text, out dbl);
                if (success)
                {
                    temperature.CelsiusProp = dbl;
                    flag = "сelsius";
                }
                else
                {
                    MessageBox.Show("Invalid input format");
                }
            }
        }

        private void fahrenheitRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                fahrenheitField.Focus();
                success = Double.TryParse(fahrenheitField.Text, out dbl);
                if (success)
                {
                    temperature.FahrenheitProp = dbl;
                    flag = "fahrenheit";
                }
                else
                {
                    MessageBox.Show("Invalid input format");
                }
            }
        }

        private void kelvinRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                kelvinField.Focus();
                success = Double.TryParse(kelvinField.Text, out dbl);
                if (success)
                {
                    temperature.KelvinProp = dbl;
                    flag = "kelvin";
                }
                else
                {
                    MessageBox.Show("Invalid input format");
                }
            }
        }

        private void celsiusField_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(celsiusField.Text, out dbl);
            temperature.CelsiusProp = dbl;
        }

        private void fahrenheitField_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(fahrenheitField.Text, out dbl);
            temperature.FahrenheitProp = dbl;
        }

        private void kelvinField_TextChanged(object sender, EventArgs e)
        {
            Double.TryParse(kelvinField.Text, out dbl);
            temperature.KelvinProp = dbl;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConvertButtonClick(sender, e);
            }
        }

        private void logsButton_Click(object sender, EventArgs e)
        {
            Log log = new Log();
            
            if (log.ReadingFromFile())
            {
                log.Show();
            }
        }
    }
}
