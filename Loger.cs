using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public static class Loger
    {
        public static void Log(string celsius, string fahrenheit, string kelvin)
        {
            string writePath = @"log.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"Time: {DateTime.Now}");
                    sw.WriteLine($"Celsius: {celsius} " +
                                 $"Fahrenheit: {fahrenheit} " +
                                 $"Kelvin: {kelvin} \n");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
