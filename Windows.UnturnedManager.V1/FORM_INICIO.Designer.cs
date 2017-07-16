namespace Windows.UnturnedManager.V1
{
    partial class FORM_INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_INICIO));
            this.MENUSTRIP_SHOP = new System.Windows.Forms.MenuStrip();
            this.BUTTON_EXIT = new System.Windows.Forms.ToolStripMenuItem();
            this.BUTTON_SETTINGS = new System.Windows.Forms.ToolStripMenuItem();
            this.TABCONTROL_SHOP = new System.Windows.Forms.TabControl();
            this.TABPAGE_ITEMS = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DATAGRIDVIEW_ITEMS = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTEXTMENUSTRIP_ITEMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BUTTON_DELETE_ITEM = new System.Windows.Forms.ToolStripMenuItem();
            this.TEXTBOX_SEARCH_ITEMS = new System.Windows.Forms.TextBox();
            this.TABPAGE_VEHICLES = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DATAGRIDVIEW_VEHICLES = new System.Windows.Forms.DataGridView();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTEXTMENUSTRIP_VEHICLES = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BUTTON_DELETE_VEHICLE = new System.Windows.Forms.ToolStripMenuItem();
            this.TEXTBOX_SEARCH_VEHICLES = new System.Windows.Forms.TextBox();
            this.MENUSTRIP_SHOP.SuspendLayout();
            this.TABCONTROL_SHOP.SuspendLayout();
            this.TABPAGE_ITEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_ITEMS)).BeginInit();
            this.CONTEXTMENUSTRIP_ITEMS.SuspendLayout();
            this.TABPAGE_VEHICLES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_VEHICLES)).BeginInit();
            this.CONTEXTMENUSTRIP_VEHICLES.SuspendLayout();
            this.SuspendLayout();
            // 
            // MENUSTRIP_SHOP
            // 
            this.MENUSTRIP_SHOP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENUSTRIP_SHOP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_EXIT,
            this.BUTTON_SETTINGS});
            this.MENUSTRIP_SHOP.Location = new System.Drawing.Point(0, 0);
            this.MENUSTRIP_SHOP.Name = "MENUSTRIP_SHOP";
            this.MENUSTRIP_SHOP.Size = new System.Drawing.Size(286, 26);
            this.MENUSTRIP_SHOP.TabIndex = 0;
            this.MENUSTRIP_SHOP.Text = "menuStrip1";
            // 
            // BUTTON_EXIT
            // 
            this.BUTTON_EXIT.Name = "BUTTON_EXIT";
            this.BUTTON_EXIT.Size = new System.Drawing.Size(43, 22);
            this.BUTTON_EXIT.Text = "Exit";
            this.BUTTON_EXIT.Click += new System.EventHandler(this.BUTTON_EXIT_Click);
            // 
            // BUTTON_SETTINGS
            // 
            this.BUTTON_SETTINGS.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BUTTON_SETTINGS.Name = "BUTTON_SETTINGS";
            this.BUTTON_SETTINGS.Size = new System.Drawing.Size(68, 22);
            this.BUTTON_SETTINGS.Text = "Settings";
            this.BUTTON_SETTINGS.Click += new System.EventHandler(this.BUTTON_SETTINGS_Click);
            // 
            // TABCONTROL_SHOP
            // 
            this.TABCONTROL_SHOP.Controls.Add(this.TABPAGE_ITEMS);
            this.TABCONTROL_SHOP.Controls.Add(this.TABPAGE_VEHICLES);
            this.TABCONTROL_SHOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TABCONTROL_SHOP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TABCONTROL_SHOP.Location = new System.Drawing.Point(0, 26);
            this.TABCONTROL_SHOP.Name = "TABCONTROL_SHOP";
            this.TABCONTROL_SHOP.SelectedIndex = 0;
            this.TABCONTROL_SHOP.Size = new System.Drawing.Size(286, 257);
            this.TABCONTROL_SHOP.TabIndex = 1;
            // 
            // TABPAGE_ITEMS
            // 
            this.TABPAGE_ITEMS.Controls.Add(this.splitContainer1);
            this.TABPAGE_ITEMS.Location = new System.Drawing.Point(4, 27);
            this.TABPAGE_ITEMS.Name = "TABPAGE_ITEMS";
            this.TABPAGE_ITEMS.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_ITEMS.Size = new System.Drawing.Size(278, 226);
            this.TABPAGE_ITEMS.TabIndex = 0;
            this.TABPAGE_ITEMS.Text = "Items";
            this.TABPAGE_ITEMS.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DATAGRIDVIEW_ITEMS);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TEXTBOX_SEARCH_ITEMS);
            this.splitContainer1.Size = new System.Drawing.Size(272, 220);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.TabIndex = 0;
            // 
            // DATAGRIDVIEW_ITEMS
            // 
            this.DATAGRIDVIEW_ITEMS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DATAGRIDVIEW_ITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDVIEW_ITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemCost});
            this.DATAGRIDVIEW_ITEMS.ContextMenuStrip = this.CONTEXTMENUSTRIP_ITEMS;
            this.DATAGRIDVIEW_ITEMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DATAGRIDVIEW_ITEMS.Location = new System.Drawing.Point(0, 0);
            this.DATAGRIDVIEW_ITEMS.Name = "DATAGRIDVIEW_ITEMS";
            this.DATAGRIDVIEW_ITEMS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DATAGRIDVIEW_ITEMS.RowHeadersWidth = 20;
            this.DATAGRIDVIEW_ITEMS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DATAGRIDVIEW_ITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGRIDVIEW_ITEMS.Size = new System.Drawing.Size(272, 190);
            this.DATAGRIDVIEW_ITEMS.TabIndex = 5;
            this.DATAGRIDVIEW_ITEMS.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRIDVIEW_ITEMS_CellValueChanged);
            this.DATAGRIDVIEW_ITEMS.SelectionChanged += new System.EventHandler(this.DATAGRIDVIEW_ITEMS_SelectionChanged);
            this.DATAGRIDVIEW_ITEMS.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DATAGRIDVIEW_ITEMS_UserDeletingRow);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "id";
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "itemname";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // ItemCost
            // 
            this.ItemCost.DataPropertyName = "cost";
            this.ItemCost.HeaderText = "Cost";
            this.ItemCost.Name = "ItemCost";
            this.ItemCost.Width = 50;
            // 
            // CONTEXTMENUSTRIP_ITEMS
            // 
            this.CONTEXTMENUSTRIP_ITEMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_DELETE_ITEM});
            this.CONTEXTMENUSTRIP_ITEMS.Name = "CONTEXTMENUSTRIP_ITEMS";
            this.CONTEXTMENUSTRIP_ITEMS.Size = new System.Drawing.Size(108, 26);
            // 
            // BUTTON_DELETE_ITEM
            // 
            this.BUTTON_DELETE_ITEM.Name = "BUTTON_DELETE_ITEM";
            this.BUTTON_DELETE_ITEM.Size = new System.Drawing.Size(107, 22);
            this.BUTTON_DELETE_ITEM.Text = "Delete";
            this.BUTTON_DELETE_ITEM.Click += new System.EventHandler(this.BUTTON_DELETE_ITEM_Click);
            // 
            // TEXTBOX_SEARCH_ITEMS
            // 
            this.TEXTBOX_SEARCH_ITEMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEXTBOX_SEARCH_ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_SEARCH_ITEMS.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_SEARCH_ITEMS.Location = new System.Drawing.Point(0, 0);
            this.TEXTBOX_SEARCH_ITEMS.Name = "TEXTBOX_SEARCH_ITEMS";
            this.TEXTBOX_SEARCH_ITEMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXTBOX_SEARCH_ITEMS.Size = new System.Drawing.Size(272, 26);
            this.TEXTBOX_SEARCH_ITEMS.TabIndex = 1;
            this.TEXTBOX_SEARCH_ITEMS.Text = "Search...";
            this.TEXTBOX_SEARCH_ITEMS.TextChanged += new System.EventHandler(this.TEXTBOX_SEARCH_ITEMS_TextChanged);
            this.TEXTBOX_SEARCH_ITEMS.Enter += new System.EventHandler(this.TEXTBOX_SEARCH_ITEMS_Enter);
            this.TEXTBOX_SEARCH_ITEMS.Leave += new System.EventHandler(this.TEXTBOX_SEARCH_ITEMS_Leave);
            // 
            // TABPAGE_VEHICLES
            // 
            this.TABPAGE_VEHICLES.Controls.Add(this.splitContainer2);
            this.TABPAGE_VEHICLES.Location = new System.Drawing.Point(4, 27);
            this.TABPAGE_VEHICLES.Name = "TABPAGE_VEHICLES";
            this.TABPAGE_VEHICLES.Padding = new System.Windows.Forms.Padding(3);
            this.TABPAGE_VEHICLES.Size = new System.Drawing.Size(278, 226);
            this.TABPAGE_VEHICLES.TabIndex = 1;
            this.TABPAGE_VEHICLES.Text = "Vehicles";
            this.TABPAGE_VEHICLES.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DATAGRIDVIEW_VEHICLES);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TEXTBOX_SEARCH_VEHICLES);
            this.splitContainer2.Size = new System.Drawing.Size(272, 220);
            this.splitContainer2.SplitterDistance = 190;
            this.splitContainer2.TabIndex = 0;
            // 
            // DATAGRIDVIEW_VEHICLES
            // 
            this.DATAGRIDVIEW_VEHICLES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DATAGRIDVIEW_VEHICLES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATAGRIDVIEW_VEHICLES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleID,
            this.VehicleName,
            this.VehicleCost});
            this.DATAGRIDVIEW_VEHICLES.ContextMenuStrip = this.CONTEXTMENUSTRIP_VEHICLES;
            this.DATAGRIDVIEW_VEHICLES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DATAGRIDVIEW_VEHICLES.Location = new System.Drawing.Point(0, 0);
            this.DATAGRIDVIEW_VEHICLES.Name = "DATAGRIDVIEW_VEHICLES";
            this.DATAGRIDVIEW_VEHICLES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DATAGRIDVIEW_VEHICLES.RowHeadersWidth = 20;
            this.DATAGRIDVIEW_VEHICLES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DATAGRIDVIEW_VEHICLES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DATAGRIDVIEW_VEHICLES.Size = new System.Drawing.Size(272, 190);
            this.DATAGRIDVIEW_VEHICLES.TabIndex = 1;
            this.DATAGRIDVIEW_VEHICLES.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATAGRIDVIEW_VEHICLES_CellValueChanged);
            this.DATAGRIDVIEW_VEHICLES.SelectionChanged += new System.EventHandler(this.DATAGRIDVIEW_VEHICLES_SelectionChanged);
            this.DATAGRIDVIEW_VEHICLES.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DATAGRIDVIEW_VEHICLES_UserDeletingRow);
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "id";
            this.VehicleID.HeaderText = "ID";
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.Width = 50;
            // 
            // VehicleName
            // 
            this.VehicleName.DataPropertyName = "vehiclename";
            this.VehicleName.HeaderText = "Name";
            this.VehicleName.Name = "VehicleName";
            this.VehicleName.Width = 150;
            // 
            // VehicleCost
            // 
            this.VehicleCost.DataPropertyName = "cost";
            this.VehicleCost.HeaderText = "Cost";
            this.VehicleCost.Name = "VehicleCost";
            this.VehicleCost.Width = 50;
            // 
            // CONTEXTMENUSTRIP_VEHICLES
            // 
            this.CONTEXTMENUSTRIP_VEHICLES.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BUTTON_DELETE_VEHICLE});
            this.CONTEXTMENUSTRIP_VEHICLES.Name = "CONTEXTMENUSTRIP_VEHICLES";
            this.CONTEXTMENUSTRIP_VEHICLES.Size = new System.Drawing.Size(108, 26);
            // 
            // BUTTON_DELETE_VEHICLE
            // 
            this.BUTTON_DELETE_VEHICLE.Name = "BUTTON_DELETE_VEHICLE";
            this.BUTTON_DELETE_VEHICLE.Size = new System.Drawing.Size(107, 22);
            this.BUTTON_DELETE_VEHICLE.Text = "Delete";
            this.BUTTON_DELETE_VEHICLE.Click += new System.EventHandler(this.BUTTON_DELETE_VEHICLE_Click);
            // 
            // TEXTBOX_SEARCH_VEHICLES
            // 
            this.TEXTBOX_SEARCH_VEHICLES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_SEARCH_VEHICLES.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TEXTBOX_SEARCH_VEHICLES.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_SEARCH_VEHICLES.Location = new System.Drawing.Point(0, 0);
            this.TEXTBOX_SEARCH_VEHICLES.Name = "TEXTBOX_SEARCH_VEHICLES";
            this.TEXTBOX_SEARCH_VEHICLES.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TEXTBOX_SEARCH_VEHICLES.Size = new System.Drawing.Size(272, 26);
            this.TEXTBOX_SEARCH_VEHICLES.TabIndex = 2;
            this.TEXTBOX_SEARCH_VEHICLES.Text = "Search...";
            this.TEXTBOX_SEARCH_VEHICLES.TextChanged += new System.EventHandler(this.TEXTBOX_SEARCH_VEHICLES_TextChanged);
            this.TEXTBOX_SEARCH_VEHICLES.Enter += new System.EventHandler(this.TEXTBOX_SEARCH_VEHICLES_Enter);
            this.TEXTBOX_SEARCH_VEHICLES.Leave += new System.EventHandler(this.TEXTBOX_SEARCH_VEHICLES_Leave);
            // 
            // FORM_INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 283);
            this.Controls.Add(this.TABCONTROL_SHOP);
            this.Controls.Add(this.MENUSTRIP_SHOP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MENUSTRIP_SHOP;
            this.MinimumSize = new System.Drawing.Size(302, 321);
            this.Name = "FORM_INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unturned Shop Management";
            this.MENUSTRIP_SHOP.ResumeLayout(false);
            this.MENUSTRIP_SHOP.PerformLayout();
            this.TABCONTROL_SHOP.ResumeLayout(false);
            this.TABPAGE_ITEMS.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_ITEMS)).EndInit();
            this.CONTEXTMENUSTRIP_ITEMS.ResumeLayout(false);
            this.TABPAGE_VEHICLES.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DATAGRIDVIEW_VEHICLES)).EndInit();
            this.CONTEXTMENUSTRIP_VEHICLES.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MENUSTRIP_SHOP;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_EXIT;
        private System.Windows.Forms.TabControl TABCONTROL_SHOP;
        private System.Windows.Forms.TabPage TABPAGE_ITEMS;
        private System.Windows.Forms.TabPage TABPAGE_VEHICLES;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_SETTINGS;
        private System.Windows.Forms.ContextMenuStrip CONTEXTMENUSTRIP_ITEMS;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_DELETE_ITEM;
        private System.Windows.Forms.ContextMenuStrip CONTEXTMENUSTRIP_VEHICLES;
        private System.Windows.Forms.ToolStripMenuItem BUTTON_DELETE_VEHICLE;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DATAGRIDVIEW_ITEMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCost;
        private System.Windows.Forms.TextBox TEXTBOX_SEARCH_ITEMS;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView DATAGRIDVIEW_VEHICLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleCost;
        private System.Windows.Forms.TextBox TEXTBOX_SEARCH_VEHICLES;
    }
}

