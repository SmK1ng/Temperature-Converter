using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        public Main()
        {
            InitializeComponent();
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

        }

        private void сelsiusRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                celsiusField.Text = 0.ToString();
                celsiusField.Focus();

                fahrenheitField.Text = 0.ToString();
                kelvinField.Text = 0.ToString();
                temperature.CelsiusProp = Convert.ToDouble(celsiusField.Text);
                flag = "сelsius";
            }
        }

        private void fahrenheitRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                fahrenheitField.Text = 0.ToString();
                fahrenheitField.Focus();

                celsiusField.Text = 0.ToString();
                kelvinField.Text = 0.ToString();
                temperature.FahrenheitProp = Convert.ToDouble(fahrenheitField.Text);
                flag = "fahrenheit";
            }
        }

        private void kelvinRButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                kelvinField.Text = 0.ToString();
                kelvinField.Focus();

                celsiusField.Text = 0.ToString();
                fahrenheitField.Text = 0.ToString();
                temperature.KelvinProp = Convert.ToDouble(kelvinField.Text);
                flag = "kelvin";
            }
        }

        private void celsiusField_TextChanged(object sender, EventArgs e)
        {
            
            temperature.CelsiusProp = Convert.ToDouble(celsiusField.Text);
        }

        private void fahrenheitField_TextChanged(object sender, EventArgs e)
        {
            temperature.FahrenheitProp = Convert.ToDouble(fahrenheitField.Text);
        }

        private void kelvinField_TextChanged(object sender, EventArgs e)
        {
            temperature.KelvinProp = Convert.ToDouble(kelvinField.Text);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConvertButtonClick(sender, e);
            }
        }
    }
}
