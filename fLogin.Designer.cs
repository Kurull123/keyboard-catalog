namespace WindowsFormsApp1
{
    partial class fLogin
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.keyboardsDataSet = new WindowsFormsApp1.KeyboardsDataSet();
            this.users_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_TableAdapter = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.Users_TableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // keyboardsDataSet
            // 
            this.keyboardsDataSet.DataSetName = "KeyboardsDataSet";
            this.keyboardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // users_BindingSource
            // 
            this.users_BindingSource.DataMember = "Users_";
            this.users_BindingSource.DataSource = this.keyboardsDataSet;
            // 
            // users_TableAdapter
            // 
            this.users_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.KeyboardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Users_TableAdapter = this.users_TableAdapter;
            this.tableAdapterManager.ВиробникTableAdapter = null;
            this.tableAdapterManager.КлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипКлавіатуриTableAdapter = null;
            this.tableAdapterManager.ТипПідключенняTableAdapter = null;
            this.tableAdapterManager.ФормФакторTableAdapter = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 263);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "fLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyboardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private KeyboardsDataSet keyboardsDataSet;
        private System.Windows.Forms.BindingSource users_BindingSource;
        private KeyboardsDataSetTableAdapters.Users_TableAdapter users_TableAdapter;
        private KeyboardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}