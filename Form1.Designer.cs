namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.Windows.Forms.Label fNameLabel;
            System.Windows.Forms.Label lNameLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuerDataSet = new WindowsFormsApplication2.issuerDataSet();
            this.accountTableAdapter = new WindowsFormsApplication2.issuerDataSetTableAdapters.accountTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.issuerDataSetTableAdapters.TableAdapterManager();
            this.cardholderTableAdapter = new WindowsFormsApplication2.issuerDataSetTableAdapters.cardholderTableAdapter();
            this.merchantTableAdapter = new WindowsFormsApplication2.issuerDataSetTableAdapters.merchantTableAdapter();
            this.trnsactionTableAdapter = new WindowsFormsApplication2.issuerDataSetTableAdapters.trnsactionTableAdapter();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accountBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.accountBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.merchantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trnsactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.trnsactionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.acountfkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fNameLabel = new System.Windows.Forms.Label();
            lNameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).BeginInit();
            this.accountBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trnsactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trnsactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acountfkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fNameLabel
            // 
            fNameLabel.AutoSize = true;
            fNameLabel.Location = new System.Drawing.Point(20, 96);
            fNameLabel.Name = "fNameLabel";
            fNameLabel.Size = new System.Drawing.Size(78, 17);
            fNameLabel.TabIndex = 9;
            fNameLabel.Text = "First name:";
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Location = new System.Drawing.Point(20, 127);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new System.Drawing.Size(78, 17);
            lNameLabel.TabIndex = 11;
            lNameLabel.Text = "Last name:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(73, 63);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(25, 17);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataMember = "account";
            this.accountBindingSource.DataSource = this.issuerDataSet;
            // 
            // issuerDataSet
            // 
            this.issuerDataSet.DataSetName = "issuerDataSet";
            this.issuerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountTableAdapter
            // 
            this.accountTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = this.accountTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cardholderTableAdapter = this.cardholderTableAdapter;
            this.tableAdapterManager.merchantTableAdapter = this.merchantTableAdapter;
            this.tableAdapterManager.trnsactionTableAdapter = this.trnsactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.issuerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cardholderTableAdapter
            // 
            this.cardholderTableAdapter.ClearBeforeFill = true;
            // 
            // merchantTableAdapter
            // 
            this.merchantTableAdapter.ClearBeforeFill = true;
            // 
            // trnsactionTableAdapter
            // 
            this.trnsactionTableAdapter.ClearBeforeFill = true;
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataMember = "cardholder";
            this.cardholderBindingSource.DataSource = this.issuerDataSet;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accountBindingNavigatorSaveItem
            // 
            this.accountBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountBindingNavigatorSaveItem.Image")));
            this.accountBindingNavigatorSaveItem.Name = "accountBindingNavigatorSaveItem";
            this.accountBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.accountBindingNavigatorSaveItem.Text = "Save Data";
            this.accountBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountBindingNavigatorSaveItem_Click);
            // 
            // accountBindingNavigator
            // 
            this.accountBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountBindingNavigator.BindingSource = this.cardholderBindingSource;
            this.accountBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accountBindingNavigatorSaveItem});
            this.accountBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountBindingNavigator.Name = "accountBindingNavigator";
            this.accountBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountBindingNavigator.Size = new System.Drawing.Size(921, 27);
            this.accountBindingNavigator.TabIndex = 0;
            this.accountBindingNavigator.Text = "bindingNavigator1";
            // 
            // merchantBindingSource
            // 
            this.merchantBindingSource.DataMember = "merchant";
            this.merchantBindingSource.DataSource = this.issuerDataSet;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Cardholder";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(457, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(444, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Transaction";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trnsactionBindingSource
            // 
            this.trnsactionBindingSource.DataMember = "trnsaction_fk1";
            this.trnsactionBindingSource.DataSource = this.cardholderBindingSource;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardholderBindingSource, "fName", true));
            this.fNameTextBox.Location = new System.Drawing.Point(104, 96);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.fNameTextBox.TabIndex = 19;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardholderBindingSource, "lName", true));
            this.lNameTextBox.Location = new System.Drawing.Point(104, 127);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(121, 22);
            this.lNameTextBox.TabIndex = 21;
            // 
            // trnsactionDataGridView
            // 
            this.trnsactionDataGridView.AutoGenerateColumns = false;
            this.trnsactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trnsactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.trnsactionDataGridView.DataSource = this.trnsactionBindingSource;
            this.trnsactionDataGridView.Location = new System.Drawing.Point(457, 66);
            this.trnsactionDataGridView.Name = "trnsactionDataGridView";
            this.trnsactionDataGridView.RowTemplate.Height = 24;
            this.trnsactionDataGridView.Size = new System.Drawing.Size(444, 317);
            this.trnsactionDataGridView.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tID";
            this.dataGridViewTextBoxColumn1.HeaderText = "tID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn2.HeaderText = "amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cID";
            this.dataGridViewTextBoxColumn3.HeaderText = "cID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mID";
            this.dataGridViewTextBoxColumn4.HeaderText = "mID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardholderBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(104, 63);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(121, 22);
            this.iDTextBox.TabIndex = 28;
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataMember = "acount_fk";
            this.accountBindingSource1.DataSource = this.cardholderBindingSource;
            this.accountBindingSource1.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.accountBindingSource1_AddingNew);
            // 
            // acountfkBindingSource
            // 
            this.acountfkBindingSource.DataMember = "acount_fk";
            this.acountfkBindingSource.DataSource = this.cardholderBindingSource;
            // 
            // accountDataGridView
            // 
            this.accountDataGridView.AutoGenerateColumns = false;
            this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.accountDataGridView.DataSource = this.accountBindingSource1;
            this.accountDataGridView.Location = new System.Drawing.Point(23, 160);
            this.accountDataGridView.Name = "accountDataGridView";
            this.accountDataGridView.RowTemplate.Height = 24;
            this.accountDataGridView.Size = new System.Drawing.Size(428, 223);
            this.accountDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "acountNum";
            this.dataGridViewTextBoxColumn5.HeaderText = "acountNum";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "avlLimit";
            this.dataGridViewTextBoxColumn6.HeaderText = "avlLimit";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 421);
            this.Controls.Add(this.accountDataGridView);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(this.trnsactionDataGridView);
            this.Controls.Add(this.fNameTextBox);
            this.Controls.Add(this.lNameTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(lNameLabel);
            this.Controls.Add(fNameLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.accountBindingNavigator);
            this.Name = "Form1";
            this.Text = "Issuer Database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingNavigator)).EndInit();
            this.accountBindingNavigator.ResumeLayout(false);
            this.accountBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trnsactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trnsactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acountfkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private issuerDataSet issuerDataSet;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private issuerDataSetTableAdapters.accountTableAdapter accountTableAdapter;
        private issuerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private issuerDataSetTableAdapters.cardholderTableAdapter cardholderTableAdapter;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton accountBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator accountBindingNavigator;
        private issuerDataSetTableAdapters.trnsactionTableAdapter trnsactionTableAdapter;
        private System.Windows.Forms.BindingSource merchantBindingSource;
        private issuerDataSetTableAdapters.merchantTableAdapter merchantTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource trnsactionBindingSource;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.DataGridView trnsactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.BindingSource accountBindingSource1;
        private System.Windows.Forms.BindingSource acountfkBindingSource;
        private System.Windows.Forms.DataGridView accountDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}

