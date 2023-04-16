namespace Projectile_Motion___Final_Year
{
    partial class fm_MainForm
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.txtbx_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbx_password = new System.Windows.Forms.TextBox();
            this.bt_Register = new System.Windows.Forms.Button();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Guest = new System.Windows.Forms.Button();
            this.chkbx_Password = new System.Windows.Forms.CheckBox();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.lbl_SoftwareName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_username.AutoSize = true;
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_username.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(262, 210);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(147, 31);
            this.lbl_username.TabIndex = 14;
            this.lbl_username.Text = "USERNAME:";
            // 
            // txtbx_username
            // 
            this.txtbx_username.BackColor = System.Drawing.Color.White;
            this.txtbx_username.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_username.Location = new System.Drawing.Point(421, 210);
            this.txtbx_username.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_username.Name = "txtbx_username";
            this.txtbx_username.Size = new System.Drawing.Size(202, 30);
            this.txtbx_username.TabIndex = 13;
            // 
            // lbl_password
            // 
            this.lbl_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_password.AutoSize = true;
            this.lbl_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_password.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_password.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(262, 254);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(145, 31);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "PASSWORD:";
            // 
            // txtbx_password
            // 
            this.txtbx_password.BackColor = System.Drawing.Color.White;
            this.txtbx_password.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_password.Location = new System.Drawing.Point(421, 254);
            this.txtbx_password.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_password.Name = "txtbx_password";
            this.txtbx_password.PasswordChar = '*';
            this.txtbx_password.Size = new System.Drawing.Size(202, 30);
            this.txtbx_password.TabIndex = 11;
            // 
            // bt_Register
            // 
            this.bt_Register.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Register.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Register.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Register.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Register.Location = new System.Drawing.Point(281, 342);
            this.bt_Register.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Register.Name = "bt_Register";
            this.bt_Register.Size = new System.Drawing.Size(128, 54);
            this.bt_Register.TabIndex = 501;
            this.bt_Register.Text = "CREATE ACCOUNT";
            this.bt_Register.UseVisualStyleBackColor = false;
            this.bt_Register.Click += new System.EventHandler(this.bt_Register_Click);
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Login.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.Location = new System.Drawing.Point(364, 292);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(97, 43);
            this.bt_Login.TabIndex = 502;
            this.bt_Login.Text = "LOGIN";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Guest
            // 
            this.bt_Guest.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Guest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bt_Guest.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Guest.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Guest.Location = new System.Drawing.Point(417, 342);
            this.bt_Guest.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Guest.Name = "bt_Guest";
            this.bt_Guest.Size = new System.Drawing.Size(109, 54);
            this.bt_Guest.TabIndex = 503;
            this.bt_Guest.Text = "USE AS GUEST";
            this.bt_Guest.UseVisualStyleBackColor = false;
            this.bt_Guest.Click += new System.EventHandler(this.bt_Guest_Click);
            // 
            // chkbx_Password
            // 
            this.chkbx_Password.Location = new System.Drawing.Point(537, 291);
            this.chkbx_Password.Name = "chkbx_Password";
            this.chkbx_Password.Size = new System.Drawing.Size(147, 19);
            this.chkbx_Password.TabIndex = 504;
            this.chkbx_Password.Text = "Show Password";
            this.chkbx_Password.UseVisualStyleBackColor = true;
            this.chkbx_Password.CheckedChanged += new System.EventHandler(this.chkbx_Password_CheckedChanged);
            // 
            // bt_Exit
            // 
            this.bt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_Exit.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(12, 11);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(65, 28);
            this.bt_Exit.TabIndex = 505;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // lbl_SoftwareName
            // 
            this.lbl_SoftwareName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_SoftwareName.AutoSize = true;
            this.lbl_SoftwareName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SoftwareName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SoftwareName.Font = new System.Drawing.Font("Segoe Print", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoftwareName.Location = new System.Drawing.Point(223, 80);
            this.lbl_SoftwareName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoftwareName.Name = "lbl_SoftwareName";
            this.lbl_SoftwareName.Size = new System.Drawing.Size(461, 45);
            this.lbl_SoftwareName.TabIndex = 506;
            this.lbl_SoftwareName.Text = "PROJECTILE MOTION SIMULATION";
            // 
            // fm_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 591);
            this.Controls.Add(this.lbl_SoftwareName);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.chkbx_Password);
            this.Controls.Add(this.bt_Guest);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.bt_Register);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txtbx_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txtbx_password);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_MainForm";
            this.Text = "PROJECTILE MOTION";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fm_MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txtbx_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbx_password;
        private System.Windows.Forms.Button bt_Register;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Guest;
        private System.Windows.Forms.CheckBox chkbx_Password;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Label lbl_SoftwareName;
    }
}

