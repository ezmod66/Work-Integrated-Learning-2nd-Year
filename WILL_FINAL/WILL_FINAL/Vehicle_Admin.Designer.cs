﻿namespace WILL_FINAL
{
	partial class Vehicle_Admin
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
			this.btnModifyVehicle = new System.Windows.Forms.Button();
			this.btnAddNewVehicle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(109, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 24);
			this.label1.TabIndex = 32;
			this.label1.Text = "Vehicle Admin Menu";
			// 
			// btnLog_Out
			// 
			this.btnLog_Out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog_Out.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLog_Out.Location = new System.Drawing.Point(160, 186);
			this.btnLog_Out.Name = "btnLog_Out";
			this.btnLog_Out.Size = new System.Drawing.Size(146, 32);
			this.btnLog_Out.TabIndex = 31;
			this.btnLog_Out.Text = "Log Out";
			this.btnLog_Out.UseVisualStyleBackColor = true;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(246, 47);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(209, 95);
			this.pictureBox5.TabIndex = 30;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(10, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(216, 95);
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			// 
			// btnModifyVehicle
			// 
			this.btnModifyVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModifyVehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifyVehicle.Location = new System.Drawing.Point(246, 148);
			this.btnModifyVehicle.Name = "btnModifyVehicle";
			this.btnModifyVehicle.Size = new System.Drawing.Size(209, 32);
			this.btnModifyVehicle.TabIndex = 28;
			this.btnModifyVehicle.Text = "Modify Vehicle Information";
			this.btnModifyVehicle.UseVisualStyleBackColor = true;
			this.btnModifyVehicle.Click += new System.EventHandler(this.btnModifyVehicle_Click);
			// 
			// btnAddNewVehicle
			// 
			this.btnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewVehicle.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddNewVehicle.Location = new System.Drawing.Point(10, 148);
			this.btnAddNewVehicle.Name = "btnAddNewVehicle";
			this.btnAddNewVehicle.Size = new System.Drawing.Size(216, 32);
			this.btnAddNewVehicle.TabIndex = 27;
			this.btnAddNewVehicle.Text = "Add New Vehicle";
			this.btnAddNewVehicle.UseVisualStyleBackColor = true;
			this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
			// 
			// Vehicle_Admin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 237);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLog_Out);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnModifyVehicle);
			this.Controls.Add(this.btnAddNewVehicle);
			this.Name = "Vehicle_Admin";
			this.Text = "Vehicle_Admin";
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
		private System.Windows.Forms.Button btnModifyVehicle;
		private System.Windows.Forms.Button btnAddNewVehicle;
	}
}