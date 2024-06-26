﻿namespace ManagementSystemProject.FORMS
{
    partial class MemberInfoCard
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
            this.closeWindow1 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.pictureBoxMemberPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberPic)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(526, 15);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(31, 29);
            this.closeWindow1.TabIndex = 79;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(252, 111);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Padding = new System.Windows.Forms.Padding(3);
            this.labelEmail.Size = new System.Drawing.Size(310, 68);
            this.labelEmail.TabIndex = 74;
            this.labelEmail.Text = "Email :";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(252, 179);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Padding = new System.Windows.Forms.Padding(3);
            this.labelPhone.Size = new System.Drawing.Size(91, 31);
            this.labelPhone.TabIndex = 73;
            this.labelPhone.Text = "Phone :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(252, 219);
            this.labelGender.Name = "labelGender";
            this.labelGender.Padding = new System.Windows.Forms.Padding(3);
            this.labelGender.Size = new System.Drawing.Size(102, 31);
            this.labelGender.TabIndex = 72;
            this.labelGender.Text = "Gender :";
            // 
            // labelFullname
            // 
            this.labelFullname.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullname.Location = new System.Drawing.Point(252, 46);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Padding = new System.Windows.Forms.Padding(3);
            this.labelFullname.Size = new System.Drawing.Size(305, 65);
            this.labelFullname.TabIndex = 71;
            this.labelFullname.Text = "Full name :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(252, 15);
            this.labelID.Name = "labelID";
            this.labelID.Padding = new System.Windows.Forms.Padding(3);
            this.labelID.Size = new System.Drawing.Size(56, 31);
            this.labelID.TabIndex = 70;
            this.labelID.Text = "ID :";
            // 
            // pictureBoxMemberPic
            // 
            this.pictureBoxMemberPic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxMemberPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMemberPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMemberPic.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMemberPic.Name = "pictureBoxMemberPic";
            this.pictureBoxMemberPic.Size = new System.Drawing.Size(234, 239);
            this.pictureBoxMemberPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMemberPic.TabIndex = 69;
            this.pictureBoxMemberPic.TabStop = false;
            // 
            // MemberInfoCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(574, 267);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.pictureBoxMemberPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberInfoCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfoCard";
            this.Load += new System.EventHandler(this.MemberInfoCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMemberPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.PictureBox pictureBoxMemberPic;
    }
}