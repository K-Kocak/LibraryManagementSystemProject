namespace ManagementSystemProject.FORMS
{
    partial class BooksListForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.listViewBooks = new System.Windows.Forms.ListView();
            this.closeLoginWindow = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageListBookCovers = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelAuthor);
            this.panel1.Controls.Add(this.listViewBooks);
            this.panel1.Controls.Add(this.closeLoginWindow);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 480);
            this.panel1.TabIndex = 1;
            // 
            // labelAuthor
            // 
            this.labelAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(1, 60);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(437, 58);
            this.labelAuthor.TabIndex = 3;
            this.labelAuthor.Text = "Books by: The Author";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewBooks
            // 
            this.listViewBooks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listViewBooks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBooks.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewBooks.HideSelection = false;
            this.listViewBooks.Location = new System.Drawing.Point(1, 118);
            this.listViewBooks.Name = "listViewBooks";
            this.listViewBooks.Size = new System.Drawing.Size(437, 359);
            this.listViewBooks.TabIndex = 2;
            this.listViewBooks.UseCompatibleStateImageBehavior = false;
            // 
            // closeLoginWindow
            // 
            this.closeLoginWindow.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeLoginWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLoginWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLoginWindow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeLoginWindow.Location = new System.Drawing.Point(396, 10);
            this.closeLoginWindow.Name = "closeLoginWindow";
            this.closeLoginWindow.Size = new System.Drawing.Size(26, 23);
            this.closeLoginWindow.TabIndex = 1;
            this.closeLoginWindow.Text = "X";
            this.closeLoginWindow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeLoginWindow.Click += new System.EventHandler(this.closeLoginWindow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageListBookCovers
            // 
            this.imageListBookCovers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListBookCovers.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListBookCovers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BooksListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BooksListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksListForm";
            this.Load += new System.EventHandler(this.BooksListForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label closeLoginWindow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewBooks;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.ImageList imageListBookCovers;
    }
}