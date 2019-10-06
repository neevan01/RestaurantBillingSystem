namespace WindowsFormsApplication1
{
    partial class FrmViewItemType
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
            this.dgvViewItemType = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewItemType
            // 
            this.dgvViewItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewItemType.Location = new System.Drawing.Point(20, 68);
            this.dgvViewItemType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvViewItemType.Name = "dgvViewItemType";
            this.dgvViewItemType.RowHeadersWidth = 62;
            this.dgvViewItemType.Size = new System.Drawing.Size(489, 315);
            this.dgvViewItemType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Item Types";
            // 
            // FrmViewItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvViewItemType);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmViewItemType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Item Type";
            this.Load += new System.EventHandler(this.FrmViewItemType_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewItemType;
        private System.Windows.Forms.Label label1;
    }
}