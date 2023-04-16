namespace Projectile_Motion___Final_Year
{
    partial class fm_topicIntro
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
            this.richtxtbx_Explain = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(16, 15);
            this.bt_exit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(65, 35);
            this.bt_exit.TabIndex = 0;
            this.bt_exit.Text = "EXIT";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // richtxtbx_Explain
            // 
            this.richtxtbx_Explain.Location = new System.Drawing.Point(16, 58);
            this.richtxtbx_Explain.Margin = new System.Windows.Forms.Padding(4);
            this.richtxtbx_Explain.Name = "richtxtbx_Explain";
            this.richtxtbx_Explain.ReadOnly = true;
            this.richtxtbx_Explain.Size = new System.Drawing.Size(1335, 709);
            this.richtxtbx_Explain.TabIndex = 1;
            this.richtxtbx_Explain.Text = "";
            // 
            // fm_topicIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.richtxtbx_Explain);
            this.Controls.Add(this.bt_exit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_topicIntro";
            this.Text = "Topic_Intro";
            this.Load += new System.EventHandler(this.fm_topicIntro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.RichTextBox richtxtbx_Explain;
    }
}