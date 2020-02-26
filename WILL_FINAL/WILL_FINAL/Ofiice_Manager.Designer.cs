namespace WILL_FINAL
{
	partial class Ofiice_Manager
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
			this.btnModifyEmployee = new System.Windows.Forms.Button();
			this.btnAddNewEmployee = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(231, 24);
			this.label1.TabIndex = 20;
			this.label1.Text = "Office Manager Menu";
			// 
			// btnLog_Out
			// 
			this.btnLog_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog_Out.Location = new System.Drawing.Point(130, 199);
			this.btnLog_Out.Name = "btnLog_Out";
			this.btnLog_Out.Size = new System.Drawing.Size(146, 32);
			this.btnLog_Out.TabIndex = 19;
			this.btnLog_Out.Text = "Log Out";
			this.btnLog_Out.UseVisualStyleBackColor = true;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(222, 62);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(146, 80);
			this.pictureBox5.TabIndex = 18;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(31, 62);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(146, 80);
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// btnModifyEmployee
			// 
			this.btnModifyEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifyEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifyEmployee.Location = new System.Drawing.Point(222, 148);
			this.btnModifyEmployee.Name = "btnModifyEmployee";
			this.btnModifyEmployee.Size = new System.Drawing.Size(146, 32);
			this.btnModifyEmployee.TabIndex = 12;
			this.btnModifyEmployee.Text = "Modify Employee";
			this.btnModifyEmployee.UseVisualStyleBackColor = true;
			this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
			// 
			// btnAddNewEmployee
			// 
			this.btnAddNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewEmployee.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewEmployee.Location = new System.Drawing.Point(31, 148);
			this.btnAddNewEmployee.Name = "btnAddNewEmployee";
			this.btnAddNewEmployee.Size = new System.Drawing.Size(146, 32);
			this.btnAddNewEmployee.TabIndex = 11;
			this.btnAddNewEmployee.Text = "Add New Employee";
			this.btnAddNewEmployee.UseVisualStyleBackColor = true;
			this.btnAddNewEmployee.Click += new System.EventHandler(this.btnAddNewEmployee_Click);
			// 
			// Ofiice_Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 246);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLog_Out);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnModifyEmployee);
			this.Controls.Add(this.btnAddNewEmployee);
			this.Name = "Ofiice_Manager";
			this.Text = "Ofiice_Manager";
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
		private System.Windows.Forms.Button btnModifyEmployee;
		private System.Windows.Forms.Button btnAddNewEmployee;
	}
}