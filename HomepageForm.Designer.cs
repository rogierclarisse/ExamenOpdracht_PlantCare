namespace PlantCare2._0
{
    partial class HomepageForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.dBPlantCareDataSet = new PlantCare2._0.DBPlantCareDataSet();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantsTableAdapter = new PlantCare2._0.DBPlantCareDataSetTableAdapters.PlantsTableAdapter();
            this.tableAdapterManager = new PlantCare2._0.DBPlantCareDataSetTableAdapters.TableAdapterManager();
            this.plantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.plantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.plantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Welkomslabel = new System.Windows.Forms.Label();
            this.ownersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownersTableAdapter = new PlantCare2._0.DBPlantCareDataSetTableAdapters.OwnersTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAddPlant = new System.Windows.Forms.Button();
            this.btGoToUpdate = new System.Windows.Forms.Button();
            this.lbPlacing = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nuWaterQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lbSunlight = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPlantName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.btComplete = new System.Windows.Forms.Button();
            this.btShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).BeginInit();
            this.plantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuWaterQuantity)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 3;
            // 
            // dBPlantCareDataSet
            // 
            this.dBPlantCareDataSet.DataSetName = "DBPlantCareDataSet";
            this.dBPlantCareDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.dBPlantCareDataSet;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OwnersTableAdapter = null;
            this.tableAdapterManager.PlantsTableAdapter = this.plantsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PlantCare2._0.DBPlantCareDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // plantsBindingNavigator
            // 
            this.plantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plantsBindingNavigator.BindingSource = this.plantsBindingSource;
            this.plantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plantsBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.plantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.plantsBindingNavigatorSaveItem});
            this.plantsBindingNavigator.Location = new System.Drawing.Point(0, 40);
            this.plantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantsBindingNavigator.Name = "plantsBindingNavigator";
            this.plantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantsBindingNavigator.Size = new System.Drawing.Size(1499, 39);
            this.plantsBindingNavigator.TabIndex = 11;
            this.plantsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 33);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 33);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // plantsBindingNavigatorSaveItem
            // 
            this.plantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plantsBindingNavigatorSaveItem.Name = "plantsBindingNavigatorSaveItem";
            this.plantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 33);
            this.plantsBindingNavigatorSaveItem.Text = "Save Data";
            this.plantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.plantsBindingNavigatorSaveItem_Click);
            // 
            // plantsDataGridView
            // 
            this.plantsDataGridView.AutoGenerateColumns = false;
            this.plantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.plantsDataGridView.DataSource = this.plantsBindingSource;
            this.plantsDataGridView.Location = new System.Drawing.Point(97, 624);
            this.plantsDataGridView.Name = "plantsDataGridView";
            this.plantsDataGridView.RowHeadersWidth = 82;
            this.plantsDataGridView.RowTemplate.Height = 33;
            this.plantsDataGridView.Size = new System.Drawing.Size(1247, 220);
            this.plantsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlantId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PlantId";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlantName";
            this.dataGridViewTextBoxColumn2.HeaderText = "PlantName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "WaterQuantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "WaterQuantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Place";
            this.dataGridViewTextBoxColumn4.HeaderText = "Place";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sunlight";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sunlight";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreationDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreationDate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // Welkomslabel
            // 
            this.Welkomslabel.AutoSize = true;
            this.Welkomslabel.Location = new System.Drawing.Point(1242, 40);
            this.Welkomslabel.Name = "Welkomslabel";
            this.Welkomslabel.Size = new System.Drawing.Size(70, 25);
            this.Welkomslabel.TabIndex = 14;
            this.Welkomslabel.Text = "label7";
            // 
            // ownersBindingSource
            // 
            this.ownersBindingSource.DataMember = "Owners";
            this.ownersBindingSource.DataSource = this.dBPlantCareDataSet;
            // 
            // ownersTableAdapter
            // 
            this.ownersTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1499, 40);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(110, 36);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.pinkToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(334, 44);
            this.backgroundColorToolStripMenuItem.Text = "Background color";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(97, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 459);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btAddPlant);
            this.tabPage1.Controls.Add(this.btGoToUpdate);
            this.tabPage1.Controls.Add(this.lbPlacing);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.nuWaterQuantity);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lbSunlight);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.tbPlantName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1231, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add plant";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btAddPlant
            // 
            this.btAddPlant.Location = new System.Drawing.Point(459, 305);
            this.btAddPlant.Name = "btAddPlant";
            this.btAddPlant.Size = new System.Drawing.Size(180, 41);
            this.btAddPlant.TabIndex = 15;
            this.btAddPlant.Text = "Add plant";
            this.btAddPlant.UseVisualStyleBackColor = true;
            this.btAddPlant.Click += new System.EventHandler(this.btAddPlant_Click_1);
            // 
            // btGoToUpdate
            // 
            this.btGoToUpdate.Location = new System.Drawing.Point(992, 3);
            this.btGoToUpdate.Name = "btGoToUpdate";
            this.btGoToUpdate.Size = new System.Drawing.Size(236, 41);
            this.btGoToUpdate.TabIndex = 14;
            this.btGoToUpdate.Text = "Update or delete plant";
            this.btGoToUpdate.UseVisualStyleBackColor = true;
            this.btGoToUpdate.Click += new System.EventHandler(this.btGoToUpdate_Click);
            // 
            // lbPlacing
            // 
            this.lbPlacing.FormattingEnabled = true;
            this.lbPlacing.ItemHeight = 25;
            this.lbPlacing.Items.AddRange(new object[] {
            "Inside",
            "Outside"});
            this.lbPlacing.Location = new System.Drawing.Point(247, 267);
            this.lbPlacing.Name = "lbPlacing";
            this.lbPlacing.Size = new System.Drawing.Size(194, 79);
            this.lbPlacing.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Placing ";
            // 
            // nuWaterQuantity
            // 
            this.nuWaterQuantity.Location = new System.Drawing.Point(247, 213);
            this.nuWaterQuantity.Name = "nuWaterQuantity";
            this.nuWaterQuantity.Size = new System.Drawing.Size(120, 31);
            this.nuWaterQuantity.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Weekly waterquantity in cl";
            // 
            // lbSunlight
            // 
            this.lbSunlight.FormattingEnabled = true;
            this.lbSunlight.ItemHeight = 25;
            this.lbSunlight.Items.AddRange(new object[] {
            "No sunlight",
            "Indirect sunlight",
            "Direct sunlight"});
            this.lbSunlight.Location = new System.Drawing.Point(247, 88);
            this.lbSunlight.Name = "lbSunlight";
            this.lbSunlight.Size = new System.Drawing.Size(194, 79);
            this.lbSunlight.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sunlight intensity";
            // 
            // tbPlantName
            // 
            this.tbPlantName.Location = new System.Drawing.Point(247, 26);
            this.tbPlantName.Name = "tbPlantName";
            this.tbPlantName.Size = new System.Drawing.Size(180, 31);
            this.tbPlantName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plant name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox2);
            this.tabPage2.Controls.Add(this.btComplete);
            this.tabPage2.Controls.Add(this.btShow);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(25, 83);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(1182, 312);
            this.checkedListBox2.TabIndex = 22;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // btComplete
            // 
            this.btComplete.BackColor = System.Drawing.Color.OrangeRed;
            this.btComplete.Location = new System.Drawing.Point(1063, 6);
            this.btComplete.Name = "btComplete";
            this.btComplete.Size = new System.Drawing.Size(133, 50);
            this.btComplete.TabIndex = 20;
            this.btComplete.Text = "Complete";
            this.btComplete.UseVisualStyleBackColor = false;
            this.btComplete.Click += new System.EventHandler(this.btComplete_Click);
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.Color.LimeGreen;
            this.btShow.Location = new System.Drawing.Point(6, 6);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(133, 50);
            this.btShow.TabIndex = 19;
            this.btShow.Text = "Show tasks";
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click_1);
            // 
            // HomepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1499, 963);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Welkomslabel);
            this.Controls.Add(this.plantsDataGridView);
            this.Controls.Add(this.plantsBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "HomepageForm";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.HomepageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).EndInit();
            this.plantsBindingNavigator.ResumeLayout(false);
            this.plantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownersBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuWaterQuantity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private DBPlantCareDataSet dBPlantCareDataSet;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private DBPlantCareDataSetTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private DBPlantCareDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton plantsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView plantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label Welkomslabel;
        private System.Windows.Forms.BindingSource ownersBindingSource;
        private DBPlantCareDataSetTableAdapters.OwnersTableAdapter ownersTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btAddPlant;
        private System.Windows.Forms.Button btGoToUpdate;
        private System.Windows.Forms.ListBox lbPlacing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuWaterQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbSunlight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPlantName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.Button btComplete;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}