
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.celsiusField = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.fahrenheitField = new System.Windows.Forms.TextBox();
            this.kelvinField = new System.Windows.Forms.TextBox();
            this.сelsiusRButton = new System.Windows.Forms.RadioButton();
            this.fahrenheitRButton = new System.Windows.Forms.RadioButton();
            this.kelvinRButton = new System.Windows.Forms.RadioButton();
            this.logsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // celsiusField
            // 
            resources.ApplyResources(this.celsiusField, "celsiusField");
            this.celsiusField.Name = "celsiusField";
            this.celsiusField.TextChanged += new System.EventHandler(this.celsiusField_TextChanged);
            // 
            // convertButton
            // 
            resources.ApplyResources(this.convertButton, "convertButton");
            this.convertButton.Name = "convertButton";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // fahrenheitField
            // 
            resources.ApplyResources(this.fahrenheitField, "fahrenheitField");
            this.fahrenheitField.Name = "fahrenheitField";
            this.fahrenheitField.TextChanged += new System.EventHandler(this.fahrenheitField_TextChanged);
            // 
            // kelvinField
            // 
            resources.ApplyResources(this.kelvinField, "kelvinField");
            this.kelvinField.Name = "kelvinField";
            this.kelvinField.TextChanged += new System.EventHandler(this.kelvinField_TextChanged);
            // 
            // сelsiusRButton
            // 
            resources.ApplyResources(this.сelsiusRButton, "сelsiusRButton");
            this.сelsiusRButton.Checked = true;
            this.сelsiusRButton.Name = "сelsiusRButton";
            this.сelsiusRButton.TabStop = true;
            this.сelsiusRButton.UseVisualStyleBackColor = true;
            this.сelsiusRButton.CheckedChanged += new System.EventHandler(this.сelsiusRButton_CheckedChanged);
            // 
            // fahrenheitRButton
            // 
            resources.ApplyResources(this.fahrenheitRButton, "fahrenheitRButton");
            this.fahrenheitRButton.Name = "fahrenheitRButton";
            this.fahrenheitRButton.UseVisualStyleBackColor = true;
            this.fahrenheitRButton.CheckedChanged += new System.EventHandler(this.fahrenheitRButton_CheckedChanged);
            // 
            // kelvinRButton
            // 
            resources.ApplyResources(this.kelvinRButton, "kelvinRButton");
            this.kelvinRButton.Name = "kelvinRButton";
            this.kelvinRButton.UseVisualStyleBackColor = true;
            this.kelvinRButton.CheckedChanged += new System.EventHandler(this.kelvinRButton_CheckedChanged);
            // 
            // logsButton
            // 
            resources.ApplyResources(this.logsButton, "logsButton");
            this.logsButton.Name = "logsButton";
            this.logsButton.UseVisualStyleBackColor = true;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logsButton);
            this.Controls.Add(this.kelvinRButton);
            this.Controls.Add(this.fahrenheitRButton);
            this.Controls.Add(this.сelsiusRButton);
            this.Controls.Add(this.kelvinField);
            this.Controls.Add(this.fahrenheitField);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.celsiusField);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
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
        private System.Windows.Forms.Button logsButton;
    }
}

