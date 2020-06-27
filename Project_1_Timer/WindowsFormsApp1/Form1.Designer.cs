namespace OneHourTimer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Label();
            this.timerLengthMinutes = new System.Windows.Forms.ComboBox();
            this.timerLengthSeconds = new System.Windows.Forms.ComboBox();
            this.Minutes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(95, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(188, 99);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Put Timer in minutes and press start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Remaining ";
            // 
            // countdownTimer
            // 
            this.countdownTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownTimer.ForeColor = System.Drawing.Color.Maroon;
            this.countdownTimer.Location = new System.Drawing.Point(159, 73);
            this.countdownTimer.Name = "countdownTimer";
            this.countdownTimer.Size = new System.Drawing.Size(284, 108);
            this.countdownTimer.TabIndex = 5;
            this.countdownTimer.Text = "00:00";
            // 
            // timerLengthMinutes
            // 
            this.timerLengthMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLengthMinutes.FormattingEnabled = true;
            this.timerLengthMinutes.Location = new System.Drawing.Point(162, 245);
            this.timerLengthMinutes.Name = "timerLengthMinutes";
            this.timerLengthMinutes.Size = new System.Drawing.Size(121, 28);
            this.timerLengthMinutes.TabIndex = 6;
            // 
            // timerLengthSeconds
            // 
            this.timerLengthSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLengthSeconds.FormattingEnabled = true;
            this.timerLengthSeconds.Location = new System.Drawing.Point(370, 242);
            this.timerLengthSeconds.Name = "timerLengthSeconds";
            this.timerLengthSeconds.Size = new System.Drawing.Size(121, 28);
            this.timerLengthSeconds.TabIndex = 7;
            // 
            // Minutes
            // 
            this.Minutes.AutoSize = true;
            this.Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutes.Location = new System.Drawing.Point(91, 245);
            this.Minutes.Name = "Minutes";
            this.Minutes.Size = new System.Drawing.Size(65, 20);
            this.Minutes.TabIndex = 8;
            this.Minutes.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Seconds";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(303, 289);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(188, 99);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 425);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minutes);
            this.Controls.Add(this.timerLengthSeconds);
            this.Controls.Add(this.timerLengthMinutes);
            this.Controls.Add(this.countdownTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "One Hour Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countdownTimer;
        private System.Windows.Forms.ComboBox timerLengthMinutes;
        private System.Windows.Forms.ComboBox timerLengthSeconds;
        private System.Windows.Forms.Label Minutes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer;
    }
}

