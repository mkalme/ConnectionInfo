namespace ConnectionInfo
{
    partial class Document
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.changeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(566, 270);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(498, 294);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(80, 25);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // changeFont
            // 
            this.changeFont.Location = new System.Drawing.Point(12, 294);
            this.changeFont.Name = "changeFont";
            this.changeFont.Size = new System.Drawing.Size(84, 25);
            this.changeFont.TabIndex = 2;
            this.changeFont.Text = "Change Font";
            this.changeFont.UseVisualStyleBackColor = true;
            this.changeFont.Click += new System.EventHandler(this.changeFont_Click);
            // 
            // Document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 331);
            this.Controls.Add(this.changeFont);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Document";
            this.Load += new System.EventHandler(this.Document_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button changeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}