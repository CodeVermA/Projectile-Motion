
namespace Projectile_Motion___Final_Year
{
    partial class fm_questions
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
            this.bt_exit = new System.Windows.Forms.Button();
            this.lbl_introduction = new System.Windows.Forms.Label();
            this.lbl_questions = new System.Windows.Forms.Label();
            this.bt_nextQuestion = new System.Windows.Forms.Button();
            this.bt_previousQuestion = new System.Windows.Forms.Button();
            this.bt_changeNumbers = new System.Windows.Forms.Button();
            this.lbl_questionNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(13, 14);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lbl_introduction
            // 
            this.lbl_introduction.AutoSize = true;
            this.lbl_introduction.Location = new System.Drawing.Point(93, 114);
            this.lbl_introduction.Name = "lbl_introduction";
            this.lbl_introduction.Size = new System.Drawing.Size(104, 17);
            this.lbl_introduction.TabIndex = 1;
            this.lbl_introduction.Text = "lbl_introduction";
            // 
            // lbl_questions
            // 
            this.lbl_questions.AutoSize = true;
            this.lbl_questions.Location = new System.Drawing.Point(93, 154);
            this.lbl_questions.Name = "lbl_questions";
            this.lbl_questions.Size = new System.Drawing.Size(91, 17);
            this.lbl_questions.TabIndex = 2;
            this.lbl_questions.Text = "lbl_questions";
            // 
            // bt_nextQuestion
            // 
            this.bt_nextQuestion.Location = new System.Drawing.Point(871, 524);
            this.bt_nextQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_nextQuestion.Name = "bt_nextQuestion";
            this.bt_nextQuestion.Size = new System.Drawing.Size(119, 28);
            this.bt_nextQuestion.TabIndex = 3;
            this.bt_nextQuestion.Text = "NEXT QUES";
            this.bt_nextQuestion.UseVisualStyleBackColor = true;
            this.bt_nextQuestion.Click += new System.EventHandler(this.bt_nextQuestion_Click);
            // 
            // bt_previousQuestion
            // 
            this.bt_previousQuestion.Location = new System.Drawing.Point(13, 524);
            this.bt_previousQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_previousQuestion.Name = "bt_previousQuestion";
            this.bt_previousQuestion.Size = new System.Drawing.Size(152, 28);
            this.bt_previousQuestion.TabIndex = 4;
            this.bt_previousQuestion.Text = "PREVIOUS QUES";
            this.bt_previousQuestion.UseVisualStyleBackColor = true;
            this.bt_previousQuestion.Click += new System.EventHandler(this.bt_previousQuestion_Click);
            // 
            // bt_changeNumbers
            // 
            this.bt_changeNumbers.Location = new System.Drawing.Point(447, 15);
            this.bt_changeNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_changeNumbers.Name = "bt_changeNumbers";
            this.bt_changeNumbers.Size = new System.Drawing.Size(125, 42);
            this.bt_changeNumbers.TabIndex = 5;
            this.bt_changeNumbers.Text = "CHANGE NUMBERS";
            this.bt_changeNumbers.UseVisualStyleBackColor = true;
            // 
            // lbl_questionNumber
            // 
            this.lbl_questionNumber.AutoSize = true;
            this.lbl_questionNumber.Location = new System.Drawing.Point(93, 88);
            this.lbl_questionNumber.Name = "lbl_questionNumber";
            this.lbl_questionNumber.Size = new System.Drawing.Size(134, 17);
            this.lbl_questionNumber.TabIndex = 6;
            this.lbl_questionNumber.Text = "lbl_questionNumber";
            // 
            // fm_questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 567);
            this.Controls.Add(this.lbl_questionNumber);
            this.Controls.Add(this.bt_changeNumbers);
            this.Controls.Add(this.bt_previousQuestion);
            this.Controls.Add(this.bt_nextQuestion);
            this.Controls.Add(this.lbl_questions);
            this.Controls.Add(this.lbl_introduction);
            this.Controls.Add(this.bt_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fm_questions";
            this.Text = "fm_learnTopic";
            this.Load += new System.EventHandler(this.fm_learnTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label lbl_introduction;
        private System.Windows.Forms.Label lbl_questions;
        private System.Windows.Forms.Button bt_nextQuestion;
        private System.Windows.Forms.Button bt_previousQuestion;
        private System.Windows.Forms.Button bt_changeNumbers;
        private System.Windows.Forms.Label lbl_questionNumber;
    }
}