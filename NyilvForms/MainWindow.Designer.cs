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
            this.btFind = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fajlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importalasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadAll = new System.Windows.Forms.Button();
            this.panelGombok = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWorkspace = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerAdatok = new System.Windows.Forms.SplitContainer();
            this.splitContainerBalOldal = new System.Windows.Forms.SplitContainer();
            this.alapadatokBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.splitContainerJobbOldal = new System.Windows.Forms.SplitContainer();
            this.panelCegAdat = new System.Windows.Forms.Panel();
            this.alapadatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cegadatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ceg_teljes_nevLabel1 = new System.Windows.Forms.Label();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.telefonLabel1 = new System.Windows.Forms.Label();
            this.telephelyLabel1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelGombok.SuspendLayout();
            this.tableLayoutPanelWorkspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdatok)).BeginInit();
            this.splitContainerAdatok.Panel1.SuspendLayout();
            this.splitContainerAdatok.Panel2.SuspendLayout();
            this.splitContainerAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBalOldal)).BeginInit();
            this.splitContainerBalOldal.Panel1.SuspendLayout();
            this.splitContainerBalOldal.Panel2.SuspendLayout();
            this.splitContainerBalOldal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingNavigator)).BeginInit();
            this.alapadatokBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJobbOldal)).BeginInit();
            this.splitContainerJobbOldal.Panel1.SuspendLayout();
            this.splitContainerJobbOldal.SuspendLayout();
            this.panelCegAdat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cegadatokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(403, 2);
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
            // buttonLoadAll
            // 
            this.buttonLoadAll.Location = new System.Drawing.Point(563, 2);
            this.buttonLoadAll.Name = "buttonLoadAll";
            this.buttonLoadAll.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadAll.TabIndex = 4;
            this.buttonLoadAll.Text = "Load all";
            this.buttonLoadAll.UseVisualStyleBackColor = true;
            this.buttonLoadAll.Click += new System.EventHandler(this.buttonLoadAll_Click);
            // 
            // panelGombok
            // 
            this.panelGombok.Controls.Add(this.btFind);
            this.panelGombok.Controls.Add(this.buttonLoadAll);
            this.panelGombok.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGombok.Location = new System.Drawing.Point(3, 3);
            this.panelGombok.Name = "panelGombok";
            this.panelGombok.Size = new System.Drawing.Size(802, 24);
            this.panelGombok.TabIndex = 6;
            // 
            // tableLayoutPanelWorkspace
            // 
            this.tableLayoutPanelWorkspace.ColumnCount = 1;
            this.tableLayoutPanelWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkspace.Controls.Add(this.panelGombok, 0, 0);
            this.tableLayoutPanelWorkspace.Controls.Add(this.splitContainerAdatok, 0, 1);
            this.tableLayoutPanelWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkspace.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelWorkspace.Name = "tableLayoutPanelWorkspace";
            this.tableLayoutPanelWorkspace.RowCount = 2;
            this.tableLayoutPanelWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.042885F));
            this.tableLayoutPanelWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.95712F));
            this.tableLayoutPanelWorkspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 447F));
            this.tableLayoutPanelWorkspace.Size = new System.Drawing.Size(808, 513);
            this.tableLayoutPanelWorkspace.TabIndex = 7;
            // 
            // splitContainerAdatok
            // 
            this.splitContainerAdatok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdatok.Location = new System.Drawing.Point(3, 33);
            this.splitContainerAdatok.Name = "splitContainerAdatok";
            // 
            // splitContainerAdatok.Panel1
            // 
            this.splitContainerAdatok.Panel1.Controls.Add(this.splitContainerBalOldal);
            // 
            // splitContainerAdatok.Panel2
            // 
            this.splitContainerAdatok.Panel2.Controls.Add(this.splitContainerJobbOldal);
            this.splitContainerAdatok.Size = new System.Drawing.Size(802, 477);
            this.splitContainerAdatok.SplitterDistance = 554;
            this.splitContainerAdatok.TabIndex = 7;
            // 
            // splitContainerBalOldal
            // 
            this.splitContainerBalOldal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerBalOldal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerBalOldal.Name = "splitContainerBalOldal";
            this.splitContainerBalOldal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerBalOldal.Panel1
            // 
            this.splitContainerBalOldal.Panel1.Controls.Add(this.alapadatokBindingNavigator);
            // 
            // splitContainerBalOldal.Panel2
            // 
            this.splitContainerBalOldal.Panel2.AutoScroll = true;
            this.splitContainerBalOldal.Panel2.Controls.Add(this.alapadatokDataGridView);
            this.splitContainerBalOldal.Size = new System.Drawing.Size(554, 477);
            this.splitContainerBalOldal.SplitterDistance = 34;
            this.splitContainerBalOldal.TabIndex = 8;
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
            this.alapadatokBindingNavigator.Size = new System.Drawing.Size(554, 25);
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
            this.alapadatokDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alapadatokDataGridView.Location = new System.Drawing.Point(0, 0);
            this.alapadatokDataGridView.Name = "alapadatokDataGridView";
            this.alapadatokDataGridView.Size = new System.Drawing.Size(554, 439);
            this.alapadatokDataGridView.TabIndex = 1;
            // 
            // splitContainerJobbOldal
            // 
            this.splitContainerJobbOldal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerJobbOldal.Location = new System.Drawing.Point(0, 0);
            this.splitContainerJobbOldal.Name = "splitContainerJobbOldal";
            this.splitContainerJobbOldal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerJobbOldal.Panel1
            // 
            this.splitContainerJobbOldal.Panel1.Controls.Add(this.panelCegAdat);
            this.splitContainerJobbOldal.Size = new System.Drawing.Size(244, 477);
            this.splitContainerJobbOldal.SplitterDistance = 145;
            this.splitContainerJobbOldal.TabIndex = 0;
            // 
            // panelCegAdat
            // 
            this.panelCegAdat.AutoScroll = true;
            this.panelCegAdat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panelCegAdat.Controls.Add(this.ceg_teljes_nevLabel1);
            this.panelCegAdat.Controls.Add(this.emailLinkLabel);
            this.panelCegAdat.Controls.Add(this.telefonLabel1);
            this.panelCegAdat.Controls.Add(this.telephelyLabel1);
            this.panelCegAdat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCegAdat.Location = new System.Drawing.Point(0, 0);
            this.panelCegAdat.Name = "panelCegAdat";
            this.panelCegAdat.Size = new System.Drawing.Size(244, 145);
            this.panelCegAdat.TabIndex = 0;
            // 
            // alapadatokBindingSource
            // 
            this.alapadatokBindingSource.DataSource = typeof(NyilvForms.Entities.Alapadatok);
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
            // cegadatokBindingSource
            // 
            this.cegadatokBindingSource.DataSource = typeof(NyilvForms.Entities.Cegadatok);
            // 
            // ceg_teljes_nevLabel1
            // 
            this.ceg_teljes_nevLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cegadatokBindingSource, "Ceg_teljes_nev", true));
            this.ceg_teljes_nevLabel1.Location = new System.Drawing.Point(44, 26);
            this.ceg_teljes_nevLabel1.Name = "ceg_teljes_nevLabel1";
            this.ceg_teljes_nevLabel1.Size = new System.Drawing.Size(100, 23);
            this.ceg_teljes_nevLabel1.TabIndex = 1;
            this.ceg_teljes_nevLabel1.Text = "label1";
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cegadatokBindingSource, "Email", true));
            this.emailLinkLabel.Location = new System.Drawing.Point(44, 49);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.emailLinkLabel.TabIndex = 3;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "linkLabel1";
            // 
            // telefonLabel1
            // 
            this.telefonLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cegadatokBindingSource, "Telefon", true));
            this.telefonLabel1.Location = new System.Drawing.Point(44, 72);
            this.telefonLabel1.Name = "telefonLabel1";
            this.telefonLabel1.Size = new System.Drawing.Size(100, 23);
            this.telefonLabel1.TabIndex = 5;
            this.telefonLabel1.Text = "label1";
            // 
            // telephelyLabel1
            // 
            this.telephelyLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cegadatokBindingSource, "Telephely", true));
            this.telephelyLabel1.Location = new System.Drawing.Point(44, 95);
            this.telephelyLabel1.Name = "telephelyLabel1";
            this.telephelyLabel1.Size = new System.Drawing.Size(100, 23);
            this.telephelyLabel1.TabIndex = 7;
            this.telephelyLabel1.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 537);
            this.Controls.Add(this.tableLayoutPanelWorkspace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelGombok.ResumeLayout(false);
            this.tableLayoutPanelWorkspace.ResumeLayout(false);
            this.splitContainerAdatok.Panel1.ResumeLayout(false);
            this.splitContainerAdatok.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdatok)).EndInit();
            this.splitContainerAdatok.ResumeLayout(false);
            this.splitContainerBalOldal.Panel1.ResumeLayout(false);
            this.splitContainerBalOldal.Panel1.PerformLayout();
            this.splitContainerBalOldal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerBalOldal)).EndInit();
            this.splitContainerBalOldal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingNavigator)).EndInit();
            this.alapadatokBindingNavigator.ResumeLayout(false);
            this.alapadatokBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokDataGridView)).EndInit();
            this.splitContainerJobbOldal.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerJobbOldal)).EndInit();
            this.splitContainerJobbOldal.ResumeLayout(false);
            this.panelCegAdat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alapadatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cegadatokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource alapadatokBindingSource;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fajlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importalasToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.Button buttonLoadAll;
        private System.Windows.Forms.Panel panelGombok;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkspace;
        private System.Windows.Forms.BindingSource cegadatokBindingSource;
        private System.Windows.Forms.SplitContainer splitContainerAdatok;
        private System.Windows.Forms.SplitContainer splitContainerBalOldal;
        private System.Windows.Forms.BindingNavigator alapadatokBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
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
        private System.Windows.Forms.SplitContainer splitContainerJobbOldal;
        private System.Windows.Forms.Panel panelCegAdat;
        private System.Windows.Forms.Label ceg_teljes_nevLabel1;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.Label telefonLabel1;
        private System.Windows.Forms.Label telephelyLabel1;
    }
}

