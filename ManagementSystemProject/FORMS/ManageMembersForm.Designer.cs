namespace ManagementSystemProject.FORMS
{
    partial class ManageMembersForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonRefreshTable = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.buttonSelectPicture = new System.Windows.Forms.Button();
            this.pictureBoxMember = new System.Windows.Forms.PictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.snameTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnameTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.memberCountLabel = new System.Windows.Forms.Label();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.removeButton1 = new System.Windows.Forms.Button();
            this.editButton1 = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeWindow1
            // 
            this.closeWindow1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.closeWindow1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeWindow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeWindow1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.closeWindow1.Location = new System.Drawing.Point(1257, 9);
            this.closeWindow1.Name = "closeWindow1";
            this.closeWindow1.Size = new System.Drawing.Size(34, 29);
            this.closeWindow1.TabIndex = 9;
            this.closeWindow1.Text = "X";
            this.closeWindow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeWindow1.Click += new System.EventHandler(this.closeWindow1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1301, 93);
            this.label1.TabIndex = 10;
            this.label1.Text = "Members";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonRefreshTable);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.buttonSelectPicture);
            this.panel2.Controls.Add(this.pictureBoxMember);
            this.panel2.Controls.Add(this.textBoxEmail);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxPhoneNumber);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dataGridViewMembers);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.snameTextbox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fnameTextbox);
            this.panel2.Controls.Add(this.idTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(179, 95);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 564);
            this.panel2.TabIndex = 12;
            // 
            // buttonRefreshTable
            // 
            this.buttonRefreshTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefreshTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshTable.Location = new System.Drawing.Point(384, 511);
            this.buttonRefreshTable.Name = "buttonRefreshTable";
            this.buttonRefreshTable.Size = new System.Drawing.Size(728, 41);
            this.buttonRefreshTable.TabIndex = 60;
            this.buttonRefreshTable.Text = "Refresh Table";
            this.buttonRefreshTable.UseVisualStyleBackColor = false;
            this.buttonRefreshTable.Click += new System.EventHandler(this.buttonRefreshTable_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 59;
            this.label8.Text = "Picture:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonFemale);
            this.groupBox1.Controls.Add(this.radioButtonMale);
            this.groupBox1.Location = new System.Drawing.Point(119, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 31);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(102, 8);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(72, 21);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.CheckedChanged += new System.EventHandler(this.radioButtonFemale_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(0, 8);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(56, 21);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.CheckedChanged += new System.EventHandler(this.radioButtonMale_CheckedChanged);
            // 
            // buttonSelectPicture
            // 
            this.buttonSelectPicture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSelectPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectPicture.Location = new System.Drawing.Point(119, 511);
            this.buttonSelectPicture.Name = "buttonSelectPicture";
            this.buttonSelectPicture.Size = new System.Drawing.Size(248, 41);
            this.buttonSelectPicture.TabIndex = 57;
            this.buttonSelectPicture.Text = "Select member picture";
            this.buttonSelectPicture.UseVisualStyleBackColor = false;
            this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
            // 
            // pictureBoxMember
            // 
            this.pictureBoxMember.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxMember.ImageLocation = "../../IMAGES/userimage.png";
            this.pictureBoxMember.Location = new System.Drawing.Point(119, 275);
            this.pictureBoxMember.Name = "pictureBoxMember";
            this.pictureBoxMember.Size = new System.Drawing.Size(248, 221);
            this.pictureBoxMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMember.TabIndex = 56;
            this.pictureBoxMember.TabStop = false;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(119, 209);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(248, 31);
            this.textBoxEmail.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(119, 172);
            this.textBoxPhoneNumber.Multiline = true;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(248, 31);
            this.textBoxPhoneNumber.TabIndex = 16;
            this.textBoxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhoneNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone:";
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.AllowUserToAddRows = false;
            this.dataGridViewMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(384, 17);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.Size = new System.Drawing.Size(728, 479);
            this.dataGridViewMembers.TabIndex = 14;
            this.dataGridViewMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMembers_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender:";
            // 
            // snameTextbox
            // 
            this.snameTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snameTextbox.Location = new System.Drawing.Point(119, 98);
            this.snameTextbox.Multiline = true;
            this.snameTextbox.Name = "snameTextbox";
            this.snameTextbox.Size = new System.Drawing.Size(248, 31);
            this.snameTextbox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surname:";
            // 
            // fnameTextbox
            // 
            this.fnameTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fnameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameTextbox.Location = new System.Drawing.Point(119, 61);
            this.fnameTextbox.Multiline = true;
            this.fnameTextbox.Name = "fnameTextbox";
            this.fnameTextbox.Size = new System.Drawing.Size(248, 31);
            this.fnameTextbox.TabIndex = 7;
            // 
            // idTextbox
            // 
            this.idTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextbox.Location = new System.Drawing.Point(119, 17);
            this.idTextbox.Multiline = true;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.ReadOnly = true;
            this.idTextbox.Size = new System.Drawing.Size(123, 31);
            this.idTextbox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.memberCountLabel);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Controls.Add(this.removeButton1);
            this.panel1.Controls.Add(this.editButton1);
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Location = new System.Drawing.Point(0, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 566);
            this.panel1.TabIndex = 11;
            // 
            // memberCountLabel
            // 
            this.memberCountLabel.AutoSize = true;
            this.memberCountLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.memberCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberCountLabel.Location = new System.Drawing.Point(21, 533);
            this.memberCountLabel.Name = "memberCountLabel";
            this.memberCountLabel.Size = new System.Drawing.Size(145, 24);
            this.memberCountLabel.TabIndex = 53;
            this.memberCountLabel.Text = "99999 Members";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClearFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.Location = new System.Drawing.Point(7, 228);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(161, 58);
            this.buttonClearFields.TabIndex = 9;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClearFields.UseVisualStyleBackColor = false;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // removeButton1
            // 
            this.removeButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.removeButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton1.Location = new System.Drawing.Point(7, 161);
            this.removeButton1.Name = "removeButton1";
            this.removeButton1.Size = new System.Drawing.Size(161, 51);
            this.removeButton1.TabIndex = 8;
            this.removeButton1.Text = "Remove";
            this.removeButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.removeButton1.UseVisualStyleBackColor = false;
            this.removeButton1.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // editButton1
            // 
            this.editButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.editButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton1.Location = new System.Drawing.Point(7, 91);
            this.editButton1.Name = "editButton1";
            this.editButton1.Size = new System.Drawing.Size(161, 51);
            this.editButton1.TabIndex = 7;
            this.editButton1.Text = "Edit";
            this.editButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton1.UseVisualStyleBackColor = false;
            this.editButton1.Click += new System.EventHandler(this.editButton1_Click);
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton1.Location = new System.Drawing.Point(7, 23);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(161, 51);
            this.addButton1.TabIndex = 6;
            this.addButton1.Text = "Add";
            this.addButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton1.UseVisualStyleBackColor = false;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // ManageMembersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeWindow1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMembersForm";
            this.Load += new System.EventHandler(this.ManageMembersForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label closeWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox snameTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnameTextbox;
        private System.Windows.Forms.TextBox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label memberCountLabel;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button removeButton1;
        private System.Windows.Forms.Button editButton1;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Button buttonSelectPicture;
        private System.Windows.Forms.PictureBox pictureBoxMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button buttonRefreshTable;
    }
}