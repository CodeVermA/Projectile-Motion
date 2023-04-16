
namespace Projectile_Motion___Final_Year
{
    partial class fm_projectileMotion
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
            this.bt_Simulate = new System.Windows.Forms.Button();
            this.lbl_ScaleNum = new System.Windows.Forms.Label();
            this.srlBar_Scale = new System.Windows.Forms.HScrollBar();
            this.lbl_Scale = new System.Windows.Forms.Label();
            this.bt_ClearScreen = new System.Windows.Forms.Button();
            this.lbl_Points = new System.Windows.Forms.Label();
            this.txtbx_Target = new System.Windows.Forms.TextBox();
            this.chkbx_Target = new System.Windows.Forms.CheckBox();
            this.lbl_M = new System.Windows.Forms.Label();
            this.picBox_Graph = new System.Windows.Forms.PictureBox();
            this.lbl_YLabel = new System.Windows.Forms.Label();
            this.lbl_XLabel = new System.Windows.Forms.Label();
            this.lbl_Help = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(3, 2);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(53, 32);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_Simulate
            // 
            this.bt_Simulate.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Simulate.Location = new System.Drawing.Point(89, 11);
            this.bt_Simulate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Simulate.Name = "bt_Simulate";
            this.bt_Simulate.Size = new System.Drawing.Size(131, 57);
            this.bt_Simulate.TabIndex = 15;
            this.bt_Simulate.Text = "SHOW SIMULATION";
            this.bt_Simulate.UseVisualStyleBackColor = true;
            this.bt_Simulate.Click += new System.EventHandler(this.bt_Simulate_Click);
            // 
            // lbl_ScaleNum
            // 
            this.lbl_ScaleNum.AutoSize = true;
            this.lbl_ScaleNum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ScaleNum.Location = new System.Drawing.Point(342, 94);
            this.lbl_ScaleNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ScaleNum.Name = "lbl_ScaleNum";
            this.lbl_ScaleNum.Size = new System.Drawing.Size(29, 19);
            this.lbl_ScaleNum.TabIndex = 22;
            this.lbl_ScaleNum.Text = "X1";
            // 
            // srlBar_Scale
            // 
            this.srlBar_Scale.LargeChange = 1;
            this.srlBar_Scale.Location = new System.Drawing.Point(164, 94);
            this.srlBar_Scale.Minimum = 5;
            this.srlBar_Scale.Name = "srlBar_Scale";
            this.srlBar_Scale.Size = new System.Drawing.Size(163, 17);
            this.srlBar_Scale.TabIndex = 20;
            this.srlBar_Scale.Value = 5;
            this.srlBar_Scale.Scroll += new System.Windows.Forms.ScrollEventHandler(this.srlBar_Scale_Scroll);
            // 
            // lbl_Scale
            // 
            this.lbl_Scale.AutoSize = true;
            this.lbl_Scale.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Scale.Location = new System.Drawing.Point(89, 90);
            this.lbl_Scale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Scale.Name = "lbl_Scale";
            this.lbl_Scale.Size = new System.Drawing.Size(71, 21);
            this.lbl_Scale.TabIndex = 21;
            this.lbl_Scale.Text = "SCALE: ";
            // 
            // bt_ClearScreen
            // 
            this.bt_ClearScreen.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ClearScreen.Location = new System.Drawing.Point(236, 11);
            this.bt_ClearScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ClearScreen.Name = "bt_ClearScreen";
            this.bt_ClearScreen.Size = new System.Drawing.Size(99, 57);
            this.bt_ClearScreen.TabIndex = 23;
            this.bt_ClearScreen.Text = "CLEAR SCREEN";
            this.bt_ClearScreen.UseVisualStyleBackColor = true;
            this.bt_ClearScreen.Click += new System.EventHandler(this.bt_ClearScreen_Click);
            // 
            // lbl_Points
            // 
            this.lbl_Points.AutoSize = true;
            this.lbl_Points.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Points.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Points.Location = new System.Drawing.Point(383, 11);
            this.lbl_Points.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Points.Name = "lbl_Points";
            this.lbl_Points.Size = new System.Drawing.Size(64, 23);
            this.lbl_Points.TabIndex = 24;
            this.lbl_Points.Text = "POINTS:";
            // 
            // txtbx_Target
            // 
            this.txtbx_Target.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Target.Location = new System.Drawing.Point(383, 126);
            this.txtbx_Target.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_Target.Name = "txtbx_Target";
            this.txtbx_Target.Size = new System.Drawing.Size(86, 27);
            this.txtbx_Target.TabIndex = 47;
            // 
            // chkbx_Target
            // 
            this.chkbx_Target.AutoSize = true;
            this.chkbx_Target.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_Target.Location = new System.Drawing.Point(25, 128);
            this.chkbx_Target.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkbx_Target.Name = "chkbx_Target";
            this.chkbx_Target.Size = new System.Drawing.Size(335, 25);
            this.chkbx_Target.TabIndex = 46;
            this.chkbx_Target.Text = "PLACE TARGET AT DISPLACEMENT(m): ";
            this.chkbx_Target.UseVisualStyleBackColor = true;
            this.chkbx_Target.CheckedChanged += new System.EventHandler(this.chkbx_Target_CheckedChanged);
            // 
            // lbl_M
            // 
            this.lbl_M.AutoSize = true;
            this.lbl_M.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_M.Location = new System.Drawing.Point(487, 136);
            this.lbl_M.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(23, 19);
            this.lbl_M.TabIndex = 48;
            this.lbl_M.Text = "m";
            // 
            // picBox_Graph
            // 
            this.picBox_Graph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_Graph.Location = new System.Drawing.Point(117, 158);
            this.picBox_Graph.Name = "picBox_Graph";
            this.picBox_Graph.Size = new System.Drawing.Size(930, 351);
            this.picBox_Graph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_Graph.TabIndex = 49;
            this.picBox_Graph.TabStop = false;
            // 
            // lbl_YLabel
            // 
            this.lbl_YLabel.AutoSize = true;
            this.lbl_YLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_YLabel.Location = new System.Drawing.Point(13, 295);
            this.lbl_YLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_YLabel.Name = "lbl_YLabel";
            this.lbl_YLabel.Size = new System.Drawing.Size(97, 19);
            this.lbl_YLabel.TabIndex = 50;
            this.lbl_YLabel.Text = "HEIGHT(m)";
            // 
            // lbl_XLabel
            // 
            this.lbl_XLabel.AutoSize = true;
            this.lbl_XLabel.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_XLabel.Location = new System.Drawing.Point(401, 512);
            this.lbl_XLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_XLabel.Name = "lbl_XLabel";
            this.lbl_XLabel.Size = new System.Drawing.Size(163, 19);
            this.lbl_XLabel.TabIndex = 51;
            this.lbl_XLabel.Text = "DISPLACEMENT(m)";
            // 
            // lbl_Help
            // 
            this.lbl_Help.AutoSize = true;
            this.lbl_Help.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Help.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Help.Location = new System.Drawing.Point(379, 90);
            this.lbl_Help.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Help.Name = "lbl_Help";
            this.lbl_Help.Size = new System.Drawing.Size(19, 23);
            this.lbl_Help.TabIndex = 52;
            this.lbl_Help.Text = "?";
            this.lbl_Help.Click += new System.EventHandler(this.lbl_Help_Click);
            // 
            // fm_projectileMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 540);
            this.Controls.Add(this.lbl_Help);
            this.Controls.Add(this.lbl_XLabel);
            this.Controls.Add(this.lbl_YLabel);
            this.Controls.Add(this.picBox_Graph);
            this.Controls.Add(this.lbl_M);
            this.Controls.Add(this.txtbx_Target);
            this.Controls.Add(this.chkbx_Target);
            this.Controls.Add(this.lbl_Points);
            this.Controls.Add(this.bt_ClearScreen);
            this.Controls.Add(this.lbl_ScaleNum);
            this.Controls.Add(this.srlBar_Scale);
            this.Controls.Add(this.lbl_Scale);
            this.Controls.Add(this.bt_Simulate);
            this.Controls.Add(this.bt_exit);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fm_projectileMotion";
            this.Text = "PROJECTILE MOTION SIMULATION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_projectileMotion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_Simulate;
        private System.Windows.Forms.Label lbl_ScaleNum;
        private System.Windows.Forms.HScrollBar srlBar_Scale;
        private System.Windows.Forms.Label lbl_Scale;
        private System.Windows.Forms.Button bt_ClearScreen;
        private System.Windows.Forms.Label lbl_Points;
        private System.Windows.Forms.TextBox txtbx_Target;
        private System.Windows.Forms.CheckBox chkbx_Target;
        private System.Windows.Forms.Label lbl_M;
        private System.Windows.Forms.PictureBox picBox_Graph;
        private System.Windows.Forms.Label lbl_YLabel;
        private System.Windows.Forms.Label lbl_XLabel;
        private System.Windows.Forms.Label lbl_Help;
    }
}