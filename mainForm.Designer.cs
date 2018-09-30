﻿namespace ContactsExplorer {
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.type = new System.Windows.Forms.DataGridViewImageColumn();
      this.image = new System.Windows.Forms.DataGridViewImageColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.filterSkype = new System.Windows.Forms.CheckBox();
      this.filterViberAccounts = new System.Windows.Forms.CheckBox();
      this.filterViber = new System.Windows.Forms.CheckBox();
      this.filterAll = new System.Windows.Forms.CheckBox();
      this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
      this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
      this.addDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.skypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.addDatabaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.viberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.skypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.type,
            this.image,
            this.name,
            this.phone,
            this.timestamp});
      this.dataGridView1.Location = new System.Drawing.Point(0, 0);
      this.dataGridView1.MultiSelect = false;
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridView1.RowHeadersVisible = false;
      this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(502, 500);
      this.dataGridView1.TabIndex = 2;
      this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
      this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
      this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
      this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
      // 
      // num
      // 
      this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.num.DefaultCellStyle = dataGridViewCellStyle3;
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
      // openFileDialog1
      // 
      this.openFileDialog1.CheckFileExists = false;
      this.openFileDialog1.CheckPathExists = false;
      this.openFileDialog1.FileName = "viber.db";
      this.openFileDialog1.Filter = "SQLite database|*.db";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 24);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
      this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
      this.splitContainer1.Panel1MinSize = 300;
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
      this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
      this.splitContainer1.Panel2MinSize = 200;
      this.splitContainer1.Size = new System.Drawing.Size(1061, 552);
      this.splitContainer1.SplitterDistance = 502;
      this.splitContainer1.SplitterWidth = 6;
      this.splitContainer1.TabIndex = 5;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.filterSkype);
      this.groupBox1.Controls.Add(this.filterViberAccounts);
      this.groupBox1.Controls.Add(this.filterViber);
      this.groupBox1.Controls.Add(this.filterAll);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 506);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(502, 46);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Filter";
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
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDatabaseToolStripMenuItem1,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
      this.menuStrip1.Size = new System.Drawing.Size(1061, 24);
      this.menuStrip1.TabIndex = 6;
      this.menuStrip1.Text = "menuStrip1";
      this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
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
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
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
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 0);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(553, 552);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
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
      // mainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1061, 576);
      this.Controls.Add(this.splitContainer1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(700, 400);
      this.Name = "mainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Contacts explorer";
      this.Load += new System.EventHandler(this.mainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
    private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
    private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
    private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
    private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem viberToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem skypeToolStripMenuItem;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem addDatabaseToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem viberToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem skypeToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.CheckBox filterSkype;
    private System.Windows.Forms.CheckBox filterViberAccounts;
    private System.Windows.Forms.CheckBox filterViber;
    private System.Windows.Forms.CheckBox filterAll;
  }
}

