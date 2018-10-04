namespace ContactsExplorer {
  partial class mainForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
      this.mainDataGrid = new System.Windows.Forms.DataGridView();
      this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.type = new System.Windows.Forms.DataGridViewImageColumn();
      this.image = new System.Windows.Forms.DataGridViewImageColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.filterGroupBox = new System.Windows.Forms.GroupBox();
      this.filterSkype = new System.Windows.Forms.CheckBox();
      this.filterViberAccounts = new System.Windows.Forms.CheckBox();
      this.filterViber = new System.Windows.Forms.CheckBox();
      this.filterAll = new System.Windows.Forms.CheckBox();
      this.contactPictureBox = new System.Windows.Forms.PictureBox();
      this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
      this.addDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.skypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.addDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.viberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.skypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.pictureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.listMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.filterGroupBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).BeginInit();
      this.mainMenu.SuspendLayout();
      this.pictureMenuStrip.SuspendLayout();
      this.listMenuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainDataGrid
      // 
      this.mainDataGrid.AllowUserToAddRows = false;
      this.mainDataGrid.AllowUserToDeleteRows = false;
      this.mainDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
      this.mainDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
      this.mainDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mainDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.mainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.mainDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.type,
            this.image,
            this.name,
            this.phone,
            this.timestamp});
      this.mainDataGrid.ContextMenuStrip = this.listMenuStrip;
      this.mainDataGrid.Location = new System.Drawing.Point(0, 0);
      this.mainDataGrid.MultiSelect = false;
      this.mainDataGrid.Name = "mainDataGrid";
      this.mainDataGrid.ReadOnly = true;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.mainDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.mainDataGrid.RowHeadersVisible = false;
      this.mainDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.mainDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.mainDataGrid.Size = new System.Drawing.Size(502, 500);
      this.mainDataGrid.TabIndex = 2;
      this.mainDataGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
      this.mainDataGrid.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      this.mainDataGrid.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
      this.mainDataGrid.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
      // 
      // num
      // 
      this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.num.DefaultCellStyle = dataGridViewCellStyle1;
      this.num.HeaderText = "#";
      this.num.MinimumWidth = 20;
      this.num.Name = "num";
      this.num.ReadOnly = true;
      this.num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.num.Width = 20;
      // 
      // type
      // 
      this.type.HeaderText = "";
      this.type.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.type.MinimumWidth = 20;
      this.type.Name = "type";
      this.type.ReadOnly = true;
      this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.type.ToolTipText = "Type";
      this.type.Width = 20;
      // 
      // image
      // 
      this.image.HeaderText = "";
      this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.image.MinimumWidth = 20;
      this.image.Name = "image";
      this.image.ReadOnly = true;
      this.image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.image.ToolTipText = "Avatar";
      this.image.Width = 20;
      // 
      // name
      // 
      this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.name.HeaderText = "Name";
      this.name.MinimumWidth = 70;
      this.name.Name = "name";
      this.name.ReadOnly = true;
      this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.name.Width = 160;
      // 
      // phone
      // 
      this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.phone.HeaderText = "Phone";
      this.phone.MinimumWidth = 70;
      this.phone.Name = "phone";
      this.phone.ReadOnly = true;
      this.phone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.phone.Width = 120;
      // 
      // timestamp
      // 
      this.timestamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.timestamp.HeaderText = "Time";
      this.timestamp.MinimumWidth = 70;
      this.timestamp.Name = "timestamp";
      this.timestamp.ReadOnly = true;
      // 
      // openFileDialog
      // 
      this.openFileDialog.CheckFileExists = false;
      this.openFileDialog.CheckPathExists = false;
      this.openFileDialog.FileName = "viber.db";
      this.openFileDialog.Filter = "SQLite database|*.db";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.filterGroupBox);
      this.splitContainer1.Panel1.Controls.Add(this.mainDataGrid);
      this.splitContainer1.Panel1MinSize = 300;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
      this.splitContainer1.Panel2.Controls.Add(this.contactPictureBox);
      this.splitContainer1.Panel2MinSize = 200;
      this.splitContainer1.Size = new System.Drawing.Size(1061, 552);
      this.splitContainer1.SplitterDistance = 502;
      this.splitContainer1.SplitterWidth = 6;
      this.splitContainer1.TabIndex = 5;
      // 
      // filterGroupBox
      // 
      this.filterGroupBox.Controls.Add(this.filterSkype);
      this.filterGroupBox.Controls.Add(this.filterViberAccounts);
      this.filterGroupBox.Controls.Add(this.filterViber);
      this.filterGroupBox.Controls.Add(this.filterAll);
      this.filterGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.filterGroupBox.Location = new System.Drawing.Point(0, 506);
      this.filterGroupBox.Name = "filterGroupBox";
      this.filterGroupBox.Size = new System.Drawing.Size(502, 46);
      this.filterGroupBox.TabIndex = 4;
      this.filterGroupBox.TabStop = false;
      this.filterGroupBox.Text = "Filter";
      // 
      // filterSkype
      // 
      this.filterSkype.AutoSize = true;
      this.filterSkype.Location = new System.Drawing.Point(236, 17);
      this.filterSkype.Name = "filterSkype";
      this.filterSkype.Size = new System.Drawing.Size(55, 17);
      this.filterSkype.TabIndex = 3;
      this.filterSkype.Text = "Skype";
      this.filterSkype.UseVisualStyleBackColor = true;
      this.filterSkype.CheckedChanged += new System.EventHandler(this.filterSkype_CheckedChanged);
      // 
      // filterViberAccounts
      // 
      this.filterViberAccounts.AutoSize = true;
      this.filterViberAccounts.Location = new System.Drawing.Point(111, 17);
      this.filterViberAccounts.Name = "filterViberAccounts";
      this.filterViberAccounts.Size = new System.Drawing.Size(119, 17);
      this.filterViberAccounts.TabIndex = 2;
      this.filterViberAccounts.Text = "Viber accounts only";
      this.filterViberAccounts.UseVisualStyleBackColor = true;
      this.filterViberAccounts.CheckedChanged += new System.EventHandler(this.filterViberAccounts_CheckedChanged);
      // 
      // filterViber
      // 
      this.filterViber.AutoSize = true;
      this.filterViber.Location = new System.Drawing.Point(55, 17);
      this.filterViber.Name = "filterViber";
      this.filterViber.Size = new System.Drawing.Size(50, 17);
      this.filterViber.TabIndex = 1;
      this.filterViber.Text = "Viber";
      this.filterViber.UseVisualStyleBackColor = true;
      this.filterViber.CheckedChanged += new System.EventHandler(this.filterViber_CheckedChanged);
      // 
      // filterAll
      // 
      this.filterAll.AutoSize = true;
      this.filterAll.Location = new System.Drawing.Point(12, 17);
      this.filterAll.Name = "filterAll";
      this.filterAll.Size = new System.Drawing.Size(37, 17);
      this.filterAll.TabIndex = 0;
      this.filterAll.Text = "All";
      this.filterAll.UseVisualStyleBackColor = true;
      this.filterAll.CheckedChanged += new System.EventHandler(this.filterAll_CheckedChanged);
      // 
      // contactPictureBox
      // 
      this.contactPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.contactPictureBox.Location = new System.Drawing.Point(0, 0);
      this.contactPictureBox.Name = "contactPictureBox";
      this.contactPictureBox.Size = new System.Drawing.Size(553, 552);
      this.contactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.contactPictureBox.TabIndex = 3;
      this.contactPictureBox.TabStop = false;
      this.contactPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
      this.contactPictureBox.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
      // 
      // BottomToolStripPanel
      // 
      this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.BottomToolStripPanel.Name = "BottomToolStripPanel";
      this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // TopToolStripPanel
      // 
      this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.TopToolStripPanel.Name = "TopToolStripPanel";
      this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // RightToolStripPanel
      // 
      this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.RightToolStripPanel.Name = "RightToolStripPanel";
      this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // LeftToolStripPanel
      // 
      this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
      this.LeftToolStripPanel.Name = "LeftToolStripPanel";
      this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
      this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
      // 
      // ContentPanel
      // 
      this.ContentPanel.Size = new System.Drawing.Size(692, 20);
      // 
      // addDatabaseToolStripMenuItem
      // 
      this.addDatabaseToolStripMenuItem.Name = "addDatabaseToolStripMenuItem";
      this.addDatabaseToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
      this.addDatabaseToolStripMenuItem.Text = "Add database";
      // 
      // viberToolStripMenuItem
      // 
      this.viberToolStripMenuItem.Name = "viberToolStripMenuItem";
      this.viberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.viberToolStripMenuItem.Text = "Viber";
      // 
      // skypeToolStripMenuItem
      // 
      this.skypeToolStripMenuItem.Name = "skypeToolStripMenuItem";
      this.skypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.skypeToolStripMenuItem.Text = "Skype";
      // 
      // mainMenu
      // 
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatabaseToolStripMenuItem1,
            this.aboutToolStripMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.mainMenu.Size = new System.Drawing.Size(1061, 24);
      this.mainMenu.TabIndex = 6;
      this.mainMenu.Text = "menuStrip1";
      this.mainMenu.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
      // 
      // addDatabaseToolStripMenuItem1
      // 
      this.addDatabaseToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viberToolStripMenuItem1,
            this.skypeToolStripMenuItem1,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.addDatabaseToolStripMenuItem1.Name = "addDatabaseToolStripMenuItem1";
      this.addDatabaseToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
      this.addDatabaseToolStripMenuItem1.Text = "Database";
      this.addDatabaseToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // viberToolStripMenuItem1
      // 
      this.viberToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("viberToolStripMenuItem1.Image")));
      this.viberToolStripMenuItem1.Name = "viberToolStripMenuItem1";
      this.viberToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
      this.viberToolStripMenuItem1.Text = "Viber";
      this.viberToolStripMenuItem1.Click += new System.EventHandler(this.viberToolStripMenuItem_Click);
      // 
      // skypeToolStripMenuItem1
      // 
      this.skypeToolStripMenuItem1.Image = global::ContactsExplorer.Properties.Resources.skype;
      this.skypeToolStripMenuItem1.Name = "skypeToolStripMenuItem1";
      this.skypeToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
      this.skypeToolStripMenuItem1.Text = "Skype";
      this.skypeToolStripMenuItem1.Click += new System.EventHandler(this.skypeToolStripMenuItem1_Click);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem1
      // 
      this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
      this.saveToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
      this.saveToolStripMenuItem1.Text = "Save";
      this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // pictureMenuStrip
      // 
      this.pictureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.pictureMenuStrip.Name = "contextMenuStrip1";
      this.pictureMenuStrip.Size = new System.Drawing.Size(100, 48);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // listMenuStrip
      // 
      this.listMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
      this.listMenuStrip.Name = "listMenuStrip";
      this.listMenuStrip.Size = new System.Drawing.Size(181, 48);
      this.listMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.listMenuStrip_Opening);
      // 
      // copyToClipboardToolStripMenuItem
      // 
      this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
      this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.copyToClipboardToolStripMenuItem.Text = "Copy to clipboard";
      this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
      // 
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1061, 576);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.mainMenu);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(700, 400);
      this.Name = "mainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Contacts explorer";
      this.Load += new System.EventHandler(this.mainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.mainDataGrid)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.filterGroupBox.ResumeLayout(false);
      this.filterGroupBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).EndInit();
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.pictureMenuStrip.ResumeLayout(false);
      this.listMenuStrip.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView mainDataGrid;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.PictureBox contactPictureBox;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
    private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
    private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
    private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
    private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viberToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem skypeToolStripMenuItem;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem viberToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem skypeToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog;
    private System.Windows.Forms.ContextMenuStrip pictureMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.DataGridViewTextBoxColumn num;
    private System.Windows.Forms.DataGridViewImageColumn type;
    private System.Windows.Forms.DataGridViewImageColumn image;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    private System.Windows.Forms.DataGridViewTextBoxColumn timestamp;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
    private System.Windows.Forms.GroupBox filterGroupBox;
    private System.Windows.Forms.CheckBox filterSkype;
    private System.Windows.Forms.CheckBox filterViberAccounts;
    private System.Windows.Forms.CheckBox filterViber;
    private System.Windows.Forms.CheckBox filterAll;
    private System.Windows.Forms.ContextMenuStrip listMenuStrip;
    private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
  }
}

