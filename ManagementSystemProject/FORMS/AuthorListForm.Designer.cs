namespace ManagementSystemProject.FORMS
{
    partial class AuthorListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAuthors = new System.Windows.Forms.ListBox();
            this.selectAuthorAndCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(338, 9);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(39, 29);
            this.closeWindow1.TabIndex = 10;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 93);
            this.label1.TabIndex = 9;
            this.label1.Text = "Author List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxAuthors
            // 
            this.listBoxAuthors.FormattingEnabled = true;
            this.listBoxAuthors.Location = new System.Drawing.Point(6, 95);
            this.listBoxAuthors.Name = "listBoxAuthors";
            this.listBoxAuthors.Size = new System.Drawing.Size(377, 290);
            this.listBoxAuthors.TabIndex = 11;
            // 
            // selectAuthorAndCloseButton
            // 
            this.selectAuthorAndCloseButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.selectAuthorAndCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectAuthorAndCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAuthorAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAuthorAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAuthorAndCloseButton.Location = new System.Drawing.Point(12, 388);
            this.selectAuthorAndCloseButton.Name = "selectAuthorAndCloseButton";
            this.selectAuthorAndCloseButton.Size = new System.Drawing.Size(365, 48);
            this.selectAuthorAndCloseButton.TabIndex = 12;
            this.selectAuthorAndCloseButton.Text = "Select Author and Close";
            this.selectAuthorAndCloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectAuthorAndCloseButton.UseVisualStyleBackColor = false;
            this.selectAuthorAndCloseButton.Click += new System.EventHandler(this.selectAuthorAndCloseButton_Click);
            // 
            // AuthorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 441);
            this.Controls.Add(this.selectAuthorAndCloseButton);
            this.Controls.Add(this.listBoxAuthors);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthorListForm";
            this.Load += new System.EventHandler(this.AuthorListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAuthors;
        private System.Windows.Forms.Button selectAuthorAndCloseButton;
    }
}