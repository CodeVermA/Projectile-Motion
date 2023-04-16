namespace Projectile_Motion___Final_Year
{
    partial class fm_CreateQuestions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_Save = new System.Windows.Forms.Button();
            this.lbl_Intro = new System.Windows.Forms.Label();
            this.txtbx_Intro = new System.Windows.Forms.TextBox();
            this.lbl_NumberOfQues = new System.Windows.Forms.Label();
            this.srlbar_Parts = new System.Windows.Forms.HScrollBar();
            this.lbl_PartsNum = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.dataGrid_MyQuestions = new System.Windows.Forms.DataGridView();
            this.clm_Introduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Questions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Export = new System.Windows.Forms.Button();
            this.cmbox_FileTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CharLimit = new System.Windows.Forms.Label();
            this.bt_DeleteQues = new System.Windows.Forms.Button();
            this.txtbx_question1 = new System.Windows.Forms.TextBox();
            this.lbl_question1 = new System.Windows.Forms.Label();
            this.txtbx_marks1 = new System.Windows.Forms.TextBox();
            this.txtbx_marks2 = new System.Windows.Forms.TextBox();
            this.lbl_question2 = new System.Windows.Forms.Label();
            this.txtbx_question2 = new System.Windows.Forms.TextBox();
            this.txtbx_marks3 = new System.Windows.Forms.TextBox();
            this.lbl_question3 = new System.Windows.Forms.Label();
            this.txtbx_question3 = new System.Windows.Forms.TextBox();
            this.txtbx_marks4 = new System.Windows.Forms.TextBox();
            this.lbl_question4 = new System.Windows.Forms.Label();
            this.txtbx_question4 = new System.Windows.Forms.TextBox();
            this.txtbx_marks5 = new System.Windows.Forms.TextBox();
            this.lbl_question5 = new System.Windows.Forms.Label();
            this.txtbx_question5 = new System.Windows.Forms.TextBox();
            this.lbl_Question = new System.Windows.Forms.Label();
            this.lbl_Mark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MyQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Save
            // 
            this.bt_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Save.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(170, 32);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(87, 36);
            this.bt_Save.TabIndex = 0;
            this.bt_Save.Text = "SAVE";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // lbl_Intro
            // 
            this.lbl_Intro.AutoSize = true;
            this.lbl_Intro.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intro.Location = new System.Drawing.Point(58, 146);
            this.lbl_Intro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Intro.Name = "lbl_Intro";
            this.lbl_Intro.Size = new System.Drawing.Size(131, 21);
            this.lbl_Intro.TabIndex = 1;
            this.lbl_Intro.Text = "INTRODUCTION:";
            // 
            // txtbx_Intro
            // 
            this.txtbx_Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Intro.Location = new System.Drawing.Point(211, 113);
            this.txtbx_Intro.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_Intro.MaxLength = 400;
            this.txtbx_Intro.Multiline = true;
            this.txtbx_Intro.Name = "txtbx_Intro";
            this.txtbx_Intro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Intro.Size = new System.Drawing.Size(368, 82);
            this.txtbx_Intro.TabIndex = 2;
            this.txtbx_Intro.TextChanged += new System.EventHandler(this.txtbx_Intro_TextChanged);
            // 
            // lbl_NumberOfQues
            // 
            this.lbl_NumberOfQues.AutoSize = true;
            this.lbl_NumberOfQues.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumberOfQues.Location = new System.Drawing.Point(12, 210);
            this.lbl_NumberOfQues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NumberOfQues.Name = "lbl_NumberOfQues";
            this.lbl_NumberOfQues.Size = new System.Drawing.Size(201, 21);
            this.lbl_NumberOfQues.TabIndex = 3;
            this.lbl_NumberOfQues.Text = "NUMBER OF QUESTIONS:";
            // 
            // srlbar_Parts
            // 
            this.srlbar_Parts.LargeChange = 1;
            this.srlbar_Parts.Location = new System.Drawing.Point(224, 214);
            this.srlbar_Parts.Maximum = 5;
            this.srlbar_Parts.Minimum = 1;
            this.srlbar_Parts.Name = "srlbar_Parts";
            this.srlbar_Parts.Size = new System.Drawing.Size(143, 17);
            this.srlbar_Parts.TabIndex = 4;
            this.srlbar_Parts.Value = 1;
            this.srlbar_Parts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srlbar_Parts_Scroll);
            // 
            // lbl_PartsNum
            // 
            this.lbl_PartsNum.AutoSize = true;
            this.lbl_PartsNum.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PartsNum.Location = new System.Drawing.Point(380, 215);
            this.lbl_PartsNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PartsNum.Name = "lbl_PartsNum";
            this.lbl_PartsNum.Size = new System.Drawing.Size(16, 16);
            this.lbl_PartsNum.TabIndex = 5;
            this.lbl_PartsNum.Text = "1";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Exit.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(13, 13);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(57, 34);
            this.bt_Exit.TabIndex = 7;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // dataGrid_MyQuestions
            // 
            this.dataGrid_MyQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_MyQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_MyQuestions.ColumnHeadersHeight = 29;
            this.dataGrid_MyQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_Introduction,
            this.clm_Questions,
            this.clm_Marks});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_MyQuestions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_MyQuestions.Location = new System.Drawing.Point(830, 32);
            this.dataGrid_MyQuestions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_MyQuestions.Name = "dataGrid_MyQuestions";
            this.dataGrid_MyQuestions.ReadOnly = true;
            this.dataGrid_MyQuestions.RowHeadersWidth = 20;
            this.dataGrid_MyQuestions.Size = new System.Drawing.Size(777, 662);
            this.dataGrid_MyQuestions.TabIndex = 8;
            // 
            // clm_Introduction
            // 
            this.clm_Introduction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clm_Introduction.HeaderText = "Introduction";
            this.clm_Introduction.MaxInputLength = 400;
            this.clm_Introduction.MinimumWidth = 6;
            this.clm_Introduction.Name = "clm_Introduction";
            this.clm_Introduction.ReadOnly = true;
            this.clm_Introduction.Width = 300;
            // 
            // clm_Questions
            // 
            this.clm_Questions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clm_Questions.HeaderText = "Questions";
            this.clm_Questions.MaxInputLength = 100;
            this.clm_Questions.MinimumWidth = 6;
            this.clm_Questions.Name = "clm_Questions";
            this.clm_Questions.ReadOnly = true;
            this.clm_Questions.Width = 300;
            // 
            // clm_Marks
            // 
            this.clm_Marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clm_Marks.HeaderText = "Marks";
            this.clm_Marks.MaxInputLength = 50;
            this.clm_Marks.MinimumWidth = 6;
            this.clm_Marks.Name = "clm_Marks";
            this.clm_Marks.ReadOnly = true;
            this.clm_Marks.Width = 125;
            // 
            // bt_Export
            // 
            this.bt_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Export.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Export.Location = new System.Drawing.Point(403, 32);
            this.bt_Export.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Export.Name = "bt_Export";
            this.bt_Export.Size = new System.Drawing.Size(105, 36);
            this.bt_Export.TabIndex = 9;
            this.bt_Export.Text = "EXPORT";
            this.bt_Export.UseVisualStyleBackColor = true;
            this.bt_Export.Click += new System.EventHandler(this.bt_Export_Click);
            // 
            // cmbox_FileTypes
            // 
            this.cmbox_FileTypes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbox_FileTypes.FormattingEnabled = true;
            this.cmbox_FileTypes.Items.AddRange(new object[] {
            "None",
            "Text File(.txt)",
            "Word File(.doc)",
            "Rich Text File(.rtf)"});
            this.cmbox_FileTypes.Location = new System.Drawing.Point(519, 43);
            this.cmbox_FileTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbox_FileTypes.Name = "cmbox_FileTypes";
            this.cmbox_FileTypes.Size = new System.Drawing.Size(160, 25);
            this.cmbox_FileTypes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "File Type:";
            // 
            // lbl_CharLimit
            // 
            this.lbl_CharLimit.AutoSize = true;
            this.lbl_CharLimit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CharLimit.Location = new System.Drawing.Point(208, 92);
            this.lbl_CharLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CharLimit.Name = "lbl_CharLimit";
            this.lbl_CharLimit.Size = new System.Drawing.Size(128, 17);
            this.lbl_CharLimit.TabIndex = 12;
            this.lbl_CharLimit.Text = "Char Left: 400/400";
            // 
            // bt_DeleteQues
            // 
            this.bt_DeleteQues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_DeleteQues.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteQues.Location = new System.Drawing.Point(265, 32);
            this.bt_DeleteQues.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DeleteQues.Name = "bt_DeleteQues";
            this.bt_DeleteQues.Size = new System.Drawing.Size(102, 36);
            this.bt_DeleteQues.TabIndex = 13;
            this.bt_DeleteQues.Text = "DELETE";
            this.bt_DeleteQues.UseVisualStyleBackColor = true;
            this.bt_DeleteQues.Click += new System.EventHandler(this.bt_DeleteQues_Click);
            // 
            // txtbx_question1
            // 
            this.txtbx_question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_question1.Location = new System.Drawing.Point(211, 285);
            this.txtbx_question1.MaxLength = 200;
            this.txtbx_question1.Multiline = true;
            this.txtbx_question1.Name = "txtbx_question1";
            this.txtbx_question1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_question1.Size = new System.Drawing.Size(280, 80);
            this.txtbx_question1.TabIndex = 14;
            // 
            // lbl_question1
            // 
            this.lbl_question1.AutoSize = true;
            this.lbl_question1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question1.Location = new System.Drawing.Point(176, 320);
            this.lbl_question1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question1.Name = "lbl_question1";
            this.lbl_question1.Size = new System.Drawing.Size(27, 20);
            this.lbl_question1.TabIndex = 15;
            this.lbl_question1.Text = "1:";
            // 
            // txtbx_marks1
            // 
            this.txtbx_marks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_marks1.Location = new System.Drawing.Point(509, 314);
            this.txtbx_marks1.Name = "txtbx_marks1";
            this.txtbx_marks1.Size = new System.Drawing.Size(64, 24);
            this.txtbx_marks1.TabIndex = 16;
            // 
            // txtbx_marks2
            // 
            this.txtbx_marks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_marks2.Location = new System.Drawing.Point(509, 400);
            this.txtbx_marks2.Name = "txtbx_marks2";
            this.txtbx_marks2.Size = new System.Drawing.Size(64, 24);
            this.txtbx_marks2.TabIndex = 19;
            // 
            // lbl_question2
            // 
            this.lbl_question2.AutoSize = true;
            this.lbl_question2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question2.Location = new System.Drawing.Point(176, 406);
            this.lbl_question2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question2.Name = "lbl_question2";
            this.lbl_question2.Size = new System.Drawing.Size(27, 20);
            this.lbl_question2.TabIndex = 18;
            this.lbl_question2.Text = "2:";
            // 
            // txtbx_question2
            // 
            this.txtbx_question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_question2.Location = new System.Drawing.Point(211, 371);
            this.txtbx_question2.MaxLength = 200;
            this.txtbx_question2.Multiline = true;
            this.txtbx_question2.Name = "txtbx_question2";
            this.txtbx_question2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_question2.Size = new System.Drawing.Size(280, 80);
            this.txtbx_question2.TabIndex = 17;
            // 
            // txtbx_marks3
            // 
            this.txtbx_marks3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_marks3.Location = new System.Drawing.Point(509, 486);
            this.txtbx_marks3.Name = "txtbx_marks3";
            this.txtbx_marks3.Size = new System.Drawing.Size(64, 24);
            this.txtbx_marks3.TabIndex = 22;
            // 
            // lbl_question3
            // 
            this.lbl_question3.AutoSize = true;
            this.lbl_question3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question3.Location = new System.Drawing.Point(176, 492);
            this.lbl_question3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question3.Name = "lbl_question3";
            this.lbl_question3.Size = new System.Drawing.Size(27, 20);
            this.lbl_question3.TabIndex = 21;
            this.lbl_question3.Text = "3:";
            // 
            // txtbx_question3
            // 
            this.txtbx_question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_question3.Location = new System.Drawing.Point(211, 457);
            this.txtbx_question3.MaxLength = 200;
            this.txtbx_question3.Multiline = true;
            this.txtbx_question3.Name = "txtbx_question3";
            this.txtbx_question3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_question3.Size = new System.Drawing.Size(280, 80);
            this.txtbx_question3.TabIndex = 20;
            // 
            // txtbx_marks4
            // 
            this.txtbx_marks4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_marks4.Location = new System.Drawing.Point(509, 572);
            this.txtbx_marks4.Name = "txtbx_marks4";
            this.txtbx_marks4.Size = new System.Drawing.Size(64, 24);
            this.txtbx_marks4.TabIndex = 25;
            // 
            // lbl_question4
            // 
            this.lbl_question4.AutoSize = true;
            this.lbl_question4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question4.Location = new System.Drawing.Point(176, 572);
            this.lbl_question4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question4.Name = "lbl_question4";
            this.lbl_question4.Size = new System.Drawing.Size(27, 20);
            this.lbl_question4.TabIndex = 24;
            this.lbl_question4.Text = "4:";
            // 
            // txtbx_question4
            // 
            this.txtbx_question4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_question4.Location = new System.Drawing.Point(211, 543);
            this.txtbx_question4.MaxLength = 200;
            this.txtbx_question4.Multiline = true;
            this.txtbx_question4.Name = "txtbx_question4";
            this.txtbx_question4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_question4.Size = new System.Drawing.Size(280, 80);
            this.txtbx_question4.TabIndex = 23;
            // 
            // txtbx_marks5
            // 
            this.txtbx_marks5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_marks5.Location = new System.Drawing.Point(509, 658);
            this.txtbx_marks5.Name = "txtbx_marks5";
            this.txtbx_marks5.Size = new System.Drawing.Size(64, 24);
            this.txtbx_marks5.TabIndex = 28;
            // 
            // lbl_question5
            // 
            this.lbl_question5.AutoSize = true;
            this.lbl_question5.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question5.Location = new System.Drawing.Point(176, 658);
            this.lbl_question5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_question5.Name = "lbl_question5";
            this.lbl_question5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_question5.Size = new System.Drawing.Size(27, 20);
            this.lbl_question5.TabIndex = 27;
            this.lbl_question5.Text = "5:";
            // 
            // txtbx_question5
            // 
            this.txtbx_question5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_question5.Location = new System.Drawing.Point(211, 629);
            this.txtbx_question5.MaxLength = 200;
            this.txtbx_question5.Multiline = true;
            this.txtbx_question5.Name = "txtbx_question5";
            this.txtbx_question5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_question5.Size = new System.Drawing.Size(280, 80);
            this.txtbx_question5.TabIndex = 26;
            // 
            // lbl_Question
            // 
            this.lbl_Question.AutoSize = true;
            this.lbl_Question.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Question.Location = new System.Drawing.Point(249, 252);
            this.lbl_Question.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Question.Name = "lbl_Question";
            this.lbl_Question.Size = new System.Drawing.Size(204, 21);
            this.lbl_Question.TabIndex = 29;
            this.lbl_Question.Text = "QUESTION(200 Char Max)";
            // 
            // lbl_Mark
            // 
            this.lbl_Mark.AutoSize = true;
            this.lbl_Mark.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mark.Location = new System.Drawing.Point(515, 252);
            this.lbl_Mark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mark.Name = "lbl_Mark";
            this.lbl_Mark.Size = new System.Drawing.Size(56, 21);
            this.lbl_Mark.TabIndex = 30;
            this.lbl_Mark.Text = "MARK";
            // 
            // fm_CreateQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1067, 791);
            this.Controls.Add(this.lbl_Mark);
            this.Controls.Add(this.lbl_Question);
            this.Controls.Add(this.txtbx_marks5);
            this.Controls.Add(this.lbl_question5);
            this.Controls.Add(this.txtbx_question5);
            this.Controls.Add(this.txtbx_marks4);
            this.Controls.Add(this.lbl_question4);
            this.Controls.Add(this.txtbx_question4);
            this.Controls.Add(this.txtbx_marks3);
            this.Controls.Add(this.lbl_question3);
            this.Controls.Add(this.txtbx_question3);
            this.Controls.Add(this.txtbx_marks2);
            this.Controls.Add(this.lbl_question2);
            this.Controls.Add(this.txtbx_question2);
            this.Controls.Add(this.txtbx_marks1);
            this.Controls.Add(this.lbl_question1);
            this.Controls.Add(this.txtbx_question1);
            this.Controls.Add(this.bt_DeleteQues);
            this.Controls.Add(this.lbl_CharLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_FileTypes);
            this.Controls.Add(this.bt_Export);
            this.Controls.Add(this.dataGrid_MyQuestions);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.lbl_PartsNum);
            this.Controls.Add(this.srlbar_Parts);
            this.Controls.Add(this.lbl_NumberOfQues);
            this.Controls.Add(this.txtbx_Intro);
            this.Controls.Add(this.lbl_Intro);
            this.Controls.Add(this.bt_Save);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_CreateQuestions";
            this.Text = "MY QUESTIONS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_CreateQuestions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MyQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Label lbl_Intro;
        private System.Windows.Forms.TextBox txtbx_Intro;
        private System.Windows.Forms.Label lbl_NumberOfQues;
        private System.Windows.Forms.HScrollBar srlbar_Parts;
        private System.Windows.Forms.Label lbl_PartsNum;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.DataGridView dataGrid_MyQuestions;
        private System.Windows.Forms.Button bt_Export;
        private System.Windows.Forms.ComboBox cmbox_FileTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CharLimit;
        private System.Windows.Forms.Button bt_DeleteQues;
        private System.Windows.Forms.TextBox txtbx_question1;
        private System.Windows.Forms.Label lbl_question1;
        private System.Windows.Forms.TextBox txtbx_marks1;
        private System.Windows.Forms.TextBox txtbx_marks2;
        private System.Windows.Forms.Label lbl_question2;
        private System.Windows.Forms.TextBox txtbx_question2;
        private System.Windows.Forms.TextBox txtbx_marks3;
        private System.Windows.Forms.Label lbl_question3;
        private System.Windows.Forms.TextBox txtbx_question3;
        private System.Windows.Forms.TextBox txtbx_marks4;
        private System.Windows.Forms.Label lbl_question4;
        private System.Windows.Forms.TextBox txtbx_question4;
        private System.Windows.Forms.TextBox txtbx_marks5;
        private System.Windows.Forms.Label lbl_question5;
        private System.Windows.Forms.TextBox txtbx_question5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Introduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Questions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Marks;
        private System.Windows.Forms.Label lbl_Question;
        private System.Windows.Forms.Label lbl_Mark;
    }
}