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
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewItemType
            // 
            this.dgvViewItemType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewItemType.Location = new System.Drawing.Point(13, 44);
            this.dgvViewItemType.Name = "dgvViewItemType";
            this.dgvViewItemType.Size = new System.Drawing.Size(340, 205);
            this.dgvViewItemType.TabIndex = 0;
            this.dgvViewItemType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // frmViewItemType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 261);
            this.Controls.Add(this.dgvViewItemType);
            this.Name = "frmViewItemType";
            this.Text = "View Item Type";
            this.Load += new System.EventHandler(this.frmViewItemType_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItemType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewItemType;
    }
}