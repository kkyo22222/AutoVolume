namespace SetTimetoSleep
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowSystemTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FixTime = new System.Windows.Forms.Timer(this.components);
            this.Countdown = new System.Windows.Forms.Timer(this.components);
            this.CountdownLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FixTimeH = new System.Windows.Forms.NumericUpDown();
            this.FixTimeM = new System.Windows.Forms.NumericUpDown();
            this.CountDownH = new System.Windows.Forms.NumericUpDown();
            this.CountDownM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.FixTimeH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixTimeM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownM)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "定時";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Now Time";
            // 
            // ShowSystemTimeTimer
            // 
            this.ShowSystemTimeTimer.Interval = 1000;
            this.ShowSystemTimeTimer.Tick += new System.EventHandler(this.ShowSystemTimeTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "時";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "時";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(373, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "倒數";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "取消";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FixTime
            // 
            this.FixTime.Tick += new System.EventHandler(this.FixTime_Tick);
            // 
            // Countdown
            // 
            this.Countdown.Tick += new System.EventHandler(this.Countdown_Tick);
            // 
            // CountdownLabel
            // 
            this.CountdownLabel.AutoSize = true;
            this.CountdownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountdownLabel.Location = new System.Drawing.Point(49, 218);
            this.CountdownLabel.Name = "CountdownLabel";
            this.CountdownLabel.Size = new System.Drawing.Size(99, 40);
            this.CountdownLabel.TabIndex = 10;
            this.CountdownLabel.Text = "倒數:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "分";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "分";
            // 
            // FixTimeH
            // 
            this.FixTimeH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixTimeH.Location = new System.Drawing.Point(43, 124);
            this.FixTimeH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.FixTimeH.Name = "FixTimeH";
            this.FixTimeH.Size = new System.Drawing.Size(120, 35);
            this.FixTimeH.TabIndex = 13;
            this.FixTimeH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FixTimeM
            // 
            this.FixTimeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixTimeM.Location = new System.Drawing.Point(202, 126);
            this.FixTimeM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.FixTimeM.Name = "FixTimeM";
            this.FixTimeM.Size = new System.Drawing.Size(120, 35);
            this.FixTimeM.TabIndex = 14;
            this.FixTimeM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountDownH
            // 
            this.CountDownH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownH.Location = new System.Drawing.Point(43, 178);
            this.CountDownH.Name = "CountDownH";
            this.CountDownH.Size = new System.Drawing.Size(120, 35);
            this.CountDownH.TabIndex = 15;
            this.CountDownH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CountDownM
            // 
            this.CountDownM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDownM.Location = new System.Drawing.Point(202, 178);
            this.CountDownM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.CountDownM.Name = "CountDownM";
            this.CountDownM.Size = new System.Drawing.Size(120, 35);
            this.CountDownM.TabIndex = 16;
            this.CountDownM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 328);
            this.Controls.Add(this.CountDownM);
            this.Controls.Add(this.CountDownH);
            this.Controls.Add(this.FixTimeM);
            this.Controls.Add(this.FixTimeH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CountdownLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Sleep";
            ((System.ComponentModel.ISupportInitialize)(this.FixTimeH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FixTimeM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountDownM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer ShowSystemTimeTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer FixTime;
        private System.Windows.Forms.Timer Countdown;
        private System.Windows.Forms.Label CountdownLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown FixTimeH;
        private System.Windows.Forms.NumericUpDown FixTimeM;
        private System.Windows.Forms.NumericUpDown CountDownH;
        private System.Windows.Forms.NumericUpDown CountDownM;
    }
}

