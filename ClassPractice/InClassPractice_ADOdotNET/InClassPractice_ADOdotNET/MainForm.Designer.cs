namespace InClassPractice_ADOdotNET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.quoteDataSet = new InClassPractice_ADOdotNET.QuoteDataSet();
            this.tblFTCustomerInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFTCustomerInfoTableAdapter = new InClassPractice_ADOdotNET.QuoteDataSetTableAdapters.tblFTCustomerInfoTableAdapter();
            this.tableAdapterManager = new InClassPractice_ADOdotNET.QuoteDataSetTableAdapters.TableAdapterManager();
            this.tblCarInfoTableAdapter = new InClassPractice_ADOdotNET.QuoteDataSetTableAdapters.tblCarInfoTableAdapter();
            this.tblFTCustomerInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tblFTCustomerInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tblFTCustomerInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCarInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showDetailsWindowButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoBindingNavigator)).BeginInit();
            this.tblFTCustomerInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quoteDataSet
            // 
            this.quoteDataSet.DataSetName = "QuoteDataSet";
            this.quoteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFTCustomerInfoBindingSource
            // 
            this.tblFTCustomerInfoBindingSource.DataMember = "tblFTCustomerInfo";
            this.tblFTCustomerInfoBindingSource.DataSource = this.quoteDataSet;
            // 
            // tblFTCustomerInfoTableAdapter
            // 
            this.tblFTCustomerInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarInfoTableAdapter = this.tblCarInfoTableAdapter;
            this.tableAdapterManager.tblFTCustomerInfoTableAdapter = this.tblFTCustomerInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = InClassPractice_ADOdotNET.QuoteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCarInfoTableAdapter
            // 
            this.tblCarInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tblFTCustomerInfoBindingNavigator
            // 
            this.tblFTCustomerInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblFTCustomerInfoBindingNavigator.BindingSource = this.tblFTCustomerInfoBindingSource;
            this.tblFTCustomerInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblFTCustomerInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblFTCustomerInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tblFTCustomerInfoBindingNavigatorSaveItem});
            this.tblFTCustomerInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblFTCustomerInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblFTCustomerInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblFTCustomerInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblFTCustomerInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblFTCustomerInfoBindingNavigator.Name = "tblFTCustomerInfoBindingNavigator";
            this.tblFTCustomerInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblFTCustomerInfoBindingNavigator.Size = new System.Drawing.Size(1257, 25);
            this.tblFTCustomerInfoBindingNavigator.TabIndex = 0;
            this.tblFTCustomerInfoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // tblFTCustomerInfoBindingNavigatorSaveItem
            // 
            this.tblFTCustomerInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblFTCustomerInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblFTCustomerInfoBindingNavigatorSaveItem.Image")));
            this.tblFTCustomerInfoBindingNavigatorSaveItem.Name = "tblFTCustomerInfoBindingNavigatorSaveItem";
            this.tblFTCustomerInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tblFTCustomerInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.tblFTCustomerInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblFTCustomerInfoBindingNavigatorSaveItem_Click);
            // 
            // tblFTCustomerInfoDataGridView
            // 
            this.tblFTCustomerInfoDataGridView.AutoGenerateColumns = false;
            this.tblFTCustomerInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFTCustomerInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.tblFTCustomerInfoDataGridView.DataSource = this.tblFTCustomerInfoBindingSource;
            this.tblFTCustomerInfoDataGridView.Location = new System.Drawing.Point(12, 28);
            this.tblFTCustomerInfoDataGridView.Name = "tblFTCustomerInfoDataGridView";
            this.tblFTCustomerInfoDataGridView.Size = new System.Drawing.Size(1142, 438);
            this.tblFTCustomerInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DiscountCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "DiscountCode";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MI";
            this.dataGridViewTextBoxColumn4.HeaderText = "MI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn5.HeaderText = "Street";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn7.HeaderText = "State";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ZipCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "ZipCode";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ReceivedDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "ReceivedDate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ProcessedDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "ProcessedDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn11.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // tblCarInfoBindingSource
            // 
            this.tblCarInfoBindingSource.DataMember = "tblCarInfo";
            this.tblCarInfoBindingSource.DataSource = this.quoteDataSet;
            // 
            // showDetailsWindowButton
            // 
            this.showDetailsWindowButton.Location = new System.Drawing.Point(12, 472);
            this.showDetailsWindowButton.Name = "showDetailsWindowButton";
            this.showDetailsWindowButton.Size = new System.Drawing.Size(127, 23);
            this.showDetailsWindowButton.TabIndex = 2;
            this.showDetailsWindowButton.Text = "Show Details Window";
            this.showDetailsWindowButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1079, 472);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 511);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showDetailsWindowButton);
            this.Controls.Add(this.tblFTCustomerInfoDataGridView);
            this.Controls.Add(this.tblFTCustomerInfoBindingNavigator);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoBindingNavigator)).EndInit();
            this.tblFTCustomerInfoBindingNavigator.ResumeLayout(false);
            this.tblFTCustomerInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFTCustomerInfoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuoteDataSet quoteDataSet;
        private System.Windows.Forms.BindingSource tblFTCustomerInfoBindingSource;
        private QuoteDataSetTableAdapters.tblFTCustomerInfoTableAdapter tblFTCustomerInfoTableAdapter;
        private QuoteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tblFTCustomerInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tblFTCustomerInfoBindingNavigatorSaveItem;
        private QuoteDataSetTableAdapters.tblCarInfoTableAdapter tblCarInfoTableAdapter;
        private System.Windows.Forms.DataGridView tblFTCustomerInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource tblCarInfoBindingSource;
        private System.Windows.Forms.Button showDetailsWindowButton;
        private System.Windows.Forms.Button exitButton;
    }
}

