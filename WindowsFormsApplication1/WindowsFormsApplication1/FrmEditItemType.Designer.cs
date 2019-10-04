namespace WindowsFormsApplication1
{
    partial class FrmEditItemType
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewItemType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvEditItemType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Type";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(131, 51);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(100, 20);
            this.txtItemType.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Type ID";
            // 
            // txtItemTypeID
            // 
            this.txtItemTypeID.Location = new System.Drawing.Point(131, 81);
            this.txtItemTypeID.Name = "txtItemTypeID";
            this.txtItemTypeID.ReadOnly = true;
            this.txtItemTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtItemTypeID.TabIndex = 1;
            this.txtItemTypeID.TextChanged += new System.EventHandler(this.txtItemTypeID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Item Type";
            // 
            // txtNewItemType
            // 
            this.txtNewItemType.Location = new System.Drawing.Point(131, 111);
            this.txtNewItemType.Name = "txtNewItemType";
            this.txtNewItemType.Size = new System.Drawing.Size(100, 20);
            this.txtNewItemType.TabIndex = 3;
            this.txtNewItemType.TextChanged += new System.EventHandler(this.txtNewItemType_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(156, 146);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvEditItemType
            // 
            this.dgvEditItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditItemType.Location = new System.Drawing.Point(351, 23);
            this.dgvEditItemType.Name = "dgvEditItemType";
            this.dgvEditItemType.Size = new System.Drawing.Size(240, 150);
            this.dgvEditItemType.TabIndex = 3;
            this.dgvEditItemType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditItemType_CellContentClick);
            // 
            // frmEditItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 261);
            this.Controls.Add(this.dgvEditItemType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNewItemType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemTypeID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.label1);
            this.Name = "frmEditItemType";
            this.Text = "frmEditItemType";
            this.Load += new System.EventHandler(this.frmEditItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItemType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewItemType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvEditItemType;
    }
}