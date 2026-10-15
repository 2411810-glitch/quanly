namespace KetNoiVaTruyVanDuLieu_Lab4
{
    partial class CategoryForm
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
            this.lvDS = new System.Windows.Forms.ListView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ML = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDS
            // 
            this.lvDS.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ML,
            this.ten,
            this.loai});
            this.lvDS.FullRowSelect = true;
            this.lvDS.HideSelection = false;
            this.lvDS.Location = new System.Drawing.Point(-1, 80);
            this.lvDS.MultiSelect = false;
            this.lvDS.Name = "lvDS";
            this.lvDS.Size = new System.Drawing.Size(497, 276);
            this.lvDS.TabIndex = 0;
            this.lvDS.UseCompatibleStateImageBehavior = false;
            this.lvDS.View = System.Windows.Forms.View.Details;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(317, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Lay danh sach";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ML
            // 
            this.ML.Text = "Ma Loai";
            this.ML.Width = 164;
            // 
            // ten
            // 
            this.ten.Text = "Ten loai mon an";
            this.ten.Width = 201;
            // 
            // loai
            // 
            this.loai.Text = "Loai";
            this.loai.Width = 128;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 355);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lvDS);
            this.Name = "CategoryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDS;
        private System.Windows.Forms.ColumnHeader ML;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader loai;
        private System.Windows.Forms.Button btnLoad;
    }
}

