namespace ConnectionInfo
{
    partial class Base
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.windowsExplorerLink = new System.Windows.Forms.LinkLabel();
            this.renameLink = new System.Windows.Forms.LinkLabel();
            this.closeButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.directoryNameField = new System.Windows.Forms.TextBox();
            this.addDirectoryButton = new System.Windows.Forms.Button();
            this.clearClipboardLink = new System.Windows.Forms.LinkLabel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WebsiteCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.moveLink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsExplorerLink
            // 
            this.windowsExplorerLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.windowsExplorerLink.AutoSize = true;
            this.windowsExplorerLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.257F);
            this.windowsExplorerLink.LinkColor = System.Drawing.Color.Black;
            this.windowsExplorerLink.Location = new System.Drawing.Point(662, 506);
            this.windowsExplorerLink.Name = "windowsExplorerLink";
            this.windowsExplorerLink.Size = new System.Drawing.Size(152, 15);
            this.windowsExplorerLink.TabIndex = 23;
            this.windowsExplorerLink.TabStop = true;
            this.windowsExplorerLink.Text = "Open in Windows Explorer";
            this.windowsExplorerLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.windowsExplorerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.windowsExplorerLink_LinkClicked);
            // 
            // renameLink
            // 
            this.renameLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.renameLink.AutoSize = true;
            this.renameLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.27F);
            this.renameLink.LinkColor = System.Drawing.Color.Black;
            this.renameLink.Location = new System.Drawing.Point(766, 28);
            this.renameLink.Name = "renameLink";
            this.renameLink.Size = new System.Drawing.Size(55, 15);
            this.renameLink.TabIndex = 22;
            this.renameLink.TabStop = true;
            this.renameLink.Text = "Rename";
            this.renameLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.renameLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.renameLink_LinkClicked);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(820, 497);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 25);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoEllipsis = true;
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Noto Sans Lisu", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.Location = new System.Drawing.Point(13, 499);
            this.pathLabel.MaximumSize = new System.Drawing.Size(600, 26);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(0, 20);
            this.pathLabel.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(547, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(99, 25);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // directoryNameField
            // 
            this.directoryNameField.BackColor = System.Drawing.SystemColors.Window;
            this.directoryNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.directoryNameField.Location = new System.Drawing.Point(351, 14);
            this.directoryNameField.Name = "directoryNameField";
            this.directoryNameField.Size = new System.Drawing.Size(158, 21);
            this.directoryNameField.TabIndex = 17;
            // 
            // addDirectoryButton
            // 
            this.addDirectoryButton.Location = new System.Drawing.Point(232, 12);
            this.addDirectoryButton.Name = "addDirectoryButton";
            this.addDirectoryButton.Size = new System.Drawing.Size(113, 25);
            this.addDirectoryButton.TabIndex = 16;
            this.addDirectoryButton.Text = "Add Directory";
            this.addDirectoryButton.UseVisualStyleBackColor = true;
            this.addDirectoryButton.Click += new System.EventHandler(this.addDirectoryButton_Click);
            // 
            // clearClipboardLink
            // 
            this.clearClipboardLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.clearClipboardLink.AutoSize = true;
            this.clearClipboardLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.257F);
            this.clearClipboardLink.LinkColor = System.Drawing.Color.Black;
            this.clearClipboardLink.Location = new System.Drawing.Point(827, 28);
            this.clearClipboardLink.Name = "clearClipboardLink";
            this.clearClipboardLink.Size = new System.Drawing.Size(92, 15);
            this.clearClipboardLink.TabIndex = 15;
            this.clearClipboardLink.TabStop = true;
            this.clearClipboardLink.Text = "Clear Clipboard";
            this.clearClipboardLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.clearClipboardLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clearClipboardLink_LinkClicked);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(106, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 25);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 25);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseCompatibleTextRendering = true;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeCol,
            this.NameCol,
            this.WebsiteCol,
            this.PasswordCol,
            this.Email,
            this.editedCol,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 438);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // TypeCol
            // 
            this.TypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.ReadOnly = true;
            this.TypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TypeCol.Width = 37;
            // 
            // NameCol
            // 
            this.NameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameCol.FillWeight = 200F;
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.ReadOnly = true;
            this.NameCol.Width = 200;
            // 
            // WebsiteCol
            // 
            this.WebsiteCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.WebsiteCol.FillWeight = 200F;
            this.WebsiteCol.HeaderText = "Website";
            this.WebsiteCol.Name = "WebsiteCol";
            this.WebsiteCol.ReadOnly = true;
            this.WebsiteCol.Width = 232;
            // 
            // PasswordCol
            // 
            this.PasswordCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PasswordCol.HeaderText = "Key Length";
            this.PasswordCol.Name = "PasswordCol";
            this.PasswordCol.ReadOnly = true;
            this.PasswordCol.Width = 90;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 232;
            // 
            // editedCol
            // 
            this.editedCol.HeaderText = "Last Edited";
            this.editedCol.Name = "editedCol";
            this.editedCol.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Type";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // statsLinkLabel
            // 
            this.statsLinkLabel.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.statsLinkLabel.AutoSize = true;
            this.statsLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.257F);
            this.statsLinkLabel.LinkColor = System.Drawing.Color.Black;
            this.statsLinkLabel.Location = new System.Drawing.Point(856, 9);
            this.statsLinkLabel.Name = "statsLinkLabel";
            this.statsLinkLabel.Size = new System.Drawing.Size(63, 15);
            this.statsLinkLabel.TabIndex = 25;
            this.statsLinkLabel.TabStop = true;
            this.statsLinkLabel.Text = "View Stats";
            this.statsLinkLabel.VisitedLinkColor = System.Drawing.Color.Black;
            this.statsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.statsLinkLabel_LinkClicked);
            // 
            // moveLink
            // 
            this.moveLink.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.moveLink.AutoSize = true;
            this.moveLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.257F);
            this.moveLink.LinkColor = System.Drawing.Color.Black;
            this.moveLink.Location = new System.Drawing.Point(766, 9);
            this.moveLink.Name = "moveLink";
            this.moveLink.Size = new System.Drawing.Size(37, 15);
            this.moveLink.TabIndex = 26;
            this.moveLink.TabStop = true;
            this.moveLink.Text = "Move";
            this.moveLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.moveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.moveLink_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ConnectionInfo.Properties.Resources.documentImage;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::ConnectionInfo.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(652, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(25, 25);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 531);
            this.Controls.Add(this.moveLink);
            this.Controls.Add(this.statsLinkLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.windowsExplorerLink);
            this.Controls.Add(this.renameLink);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.directoryNameField);
            this.Controls.Add(this.addDirectoryButton);
            this.Controls.Add(this.clearClipboardLink);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Base";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel windowsExplorerLink;
        private System.Windows.Forms.LinkLabel renameLink;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox directoryNameField;
        private System.Windows.Forms.Button addDirectoryButton;
        private System.Windows.Forms.LinkLabel clearClipboardLink;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn TypeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WebsiteCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn editedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel statsLinkLabel;
        private System.Windows.Forms.LinkLabel moveLink;
    }
}