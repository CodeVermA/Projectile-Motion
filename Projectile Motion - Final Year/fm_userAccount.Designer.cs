
namespace Projectile_Motion___Final_Year
{
    partial class fm_userAccount
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
            this.bt_changePassword = new System.Windows.Forms.Button();
            this.bt_deleteAcc = new System.Windows.Forms.Button();
            this.lbl_oldPassword = new System.Windows.Forms.Label();
            this.txtbx_oldPassword = new System.Windows.Forms.TextBox();
            this.txtbx_newPassword = new System.Windows.Forms.TextBox();
            this.lbl_newPassword = new System.Windows.Forms.Label();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_DeleteData = new System.Windows.Forms.Button();
            this.chkbx_Password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_username.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(288, 100);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(115, 26);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username: ";
            // 
            // bt_changePassword
            // 
            this.bt_changePassword.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_changePassword.Location = new System.Drawing.Point(212, 183);
            this.bt_changePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_changePassword.Name = "bt_changePassword";
            this.bt_changePassword.Size = new System.Drawing.Size(131, 57);
            this.bt_changePassword.TabIndex = 1;
            this.bt_changePassword.Text = "CHANGE PASSWORD";
            this.bt_changePassword.UseVisualStyleBackColor = true;
            this.bt_changePassword.Click += new System.EventHandler(this.bt_changePassword_Click);
            // 
            // bt_deleteAcc
            // 
            this.bt_deleteAcc.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_deleteAcc.Location = new System.Drawing.Point(361, 183);
            this.bt_deleteAcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_deleteAcc.Name = "bt_deleteAcc";
            this.bt_deleteAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_deleteAcc.Size = new System.Drawing.Size(111, 57);
            this.bt_deleteAcc.TabIndex = 2;
            this.bt_deleteAcc.Text = "DELETE ACCOUNT";
            this.bt_deleteAcc.UseVisualStyleBackColor = true;
            this.bt_deleteAcc.Click += new System.EventHandler(this.bt_deleteAcc_Click);
            // 
            // lbl_oldPassword
            // 
            this.lbl_oldPassword.AutoSize = true;
            this.lbl_oldPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_oldPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_oldPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oldPassword.Location = new System.Drawing.Point(263, 279);
            this.lbl_oldPassword.Name = "lbl_oldPassword";
            this.lbl_oldPassword.Size = new System.Drawing.Size(140, 23);
            this.lbl_oldPassword.TabIndex = 3;
            this.lbl_oldPassword.Text = "OLD PASSWORD:";
            // 
            // txtbx_oldPassword
            // 
            this.txtbx_oldPassword.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_oldPassword.Location = new System.Drawing.Point(430, 275);
            this.txtbx_oldPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_oldPassword.Name = "txtbx_oldPassword";
            this.txtbx_oldPassword.PasswordChar = '*';
            this.txtbx_oldPassword.Size = new System.Drawing.Size(144, 27);
            this.txtbx_oldPassword.TabIndex = 4;
            // 
            // txtbx_newPassword
            // 
            this.txtbx_newPassword.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_newPassword.Location = new System.Drawing.Point(430, 307);
            this.txtbx_newPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbx_newPassword.Name = "txtbx_newPassword";
            this.txtbx_newPassword.PasswordChar = '*';
            this.txtbx_newPassword.Size = new System.Drawing.Size(144, 27);
            this.txtbx_newPassword.TabIndex = 6;
            // 
            // lbl_newPassword
            // 
            this.lbl_newPassword.AutoSize = true;
            this.lbl_newPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_newPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbl_newPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newPassword.Location = new System.Drawing.Point(259, 307);
            this.lbl_newPassword.Name = "lbl_newPassword";
            this.lbl_newPassword.Size = new System.Drawing.Size(144, 23);
            this.lbl_newPassword.TabIndex = 5;
            this.lbl_newPassword.Text = "NEW PASSWORD:";
            // 
            // bt_confirm
            // 
            this.bt_confirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_confirm.Font = new System.Drawing.Font("Consolas", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_confirm.Location = new System.Drawing.Point(357, 349);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(115, 43);
            this.bt_confirm.TabIndex = 7;
            this.bt_confirm.Text = "CONFIRM";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_id.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(365, 63);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(40, 26);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Text = "ID: ";
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_back.Location = new System.Drawing.Point(15, 12);
            this.bt_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(61, 28);
            this.bt_back.TabIndex = 10;
            this.bt_back.Text = "EXIT";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_DeleteData
            // 
            this.bt_DeleteData.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DeleteData.Location = new System.Drawing.Point(495, 183);
            this.bt_DeleteData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_DeleteData.Name = "bt_DeleteData";
            this.bt_DeleteData.Size = new System.Drawing.Size(111, 57);
            this.bt_DeleteData.TabIndex = 11;
            this.bt_DeleteData.Text = "DELETE DATA";
            this.bt_DeleteData.UseVisualStyleBackColor = true;
            this.bt_DeleteData.Click += new System.EventHandler(this.bt_DeleteData_Click);
            // 
            // chkbx_Password
            // 
            this.chkbx_Password.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbx_Password.Location = new System.Drawing.Point(580, 283);
            this.chkbx_Password.Name = "chkbx_Password";
            this.chkbx_Password.Size = new System.Drawing.Size(160, 19);
            this.chkbx_Password.TabIndex = 505;
            this.chkbx_Password.Text = "Show Password";
            this.chkbx_Password.UseVisualStyleBackColor = true;
            this.chkbx_Password.CheckedChanged += new System.EventHandler(this.chkbx_Password_CheckedChanged);
            // 
            // fm_userAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 474);
            this.Controls.Add(this.chkbx_Password);
            this.Controls.Add(this.bt_DeleteData);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.txtbx_newPassword);
            this.Controls.Add(this.lbl_newPassword);
            this.Controls.Add(this.txtbx_oldPassword);
            this.Controls.Add(this.lbl_oldPassword);
            this.Controls.Add(this.bt_deleteAcc);
            this.Controls.Add(this.bt_changePassword);
            this.Controls.Add(this.lbl_username);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(863, 521);
            this.MinimumSize = new System.Drawing.Size(863, 521);
            this.Name = "fm_userAccount";
            this.Text = "fm_userAccount";
            this.Load += new System.EventHandler(this.fm_userAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button bt_changePassword;
        private System.Windows.Forms.Button bt_deleteAcc;
        private System.Windows.Forms.Label lbl_oldPassword;
        private System.Windows.Forms.TextBox txtbx_oldPassword;
        private System.Windows.Forms.TextBox txtbx_newPassword;
        private System.Windows.Forms.Label lbl_newPassword;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_DeleteData;
        private System.Windows.Forms.CheckBox chkbx_Password;
    }
}