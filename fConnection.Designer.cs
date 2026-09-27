namespace WindowsFormsApp1
{
    partial class fConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConnection));
            this.keyboardsDataSet = new WindowsFormsApp1.KeyboardsDataSet();
            this.типПідключенняBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типПідключенняTableAdapter = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.ТипПідключенняTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager();
            this.типПідключенняBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.типПідключенняBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.типПідключенняDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMultiSearch = new System.Windows.Forms.Button();
            this.textBoxInterface = new System.Windows.Forms.TextBox();
            this.textBoxConnType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняBindingNavigator)).BeginInit();
            this.типПідключенняBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyboardsDataSet
            // 
            this.keyboardsDataSet.DataSetName = "KeyboardsDataSet";
            this.keyboardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типПідключенняBindingSource
            // 
            this.типПідключенняBindingSource.DataMember = "ТипПідключення";
            this.типПідключенняBindingSource.DataSource = this.keyboardsDataSet;
            // 
            // типПідключенняTableAdapter
            // 
            this.типПідключенняTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВиробникTableAdapter = null;
            this.tableAdapterManager.КлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипКлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипПідключенняTableAdapter = this.типПідключенняTableAdapter;
            this.tableAdapterManager.ФормФакторTableAdapter = null;
            // 
            // типПідключенняBindingNavigator
            // 
            this.типПідключенняBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.типПідключенняBindingNavigator.BindingSource = this.типПідключенняBindingSource;
            this.типПідключенняBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.типПідключенняBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.типПідключенняBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.типПідключенняBindingNavigatorSaveItem});
            this.типПідключенняBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.типПідключенняBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.типПідключенняBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.типПідключенняBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.типПідключенняBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.типПідключенняBindingNavigator.Name = "типПідключенняBindingNavigator";
            this.типПідключенняBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.типПідключенняBindingNavigator.Size = new System.Drawing.Size(501, 25);
            this.типПідключенняBindingNavigator.TabIndex = 0;
            this.типПідключенняBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // типПідключенняBindingNavigatorSaveItem
            // 
            this.типПідключенняBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.типПідключенняBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("типПідключенняBindingNavigatorSaveItem.Image")));
            this.типПідключенняBindingNavigatorSaveItem.Name = "типПідключенняBindingNavigatorSaveItem";
            this.типПідключенняBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.типПідключенняBindingNavigatorSaveItem.Text = "Save Data";
            this.типПідключенняBindingNavigatorSaveItem.Click += new System.EventHandler(this.типПідключенняBindingNavigatorSaveItem_Click);
            // 
            // типПідключенняDataGridView
            // 
            this.типПідключенняDataGridView.AutoGenerateColumns = false;
            this.типПідключенняDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.типПідключенняDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.типПідключенняDataGridView.DataSource = this.типПідключенняBindingSource;
            this.типПідключенняDataGridView.Location = new System.Drawing.Point(12, 76);
            this.типПідключенняDataGridView.Name = "типПідключенняDataGridView";
            this.типПідключенняDataGridView.Size = new System.Drawing.Size(350, 239);
            this.типПідключенняDataGridView.TabIndex = 1;
            this.типПідключенняDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.типПідключенняDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Тип підключення";
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип підключення";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Інтерфейс";
            this.dataGridViewTextBoxColumn3.HeaderText = "Інтерфейс";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bSave);
            this.panel1.Controls.Add(this.bDelete);
            this.panel1.Controls.Add(this.bAddNew);
            this.panel1.Controls.Add(this.bNext);
            this.panel1.Controls.Add(this.bPrevious);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 99);
            this.panel1.TabIndex = 2;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(327, 43);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 26;
            this.bSave.Text = "button5";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(246, 43);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 25;
            this.bDelete.Text = "delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(165, 43);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(75, 23);
            this.bAddNew.TabIndex = 24;
            this.bAddNew.Text = "insert";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(84, 43);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 23;
            this.bNext.Text = "next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(3, 43);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(75, 23);
            this.bPrevious.TabIndex = 22;
            this.bPrevious.Text = "prev";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(215, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 42);
            this.panel2.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типПідключенняBindingSource, "Інтерфейс", true));
            this.textBox4.Location = new System.Drawing.Point(215, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типПідключенняBindingSource, "Тип підключення", true));
            this.textBox5.Location = new System.Drawing.Point(109, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типПідключенняBindingSource, "Код", true));
            this.textBox6.Location = new System.Drawing.Point(3, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnMultiSearch);
            this.panel3.Controls.Add(this.textBoxInterface);
            this.panel3.Controls.Add(this.textBoxConnType);
            this.panel3.Location = new System.Drawing.Point(368, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(124, 249);
            this.panel3.TabIndex = 4;
            // 
            // btnMultiSearch
            // 
            this.btnMultiSearch.Location = new System.Drawing.Point(20, 119);
            this.btnMultiSearch.Name = "btnMultiSearch";
            this.btnMultiSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMultiSearch.TabIndex = 26;
            this.btnMultiSearch.Text = "знайти";
            this.btnMultiSearch.UseVisualStyleBackColor = true;
            this.btnMultiSearch.Click += new System.EventHandler(this.btnMultiSearch_Click);
            // 
            // textBoxInterface
            // 
            this.textBoxInterface.Location = new System.Drawing.Point(8, 82);
            this.textBoxInterface.Name = "textBoxInterface";
            this.textBoxInterface.Size = new System.Drawing.Size(100, 20);
            this.textBoxInterface.TabIndex = 2;
            // 
            // textBoxConnType
            // 
            this.textBoxConnType.Location = new System.Drawing.Point(8, 41);
            this.textBoxConnType.Name = "textBoxConnType";
            this.textBoxConnType.Size = new System.Drawing.Size(100, 20);
            this.textBoxConnType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Тип підключення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Інтерфейс";
            // 
            // fConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.типПідключенняDataGridView);
            this.Controls.Add(this.типПідключенняBindingNavigator);
            this.Name = "fConnection";
            this.Text = "fConnection";
            this.Load += new System.EventHandler(this.fConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняBindingNavigator)).EndInit();
            this.типПідключенняBindingNavigator.ResumeLayout(false);
            this.типПідключенняBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.типПідключенняDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyboardsDataSet keyboardsDataSet;
        private System.Windows.Forms.BindingSource типПідключенняBindingSource;
        private KeyboardsDataSetTableAdapters.ТипПідключенняTableAdapter типПідключенняTableAdapter;
        private KeyboardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator типПідключенняBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton типПідключенняBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView типПідключенняDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMultiSearch;
        private System.Windows.Forms.TextBox textBoxInterface;
        private System.Windows.Forms.TextBox textBoxConnType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}