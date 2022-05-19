
namespace laba6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(616, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(6, 208);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(283, 21);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "y = ((sin(x) + a * x)/((x – (x)^1/2) + 1))^b/x";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(6, 181);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(107, 21);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "y = a^(x + b)";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 154);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(94, 21);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "y = b * x^a";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 127);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(152, 21);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "y = a * ctg(x * b + c)";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(145, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "y = a * tg(x * b) + c";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(155, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "y = a * cos(x * b + c)";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "y=  a * sin(x * b) + c";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "y = x * a + b\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Build a graph";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(850, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(622, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 163);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variables";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Leave += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "X(отметить точку на грфике)=";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 10;
            this.textBox5.Leave += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "С=";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Leave += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(159, 26);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Leave += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "B=";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Leave += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "H(шаг)=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "A=";
            // 
            // chart1
            // 
            chartArea12.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chart1.Legends.Add(legend12);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.Red;
            series23.Legend = "Legend1";
            series23.LegendText = "Funtion";
            series23.Name = "Series1";
            series24.BorderWidth = 10;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Color = System.Drawing.Color.Black;
            series24.Legend = "Legend1";
            series24.LegendText = "Point";
            series24.Name = "Series2";
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(598, 365);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Чтобы отметиь точку, повторно нажмите кнопку\r\nBuild a graph\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 470);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label6;
    }
}

