namespace Form_Loan
{
    partial class FormAlarm
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
            this.labelNow = new System.Windows.Forms.Label();
            this.labelAlarmTime = new System.Windows.Forms.Label();
            this.groupBoxSelectTime = new System.Windows.Forms.GroupBox();
            this.buttonSetAlarm = new System.Windows.Forms.Button();
            this.labelSec = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.textBoxSec = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxHour = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxSelectTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelNow.Location = new System.Drawing.Point(127, 66);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(0, 37);
            this.labelNow.TabIndex = 0;
            // 
            // labelAlarmTime
            // 
            this.labelAlarmTime.AutoSize = true;
            this.labelAlarmTime.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelAlarmTime.Location = new System.Drawing.Point(194, 35);
            this.labelAlarmTime.Name = "labelAlarmTime";
            this.labelAlarmTime.Size = new System.Drawing.Size(111, 21);
            this.labelAlarmTime.TabIndex = 1;
            this.labelAlarmTime.Text = "Alarm Time:";
            // 
            // groupBoxSelectTime
            // 
            this.groupBoxSelectTime.Controls.Add(this.buttonSetAlarm);
            this.groupBoxSelectTime.Controls.Add(this.labelSec);
            this.groupBoxSelectTime.Controls.Add(this.labelMin);
            this.groupBoxSelectTime.Controls.Add(this.labelHour);
            this.groupBoxSelectTime.Controls.Add(this.textBoxSec);
            this.groupBoxSelectTime.Controls.Add(this.textBoxMin);
            this.groupBoxSelectTime.Controls.Add(this.textBoxHour);
            this.groupBoxSelectTime.Controls.Add(this.labelAlarmTime);
            this.groupBoxSelectTime.Location = new System.Drawing.Point(129, 178);
            this.groupBoxSelectTime.Name = "groupBoxSelectTime";
            this.groupBoxSelectTime.Size = new System.Drawing.Size(560, 211);
            this.groupBoxSelectTime.TabIndex = 2;
            this.groupBoxSelectTime.TabStop = false;
            this.groupBoxSelectTime.Text = "Select Time";
            // 
            // buttonSetAlarm
            // 
            this.buttonSetAlarm.Location = new System.Drawing.Point(230, 162);
            this.buttonSetAlarm.Name = "buttonSetAlarm";
            this.buttonSetAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonSetAlarm.TabIndex = 7;
            this.buttonSetAlarm.Text = "Set Alarm";
            this.buttonSetAlarm.UseVisualStyleBackColor = true;
            this.buttonSetAlarm.Click += new System.EventHandler(this.buttonSetAlarm_Click);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(498, 90);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(17, 12);
            this.labelSec.TabIndex = 6;
            this.labelSec.Text = "秒";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(311, 90);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(17, 12);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "分";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(136, 90);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(17, 12);
            this.labelHour.TabIndex = 3;
            this.labelHour.Text = "時";
            // 
            // textBoxSec
            // 
            this.textBoxSec.Location = new System.Drawing.Point(369, 87);
            this.textBoxSec.Name = "textBoxSec";
            this.textBoxSec.Size = new System.Drawing.Size(100, 22);
            this.textBoxSec.TabIndex = 4;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(191, 87);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin.TabIndex = 3;
            // 
            // textBoxHour
            // 
            this.textBoxHour.Location = new System.Drawing.Point(6, 87);
            this.textBoxHour.Name = "textBoxHour";
            this.textBoxHour.Size = new System.Drawing.Size(100, 22);
            this.textBoxHour.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxSelectTime);
            this.Controls.Add(this.labelNow);
            this.Name = "FormAlarm";
            this.Text = "Form Alarm";
            this.groupBoxSelectTime.ResumeLayout(false);
            this.groupBoxSelectTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.Label labelAlarmTime;
        private System.Windows.Forms.GroupBox groupBoxSelectTime;
        private System.Windows.Forms.Button buttonSetAlarm;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.TextBox textBoxSec;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxHour;
        private System.Windows.Forms.Timer timer1;
    }
}