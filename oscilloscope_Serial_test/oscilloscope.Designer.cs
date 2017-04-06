namespace oscilloscope_Serial_test
{
    partial class Oscilloscope
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine1 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serial_port = new System.Windows.Forms.ComboBox();
            this.open_port = new System.Windows.Forms.Button();
            this.close_port = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recieve_data = new System.Windows.Forms.Button();
            this.data_text = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.channel_0 = new System.Windows.Forms.GroupBox();
            this.check_channel0 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.channel_1 = new System.Windows.Forms.GroupBox();
            this.check_channel1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.channel_0.SuspendLayout();
            this.channel_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serial_port
            // 
            this.serial_port.FormattingEnabled = true;
            this.serial_port.Location = new System.Drawing.Point(174, 318);
            this.serial_port.Name = "serial_port";
            this.serial_port.Size = new System.Drawing.Size(121, 21);
            this.serial_port.TabIndex = 0;
            // 
            // open_port
            // 
            this.open_port.Location = new System.Drawing.Point(12, 318);
            this.open_port.Name = "open_port";
            this.open_port.Size = new System.Drawing.Size(75, 23);
            this.open_port.TabIndex = 1;
            this.open_port.Text = "Open";
            this.open_port.UseVisualStyleBackColor = true;
            this.open_port.Click += new System.EventHandler(this.open_port_Click);
            // 
            // close_port
            // 
            this.close_port.Location = new System.Drawing.Point(93, 318);
            this.close_port.Name = "close_port";
            this.close_port.Size = new System.Drawing.Size(75, 23);
            this.close_port.TabIndex = 2;
            this.close_port.Text = "Close";
            this.close_port.UseVisualStyleBackColor = true;
            this.close_port.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.recieve_data);
            this.groupBox1.Controls.Add(this.data_text);
            this.groupBox1.Location = new System.Drawing.Point(12, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 155);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // recieve_data
            // 
            this.recieve_data.Location = new System.Drawing.Point(77, 19);
            this.recieve_data.Name = "recieve_data";
            this.recieve_data.Size = new System.Drawing.Size(75, 23);
            this.recieve_data.TabIndex = 1;
            this.recieve_data.Text = "Recieve";
            this.recieve_data.UseVisualStyleBackColor = true;
            this.recieve_data.Click += new System.EventHandler(this.recieve_data_Click);
            // 
            // data_text
            // 
            this.data_text.Location = new System.Drawing.Point(47, 48);
            this.data_text.Multiline = true;
            this.data_text.Name = "data_text";
            this.data_text.Size = new System.Drawing.Size(157, 101);
            this.data_text.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX.CustomLabels.Add(customLabel1);
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Green;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisY.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisY.CustomLabels.Add(customLabel2);
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.AxisY.Maximum = 5D;
            chartArea1.AxisY.Minimum = -5D;
            stripLine1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            stripLine1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.AxisY.StripLines.Add(stripLine1);
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "channel_0";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "channel_1";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(480, 300);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click_2);
            // 
            // channel_0
            // 
            this.channel_0.Controls.Add(this.check_channel0);
            this.channel_0.Controls.Add(this.comboBox1);
            this.channel_0.Location = new System.Drawing.Point(492, 12);
            this.channel_0.Name = "channel_0";
            this.channel_0.Size = new System.Drawing.Size(155, 130);
            this.channel_0.TabIndex = 5;
            this.channel_0.TabStop = false;
            this.channel_0.Text = "Channel 0";
            // 
            // check_channel0
            // 
            this.check_channel0.AutoSize = true;
            this.check_channel0.Location = new System.Drawing.Point(6, 47);
            this.check_channel0.Name = "check_channel0";
            this.check_channel0.Size = new System.Drawing.Size(15, 14);
            this.check_channel0.TabIndex = 1;
            this.check_channel0.UseVisualStyleBackColor = true;
            this.check_channel0.CheckedChanged += new System.EventHandler(this.check_channel0_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Channel 0";
            // 
            // channel_1
            // 
            this.channel_1.Controls.Add(this.check_channel1);
            this.channel_1.Controls.Add(this.comboBox2);
            this.channel_1.Location = new System.Drawing.Point(662, 12);
            this.channel_1.Name = "channel_1";
            this.channel_1.Size = new System.Drawing.Size(155, 130);
            this.channel_1.TabIndex = 6;
            this.channel_1.TabStop = false;
            this.channel_1.Text = "Channel 1";
            // 
            // check_channel1
            // 
            this.check_channel1.AutoSize = true;
            this.check_channel1.Location = new System.Drawing.Point(7, 47);
            this.check_channel1.Name = "check_channel1";
            this.check_channel1.Size = new System.Drawing.Size(15, 14);
            this.check_channel1.TabIndex = 1;
            this.check_channel1.UseVisualStyleBackColor = true;
            this.check_channel1.CheckedChanged += new System.EventHandler(this.check_channel1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "Channel 1";
            // 
            // Oscilloscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.channel_1);
            this.Controls.Add(this.channel_0);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close_port);
            this.Controls.Add(this.open_port);
            this.Controls.Add(this.serial_port);
            this.Name = "Oscilloscope";
            this.Text = "Oscilloscope";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.channel_0.ResumeLayout(false);
            this.channel_0.PerformLayout();
            this.channel_1.ResumeLayout(false);
            this.channel_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serial_port;
        private System.Windows.Forms.Button open_port;
        private System.Windows.Forms.Button close_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button recieve_data;
        private System.Windows.Forms.TextBox data_text;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox channel_0;
        private System.Windows.Forms.CheckBox check_channel0;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox channel_1;
        private System.Windows.Forms.CheckBox check_channel1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

