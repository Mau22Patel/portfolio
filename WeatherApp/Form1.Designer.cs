namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label sunsetLabel;
            this.cityLabel = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.WindSpeedlabel = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.PreasureLabel = new System.Windows.Forms.Label();
            this.sundriseLabel = new System.Windows.Forms.Label();
            this.lblSunrise = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSunset = new System.Windows.Forms.Label();
            sunsetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sunsetLabel
            // 
            sunsetLabel.AutoSize = true;
            sunsetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sunsetLabel.Location = new System.Drawing.Point(697, 361);
            sunsetLabel.Name = "sunsetLabel";
            sunsetLabel.Size = new System.Drawing.Size(93, 29);
            sunsetLabel.TabIndex = 10;
            sunsetLabel.Text = "Sunset:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(398, 70);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(63, 32);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(782, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(467, 80);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(309, 22);
            this.txtCity.TabIndex = 2;
            this.txtCity.TabStop = false;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(467, 134);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(309, 123);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(795, 174);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 32);
            this.lblTemp.TabIndex = 4;
            // 
            // WindSpeedlabel
            // 
            this.WindSpeedlabel.AutoSize = true;
            this.WindSpeedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindSpeedlabel.Location = new System.Drawing.Point(399, 301);
            this.WindSpeedlabel.Name = "WindSpeedlabel";
            this.WindSpeedlabel.Size = new System.Drawing.Size(158, 29);
            this.WindSpeedlabel.TabIndex = 5;
            this.WindSpeedlabel.Text = "Wind Speed: ";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(574, 371);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(44, 16);
            this.lblPressure.TabIndex = 6;
            this.lblPressure.Text = "label4";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(574, 311);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(44, 16);
            this.lblWind.TabIndex = 7;
            this.lblWind.Text = "label5";
            // 
            // PreasureLabel
            // 
            this.PreasureLabel.AutoSize = true;
            this.PreasureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreasureLabel.Location = new System.Drawing.Point(399, 358);
            this.PreasureLabel.Name = "PreasureLabel";
            this.PreasureLabel.Size = new System.Drawing.Size(117, 29);
            this.PreasureLabel.TabIndex = 8;
            this.PreasureLabel.Text = "Preasure:";
            // 
            // sundriseLabel
            // 
            this.sundriseLabel.AutoSize = true;
            this.sundriseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sundriseLabel.Location = new System.Drawing.Point(695, 304);
            this.sundriseLabel.Name = "sundriseLabel";
            this.sundriseLabel.Size = new System.Drawing.Size(101, 29);
            this.sundriseLabel.TabIndex = 9;
            this.sundriseLabel.Text = "Sunrise:";
            // 
            // lblSunrise
            // 
            this.lblSunrise.AutoSize = true;
            this.lblSunrise.Location = new System.Drawing.Point(822, 311);
            this.lblSunrise.Name = "lblSunrise";
            this.lblSunrise.Size = new System.Drawing.Size(44, 16);
            this.lblSunrise.TabIndex = 11;
            this.lblSunrise.Text = "label7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(777, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = " ";
            // 
            // lblSunset
            // 
            this.lblSunset.AutoSize = true;
            this.lblSunset.Location = new System.Drawing.Point(815, 368);
            this.lblSunset.Name = "lblSunset";
            this.lblSunset.Size = new System.Drawing.Size(51, 16);
            this.lblSunset.TabIndex = 14;
            this.lblSunset.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 519);
            this.Controls.Add(this.lblSunset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSunrise);
            this.Controls.Add(sunsetLabel);
            this.Controls.Add(this.sundriseLabel);
            this.Controls.Add(this.PreasureLabel);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.WindSpeedlabel);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cityLabel);
            this.Name = "Form1";
            this.Tag = " ";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label WindSpeedlabel;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label PreasureLabel;
        private System.Windows.Forms.Label sundriseLabel;
        private System.Windows.Forms.Label lblSunrise;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSunset;
    }
}

