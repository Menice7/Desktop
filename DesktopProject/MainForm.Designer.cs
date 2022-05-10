
namespace DesktopProject
{
    partial class MainForm
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
            this.grdList = new System.Windows.Forms.DataGridView();
            this.CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxtmSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grdComp = new System.Windows.Forms.DataGridView();
            this.ComputerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComputerBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sortedByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saledNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ascendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descendingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.cntxtmSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdComp)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdList
            // 
            this.grdList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyId,
            this.CompanyName,
            this.UserId,
            this.TotalNumber,
            this.Number});
            this.grdList.ContextMenuStrip = this.cntxtmSort;
            this.grdList.Location = new System.Drawing.Point(10, 130);
            this.grdList.Name = "grdList";
            this.grdList.RowHeadersWidth = 51;
            this.grdList.RowTemplate.Height = 24;
            this.grdList.Size = new System.Drawing.Size(415, 523);
            this.grdList.TabIndex = 1;
            // 
            // CompanyId
            // 
            this.CompanyId.DataPropertyName = "CompanyId";
            this.CompanyId.HeaderText = "CompanyId";
            this.CompanyId.MinimumWidth = 6;
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.Visible = false;
            this.CompanyId.Width = 125;
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "CompanyName";
            this.CompanyName.MinimumWidth = 6;
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 125;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // TotalNumber
            // 
            this.TotalNumber.DataPropertyName = "TotalNumber";
            this.TotalNumber.HeaderText = "TotalNumber";
            this.TotalNumber.MinimumWidth = 6;
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.Width = 180;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Visible = false;
            this.Number.Width = 80;
            // 
            // cntxtmSort
            // 
            this.cntxtmSort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxtmSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.cntxtmSort.Name = "cntxtmSelect";
            this.cntxtmSort.Size = new System.Drawing.Size(128, 52);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyIdToolStripMenuItem,
            this.companyNameToolStripMenuItem,
            this.numberToolStripMenuItem,
            this.userToolStripMenuItem,
            this.totalNumberToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // companyIdToolStripMenuItem
            // 
            this.companyIdToolStripMenuItem.Name = "companyIdToolStripMenuItem";
            this.companyIdToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.companyIdToolStripMenuItem.Text = "CompanyId";
            this.companyIdToolStripMenuItem.Click += new System.EventHandler(this.companyIdToolStripMenuItem_Click);
            // 
            // companyNameToolStripMenuItem
            // 
            this.companyNameToolStripMenuItem.Name = "companyNameToolStripMenuItem";
            this.companyNameToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.companyNameToolStripMenuItem.Text = "CompanyName";
            this.companyNameToolStripMenuItem.Click += new System.EventHandler(this.companyNameToolStripMenuItem_Click);
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.numberToolStripMenuItem.Text = "Number";
            this.numberToolStripMenuItem.Click += new System.EventHandler(this.numberToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // totalNumberToolStripMenuItem
            // 
            this.totalNumberToolStripMenuItem.Name = "totalNumberToolStripMenuItem";
            this.totalNumberToolStripMenuItem.Size = new System.Drawing.Size(195, 26);
            this.totalNumberToolStripMenuItem.Text = "TotalNumber";
            this.totalNumberToolStripMenuItem.Click += new System.EventHandler(this.totalNumberToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // grdComp
            // 
            this.grdComp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.grdComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdComp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputerId,
            this.ComputerBrand,
            this.Number1,
            this.Date,
            this.CompanyId1,
            this.UserId1});
            this.grdComp.ContextMenuStrip = this.contextMenuStrip1;
            this.grdComp.Location = new System.Drawing.Point(443, 130);
            this.grdComp.Name = "grdComp";
            this.grdComp.RowHeadersWidth = 51;
            this.grdComp.RowTemplate.Height = 24;
            this.grdComp.Size = new System.Drawing.Size(596, 523);
            this.grdComp.TabIndex = 2;
            // 
            // ComputerId
            // 
            this.ComputerId.DataPropertyName = "ComputerId";
            this.ComputerId.HeaderText = "ComputerId";
            this.ComputerId.MinimumWidth = 6;
            this.ComputerId.Name = "ComputerId";
            this.ComputerId.Visible = false;
            this.ComputerId.Width = 125;
            // 
            // ComputerBrand
            // 
            this.ComputerBrand.DataPropertyName = "ComputerBrand";
            this.ComputerBrand.HeaderText = "ComputerBrand";
            this.ComputerBrand.MinimumWidth = 6;
            this.ComputerBrand.Name = "ComputerBrand";
            this.ComputerBrand.Width = 125;
            // 
            // Number1
            // 
            this.Number1.DataPropertyName = "Number";
            this.Number1.HeaderText = "Number";
            this.Number1.MinimumWidth = 6;
            this.Number1.Name = "Number1";
            this.Number1.Width = 125;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // CompanyId1
            // 
            this.CompanyId1.DataPropertyName = "CompanyId";
            this.CompanyId1.HeaderText = "CompanyId";
            this.CompanyId1.MinimumWidth = 6;
            this.CompanyId1.Name = "CompanyId1";
            this.CompanyId1.Visible = false;
            this.CompanyId1.Width = 125;
            // 
            // UserId1
            // 
            this.UserId1.DataPropertyName = "UserId";
            this.UserId1.HeaderText = "UserId";
            this.UserId1.MinimumWidth = 6;
            this.UserId1.Name = "UserId1";
            this.UserId1.Visible = false;
            this.UserId1.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortedByToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // sortedByToolStripMenuItem
            // 
            this.sortedByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brandToolStripMenuItem,
            this.addDateToolStripMenuItem,
            this.saleDateToolStripMenuItem,
            this.saledNumberToolStripMenuItem});
            this.sortedByToolStripMenuItem.Name = "sortedByToolStripMenuItem";
            this.sortedByToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.sortedByToolStripMenuItem.Text = "Sorted by";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // addDateToolStripMenuItem
            // 
            this.addDateToolStripMenuItem.Name = "addDateToolStripMenuItem";
            this.addDateToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.addDateToolStripMenuItem.Text = "Date";
            // 
            // saleDateToolStripMenuItem
            // 
            this.saleDateToolStripMenuItem.Name = "saleDateToolStripMenuItem";
            this.saleDateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saleDateToolStripMenuItem.Text = "Number";
            this.saleDateToolStripMenuItem.Click += new System.EventHandler(this.saleDateToolStripMenuItem_Click);
            // 
            // saledNumberToolStripMenuItem
            // 
            this.saledNumberToolStripMenuItem.Name = "saledNumberToolStripMenuItem";
            this.saledNumberToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.saledNumberToolStripMenuItem.Text = "TotalNumber";
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.refreshToolStripMenuItem1.Text = "Refresh";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "A   d   d";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(387, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "U  p  d  a  t  e";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(752, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(287, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "D  e  l  e  t  e";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainTablesToolStripMenuItem,
            this.sortByToolStripMenuItem1,
            this.sortByToolStripMenuItem2,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainTablesToolStripMenuItem
            // 
            this.mainTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companiesToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.mainTablesToolStripMenuItem.Name = "mainTablesToolStripMenuItem";
            this.mainTablesToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.mainTablesToolStripMenuItem.Text = "Main Tables";
            // 
            // companiesToolStripMenuItem
            // 
            this.companiesToolStripMenuItem.Name = "companiesToolStripMenuItem";
            this.companiesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.companiesToolStripMenuItem.Text = "Companies";
            this.companiesToolStripMenuItem.Click += new System.EventHandler(this.companiesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem1
            // 
            this.sortByToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem,
            this.descendingToolStripMenuItem});
            this.sortByToolStripMenuItem1.Name = "sortByToolStripMenuItem1";
            this.sortByToolStripMenuItem1.Size = new System.Drawing.Size(116, 24);
            this.sortByToolStripMenuItem1.Text = "Select by User";
            // 
            // ascendingToolStripMenuItem
            // 
            this.ascendingToolStripMenuItem.Name = "ascendingToolStripMenuItem";
            this.ascendingToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.ascendingToolStripMenuItem.Text = "Worker1";
            // 
            // descendingToolStripMenuItem
            // 
            this.descendingToolStripMenuItem.Name = "descendingToolStripMenuItem";
            this.descendingToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.descendingToolStripMenuItem.Text = "Worker2";
            // 
            // sortByToolStripMenuItem2
            // 
            this.sortByToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendingToolStripMenuItem1,
            this.descendingToolStripMenuItem1});
            this.sortByToolStripMenuItem2.Name = "sortByToolStripMenuItem2";
            this.sortByToolStripMenuItem2.Size = new System.Drawing.Size(70, 24);
            this.sortByToolStripMenuItem2.Text = "Sort by";
            // 
            // ascendingToolStripMenuItem1
            // 
            this.ascendingToolStripMenuItem1.Name = "ascendingToolStripMenuItem1";
            this.ascendingToolStripMenuItem1.Size = new System.Drawing.Size(170, 26);
            this.ascendingToolStripMenuItem1.Text = "Ascending";
            // 
            // descendingToolStripMenuItem1
            // 
            this.descendingToolStripMenuItem1.Name = "descendingToolStripMenuItem1";
            this.descendingToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.descendingToolStripMenuItem1.Text = "Descending";
            this.descendingToolStripMenuItem1.Click += new System.EventHandler(this.descendingToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeToolStripMenuItem,
            this.darkModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1089, 667);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.grdComp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.cntxtmSort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdComp)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridView grdComp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputerBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId1;
        private System.Windows.Forms.ContextMenuStrip cntxtmSort;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalNumberToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortedByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saledNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ascendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descendingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
    }
}