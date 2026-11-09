namespace Lab_Advanced_Command
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
            this.components = new System.ComponentModel.Container();
            this.cbbChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.ctmFoodList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeperator = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.ctmFoodList.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbChon
            // 
            this.cbbChon.FormattingEnabled = true;
            this.cbbChon.Location = new System.Drawing.Point(117, 12);
            this.cbbChon.Name = "cbbChon";
            this.cbbChon.Size = new System.Drawing.Size(124, 21);
            this.cbbChon.TabIndex = 0;
            this.cbbChon.SelectedIndexChanged += new System.EventHandler(this.cbbChon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chon nhom mon an";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.ContextMenuStrip = this.ctmFoodList;
            this.dgvFoodList.Location = new System.Drawing.Point(-14, 39);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(634, 355);
            this.dgvFoodList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Co tat ca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mon an thuoc nhom";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(96, 419);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 13);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "...";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(256, 419);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 13);
            this.lblCatName.TabIndex = 3;
            this.lblCatName.Text = "...";
            // 
            // ctmFoodList
            // 
            this.ctmFoodList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmSeperator,
            this.tsmAddFood,
            this.tsmUpdateFood});
            this.ctmFoodList.Name = "tsmCalculateQuantity";
            this.ctmFoodList.Size = new System.Drawing.Size(205, 92);
            this.ctmFoodList.Text = "Menu";
            // 
            // tsmCalculateQuantity
            // 
            this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            this.tsmCalculateQuantity.Size = new System.Drawing.Size(204, 22);
            this.tsmCalculateQuantity.Text = "Tinh so luong da ban";
            this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
            // 
            // tsmSeperator
            // 
            this.tsmSeperator.Name = "tsmSeperator";
            this.tsmSeperator.Size = new System.Drawing.Size(204, 22);
            this.tsmSeperator.Text = "--------------------------";
            // 
            // tsmAddFood
            // 
            this.tsmAddFood.Name = "tsmAddFood";
            this.tsmAddFood.Size = new System.Drawing.Size(204, 22);
            this.tsmAddFood.Text = "Them mon an moi";
            this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
            // 
            // tsmUpdateFood
            // 
            this.tsmUpdateFood.Name = "tsmUpdateFood";
            this.tsmUpdateFood.Size = new System.Drawing.Size(204, 22);
            this.tsmUpdateFood.Text = "Cap nhat mon an";
            this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbChon);
            this.Name = "FoodForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ctmFoodList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.ContextMenuStrip ctmFoodList;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmSeperator;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
    }
}

