namespace Form_Loan
{
    partial class FormGuess
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
            this.buttonGuess = new System.Windows.Forms.Button();
            this.buttonShowAnswer = new System.Windows.Forms.Button();
            this.labelShow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnter = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGuess
            // 
            this.buttonGuess.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonGuess.Location = new System.Drawing.Point(195, 252);
            this.buttonGuess.Name = "buttonGuess";
            this.buttonGuess.Size = new System.Drawing.Size(163, 43);
            this.buttonGuess.TabIndex = 0;
            this.buttonGuess.Text = "Guess";
            this.buttonGuess.UseVisualStyleBackColor = true;
            this.buttonGuess.Click += new System.EventHandler(this.buttonGuess_Click);
            // 
            // buttonShowAnswer
            // 
            this.buttonShowAnswer.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonShowAnswer.Location = new System.Drawing.Point(417, 252);
            this.buttonShowAnswer.Name = "buttonShowAnswer";
            this.buttonShowAnswer.Size = new System.Drawing.Size(165, 43);
            this.buttonShowAnswer.TabIndex = 1;
            this.buttonShowAnswer.Text = "Show Answer";
            this.buttonShowAnswer.UseVisualStyleBackColor = true;
            this.buttonShowAnswer.Click += new System.EventHandler(this.buttonShowAnswer_Click);
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelShow.Location = new System.Drawing.Point(47, 142);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(664, 37);
            this.labelShow.TabIndex = 2;
            this.labelShow.Text = "Please Select A Number Between 1 to 100!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxEnter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.buttonEnter);
            this.panel1.Location = new System.Drawing.Point(265, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 108);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(142, 19);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 0;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(142, 48);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please input a number.";
            // 
            // textBoxEnter
            // 
            this.textBoxEnter.Location = new System.Drawing.Point(26, 50);
            this.textBoxEnter.Name = "textBoxEnter";
            this.textBoxEnter.Size = new System.Drawing.Size(100, 22);
            this.textBoxEnter.TabIndex = 3;
            // 
            // FormGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.buttonShowAnswer);
            this.Controls.Add(this.buttonGuess);
            this.Name = "FormGuess";
            this.Text = "Form Guess Number";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuess;
        private System.Windows.Forms.Button buttonShowAnswer;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button buttonEnter;
    }
}