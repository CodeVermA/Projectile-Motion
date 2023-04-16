
namespace Projectile_Motion___Final_Year
{
    partial class fm_report
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
            this.lstbx_showReport = new System.Windows.Forms.ListBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstbx_showReport
            // 
            this.lstbx_showReport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_showReport.FormattingEnabled = true;
            this.lstbx_showReport.ItemHeight = 23;
            this.lstbx_showReport.Location = new System.Drawing.Point(11, 50);
            this.lstbx_showReport.Name = "lstbx_showReport";
            this.lstbx_showReport.Size = new System.Drawing.Size(956, 579);
            this.lstbx_showReport.TabIndex = 0;
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(12, 12);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(61, 32);
            this.bt_exit.TabIndex = 1;
            this.bt_exit.Text = "Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // fm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 629);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.lstbx_showReport);
            this.Name = "fm_report";
            this.Text = "fm_report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstbx_showReport;
        private System.Windows.Forms.Button bt_exit;
    }
}