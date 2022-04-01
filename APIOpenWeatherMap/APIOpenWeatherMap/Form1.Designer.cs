namespace APIOpenWeatherMap
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tempReal = new System.Windows.Forms.Label();
            this.tempFeelLike = new System.Windows.Forms.Label();
            this.whenDay = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.minTemp = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LongSolsticeDay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dayLengthHours = new System.Windows.Forms.Label();
            this.dayLengthMinutes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Проверить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Температура \"Реальная\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Температура \"Ощущаемая\"";
            // 
            // tempReal
            // 
            this.tempReal.AutoSize = true;
            this.tempReal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempReal.Location = new System.Drawing.Point(57, 41);
            this.tempReal.Name = "tempReal";
            this.tempReal.Size = new System.Drawing.Size(19, 21);
            this.tempReal.TabIndex = 3;
            this.tempReal.Text = "0";
            // 
            // tempFeelLike
            // 
            this.tempFeelLike.AutoSize = true;
            this.tempFeelLike.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tempFeelLike.Location = new System.Drawing.Point(261, 41);
            this.tempFeelLike.Name = "tempFeelLike";
            this.tempFeelLike.Size = new System.Drawing.Size(19, 21);
            this.tempFeelLike.TabIndex = 4;
            this.tempFeelLike.Text = "0";
            // 
            // whenDay
            // 
            this.whenDay.AutoSize = true;
            this.whenDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.whenDay.Location = new System.Drawing.Point(685, 41);
            this.whenDay.Name = "whenDay";
            this.whenDay.Size = new System.Drawing.Size(19, 21);
            this.whenDay.TabIndex = 5;
            this.whenDay.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(685, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(439, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Минимальная разница";
            // 
            // minTemp
            // 
            this.minTemp.AutoSize = true;
            this.minTemp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minTemp.Location = new System.Drawing.Point(439, 41);
            this.minTemp.Name = "minTemp";
            this.minTemp.Size = new System.Drawing.Size(19, 21);
            this.minTemp.TabIndex = 8;
            this.minTemp.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Найти дату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(-1, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "День когда солнце стоянии будет долгим";
            // 
            // LongSolsticeDay
            // 
            this.LongSolsticeDay.AutoSize = true;
            this.LongSolsticeDay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LongSolsticeDay.Location = new System.Drawing.Point(-1, 258);
            this.LongSolsticeDay.Name = "LongSolsticeDay";
            this.LongSolsticeDay.Size = new System.Drawing.Size(19, 21);
            this.LongSolsticeDay.TabIndex = 11;
            this.LongSolsticeDay.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(424, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Продолжительность";
            // 
            // dayLengthHours
            // 
            this.dayLengthHours.AutoSize = true;
            this.dayLengthHours.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayLengthHours.Location = new System.Drawing.Point(439, 258);
            this.dayLengthHours.Name = "dayLengthHours";
            this.dayLengthHours.Size = new System.Drawing.Size(19, 21);
            this.dayLengthHours.TabIndex = 13;
            this.dayLengthHours.Text = "0";
            // 
            // dayLengthMinutes
            // 
            this.dayLengthMinutes.AutoSize = true;
            this.dayLengthMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dayLengthMinutes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dayLengthMinutes.Location = new System.Drawing.Point(524, 258);
            this.dayLengthMinutes.Name = "dayLengthMinutes";
            this.dayLengthMinutes.Size = new System.Drawing.Size(19, 21);
            this.dayLengthMinutes.TabIndex = 15;
            this.dayLengthMinutes.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(478, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 46);
            this.label8.TabIndex = 16;
            this.label8.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 418);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dayLengthMinutes);
            this.Controls.Add(this.dayLengthHours);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LongSolsticeDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.minTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.whenDay);
            this.Controls.Add(this.tempFeelLike);
            this.Controls.Add(this.tempReal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "API + openweathermap.org";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label tempReal;
        private Label tempFeelLike;
        private Label whenDay;
        private Label label3;
        private Label label4;
        private Label minTemp;
        private Button button2;
        private Label label5;
        private Label LongSolsticeDay;
        private Label label6;
        private Label dayLengthHours;
        private Label dayLengthMinutes;
        private Label label8;
    }
}