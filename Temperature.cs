using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Temperature
    {
        private double celsius;
        private double fahrenheit;
        private double kelvin;

        public double CelsiusProp { get => celsius; set => celsius = value; }
        public double FahrenheitProp { get => fahrenheit; set => fahrenheit = value; }
        public double KelvinProp { get => kelvin; set => kelvin = value; }

        public double CelsiuisToFahrenheit()
        {
            return celsius * 1.8 + 32;
        }

        public double CelsiuisToKelvin()
        {
            return celsius + 273.15;
        }

        public double FahrenheitToCelsiuis()
        {
            return (fahrenheit - 32) / 1.8;
        }

        public double FahrenheitToKelvin()
        {
            return (fahrenheit + 459.67) / 1.8;
        }

        public double KelvinToCelsiuis()
        {
            return kelvin - 273.15;
        }

        public double KelvinToFahrenheit()
        {
            return kelvin * 1.8 - 459.67;
        }
    }
}
