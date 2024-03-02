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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.form = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.humidity = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.rain = new System.Windows.Forms.Label();
            this.cloud = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.templabel = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.locationbox = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.snow = new System.Windows.Forms.Label();
            this.form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.White;
            this.form.Controls.Add(this.snow);
            this.form.Controls.Add(this.pictureBox6);
            this.form.Controls.Add(this.pictureBox5);
            this.form.Controls.Add(this.pictureBox4);
            this.form.Controls.Add(this.panel1);
            this.form.Controls.Add(this.panel2);
            this.form.Controls.Add(this.heading);
            this.form.Controls.Add(this.city);
            this.form.Controls.Add(this.rain);
            this.form.Controls.Add(this.cloud);
            this.form.Controls.Add(this.time);
            this.form.Controls.Add(this.templabel);
            this.form.Controls.Add(this.image);
            this.form.Controls.Add(this.searchbtn);
            this.form.Controls.Add(this.locationbox);
            this.form.Location = new System.Drawing.Point(24, 27);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(1117, 441);
            this.form.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(14, 353);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(47, 39);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(14, 305);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 39);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.humidity);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(808, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 173);
            this.panel1.TabIndex = 10;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(140, 74);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(30, 16);
            this.humidity.TabIndex = 13;
            this.humidity.Text = "N/A";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(16, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 103);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Humidity";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.sunrise);
            this.panel2.Controls.Add(this.sunset);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(442, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 173);
            this.panel2.TabIndex = 9;
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.Location = new System.Drawing.Point(92, 47);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(30, 16);
            this.sunrise.TabIndex = 10;
            this.sunrise.Text = "N/A";
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.Location = new System.Drawing.Point(92, 119);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(30, 16);
            this.sunset.TabIndex = 11;
            this.sunset.Text = "N/A";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 70);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sunrise and Sunset";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // heading
            // 
            this.heading.AllowDrop = true;
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(451, 69);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(264, 32);
            this.heading.TabIndex = 8;
            this.heading.Text = "Today\'s Highlights";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(20, 395);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(30, 16);
            this.city.TabIndex = 7;
            this.city.Text = "N/A";
            // 
            // rain
            // 
            this.rain.AutoSize = true;
            this.rain.Location = new System.Drawing.Point(67, 364);
            this.rain.Name = "rain";
            this.rain.Size = new System.Drawing.Size(30, 16);
            this.rain.TabIndex = 6;
            this.rain.Text = "N/A";
            // 
            // cloud
            // 
            this.cloud.AutoSize = true;
            this.cloud.Location = new System.Drawing.Point(67, 318);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(30, 16);
            this.cloud.TabIndex = 5;
            this.cloud.Text = "N/A";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(93, 280);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(30, 16);
            this.time.TabIndex = 4;
            this.time.Text = "N/A";
            // 
            // templabel
            // 
            this.templabel.AutoSize = true;
            this.templabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templabel.Location = new System.Drawing.Point(93, 242);
            this.templabel.Name = "templabel";
            this.templabel.Size = new System.Drawing.Size(43, 22);
            this.templabel.TabIndex = 3;
            this.templabel.Text = "N/A";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(23, 81);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(215, 136);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            this.image.WaitOnLoad = true;
            // 
            // searchbtn
            // 
            this.searchbtn.AccessibleName = "searchbtn";
            this.searchbtn.Location = new System.Drawing.Point(276, 20);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 24);
            this.searchbtn.TabIndex = 1;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // locationbox
            // 
            this.locationbox.AccessibleName = "locationbox";
            this.locationbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationbox.Location = new System.Drawing.Point(23, 20);
            this.locationbox.Name = "locationbox";
            this.locationbox.Size = new System.Drawing.Size(215, 24);
            this.locationbox.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(156, 353);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 39);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // snow
            // 
            this.snow.AutoSize = true;
            this.snow.Location = new System.Drawing.Point(218, 364);
            this.snow.Name = "snow";
            this.snow.Size = new System.Drawing.Size(30, 16);
            this.snow.TabIndex = 14;
            this.snow.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 480);
            this.Controls.Add(this.form);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.TextBox locationbox;
        public System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label templabel;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label cloud;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label rain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label snow;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

