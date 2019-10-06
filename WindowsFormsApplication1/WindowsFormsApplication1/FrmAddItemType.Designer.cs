namespace WindowsFormsApplication1
{
    partial class FrmAddItemType
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
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.GvItemType = new System.Windows.Forms.DataGridView();
            this.itemTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTypeSet = new WindowsFormsApplication1.ItemTypeSet();
            this.label2 = new System.Windows.Forms.Label();
            this.tblItemTypeTableAdapter = new WindowsFormsApplication1.ItemTypeSetTableAdapters.TblItemTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.GvItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Item Type";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(203, 8);
            this.txtItemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(148, 26);
            this.txtItemType.TabIndex = 1;
            this.txtItemType.TextChanged += new System.EventHandler(this.txtItemType_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(390, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // GvItemType
            // 
            this.GvItemType.AutoGenerateColumns = false;
            this.GvItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvItemType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemTypeIdDataGridViewTextBoxColumn,
            this.itemTypeDataGridViewTextBoxColumn});
            this.GvItemType.DataSource = this.tblItemTypeBindingSource;
            this.GvItemType.Location = new System.Drawing.Point(12, 107);
            this.GvItemType.Name = "GvItemType";
            this.GvItemType.RowHeadersWidth = 62;
            this.GvItemType.RowTemplate.Height = 28;
            this.GvItemType.Size = new System.Drawing.Size(636, 253);
            this.GvItemType.TabIndex = 3;
            // 
            // itemTypeIdDataGridViewTextBoxColumn
            // 
            this.itemTypeIdDataGridViewTextBoxColumn.DataPropertyName = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.HeaderText = "ItemTypeId";
            this.itemTypeIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemTypeIdDataGridViewTextBoxColumn.Name = "itemTypeIdDataGridViewTextBoxColumn";
            this.itemTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemTypeIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            this.itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            this.itemTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            this.itemTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblItemTypeBindingSource
            // 
            this.tblItemTypeBindingSource.DataMember = "TblItemType";
            this.tblItemTypeBindingSource.DataSource = this.itemTypeSet;
            // 
            // itemTypeSet
            // 
            this.itemTypeSet.DataSetName = "ItemTypeSet";
            this.itemTypeSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registered Item Type";
            // 
            // tblItemTypeTableAdapter
            // 
            this.tblItemTypeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAddItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GvItemType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddItemType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Item Type";
            this.Load += new System.EventHandler(this.FrmAddItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GvItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemTypeSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView GvItemType;
        private System.Windows.Forms.Label label2;
        private ItemTypeSet itemTypeSet;
        private System.Windows.Forms.BindingSource tblItemTypeBindingSource;
        private ItemTypeSetTableAdapters.TblItemTypeTableAdapter tblItemTypeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
    }
}