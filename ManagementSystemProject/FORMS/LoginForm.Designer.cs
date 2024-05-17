namespace ManagementSystemProject.FORMS
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.pictureLock = new System.Windows.Forms.PictureBox();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.pictureUser = new System.Windows.Forms.PictureBox();
            this.closeLoginWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.buttonLogin);
            this.panel1.Controls.Add(this.textboxPassword);
            this.panel1.Controls.Add(this.pictureLock);
            this.panel1.Controls.Add(this.textboxUsername);
            this.panel1.Controls.Add(this.pictureUser);
            this.panel1.Controls.Add(this.closeLoginWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 351);
            this.panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Honeydew;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.Font = new System.Drawing.Font("Mongolian Baiti", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(88, 254);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(270, 56);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.Location = new System.Drawing.Point(97, 185);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(297, 41);
            this.textboxPassword.TabIndex = 5;
            this.textboxPassword.Text = "1234";
            this.textboxPassword.UseSystemPasswordChar = true;
            // 
            // pictureLock
            // 
            this.pictureLock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pictureLock.Image = global::ManagementSystemProject.Properties.Resources.lockimage;
            this.pictureLock.Location = new System.Drawing.Point(41, 180);
            this.pictureLock.Name = "pictureLock";
            this.pictureLock.Size = new System.Drawing.Size(50, 50);
            this.pictureLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLock.TabIndex = 4;
            this.pictureLock.TabStop = false;
            // 
            // textboxUsername
            // 
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.Location = new System.Drawing.Point(97, 118);
            this.textboxUsername.Multiline = true;
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(297, 41);
            this.textboxUsername.TabIndex = 3;
            this.textboxUsername.Text = "usertest";
            // 
            // pictureUser
            // 
            this.pictureUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(128)))));
            this.pictureUser.Image = global::ManagementSystemProject.Properties.Resources.userimage;
            this.pictureUser.Location = new System.Drawing.Point(41, 114);
            this.pictureUser.Name = "pictureUser";
            this.pictureUser.Size = new System.Drawing.Size(50, 50);
            this.pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureUser.TabIndex = 2;
            this.pictureUser.TabStop = false;
            // 
            // closeLoginWindow
            // 
            this.closeLoginWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLoginWindow.BackColor = System.Drawing.Color.Crimson;
            this.closeLoginWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.closeLoginWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLoginWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLoginWindow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.closeLoginWindow.Location = new System.Drawing.Point(395, 10);
            this.closeLoginWindow.Margin = new System.Windows.Forms.Padding(0);
            this.closeLoginWindow.Name = "closeLoginWindow";
            this.closeLoginWindow.Size = new System.Drawing.Size(30, 31);
            this.closeLoginWindow.TabIndex = 1;
            this.closeLoginWindow.Text = "X";
            this.closeLoginWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeLoginWindow.UseCompatibleTextRendering = true;
            this.closeLoginWindow.Click += new System.EventHandler(this.closeLoginWindow_Click);
            this.closeLoginWindow.MouseEnter += new System.EventHandler(this.closeLoginWindow_MouseEnter);
            this.closeLoginWindow.MouseLeave += new System.EventHandler(this.closeLoginWindow_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 349);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.PictureBox pictureUser;
        private System.Windows.Forms.Label closeLoginWindow;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.PictureBox pictureLock;
    }
}