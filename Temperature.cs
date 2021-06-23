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
            var result = celsius * 1.8 + 32;
            return Math.Round(result, 5);
        }

        public double CelsiuisToKelvin()
        {
            var result = celsius + 273.15;
            return Math.Round(result, 5);
        }

        public double FahrenheitToCelsiuis()
        {
            var result = (fahrenheit - 32) / 1.8;
            return Math.Round(result, 5);
        }

        public double FahrenheitToKelvin()
        {
            var result = (fahrenheit + 459.67) / 1.8;
            return Math.Round(result, 5);
        }

        public double KelvinToCelsiuis()
        {
            var result = kelvin - 273.15;
            return Math.Round(result, 5);
        }

        public double KelvinToFahrenheit()
        {
            var result = kelvin * 1.8 - 459.67;
            return Math.Round(result, 5);
        }
    }
}
