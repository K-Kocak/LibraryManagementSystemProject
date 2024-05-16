namespace ManagementSystemProject.FORMS
{
    partial class ManageAuthorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.closeWindow1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExportAuthors = new System.Windows.Forms.Button();
            this.authorCountLabel = new System.Windows.Forms.Label();
            this.removeButton1 = new System.Windows.Forms.Button();
            this.editButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutRichTextbox = new System.Windows.Forms.RichTextBox();
            this.dataGridViewAuthors = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.educationTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.snameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showAuthorBooksButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(1032, 9);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(34, 29);
            this.closeWindow1.TabIndex = 5;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1077, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Authors";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonExportAuthors);
            this.panel1.Controls.Add(this.authorCountLabel);
            this.panel1.Controls.Add(this.showAuthorBooksButton);
            this.panel1.Controls.Add(this.removeButton1);
            this.panel1.Controls.Add(this.editButton1);
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 449);
            this.panel1.TabIndex = 6;
            // 
            // buttonExportAuthors
            // 
            this.buttonExportAuthors.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExportAuthors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExportAuthors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportAuthors.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportAuthors.Image = global::ManagementSystemProject.Properties.Resources.exporttotextfile;
            this.buttonExportAuthors.Location = new System.Drawing.Point(7, 320);
            this.buttonExportAuthors.Name = "buttonExportAuthors";
            this.buttonExportAuthors.Size = new System.Drawing.Size(161, 86);
            this.buttonExportAuthors.TabIndex = 54;
            this.buttonExportAuthors.Text = "Export Author to text file";
            this.buttonExportAuthors.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExportAuthors.UseVisualStyleBackColor = false;
            this.buttonExportAuthors.Click += new System.EventHandler(this.buttonExportAuthors_Click);
            // 
            // authorCountLabel
            // 
            this.authorCountLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.authorCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorCountLabel.Location = new System.Drawing.Point(11, 411);
            this.authorCountLabel.Name = "authorCountLabel";
            this.authorCountLabel.Size = new System.Drawing.Size(157, 24);
            this.authorCountLabel.TabIndex = 53;
            this.authorCountLabel.Text = "99999 Authors";
            this.authorCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeButton1
            // 
            this.removeButton1.BackColor = System.Drawing.Color.LightCoral;
            this.removeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton1.Location = new System.Drawing.Point(7, 159);
            this.removeButton1.Name = "removeButton1";
            this.removeButton1.Size = new System.Drawing.Size(161, 63);
            this.removeButton1.TabIndex = 8;
            this.removeButton1.Text = "Remove Author";
            this.removeButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton1.UseVisualStyleBackColor = false;
            this.removeButton1.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // editButton1
            // 
            this.editButton1.BackColor = System.Drawing.Color.Lavender;
            this.editButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton1.Location = new System.Drawing.Point(7, 88);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(161, 65);
            this.editButton1.TabIndex = 7;
            this.editButton1.Text = "Edit Author";
            this.editButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton1.UseVisualStyleBackColor = false;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.YellowGreen;
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Location = new System.Drawing.Point(7, 17);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(161, 62);
            this.addButton1.TabIndex = 6;
            this.addButton1.Text = "Add Author";
            this.addButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton1.UseVisualStyleBackColor = false;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.aboutRichTextbox);
            this.panel2.Controls.Add(this.dataGridViewAuthors);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.educationTextbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.snameTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fnameTextbox);
            this.panel2.Controls.Add(this.idTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(181, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 447);
            this.panel2.TabIndex = 7;
            // 
            // aboutRichTextbox
            // 
            this.aboutRichTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutRichTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutRichTextbox.Location = new System.Drawing.Point(119, 211);
            this.aboutRichTextbox.Name = "aboutRichTextbox";
            this.aboutRichTextbox.Size = new System.Drawing.Size(207, 222);
            this.aboutRichTextbox.TabIndex = 15;
            this.aboutRichTextbox.Text = "";
            // 
            // dataGridViewAuthors
            // 
            this.dataGridViewAuthors.AllowUserToAddRows = false;
            this.dataGridViewAuthors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Cornsilk;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAuthors.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewAuthors.Location = new System.Drawing.Point(342, 17);
            this.dataGridViewAuthors.Name = "dataGridViewAuthors";
            this.dataGridViewAuthors.Size = new System.Drawing.Size(540, 416);
            this.dataGridViewAuthors.TabIndex = 14;
            this.dataGridViewAuthors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAuthors_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "About :";
            // 
            // educationTextbox
            // 
            this.educationTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.educationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.educationTextbox.Location = new System.Drawing.Point(119, 159);
            this.educationTextbox.Multiline = true;
            this.educationTextbox.Name = "educationTextbox";
            this.educationTextbox.Size = new System.Drawing.Size(207, 31);
            this.educationTextbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Education :";
            // 
            // snameTextbox
            // 
            this.snameTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameTextbox.Location = new System.Drawing.Point(119, 109);
            this.snameTextbox.Multiline = true;
            this.snameTextbox.Name = "snameTextbox";
            this.snameTextbox.Size = new System.Drawing.Size(207, 31);
            this.snameTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surname :";
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextbox.Location = new System.Drawing.Point(119, 61);
            this.fnameTextbox.Multiline = true;
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(207, 31);
            this.fnameTextbox.TabIndex = 7;
            // 
            // idTextbox
            // 
            this.idTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.idTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextbox.Location = new System.Drawing.Point(119, 17);
            this.idTextbox.Multiline = true;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(123, 31);
            this.idTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID :";
            // 
            // showAuthorBooksButton
            // 
            this.showAuthorBooksButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showAuthorBooksButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.showAuthorBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAuthorBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAuthorBooksButton.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAuthorBooksButton.Image = global::ManagementSystemProject.Properties.Resources.bookimage1;
            this.showAuthorBooksButton.Location = new System.Drawing.Point(7, 228);
            this.showAuthorBooksButton.Name = "showAuthorBooksButton";
            this.showAuthorBooksButton.Size = new System.Drawing.Size(161, 86);
            this.showAuthorBooksButton.TabIndex = 9;
            this.showAuthorBooksButton.Text = "Show Author Books";
            this.showAuthorBooksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showAuthorBooksButton.UseVisualStyleBackColor = false;
            this.showAuthorBooksButton.Click += new System.EventHandler(this.showAuthorBooksButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.IndianRed;
            this.label14.Location = new System.Drawing.Point(51, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 26);
            this.label14.TabIndex = 48;
            this.label14.Text = "*";
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeButton1;
        private System.Windows.Forms.Button editButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.TextBox fnameTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox educationTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox snameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox aboutRichTextbox;
        private System.Windows.Forms.DataGridView dataGridViewAuthors;
        private System.Windows.Forms.Button showAuthorBooksButton;
        private System.Windows.Forms.Label authorCountLabel;
        private System.Windows.Forms.Button buttonExportAuthors;
        private System.Windows.Forms.Label label14;
    }
}