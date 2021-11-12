namespace PlantCare2._0
{
    partial class UpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlantToUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlantName2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSunlight2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nuWaterQuantity2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPlacing2 = new System.Windows.Forms.ListBox();
            this.btUpdatePlant = new System.Windows.Forms.Button();
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
            this.btDelete = new System.Windows.Forms.Button();
            this.plantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nuWaterQuantity2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantCareDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).BeginInit();
            this.plantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type the id of the plant you wish to update:";
            // 
            // tbPlantToUpdate
            // 
            this.tbPlantToUpdate.Location = new System.Drawing.Point(498, 88);
            this.tbPlantToUpdate.Name = "tbPlantToUpdate";
            this.tbPlantToUpdate.Size = new System.Drawing.Size(58, 31);
            this.tbPlantToUpdate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plant name";
            // 
            // tbPlantName2
            // 
            this.tbPlantName2.Location = new System.Drawing.Point(362, 175);
            this.tbPlantName2.Name = "tbPlantName2";
            this.tbPlantName2.Size = new System.Drawing.Size(180, 31);
            this.tbPlantName2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sunlight intensity";
            // 
            // lbSunlight2
            // 
            this.lbSunlight2.FormattingEnabled = true;
            this.lbSunlight2.ItemHeight = 25;
            this.lbSunlight2.Items.AddRange(new object[] {
            "No sunlight",
            "Indirect sunlight",
            "Direct sunlight"});
            this.lbSunlight2.Location = new System.Drawing.Point(362, 223);
            this.lbSunlight2.Name = "lbSunlight2";
            this.lbSunlight2.Size = new System.Drawing.Size(194, 79);
            this.lbSunlight2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weekly waterquantity in cl";
            // 
            // nuWaterQuantity2
            // 
            this.nuWaterQuantity2.Location = new System.Drawing.Point(362, 333);
            this.nuWaterQuantity2.Name = "nuWaterQuantity2";
            this.nuWaterQuantity2.Size = new System.Drawing.Size(120, 31);
            this.nuWaterQuantity2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Placing ";
            // 
            // lbPlacing2
            // 
            this.lbPlacing2.FormattingEnabled = true;
            this.lbPlacing2.ItemHeight = 25;
            this.lbPlacing2.Items.AddRange(new object[] {
            "Inside",
            "Outside"});
            this.lbPlacing2.Location = new System.Drawing.Point(362, 387);
            this.lbPlacing2.Name = "lbPlacing2";
            this.lbPlacing2.Size = new System.Drawing.Size(194, 79);
            this.lbPlacing2.TabIndex = 12;
            // 
            // btUpdatePlant
            // 
            this.btUpdatePlant.Location = new System.Drawing.Point(362, 502);
            this.btUpdatePlant.Name = "btUpdatePlant";
            this.btUpdatePlant.Size = new System.Drawing.Size(180, 41);
            this.btUpdatePlant.TabIndex = 13;
            this.btUpdatePlant.Text = "Update plant";
            this.btUpdatePlant.UseVisualStyleBackColor = true;
            this.btUpdatePlant.Click += new System.EventHandler(this.btUpdatePlant_Click);
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
            this.plantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.plantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantsBindingNavigator.Name = "plantsBindingNavigator";
            this.plantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantsBindingNavigator.Size = new System.Drawing.Size(1178, 39);
            this.plantsBindingNavigator.TabIndex = 14;
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
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(876, 499);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(180, 41);
            this.btDelete.TabIndex = 15;
            this.btDelete.Text = "Delete plant";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
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
            this.plantsDataGridView.Location = new System.Drawing.Point(12, 567);
            this.plantsDataGridView.Name = "plantsDataGridView";
            this.plantsDataGridView.RowHeadersWidth = 82;
            this.plantsDataGridView.RowTemplate.Height = 33;
            this.plantsDataGridView.Size = new System.Drawing.Size(1111, 220);
            this.plantsDataGridView.TabIndex = 17;
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
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 809);
            this.Controls.Add(this.plantsDataGridView);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.plantsBindingNavigator);
            this.Controls.Add(this.btUpdatePlant);
            this.Controls.Add(this.lbPlacing2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nuWaterQuantity2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSunlight2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPlantName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPlantToUpdate);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuWaterQuantity2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBPlantCareDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).EndInit();
            this.plantsBindingNavigator.ResumeLayout(false);
            this.plantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPlantToUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPlantName2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSunlight2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuWaterQuantity2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbPlacing2;
        private System.Windows.Forms.Button btUpdatePlant;
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
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView plantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}