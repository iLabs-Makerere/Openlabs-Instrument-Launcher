namespace oscilloscope_Serial_test
{
    partial class F_Gen
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
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.wave_Type = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.run_fgen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(152, 12);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(120, 20);
            this.frequency.TabIndex = 0;
            // 
            // wave_Type
            // 
            this.wave_Type.FormattingEnabled = true;
            this.wave_Type.Items.AddRange(new object[] {
            "SINE WAVE",
            "SQUARE WAVE"});
            this.wave_Type.Location = new System.Drawing.Point(13, 10);
            this.wave_Type.Name = "wave_Type";
            this.wave_Type.Size = new System.Drawing.Size(121, 21);
            this.wave_Type.TabIndex = 1;
            this.wave_Type.Text = "Wave";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(13, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 206);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // run_fgen
            // 
            this.run_fgen.Location = new System.Drawing.Point(152, 64);
            this.run_fgen.Name = "run_fgen";
            this.run_fgen.Size = new System.Drawing.Size(75, 23);
            this.run_fgen.TabIndex = 5;
            this.run_fgen.Text = "RUN";
            this.run_fgen.UseVisualStyleBackColor = true;
            this.run_fgen.Click += new System.EventHandler(this.run_fgen_Click);
            // 
            // F_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.run_fgen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wave_Type);
            this.Controls.Add(this.frequency);
            this.Name = "F_Gen";
            this.Text = "F_Gen";
            this.Load += new System.EventHandler(this.F_Gen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.ComboBox wave_Type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button run_fgen;

    }
}