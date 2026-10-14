namespace Bai1_lab3
{
	partial class frmTim
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if(disposing && (components != null))
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent( )
		{
			this.txtTim = new System.Windows.Forms.TextBox();
			this.btnTim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtTim
			// 
			this.txtTim.Location = new System.Drawing.Point(35, 56);
			this.txtTim.Name = "txtTim";
			this.txtTim.Size = new System.Drawing.Size(296, 22);
			this.txtTim.TabIndex = 0;
			// 
			// btnTim
			// 
			this.btnTim.Location = new System.Drawing.Point(353, 56);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(95, 24);
			this.btnTim.TabIndex = 0;
			this.btnTim.Text = "Tim Kiem";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// frmTim
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 176);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txtTim);
			this.Name = "frmTim";
			this.Text = "frmTim";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTim;
		private System.Windows.Forms.Button btnTim;
	}
}