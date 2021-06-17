
namespace Temperature
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.celsiusField = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fahrenheitField = new System.Windows.Forms.TextBox();
            this.kelvinField = new System.Windows.Forms.TextBox();
            this.сelsiusRButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitRButton = new System.Windows.Forms.RadioButton();
            this.kelvinRButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // celsiusField
            // 
            this.celsiusField.Location = new System.Drawing.Point(116, 12);
            this.celsiusField.Name = "celsiusField";
            this.celsiusField.PlaceholderText = "Celsius";
            this.celsiusField.Size = new System.Drawing.Size(113, 27);
            this.celsiusField.TabIndex = 0;
            this.celsiusField.TextChanged += new System.EventHandler(this.celsiusField_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(235, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(94, 95);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // fahrenheitField
            // 
            this.fahrenheitField.Location = new System.Drawing.Point(116, 45);
            this.fahrenheitField.Name = "fahrenheitField";
            this.fahrenheitField.PlaceholderText = "Fahrenheit";
            this.fahrenheitField.Size = new System.Drawing.Size(113, 27);
            this.fahrenheitField.TabIndex = 2;
            this.fahrenheitField.TextChanged += new System.EventHandler(this.fahrenheitField_TextChanged);
            // 
            // kelvinField
            // 
            this.kelvinField.Location = new System.Drawing.Point(116, 78);
            this.kelvinField.Name = "kelvinField";
            this.kelvinField.PlaceholderText = "Kelvin";
            this.kelvinField.Size = new System.Drawing.Size(113, 27);
            this.kelvinField.TabIndex = 3;
            this.kelvinField.TextChanged += new System.EventHandler(this.kelvinField_TextChanged);
            // 
            // сelsiusRButton
            // 
            this.сelsiusRButton.AutoSize = true;
            this.сelsiusRButton.Location = new System.Drawing.Point(13, 10);
            this.сelsiusRButton.Name = "сelsiusRButton";
            this.сelsiusRButton.Size = new System.Drawing.Size(73, 24);
            this.сelsiusRButton.TabIndex = 4;
            this.сelsiusRButton.TabStop = true;
            this.сelsiusRButton.Text = "сelsius";
            this.сelsiusRButton.UseVisualStyleBackColor = true;
            this.сelsiusRButton.CheckedChanged += new System.EventHandler(this.сelsiusRButton_CheckedChanged);
            // 
            // fahrenheitRButton
            // 
            this.fahrenheitRButton.AutoSize = true;
            this.fahrenheitRButton.Location = new System.Drawing.Point(13, 41);
            this.fahrenheitRButton.Name = "fahrenheitRButton";
            this.fahrenheitRButton.Size = new System.Drawing.Size(97, 24);
            this.fahrenheitRButton.TabIndex = 5;
            this.fahrenheitRButton.TabStop = true;
            this.fahrenheitRButton.Text = "fahrenheit";
            this.fahrenheitRButton.UseVisualStyleBackColor = true;
            this.fahrenheitRButton.CheckedChanged += new System.EventHandler(this.fahrenheitRButton_CheckedChanged);
            // 
            // kelvinRButton
            // 
            this.kelvinRButton.AutoSize = true;
            this.kelvinRButton.Location = new System.Drawing.Point(13, 72);
            this.kelvinRButton.Name = "kelvinRButton";
            this.kelvinRButton.Size = new System.Drawing.Size(68, 24);
            this.kelvinRButton.TabIndex = 6;
            this.kelvinRButton.TabStop = true;
            this.kelvinRButton.Text = "kelvin";
            this.kelvinRButton.UseVisualStyleBackColor = true;
            this.kelvinRButton.CheckedChanged += new System.EventHandler(this.kelvinRButton_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 113);
            this.Controls.Add(this.kelvinRButton);
            this.Controls.Add(this.fahrenheitRButton);
            this.Controls.Add(this.сelsiusRButton);
            this.Controls.Add(this.kelvinField);
            this.Controls.Add(this.fahrenheitField);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.celsiusField);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Temperature";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox celsiusField;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox fahrenheitField;
        private System.Windows.Forms.TextBox kelvinField;
        private System.Windows.Forms.RadioButton сelsiusRButton;
        private System.Windows.Forms.RadioButton fahrenheitRButton;
        private System.Windows.Forms.RadioButton kelvinRButton;
    }
}

