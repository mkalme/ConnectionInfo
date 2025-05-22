namespace ConnectionInfo
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.emailLabel = new System.Windows.Forms.LinkLabel();
            this.emailField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enableEditing = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passwordGeneratorLink = new System.Windows.Forms.LinkLabel();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.passwordGenField = new System.Windows.Forms.TextBox();
            this.passwordGenButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changeName2 = new System.Windows.Forms.LinkLabel();
            this.passwordLink3 = new System.Windows.Forms.LinkLabel();
            this.labelName1 = new System.Windows.Forms.Label();
            this.nameField2 = new System.Windows.Forms.TextBox();
            this.passwordField2 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeName1 = new System.Windows.Forms.LinkLabel();
            this.passwordLink2 = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.nameField1 = new System.Windows.Forms.TextBox();
            this.passwordField1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.notesLink = new System.Windows.Forms.LinkLabel();
            this.noteBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.passwordLink1 = new System.Windows.Forms.LinkLabel();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.websiteField = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.emailLabel);
            this.groupBox8.Controls.Add(this.emailField);
            this.groupBox8.Location = new System.Drawing.Point(11, 194);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(238, 68);
            this.groupBox8.TabIndex = 28;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "E-Mail";
            // 
            // emailLabel
            // 
            this.emailLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.emailLabel.AutoSize = true;
            this.emailLabel.LinkColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(6, 42);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(89, 13);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.TabStop = true;
            this.emailLabel.Text = "Copy to clipboard";
            this.emailLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.emailLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLabel_LinkClicked);
            // 
            // emailField
            // 
            this.emailField.Location = new System.Drawing.Point(6, 19);
            this.emailField.Name = "emailField";
            this.emailField.Size = new System.Drawing.Size(226, 20);
            this.emailField.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 27;
            // 
            // enableEditing
            // 
            this.enableEditing.AutoSize = true;
            this.enableEditing.Checked = true;
            this.enableEditing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableEditing.Location = new System.Drawing.Point(401, 415);
            this.enableEditing.Name = "enableEditing";
            this.enableEditing.Size = new System.Drawing.Size(94, 17);
            this.enableEditing.TabIndex = 26;
            this.enableEditing.Text = "Enable Editing";
            this.enableEditing.UseVisualStyleBackColor = true;
            this.enableEditing.CheckedChanged += new System.EventHandler(this.enableEditing_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(112, 410);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 26);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(95, 25);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.passwordGeneratorLink);
            this.groupBox7.Controls.Add(this.maskedTextBox4);
            this.groupBox7.Controls.Add(this.passwordGenField);
            this.groupBox7.Controls.Add(this.passwordGenButton);
            this.groupBox7.Location = new System.Drawing.Point(255, 292);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(238, 96);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Password Generator";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(143, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Width (characters)";
            // 
            // passwordGeneratorLink
            // 
            this.passwordGeneratorLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.passwordGeneratorLink.AutoSize = true;
            this.passwordGeneratorLink.LinkColor = System.Drawing.Color.Black;
            this.passwordGeneratorLink.Location = new System.Drawing.Point(6, 44);
            this.passwordGeneratorLink.Name = "passwordGeneratorLink";
            this.passwordGeneratorLink.Size = new System.Drawing.Size(89, 13);
            this.passwordGeneratorLink.TabIndex = 8;
            this.passwordGeneratorLink.TabStop = true;
            this.passwordGeneratorLink.Text = "Copy to clipboard";
            this.passwordGeneratorLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.passwordGeneratorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordGeneratorLink_LinkClicked);
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(170, 68);
            this.maskedTextBox4.Mask = "00000";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(62, 20);
            this.maskedTextBox4.TabIndex = 10;
            // 
            // passwordGenField
            // 
            this.passwordGenField.Location = new System.Drawing.Point(6, 21);
            this.passwordGenField.Name = "passwordGenField";
            this.passwordGenField.Size = new System.Drawing.Size(226, 20);
            this.passwordGenField.TabIndex = 8;
            // 
            // passwordGenButton
            // 
            this.passwordGenButton.Location = new System.Drawing.Point(6, 67);
            this.passwordGenButton.Name = "passwordGenButton";
            this.passwordGenButton.Size = new System.Drawing.Size(158, 23);
            this.passwordGenButton.TabIndex = 9;
            this.passwordGenButton.Text = "Generate Random Password";
            this.passwordGenButton.UseVisualStyleBackColor = true;
            this.passwordGenButton.Click += new System.EventHandler(this.passwordGenButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.changeName2);
            this.groupBox6.Controls.Add(this.passwordLink3);
            this.groupBox6.Controls.Add(this.labelName1);
            this.groupBox6.Controls.Add(this.nameField2);
            this.groupBox6.Controls.Add(this.passwordField2);
            this.groupBox6.Location = new System.Drawing.Point(255, 147);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(237, 131);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Entry #2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Width (characters)";
            // 
            // changeName2
            // 
            this.changeName2.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.changeName2.AutoSize = true;
            this.changeName2.LinkColor = System.Drawing.Color.Black;
            this.changeName2.Location = new System.Drawing.Point(160, 23);
            this.changeName2.Name = "changeName2";
            this.changeName2.Size = new System.Drawing.Size(75, 13);
            this.changeName2.TabIndex = 10;
            this.changeName2.TabStop = true;
            this.changeName2.Text = "Change Name";
            this.changeName2.VisitedLinkColor = System.Drawing.Color.Black;
            this.changeName2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeName2_LinkClicked);
            // 
            // passwordLink3
            // 
            this.passwordLink3.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.passwordLink3.AutoSize = true;
            this.passwordLink3.LinkColor = System.Drawing.Color.Black;
            this.passwordLink3.Location = new System.Drawing.Point(5, 107);
            this.passwordLink3.Name = "passwordLink3";
            this.passwordLink3.Size = new System.Drawing.Size(89, 13);
            this.passwordLink3.TabIndex = 12;
            this.passwordLink3.TabStop = true;
            this.passwordLink3.Text = "Copy to clipboard";
            this.passwordLink3.VisitedLinkColor = System.Drawing.Color.Black;
            this.passwordLink3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordLink3_LinkClicked);
            // 
            // labelName1
            // 
            this.labelName1.AutoSize = true;
            this.labelName1.Location = new System.Drawing.Point(3, 23);
            this.labelName1.Name = "labelName1";
            this.labelName1.Size = new System.Drawing.Size(35, 13);
            this.labelName1.TabIndex = 1;
            this.labelName1.Text = "Name";
            // 
            // nameField2
            // 
            this.nameField2.Location = new System.Drawing.Point(6, 39);
            this.nameField2.Name = "nameField2";
            this.nameField2.Size = new System.Drawing.Size(225, 20);
            this.nameField2.TabIndex = 0;
            // 
            // passwordField2
            // 
            this.passwordField2.Location = new System.Drawing.Point(5, 84);
            this.passwordField2.Name = "passwordField2";
            this.passwordField2.Size = new System.Drawing.Size(226, 20);
            this.passwordField2.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.changeName1);
            this.groupBox5.Controls.Add(this.passwordLink2);
            this.groupBox5.Controls.Add(this.labelName);
            this.groupBox5.Controls.Add(this.nameField1);
            this.groupBox5.Controls.Add(this.passwordField1);
            this.groupBox5.Location = new System.Drawing.Point(255, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(237, 131);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Entry #1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Width (characters)";
            // 
            // changeName1
            // 
            this.changeName1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.changeName1.AutoSize = true;
            this.changeName1.LinkColor = System.Drawing.Color.Black;
            this.changeName1.Location = new System.Drawing.Point(160, 23);
            this.changeName1.Name = "changeName1";
            this.changeName1.Size = new System.Drawing.Size(75, 13);
            this.changeName1.TabIndex = 10;
            this.changeName1.TabStop = true;
            this.changeName1.Text = "Change Name";
            this.changeName1.VisitedLinkColor = System.Drawing.Color.Black;
            this.changeName1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeName1_LinkClicked);
            // 
            // passwordLink2
            // 
            this.passwordLink2.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.passwordLink2.AutoSize = true;
            this.passwordLink2.LinkColor = System.Drawing.Color.Black;
            this.passwordLink2.Location = new System.Drawing.Point(5, 107);
            this.passwordLink2.Name = "passwordLink2";
            this.passwordLink2.Size = new System.Drawing.Size(89, 13);
            this.passwordLink2.TabIndex = 12;
            this.passwordLink2.TabStop = true;
            this.passwordLink2.Text = "Copy to clipboard";
            this.passwordLink2.VisitedLinkColor = System.Drawing.Color.Black;
            this.passwordLink2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordLink2_LinkClicked);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // nameField1
            // 
            this.nameField1.Location = new System.Drawing.Point(6, 39);
            this.nameField1.Name = "nameField1";
            this.nameField1.Size = new System.Drawing.Size(225, 20);
            this.nameField1.TabIndex = 0;
            // 
            // passwordField1
            // 
            this.passwordField1.Location = new System.Drawing.Point(5, 84);
            this.passwordField1.Name = "passwordField1";
            this.passwordField1.Size = new System.Drawing.Size(226, 20);
            this.passwordField1.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.notesLink);
            this.groupBox4.Controls.Add(this.noteBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 268);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 120);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notes";
            // 
            // notesLink
            // 
            this.notesLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.notesLink.AutoSize = true;
            this.notesLink.LinkColor = System.Drawing.Color.Black;
            this.notesLink.Location = new System.Drawing.Point(6, 15);
            this.notesLink.Name = "notesLink";
            this.notesLink.Size = new System.Drawing.Size(89, 13);
            this.notesLink.TabIndex = 9;
            this.notesLink.TabStop = true;
            this.notesLink.Text = "Copy to clipboard";
            this.notesLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.notesLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notesLink_LinkClicked);
            // 
            // noteBox
            // 
            this.noteBox.Location = new System.Drawing.Point(6, 35);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(225, 77);
            this.noteBox.TabIndex = 0;
            this.noteBox.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.passwordLink1);
            this.groupBox3.Controls.Add(this.passwordField);
            this.groupBox3.Location = new System.Drawing.Point(11, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 68);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Password";
            // 
            // passwordLink1
            // 
            this.passwordLink1.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.passwordLink1.AutoSize = true;
            this.passwordLink1.LinkColor = System.Drawing.Color.Black;
            this.passwordLink1.Location = new System.Drawing.Point(6, 42);
            this.passwordLink1.Name = "passwordLink1";
            this.passwordLink1.Size = new System.Drawing.Size(89, 13);
            this.passwordLink1.TabIndex = 8;
            this.passwordLink1.TabStop = true;
            this.passwordLink1.Text = "Copy to clipboard";
            this.passwordLink1.VisitedLinkColor = System.Drawing.Color.Black;
            this.passwordLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.passwordLink1_LinkClicked);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(6, 19);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(226, 20);
            this.passwordField.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.websiteField);
            this.groupBox1.Location = new System.Drawing.Point(11, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 50);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Website";
            // 
            // websiteField
            // 
            this.websiteField.Location = new System.Drawing.Point(6, 19);
            this.websiteField.Name = "websiteField";
            this.websiteField.Size = new System.Drawing.Size(226, 20);
            this.websiteField.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameField);
            this.groupBox2.Location = new System.Drawing.Point(11, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 47);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Name";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(6, 16);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(226, 20);
            this.nameField.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 446);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enableEditing);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.LinkLabel emailLabel;
        private System.Windows.Forms.TextBox emailField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enableEditing;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel passwordGeneratorLink;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.TextBox passwordGenField;
        private System.Windows.Forms.Button passwordGenButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel changeName2;
        private System.Windows.Forms.LinkLabel passwordLink3;
        public System.Windows.Forms.Label labelName1;
        private System.Windows.Forms.TextBox nameField2;
        private System.Windows.Forms.TextBox passwordField2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel changeName1;
        private System.Windows.Forms.LinkLabel passwordLink2;
        public System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox nameField1;
        private System.Windows.Forms.TextBox passwordField1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel notesLink;
        private System.Windows.Forms.RichTextBox noteBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel passwordLink1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox websiteField;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Timer timer1;
    }
}