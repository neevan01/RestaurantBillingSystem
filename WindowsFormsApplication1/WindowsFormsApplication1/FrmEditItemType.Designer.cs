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
            this.txtItemTypeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewItemType = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvEditItemType = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Type";
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(136, 32);
            this.txtItemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(148, 26);
            this.txtItemType.TabIndex = 1;
            // 
            // txtItemTypeID
            // 
            this.txtItemTypeID.Location = new System.Drawing.Point(146, 80);
            this.txtItemTypeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtItemTypeID.Name = "txtItemTypeID";
            this.txtItemTypeID.ReadOnly = true;
            this.txtItemTypeID.Size = new System.Drawing.Size(148, 26);
            this.txtItemTypeID.TabIndex = 1;
            this.txtItemTypeID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Item Type";
            // 
            // txtNewItemType
            // 
            this.txtNewItemType.Location = new System.Drawing.Point(136, 125);
            this.txtNewItemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewItemType.Name = "txtNewItemType";
            this.txtNewItemType.Size = new System.Drawing.Size(148, 26);
            this.txtNewItemType.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(155, 175);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvEditItemType
            // 
            this.dgvEditItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditItemType.Location = new System.Drawing.Point(311, 32);
            this.dgvEditItemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEditItemType.Name = "dgvEditItemType";
            this.dgvEditItemType.ReadOnly = true;
            this.dgvEditItemType.RowHeadersWidth = 62;
            this.dgvEditItemType.Size = new System.Drawing.Size(495, 313);
            this.dgvEditItemType.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(155, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "OK";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click_1);
            // 
            // FrmEditItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 402);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvEditItemType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewItemType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtItemTypeID);
            this.Controls.Add(this.txtItemType);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEditItemType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditItemType";
            this.Load += new System.EventHandler(this.FrmEditItemType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditItemType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemTypeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNewItemType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvEditItemType;
        private System.Windows.Forms.Button btnSearch;
    }
}