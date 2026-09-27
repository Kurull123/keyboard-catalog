namespace WindowsFormsApp1
{
    partial class fManufacturer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManufacturer));
            this.keyboardsDataSet = new WindowsFormsApp1.KeyboardsDataSet();
            this.виробникBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.виробникTableAdapter = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.ВиробникTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager();
            this.виробникBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.виробникBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.виробникDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bSave = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindFirst = new System.Windows.Forms.Button();
            this.textBoxFindManuf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникBindingNavigator)).BeginInit();
            this.виробникBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.виробникDataGridView)).BeginInit();
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
            // виробникBindingSource
            // 
            this.виробникBindingSource.DataMember = "Виробник";
            this.виробникBindingSource.DataSource = this.keyboardsDataSet;
            // 
            // виробникTableAdapter
            // 
            this.виробникTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВиробникTableAdapter = this.виробникTableAdapter;
            this.tableAdapterManager.КлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипКлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипПідключенняTableAdapter = null;
            this.tableAdapterManager.ФормФакторTableAdapter = null;
            // 
            // виробникBindingNavigator
            // 
            this.виробникBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.виробникBindingNavigator.BindingSource = this.виробникBindingSource;
            this.виробникBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.виробникBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.виробникBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.виробникBindingNavigatorSaveItem});
            this.виробникBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.виробникBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.виробникBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.виробникBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.виробникBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.виробникBindingNavigator.Name = "виробникBindingNavigator";
            this.виробникBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.виробникBindingNavigator.Size = new System.Drawing.Size(688, 25);
            this.виробникBindingNavigator.TabIndex = 0;
            this.виробникBindingNavigator.Text = "bindingNavigator1";
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
            // виробникBindingNavigatorSaveItem
            // 
            this.виробникBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.виробникBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("виробникBindingNavigatorSaveItem.Image")));
            this.виробникBindingNavigatorSaveItem.Name = "виробникBindingNavigatorSaveItem";
            this.виробникBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.виробникBindingNavigatorSaveItem.Text = "Save Data";
            this.виробникBindingNavigatorSaveItem.Click += new System.EventHandler(this.виробникBindingNavigatorSaveItem_Click);
            // 
            // виробникDataGridView
            // 
            this.виробникDataGridView.AutoGenerateColumns = false;
            this.виробникDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.виробникDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.виробникDataGridView.DataSource = this.виробникBindingSource;
            this.виробникDataGridView.Location = new System.Drawing.Point(0, 81);
            this.виробникDataGridView.Name = "виробникDataGridView";
            this.виробникDataGridView.Size = new System.Drawing.Size(449, 236);
            this.виробникDataGridView.TabIndex = 1;
            this.виробникDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.виробникDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Країна бренду";
            this.dataGridViewTextBoxColumn3.HeaderText = "Країна бренду";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Рейтинг";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 47);
            this.panel1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виробникBindingSource, "Рейтинг", true));
            this.textBox4.Location = new System.Drawing.Point(342, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виробникBindingSource, "Країна бренду", true));
            this.textBox3.Location = new System.Drawing.Point(236, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виробникBindingSource, "Назва", true));
            this.textBox2.Location = new System.Drawing.Point(130, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.виробникBindingSource, "Код", true));
            this.textBox1.Location = new System.Drawing.Point(24, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bSave);
            this.panel2.Controls.Add(this.bDelete);
            this.panel2.Controls.Add(this.bAddNew);
            this.panel2.Controls.Add(this.bNext);
            this.panel2.Controls.Add(this.bPrevious);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Location = new System.Drawing.Point(0, 323);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 100);
            this.panel2.TabIndex = 0;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(336, 59);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "button5";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(255, 59);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 15;
            this.bDelete.Text = "delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(174, 59);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(75, 23);
            this.bAddNew.TabIndex = 14;
            this.bAddNew.Text = "insert";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(93, 59);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 13;
            this.bNext.Text = "next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(12, 59);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(75, 23);
            this.bPrevious.TabIndex = 12;
            this.bPrevious.Text = "prev";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(342, 8);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(236, 8);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(130, 8);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(24, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnFindNext);
            this.panel3.Controls.Add(this.btnFindFirst);
            this.panel3.Controls.Add(this.textBoxFindManuf);
            this.panel3.Location = new System.Drawing.Point(456, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 342);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Навігаційний пошук";
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(55, 101);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(104, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Знайти наступну";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnFindFirst
            // 
            this.btnFindFirst.Location = new System.Drawing.Point(61, 70);
            this.btnFindFirst.Name = "btnFindFirst";
            this.btnFindFirst.Size = new System.Drawing.Size(87, 23);
            this.btnFindFirst.TabIndex = 1;
            this.btnFindFirst.Text = "Знайти першу";
            this.btnFindFirst.UseVisualStyleBackColor = true;
            this.btnFindFirst.Click += new System.EventHandler(this.btnFindFirst_Click);
            // 
            // textBoxFindManuf
            // 
            this.textBoxFindManuf.Location = new System.Drawing.Point(53, 40);
            this.textBoxFindManuf.Name = "textBoxFindManuf";
            this.textBoxFindManuf.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindManuf.TabIndex = 0;
            // 
            // fManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.виробникDataGridView);
            this.Controls.Add(this.виробникBindingNavigator);
            this.Name = "fManufacturer";
            this.Text = "fManufacturer";
            this.Load += new System.EventHandler(this.fManufacturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.виробникBindingNavigator)).EndInit();
            this.виробникBindingNavigator.ResumeLayout(false);
            this.виробникBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.виробникDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource виробникBindingSource;
        private KeyboardsDataSetTableAdapters.ВиробникTableAdapter виробникTableAdapter;
        private KeyboardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator виробникBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton виробникBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView виробникDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindFirst;
        private System.Windows.Forms.TextBox textBoxFindManuf;
    }
}