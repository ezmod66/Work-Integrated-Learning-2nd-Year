namespace WILL_FINAL
{
	partial class Trip_Manager
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
			this.btnLog_Out = new System.Windows.Forms.Button();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnModifyTrip = new System.Windows.Forms.Button();
			this.btnNewTrip = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(106, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 24);
			this.label1.TabIndex = 38;
			this.label1.Text = "Trip Manager Menu";
			// 
			// btnLog_Out
			// 
			this.btnLog_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog_Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog_Out.Location = new System.Drawing.Point(157, 186);
			this.btnLog_Out.Name = "btnLog_Out";
			this.btnLog_Out.Size = new System.Drawing.Size(146, 32);
			this.btnLog_Out.TabIndex = 37;
			this.btnLog_Out.Text = "Log Out";
			this.btnLog_Out.UseVisualStyleBackColor = true;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(243, 47);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(209, 95);
			this.pictureBox5.TabIndex = 36;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(7, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 95);
			this.pictureBox2.TabIndex = 35;
			this.pictureBox2.TabStop = false;
			// 
			// btnModifyTrip
			// 
			this.btnModifyTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifyTrip.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifyTrip.Location = new System.Drawing.Point(243, 148);
			this.btnModifyTrip.Name = "btnModifyTrip";
			this.btnModifyTrip.Size = new System.Drawing.Size(209, 32);
			this.btnModifyTrip.TabIndex = 34;
			this.btnModifyTrip.Text = "Modify Trip Information";
			this.btnModifyTrip.UseVisualStyleBackColor = true;
			// 
			// btnNewTrip
			// 
			this.btnNewTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewTrip.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewTrip.Location = new System.Drawing.Point(7, 148);
			this.btnNewTrip.Name = "btnNewTrip";
			this.btnNewTrip.Size = new System.Drawing.Size(216, 32);
			this.btnNewTrip.TabIndex = 33;
			this.btnNewTrip.Text = "New Trip";
			this.btnNewTrip.UseVisualStyleBackColor = true;
			// 
			// Trip_Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 234);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLog_Out);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnModifyTrip);
			this.Controls.Add(this.btnNewTrip);
			this.Name = "Trip_Manager";
			this.Text = "Trip_Manager";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLog_Out;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnModifyTrip;
		private System.Windows.Forms.Button btnNewTrip;
	}
}