using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        public bool ReadingFromFile()
        {
            string readPath = @"log.txt";

            if (File.Exists(readPath))
            {
                string text = System.IO.File.ReadAllText(readPath);
                logsTextBox.Text = text;
                return true;
            }
            else
            {
                MessageBox.Show("File does not exist");
                return false;
            }
        }
    }
}
