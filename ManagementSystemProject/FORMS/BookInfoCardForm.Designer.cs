namespace ManagementSystemProject.FORMS
{
    partial class BookInfoCardForm
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
            this.pictureBoxBookCover = new System.Windows.Forms.PictureBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelDateAdded = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.closeWindow1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBookCover
            // 
            this.pictureBoxBookCover.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxBookCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBookCover.Location = new System.Drawing.Point(11, 12);
            this.pictureBoxBookCover.Name = "pictureBoxBookCover";
            this.pictureBoxBookCover.Size = new System.Drawing.Size(234, 365);
            this.pictureBoxBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBookCover.TabIndex = 0;
            this.pictureBoxBookCover.TabStop = false;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(251, 12);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Padding = new System.Windows.Forms.Padding(3);
            this.labelISBN.Size = new System.Drawing.Size(84, 31);
            this.labelISBN.TabIndex = 59;
            this.labelISBN.Text = "ISBN :";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(251, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(3);
            this.labelTitle.Size = new System.Drawing.Size(76, 31);
            this.labelTitle.TabIndex = 60;
            this.labelTitle.Text = "Title :";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor.Location = new System.Drawing.Point(251, 94);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.labelAuthor.Size = new System.Drawing.Size(99, 31);
            this.labelAuthor.TabIndex = 61;
            this.labelAuthor.Text = "Author :";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(251, 135);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Padding = new System.Windows.Forms.Padding(3);
            this.labelGenre.Size = new System.Drawing.Size(90, 31);
            this.labelGenre.TabIndex = 62;
            this.labelGenre.Text = "Genre :";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(366, 177);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Padding = new System.Windows.Forms.Padding(3);
            this.labelQuantity.Size = new System.Drawing.Size(42, 31);
            this.labelQuantity.TabIndex = 63;
            this.labelQuantity.Text = "99";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(255, 221);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Padding = new System.Windows.Forms.Padding(3);
            this.labelPrice.Size = new System.Drawing.Size(80, 31);
            this.labelPrice.TabIndex = 64;
            this.labelPrice.Text = "Price :";
            // 
            // labelDateAdded
            // 
            this.labelDateAdded.AutoSize = true;
            this.labelDateAdded.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAdded.Location = new System.Drawing.Point(251, 312);
            this.labelDateAdded.Name = "labelDateAdded";
            this.labelDateAdded.Padding = new System.Windows.Forms.Padding(3);
            this.labelDateAdded.Size = new System.Drawing.Size(147, 31);
            this.labelDateAdded.TabIndex = 65;
            this.labelDateAdded.Text = "Date Added :";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(251, 266);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.labelPublisher.Size = new System.Drawing.Size(120, 31);
            this.labelPublisher.TabIndex = 66;
            this.labelPublisher.Text = "Publisher :";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(12, 392);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(600, 95);
            this.richTextBoxDescription.TabIndex = 67;
            this.richTextBoxDescription.Text = "";
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(581, 15);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(31, 29);
            this.closeWindow1.TabIndex = 68;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, 177);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(115, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Quantity :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 353);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 70;
            this.label2.Text = "About :";
            // 
            // BookInfoCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(624, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.labelDateAdded);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.pictureBoxBookCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookInfoCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookInfoCardForm";
            this.Load += new System.EventHandler(this.BookInfoCardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBookCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBookCover;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelDateAdded;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}