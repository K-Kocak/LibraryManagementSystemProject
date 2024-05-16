namespace ManagementSystemProject.FORMS
{
    partial class ManageCirculationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.bookCountLabel = new System.Windows.Forms.Label();
            this.panelIssue = new System.Windows.Forms.Panel();
            this.buttonIssueBook = new System.Windows.Forms.Button();
            this.buttonSearchMember = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.richTextBoxNote = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerReturn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIssue = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAvailability = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelMember = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.numericUpDownBookID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMemberID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonLost = new System.Windows.Forms.Button();
            this.buttonReturned = new System.Windows.Forms.Button();
            this.buttonIssued = new System.Windows.Forms.Button();
            this.dataGridViewIssuedBook = new System.Windows.Forms.DataGridView();
            this.buttonBookLost = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.richTextBoxNote2 = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerReturnDate2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIssueDate2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelMember2 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.numericUpDownBookID2 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownMemberID2 = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemberID)).BeginInit();
            this.panelReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemberID2)).BeginInit();
            this.SuspendLayout();
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(1131, 9);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(31, 29);
            this.closeWindow1.TabIndex = 10;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1175, 93);
            this.label1.TabIndex = 9;
            this.label1.Text = "Circulation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.buttonIssue);
            this.panel1.Controls.Add(this.bookCountLabel);
            this.panel1.Location = new System.Drawing.Point(-1, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 551);
            this.panel1.TabIndex = 11;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.Aquamarine;
            this.buttonReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Image = global::ManagementSystemProject.Properties.Resources.returnimage;
            this.buttonReturn.Location = new System.Drawing.Point(13, 92);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(161, 58);
            this.buttonReturn.TabIndex = 54;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonIssue
            // 
            this.buttonIssue.BackColor = System.Drawing.Color.Moccasin;
            this.buttonIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIssue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIssue.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssue.Image = global::ManagementSystemProject.Properties.Resources.issueimage;
            this.buttonIssue.Location = new System.Drawing.Point(13, 23);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(161, 61);
            this.buttonIssue.TabIndex = 53;
            this.buttonIssue.Text = "Issue";
            this.buttonIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIssue.UseVisualStyleBackColor = false;
            this.buttonIssue.Click += new System.EventHandler(this.buttonIssue_Click);
            // 
            // bookCountLabel
            // 
            this.bookCountLabel.AutoSize = true;
            this.bookCountLabel.BackColor = System.Drawing.SystemColors.Info;
            this.bookCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookCountLabel.Location = new System.Drawing.Point(39, 516);
            this.bookCountLabel.Name = "bookCountLabel";
            this.bookCountLabel.Size = new System.Drawing.Size(117, 24);
            this.bookCountLabel.TabIndex = 52;
            this.bookCountLabel.Text = "99999 Books";
            // 
            // panelIssue
            // 
            this.panelIssue.BackColor = System.Drawing.Color.OldLace;
            this.panelIssue.Controls.Add(this.buttonIssueBook);
            this.panelIssue.Controls.Add(this.buttonSearchMember);
            this.panelIssue.Controls.Add(this.buttonSearchBook);
            this.panelIssue.Controls.Add(this.richTextBoxNote);
            this.panelIssue.Controls.Add(this.dateTimePickerReturn);
            this.panelIssue.Controls.Add(this.dateTimePickerIssue);
            this.panelIssue.Controls.Add(this.label8);
            this.panelIssue.Controls.Add(this.label7);
            this.panelIssue.Controls.Add(this.label6);
            this.panelIssue.Controls.Add(this.labelAvailability);
            this.panelIssue.Controls.Add(this.label4);
            this.panelIssue.Controls.Add(this.labelMember);
            this.panelIssue.Controls.Add(this.labelTitle);
            this.panelIssue.Controls.Add(this.numericUpDownBookID);
            this.panelIssue.Controls.Add(this.label3);
            this.panelIssue.Controls.Add(this.numericUpDownMemberID);
            this.panelIssue.Controls.Add(this.label2);
            this.panelIssue.Location = new System.Drawing.Point(199, 93);
            this.panelIssue.Name = "panelIssue";
            this.panelIssue.Size = new System.Drawing.Size(963, 537);
            this.panelIssue.TabIndex = 55;
            // 
            // buttonIssueBook
            // 
            this.buttonIssueBook.BackColor = System.Drawing.Color.LightCoral;
            this.buttonIssueBook.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssueBook.Location = new System.Drawing.Point(212, 484);
            this.buttonIssueBook.Name = "buttonIssueBook";
            this.buttonIssueBook.Size = new System.Drawing.Size(471, 43);
            this.buttonIssueBook.TabIndex = 72;
            this.buttonIssueBook.Text = "Issue book";
            this.buttonIssueBook.UseVisualStyleBackColor = false;
            this.buttonIssueBook.Click += new System.EventHandler(this.buttonIssueBook_Click);
            // 
            // buttonSearchMember
            // 
            this.buttonSearchMember.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchMember.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchMember.Location = new System.Drawing.Point(524, 98);
            this.buttonSearchMember.Name = "buttonSearchMember";
            this.buttonSearchMember.Size = new System.Drawing.Size(158, 36);
            this.buttonSearchMember.TabIndex = 71;
            this.buttonSearchMember.Text = "Search Member";
            this.buttonSearchMember.UseVisualStyleBackColor = false;
            this.buttonSearchMember.Click += new System.EventHandler(this.buttonSearchMember_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchBook.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchBook.Location = new System.Drawing.Point(524, 2);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(158, 36);
            this.buttonSearchBook.TabIndex = 70;
            this.buttonSearchBook.Text = "Search Book";
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // richTextBoxNote
            // 
            this.richTextBoxNote.Location = new System.Drawing.Point(317, 321);
            this.richTextBoxNote.Name = "richTextBoxNote";
            this.richTextBoxNote.Size = new System.Drawing.Size(365, 157);
            this.richTextBoxNote.TabIndex = 69;
            this.richTextBoxNote.Text = "";
            // 
            // dateTimePickerReturn
            // 
            this.dateTimePickerReturn.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturn.Location = new System.Drawing.Point(416, 281);
            this.dateTimePickerReturn.Name = "dateTimePickerReturn";
            this.dateTimePickerReturn.Size = new System.Drawing.Size(191, 32);
            this.dateTimePickerReturn.TabIndex = 68;
            // 
            // dateTimePickerIssue
            // 
            this.dateTimePickerIssue.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssue.Location = new System.Drawing.Point(416, 239);
            this.dateTimePickerIssue.Name = "dateTimePickerIssue";
            this.dateTimePickerIssue.Size = new System.Drawing.Size(191, 32);
            this.dateTimePickerIssue.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 66;
            this.label8.Text = "Note :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 65;
            this.label7.Text = "Return Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 64;
            this.label6.Text = "Issue Date :";
            // 
            // labelAvailability
            // 
            this.labelAvailability.AutoSize = true;
            this.labelAvailability.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailability.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelAvailability.Location = new System.Drawing.Point(416, 206);
            this.labelAvailability.Name = "labelAvailability";
            this.labelAvailability.Size = new System.Drawing.Size(123, 25);
            this.labelAvailability.TabIndex = 63;
            this.labelAvailability.Text = "YES or NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 23);
            this.label4.TabIndex = 62;
            this.label4.Text = "Is this book available :";
            // 
            // labelMember
            // 
            this.labelMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMember.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelMember.Location = new System.Drawing.Point(208, 137);
            this.labelMember.Name = "labelMember";
            this.labelMember.Size = new System.Drawing.Size(475, 53);
            this.labelMember.TabIndex = 61;
            this.labelMember.Text = "Member fullname";
            this.labelMember.Click += new System.EventHandler(this.labelMember_Click);
            this.labelMember.MouseEnter += new System.EventHandler(this.labelMember_MouseEnter);
            this.labelMember.MouseLeave += new System.EventHandler(this.labelMember_MouseLeave);
            // 
            // labelTitle
            // 
            this.labelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelTitle.Location = new System.Drawing.Point(208, 41);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(470, 54);
            this.labelTitle.TabIndex = 60;
            this.labelTitle.Text = "Book title";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            this.labelTitle.MouseEnter += new System.EventHandler(this.labelTitle_MouseEnter);
            this.labelTitle.MouseLeave += new System.EventHandler(this.labelTitle_MouseLeave);
            // 
            // numericUpDownBookID
            // 
            this.numericUpDownBookID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBookID.Location = new System.Drawing.Point(378, 9);
            this.numericUpDownBookID.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBookID.Name = "numericUpDownBookID";
            this.numericUpDownBookID.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownBookID.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 58;
            this.label3.Text = "Enter book ID :";
            // 
            // numericUpDownMemberID
            // 
            this.numericUpDownMemberID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMemberID.Location = new System.Drawing.Point(378, 103);
            this.numericUpDownMemberID.Name = "numericUpDownMemberID";
            this.numericUpDownMemberID.Size = new System.Drawing.Size(140, 29);
            this.numericUpDownMemberID.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 56;
            this.label2.Text = "Enter member ID :";
            // 
            // panelReturn
            // 
            this.panelReturn.BackColor = System.Drawing.Color.GreenYellow;
            this.panelReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReturn.Controls.Add(this.label11);
            this.panelReturn.Controls.Add(this.buttonAll);
            this.panelReturn.Controls.Add(this.buttonLost);
            this.panelReturn.Controls.Add(this.buttonReturned);
            this.panelReturn.Controls.Add(this.buttonIssued);
            this.panelReturn.Controls.Add(this.dataGridViewIssuedBook);
            this.panelReturn.Controls.Add(this.buttonBookLost);
            this.panelReturn.Controls.Add(this.buttonReturnBook);
            this.panelReturn.Controls.Add(this.buttonDelete);
            this.panelReturn.Controls.Add(this.richTextBoxNote2);
            this.panelReturn.Controls.Add(this.dateTimePickerReturnDate2);
            this.panelReturn.Controls.Add(this.dateTimePickerIssueDate2);
            this.panelReturn.Controls.Add(this.label5);
            this.panelReturn.Controls.Add(this.label9);
            this.panelReturn.Controls.Add(this.label10);
            this.panelReturn.Controls.Add(this.labelMember2);
            this.panelReturn.Controls.Add(this.labelTitle2);
            this.panelReturn.Controls.Add(this.numericUpDownBookID2);
            this.panelReturn.Controls.Add(this.label15);
            this.panelReturn.Controls.Add(this.numericUpDownMemberID2);
            this.panelReturn.Controls.Add(this.label16);
            this.panelReturn.Location = new System.Drawing.Point(199, 93);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(963, 537);
            this.panelReturn.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 79;
            this.label11.Text = "Filters :";
            // 
            // buttonAll
            // 
            this.buttonAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAll.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAll.Location = new System.Drawing.Point(786, 18);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(144, 37);
            this.buttonAll.TabIndex = 78;
            this.buttonAll.Text = "ALL";
            this.buttonAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAll.UseVisualStyleBackColor = false;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonLost
            // 
            this.buttonLost.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonLost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLost.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLost.Location = new System.Drawing.Point(628, 18);
            this.buttonLost.Name = "buttonLost";
            this.buttonLost.Size = new System.Drawing.Size(144, 37);
            this.buttonLost.TabIndex = 77;
            this.buttonLost.Text = "Lost";
            this.buttonLost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLost.UseVisualStyleBackColor = false;
            this.buttonLost.Click += new System.EventHandler(this.buttonLost_Click);
            // 
            // buttonReturned
            // 
            this.buttonReturned.BackColor = System.Drawing.Color.LightGreen;
            this.buttonReturned.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonReturned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturned.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturned.Location = new System.Drawing.Point(470, 18);
            this.buttonReturned.Name = "buttonReturned";
            this.buttonReturned.Size = new System.Drawing.Size(144, 37);
            this.buttonReturned.TabIndex = 76;
            this.buttonReturned.Text = "Returned";
            this.buttonReturned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReturned.UseVisualStyleBackColor = false;
            this.buttonReturned.Click += new System.EventHandler(this.buttonReturned_Click);
            // 
            // buttonIssued
            // 
            this.buttonIssued.BackColor = System.Drawing.Color.MistyRose;
            this.buttonIssued.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonIssued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIssued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIssued.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIssued.Location = new System.Drawing.Point(312, 18);
            this.buttonIssued.Name = "buttonIssued";
            this.buttonIssued.Size = new System.Drawing.Size(144, 37);
            this.buttonIssued.TabIndex = 55;
            this.buttonIssued.Text = "Issued";
            this.buttonIssued.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonIssued.UseVisualStyleBackColor = false;
            this.buttonIssued.Click += new System.EventHandler(this.buttonIssued_Click);
            // 
            // dataGridViewIssuedBook
            // 
            this.dataGridViewIssuedBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIssuedBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIssuedBook.Location = new System.Drawing.Point(312, 64);
            this.dataGridViewIssuedBook.Name = "dataGridViewIssuedBook";
            this.dataGridViewIssuedBook.Size = new System.Drawing.Size(638, 352);
            this.dataGridViewIssuedBook.TabIndex = 75;
            this.dataGridViewIssuedBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIssuedBook_CellClick);
            // 
            // buttonBookLost
            // 
            this.buttonBookLost.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBookLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBookLost.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBookLost.Location = new System.Drawing.Point(625, 435);
            this.buttonBookLost.Name = "buttonBookLost";
            this.buttonBookLost.Size = new System.Drawing.Size(295, 43);
            this.buttonBookLost.TabIndex = 74;
            this.buttonBookLost.Text = "Book Lost";
            this.buttonBookLost.UseVisualStyleBackColor = false;
            this.buttonBookLost.Click += new System.EventHandler(this.buttonBookLost_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.BackColor = System.Drawing.Color.LightGreen;
            this.buttonReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturnBook.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnBook.Location = new System.Drawing.Point(329, 435);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(290, 43);
            this.buttonReturnBook.TabIndex = 73;
            this.buttonReturnBook.Text = "Return book";
            this.buttonReturnBook.UseVisualStyleBackColor = false;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(329, 484);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(591, 43);
            this.buttonDelete.TabIndex = 72;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // richTextBoxNote2
            // 
            this.richTextBoxNote2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.richTextBoxNote2.Location = new System.Drawing.Point(84, 370);
            this.richTextBoxNote2.Name = "richTextBoxNote2";
            this.richTextBoxNote2.Size = new System.Drawing.Size(222, 157);
            this.richTextBoxNote2.TabIndex = 69;
            this.richTextBoxNote2.Text = "";
            // 
            // dateTimePickerReturnDate2
            // 
            this.dateTimePickerReturnDate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerReturnDate2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerReturnDate2.Location = new System.Drawing.Point(122, 322);
            this.dateTimePickerReturnDate2.Name = "dateTimePickerReturnDate2";
            this.dateTimePickerReturnDate2.Size = new System.Drawing.Size(184, 29);
            this.dateTimePickerReturnDate2.TabIndex = 68;
            // 
            // dateTimePickerIssueDate2
            // 
            this.dateTimePickerIssueDate2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerIssueDate2.Enabled = false;
            this.dateTimePickerIssueDate2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerIssueDate2.Location = new System.Drawing.Point(122, 286);
            this.dateTimePickerIssueDate2.Name = "dateTimePickerIssueDate2";
            this.dateTimePickerIssueDate2.Size = new System.Drawing.Size(184, 29);
            this.dateTimePickerIssueDate2.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 66;
            this.label5.Text = "Note :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "Return Date :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 23);
            this.label10.TabIndex = 64;
            this.label10.Text = "Issue Date :";
            // 
            // labelMember2
            // 
            this.labelMember2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMember2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMember2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelMember2.Location = new System.Drawing.Point(19, 200);
            this.labelMember2.Name = "labelMember2";
            this.labelMember2.Size = new System.Drawing.Size(277, 73);
            this.labelMember2.TabIndex = 61;
            this.labelMember2.Text = "Member fullname";
            // 
            // labelTitle2
            // 
            this.labelTitle2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTitle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelTitle2.Location = new System.Drawing.Point(29, 104);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(267, 62);
            this.labelTitle2.TabIndex = 60;
            this.labelTitle2.Text = "Book title";
            // 
            // numericUpDownBookID2
            // 
            this.numericUpDownBookID2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownBookID2.Enabled = false;
            this.numericUpDownBookID2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBookID2.Location = new System.Drawing.Point(146, 66);
            this.numericUpDownBookID2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBookID2.Name = "numericUpDownBookID2";
            this.numericUpDownBookID2.Size = new System.Drawing.Size(160, 29);
            this.numericUpDownBookID2.TabIndex = 59;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 23);
            this.label15.TabIndex = 58;
            this.label15.Text = "Book ID :";
            // 
            // numericUpDownMemberID2
            // 
            this.numericUpDownMemberID2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericUpDownMemberID2.Enabled = false;
            this.numericUpDownMemberID2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMemberID2.Location = new System.Drawing.Point(146, 168);
            this.numericUpDownMemberID2.Name = "numericUpDownMemberID2";
            this.numericUpDownMemberID2.Size = new System.Drawing.Size(160, 29);
            this.numericUpDownMemberID2.TabIndex = 57;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 23);
            this.label16.TabIndex = 56;
            this.label16.Text = "Member ID :";
            // 
            // ManageCirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1174, 639);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.panelIssue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCirculationForm";
            this.Load += new System.EventHandler(this.ManageCirculationForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelIssue.ResumeLayout(false);
            this.panelIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemberID)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIssuedBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMemberID2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bookCountLabel;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.Panel panelIssue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMemberID;
        private System.Windows.Forms.Label labelMember;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAvailability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxNote;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssue;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.Button buttonSearchMember;
        private System.Windows.Forms.Button buttonIssueBook;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.RichTextBox richTextBoxNote2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReturnDate2;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDate2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelMember2;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.NumericUpDown numericUpDownBookID2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownMemberID2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonBookLost;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.DataGridView dataGridViewIssuedBook;
        private System.Windows.Forms.Button buttonLost;
        private System.Windows.Forms.Button buttonReturned;
        private System.Windows.Forms.Button buttonIssued;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label label11;
    }
}