namespace WindowsFormsApp1
{
    partial class fSize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSize));
            this.формФакторBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.формФакторBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.формФакторDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPrevious = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.формФакторBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyboardsDataSet = new WindowsFormsApp1.KeyboardsDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формФакторTableAdapter = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.ФормФакторTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPKFind = new System.Windows.Forms.TextBox();
            this.btnSearchPK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.формФакторBindingNavigator)).BeginInit();
            this.формФакторBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.формФакторDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.формФакторBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // формФакторBindingNavigator
            // 
            this.формФакторBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.формФакторBindingNavigator.BindingSource = this.формФакторBindingSource;
            this.формФакторBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.формФакторBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.формФакторBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.формФакторBindingNavigatorSaveItem});
            this.формФакторBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.формФакторBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.формФакторBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.формФакторBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.формФакторBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.формФакторBindingNavigator.Name = "формФакторBindingNavigator";
            this.формФакторBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.формФакторBindingNavigator.Size = new System.Drawing.Size(512, 25);
            this.формФакторBindingNavigator.TabIndex = 0;
            this.формФакторBindingNavigator.Text = "bindingNavigator1";
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
            // формФакторBindingNavigatorSaveItem
            // 
            this.формФакторBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.формФакторBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("формФакторBindingNavigatorSaveItem.Image")));
            this.формФакторBindingNavigatorSaveItem.Name = "формФакторBindingNavigatorSaveItem";
            this.формФакторBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.формФакторBindingNavigatorSaveItem.Text = "Save Data";
            this.формФакторBindingNavigatorSaveItem.Click += new System.EventHandler(this.формФакторBindingNavigatorSaveItem_Click);
            // 
            // формФакторDataGridView
            // 
            this.формФакторDataGridView.AutoGenerateColumns = false;
            this.формФакторDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.формФакторDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.формФакторDataGridView.DataSource = this.формФакторBindingSource;
            this.формФакторDataGridView.Location = new System.Drawing.Point(12, 120);
            this.формФакторDataGridView.Name = "формФакторDataGridView";
            this.формФакторDataGridView.Size = new System.Drawing.Size(300, 220);
            this.формФакторDataGridView.TabIndex = 1;
            this.формФакторDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.формФакторDataGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.bSave);
            this.panel2.Controls.Add(this.bDelete);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.bAddNew);
            this.panel2.Controls.Add(this.bNext);
            this.panel2.Controls.Add(this.bPrevious);
            this.panel2.Location = new System.Drawing.Point(12, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 92);
            this.panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(338, 50);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 21;
            this.bSave.Text = "button5";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(257, 50);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 20;
            this.bDelete.Text = "delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // bAddNew
            // 
            this.bAddNew.Location = new System.Drawing.Point(176, 50);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(75, 23);
            this.bAddNew.TabIndex = 19;
            this.bAddNew.Text = "insert";
            this.bAddNew.UseVisualStyleBackColor = true;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bNext
            // 
            this.bNext.Location = new System.Drawing.Point(95, 50);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(75, 23);
            this.bNext.TabIndex = 18;
            this.bNext.Text = "next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPrevious
            // 
            this.bPrevious.Location = new System.Drawing.Point(14, 50);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(75, 23);
            this.bPrevious.TabIndex = 17;
            this.bPrevious.Text = "prev";
            this.bPrevious.UseVisualStyleBackColor = true;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.формФакторBindingSource, "Код", true));
            this.textBox3.Location = new System.Drawing.Point(14, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.формФакторBindingSource, "Розмір", true));
            this.textBox4.Location = new System.Drawing.Point(120, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 52);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxPKFind);
            this.panel3.Controls.Add(this.btnSearchPK);
            this.panel3.Location = new System.Drawing.Point(318, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 289);
            this.panel3.TabIndex = 8;
            // 
            // формФакторBindingSource
            // 
            this.формФакторBindingSource.DataMember = "ФормФактор";
            this.формФакторBindingSource.DataSource = this.keyboardsDataSet;
            // 
            // keyboardsDataSet
            // 
            this.keyboardsDataSet.DataSetName = "KeyboardsDataSet";
            this.keyboardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Розмір";
            this.dataGridViewTextBoxColumn2.HeaderText = "Розмір";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // формФакторTableAdapter
            // 
            this.формФакторTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВиробникTableAdapter = null;
            this.tableAdapterManager.КлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипКлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипПідключенняTableAdapter = null;
            this.tableAdapterManager.ФормФакторTableAdapter = this.формФакторTableAdapter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пошук за первинним ключем";
            // 
            // textBoxPKFind
            // 
            this.textBoxPKFind.Location = new System.Drawing.Point(14, 55);
            this.textBoxPKFind.Name = "textBoxPKFind";
            this.textBoxPKFind.Size = new System.Drawing.Size(100, 20);
            this.textBoxPKFind.TabIndex = 10;
            // 
            // btnSearchPK
            // 
            this.btnSearchPK.Location = new System.Drawing.Point(26, 81);
            this.btnSearchPK.Name = "btnSearchPK";
            this.btnSearchPK.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPK.TabIndex = 9;
            this.btnSearchPK.Text = "button1";
            this.btnSearchPK.UseVisualStyleBackColor = true;
            this.btnSearchPK.Click += new System.EventHandler(this.btnSearchPK_Click);
            // 
            // fSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.формФакторDataGridView);
            this.Controls.Add(this.формФакторBindingNavigator);
            this.Name = "fSize";
            this.Text = "fSize";
            this.Load += new System.EventHandler(this.fSize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.формФакторBindingNavigator)).EndInit();
            this.формФакторBindingNavigator.ResumeLayout(false);
            this.формФакторBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.формФакторDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.формФакторBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KeyboardsDataSet keyboardsDataSet;
        private System.Windows.Forms.BindingSource формФакторBindingSource;
        private KeyboardsDataSetTableAdapters.ФормФакторTableAdapter формФакторTableAdapter;
        private KeyboardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator формФакторBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton формФакторBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView формФакторDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPKFind;
        private System.Windows.Forms.Button btnSearchPK;
    }
}