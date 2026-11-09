namespace KetNoiVaTruyVanDuLieu_Lab4
{
    partial class FoodForm
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TenMon,
            this.DVTinh,
            this.MaNhom,
            this.DonGia,
            this.GhiChu});
            this.dgvFood.Location = new System.Drawing.Point(2, 0);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.Size = new System.Drawing.Size(646, 291);
            this.dgvFood.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Ma";
            this.ID.Name = "ID";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "Name";
            this.TenMon.HeaderText = "Ten mon";
            this.TenMon.Name = "TenMon";
            // 
            // DVTinh
            // 
            this.DVTinh.DataPropertyName = "Unit";
            this.DVTinh.HeaderText = "DVT";
            this.DVTinh.Name = "DVTinh";
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "FoodCategoryID";
            this.MaNhom.HeaderText = "Ma nhom";
            this.MaNhom.Name = "MaNhom";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "Price";
            this.DonGia.HeaderText = "Don Gia";
            this.DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "Notes";
            this.GhiChu.HeaderText = "Ghi chu";
            this.GhiChu.Name = "GhiChu";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 296);
            this.Controls.Add(this.dgvFood);
            this.Name = "FoodForm";
            this.Text = "FoodForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}