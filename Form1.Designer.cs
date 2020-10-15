namespace BaseballQuiz
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
            this.lblMainText = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trkNumberQuestions = new System.Windows.Forms.TrackBar();
            this.chkInsane = new System.Windows.Forms.CheckBox();
            this.lblNumberQuestions = new System.Windows.Forms.Label();
            this.lblNumberQuestionsDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkNumberQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainText
            // 
            this.lblMainText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMainText.Location = new System.Drawing.Point(43, 12);
            this.lblMainText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMainText.Name = "lblMainText";
            this.lblMainText.Size = new System.Drawing.Size(680, 59);
            this.lblMainText.TabIndex = 0;
            this.lblMainText.Text = "Baseball Trivia Quiz!!!";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(14, 154);
            this.btn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 32);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(174, 154);
            this.btn2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 32);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(334, 154);
            this.btn3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(125, 32);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(494, 153);
            this.btn4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(125, 32);
            this.btn4.TabIndex = 4;
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(14, 286);
            this.btn5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(125, 32);
            this.btn5.TabIndex = 5;
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(174, 287);
            this.btn6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(125, 32);
            this.btn6.TabIndex = 6;
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(334, 287);
            this.btn7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(125, 32);
            this.btn7.TabIndex = 7;
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(494, 286);
            this.btn8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(125, 32);
            this.btn8.TabIndex = 8;
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(223, 274);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 100);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(63, 380);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(507, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // trkNumberQuestions
            // 
            this.trkNumberQuestions.Location = new System.Drawing.Point(223, 223);
            this.trkNumberQuestions.Name = "trkNumberQuestions";
            this.trkNumberQuestions.Size = new System.Drawing.Size(205, 45);
            this.trkNumberQuestions.TabIndex = 11;
            this.trkNumberQuestions.TickFrequency = 5;
            this.trkNumberQuestions.Value = 5;
            this.trkNumberQuestions.Scroll += new System.EventHandler(this.trkNumberQuestions_Scroll);
            // 
            // chkInsane
            // 
            this.chkInsane.AutoSize = true;
            this.chkInsane.Location = new System.Drawing.Point(414, 352);
            this.chkInsane.Name = "chkInsane";
            this.chkInsane.Size = new System.Drawing.Size(141, 22);
            this.chkInsane.TabIndex = 12;
            this.chkInsane.Text = "Insane mode?!!";
            this.chkInsane.UseVisualStyleBackColor = true;
            // 
            // lblNumberQuestions
            // 
            this.lblNumberQuestions.AutoSize = true;
            this.lblNumberQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lblNumberQuestions.Location = new System.Drawing.Point(43, 223);
            this.lblNumberQuestions.Name = "lblNumberQuestions";
            this.lblNumberQuestions.Size = new System.Drawing.Size(174, 18);
            this.lblNumberQuestions.TabIndex = 13;
            this.lblNumberQuestions.Text = "Number of Questions?";
            // 
            // lblNumberQuestionsDisplay
            // 
            this.lblNumberQuestionsDisplay.AutoSize = true;
            this.lblNumberQuestionsDisplay.Location = new System.Drawing.Point(298, 250);
            this.lblNumberQuestionsDisplay.Name = "lblNumberQuestionsDisplay";
            this.lblNumberQuestionsDisplay.Size = new System.Drawing.Size(0, 18);
            this.lblNumberQuestionsDisplay.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BaseballQuiz.Properties.Resources.chris_briggs_FobzAZJGM9M_unsplash;
            this.ClientSize = new System.Drawing.Size(633, 417);
            this.Controls.Add(this.lblNumberQuestionsDisplay);
            this.Controls.Add(this.lblNumberQuestions);
            this.Controls.Add(this.chkInsane);
            this.Controls.Add(this.trkNumberQuestions);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblMainText);
            this.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Baseball Trivia Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.trkNumberQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainText;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar trkNumberQuestions;
        private System.Windows.Forms.CheckBox chkInsane;
        private System.Windows.Forms.Label lblNumberQuestions;
        private System.Windows.Forms.Label lblNumberQuestionsDisplay;
    }
}

