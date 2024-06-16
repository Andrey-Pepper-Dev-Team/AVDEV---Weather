namespace AVDEV___Погода
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblCountry = new Label();
            lblPressure = new Label();
            lblHumadity = new Label();
            cboLanguage = new ComboBox();
            btnGetWeather = new Button();
            lblTemperature = new Label();
            lblDescription = new Label();
            lblCity = new Label();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // lblCountry
            // 
            resources.ApplyResources(lblCountry, "lblCountry");
            lblCountry.Name = "lblCountry";
            // 
            // lblPressure
            // 
            resources.ApplyResources(lblPressure, "lblPressure");
            lblPressure.Name = "lblPressure";
            // 
            // lblHumadity
            // 
            resources.ApplyResources(lblHumadity, "lblHumadity");
            lblHumadity.Name = "lblHumadity";
            // 
            // cboLanguage
            // 
            cboLanguage.FormattingEnabled = true;
            resources.ApplyResources(cboLanguage, "cboLanguage");
            cboLanguage.Name = "cboLanguage";
            // 
            // btnGetWeather
            // 
            resources.ApplyResources(btnGetWeather, "btnGetWeather");
            btnGetWeather.Name = "btnGetWeather";
            btnGetWeather.UseVisualStyleBackColor = true;
            btnGetWeather.Click += btnGetWeather_Click;
            // 
            // lblTemperature
            // 
            resources.ApplyResources(lblTemperature, "lblTemperature");
            lblTemperature.Name = "lblTemperature";
            // 
            // lblDescription
            // 
            resources.ApplyResources(lblDescription, "lblDescription");
            lblDescription.Name = "lblDescription";
            // 
            // lblCity
            // 
            resources.ApplyResources(lblCity, "lblCity");
            lblCity.Name = "lblCity";
            // 
            // txtCity
            // 
            resources.ApplyResources(txtCity, "txtCity");
            txtCity.Name = "txtCity";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCountry);
            Controls.Add(lblPressure);
            Controls.Add(lblHumadity);
            Controls.Add(cboLanguage);
            Controls.Add(btnGetWeather);
            Controls.Add(lblTemperature);
            Controls.Add(lblDescription);
            Controls.Add(lblCity);
            Controls.Add(txtCity);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCountry;
        private Label lblPressure;
        private Label lblHumadity;
        private ComboBox cboLanguage;
        private Button btnGetWeather;
        private Label lblTemperature;
        private Label lblDescription;
        private Label lblCity;
        private TextBox txtCity;
    }
}
