namespace NyilvForms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelCeg = new System.Windows.Forms.Panel();
            this.alapadatokBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.alapadatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.alapadatokBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.alapadatokDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFind = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerCegRelszetek = new System.Windows.Forms.SplitContainer();
            this.treeViewCeg = new System.Windows.Forms.TreeView();
            this.panelCeg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingNavigator)).BeginInit();
            this.alapadatokBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCegRelszetek)).BeginInit();
            this.splitContainerCegRelszetek.Panel1.SuspendLayout();
            this.splitContainerCegRelszetek.Panel2.SuspendLayout();
            this.splitContainerCegRelszetek.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCeg
            // 
            this.panelCeg.Controls.Add(this.alapadatokBindingNavigator);
            this.panelCeg.Controls.Add(this.alapadatokDataGridView);
            this.panelCeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCeg.Location = new System.Drawing.Point(0, 0);
            this.panelCeg.Name = "panelCeg";
            this.panelCeg.Size = new System.Drawing.Size(624, 470);
            this.panelCeg.TabIndex = 0;
            // 
            // alapadatokBindingNavigator
            // 
            this.alapadatokBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alapadatokBindingNavigator.BindingSource = this.alapadatokBindingSource;
            this.alapadatokBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alapadatokBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alapadatokBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.alapadatokBindingNavigatorSaveItem});
            this.alapadatokBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.alapadatokBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alapadatokBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alapadatokBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alapadatokBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alapadatokBindingNavigator.Name = "alapadatokBindingNavigator";
            this.alapadatokBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alapadatokBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.alapadatokBindingNavigator.TabIndex = 1;
            this.alapadatokBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // alapadatokBindingSource
            // 
            this.alapadatokBindingSource.DataSource = typeof(NyilvForms.Entities.Alapadatok);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // alapadatokBindingNavigatorSaveItem
            // 
            this.alapadatokBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alapadatokBindingNavigatorSaveItem.Enabled = false;
            this.alapadatokBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alapadatokBindingNavigatorSaveItem.Image")));
            this.alapadatokBindingNavigatorSaveItem.Name = "alapadatokBindingNavigatorSaveItem";
            this.alapadatokBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alapadatokBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // alapadatokDataGridView
            // 
            this.alapadatokDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alapadatokDataGridView.AutoGenerateColumns = false;
            this.alapadatokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alapadatokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.alapadatokDataGridView.DataSource = this.alapadatokBindingSource;
            this.alapadatokDataGridView.Location = new System.Drawing.Point(0, 28);
            this.alapadatokDataGridView.Name = "alapadatokDataGridView";
            this.alapadatokDataGridView.Size = new System.Drawing.Size(624, 439);
            this.alapadatokDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CegID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CegID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Szamlazas";
            this.dataGridViewTextBoxColumn2.HeaderText = "Szamlazas";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Felelos";
            this.dataGridViewTextBoxColumn3.HeaderText = "Felelos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cegnev";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cegnev";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ceg_forma";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ceg_forma";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hivatkozas";
            this.dataGridViewTextBoxColumn6.HeaderText = "Hivatkozas";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Felfuggesztett";
            this.dataGridViewTextBoxColumn7.HeaderText = "Felfuggesztett";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(244, 26);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fajlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fajlToolStripMenuItem
            // 
            this.fajlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importalasToolStripMenuItem});
            this.fajlToolStripMenuItem.Name = "fajlToolStripMenuItem";
            this.fajlToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fajlToolStripMenuItem.Text = "Fájl";
            // 
            // importalasToolStripMenuItem
            // 
            this.importalasToolStripMenuItem.Name = "importalasToolStripMenuItem";
            this.importalasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importalasToolStripMenuItem.Text = "Importálás...";
            this.importalasToolStripMenuItem.Click += new System.EventHandler(this.importalasToolStripMenuItem_Click);
            // 
            // ofdImport
            // 
            this.ofdImport.FileName = "ofdImport";
            this.ofdImport.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImport_FileOk);
            // 
            // splitContainerCegRelszetek
            // 
            this.splitContainerCegRelszetek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerCegRelszetek.Location = new System.Drawing.Point(0, 55);
            this.splitContainerCegRelszetek.Name = "splitContainerCegRelszetek";
            // 
            // splitContainerCegRelszetek.Panel1
            // 
            this.splitContainerCegRelszetek.Panel1.Controls.Add(this.treeViewCeg);
            // 
            // splitContainerCegRelszetek.Panel2
            // 
            this.splitContainerCegRelszetek.Panel2.Controls.Add(this.panelCeg);
            this.splitContainerCegRelszetek.Size = new System.Drawing.Size(808, 470);
            this.splitContainerCegRelszetek.SplitterDistance = 180;
            this.splitContainerCegRelszetek.TabIndex = 3;
            // 
            // treeViewCeg
            // 
            this.treeViewCeg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewCeg.Location = new System.Drawing.Point(0, 0);
            this.treeViewCeg.Name = "treeViewCeg";
            this.treeViewCeg.Size = new System.Drawing.Size(180, 470);
            this.treeViewCeg.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.splitContainerCegRelszetek);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.panelCeg.ResumeLayout(false);
            this.panelCeg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingNavigator)).EndInit();
            this.alapadatokBindingNavigator.ResumeLayout(false);
            this.alapadatokBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerCegRelszetek.Panel1.ResumeLayout(false);
            this.splitContainerCegRelszetek.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerCegRelszetek)).EndInit();
            this.splitContainerCegRelszetek.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCeg;
        private System.Windows.Forms.BindingNavigator alapadatokBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource alapadatokBindingSource;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton alapadatokBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView alapadatokDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importalasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.SplitContainer splitContainerCegRelszetek;
        private System.Windows.Forms.TreeView treeViewCeg;
    }
}

