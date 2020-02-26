namespace WILL_FINAL
{
	partial class Add_Time_Sheet
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSaveTimeSheet = new System.Windows.Forms.Button();
			this.dtEndOfShift = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dtStartOfShift = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtHoursWorked = new System.Windows.Forms.TextBox();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbJob = new System.Windows.Forms.ComboBox();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmployeeID = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSaveTimeSheet);
			this.groupBox1.Controls.Add(this.dtEndOfShift);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dtStartOfShift);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtHoursWorked);
			this.groupBox1.Controls.Add(this.dtDate);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.cbJob);
			this.groupBox1.Controls.Add(this.txtEmployeeName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtEmployeeID);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(531, 392);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Time Sheet Details";
			// 
			// btnSaveTimeSheet
			// 
			this.btnSaveTimeSheet.BackColor = System.Drawing.Color.White;
			this.btnSaveTimeSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveTimeSheet.Location = new System.Drawing.Point(213, 338);
			this.btnSaveTimeSheet.Name = "btnSaveTimeSheet";
			this.btnSaveTimeSheet.Size = new System.Drawing.Size(105, 28);
			this.btnSaveTimeSheet.TabIndex = 15;
			this.btnSaveTimeSheet.Text = "Save";
			this.btnSaveTimeSheet.UseVisualStyleBackColor = false;
			// 
			// dtEndOfShift
			// 
			this.dtEndOfShift.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtEndOfShift.Location = new System.Drawing.Point(260, 233);
			this.dtEndOfShift.Name = "dtEndOfShift";
			this.dtEndOfShift.Size = new System.Drawing.Size(200, 23);
			this.dtEndOfShift.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(39, 238);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 16);
			this.label7.TabIndex = 13;
			this.label7.Text = "Time of End Of Shift:";
			// 
			// dtStartOfShift
			// 
			this.dtStartOfShift.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtStartOfShift.Location = new System.Drawing.Point(260, 190);
			this.dtStartOfShift.Name = "dtStartOfShift";
			this.dtStartOfShift.Size = new System.Drawing.Size(186, 23);
			this.dtStartOfShift.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(39, 195);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(179, 16);
			this.label6.TabIndex = 11;
			this.label6.Text = "Time of Start of Shift:";
			// 
			// txtHoursWorked
			// 
			this.txtHoursWorked.Location = new System.Drawing.Point(260, 274);
			this.txtHoursWorked.Name = "txtHoursWorked";
			this.txtHoursWorked.Size = new System.Drawing.Size(186, 23);
			this.txtHoursWorked.TabIndex = 10;
			// 
			// dtDate
			// 
			this.dtDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtDate.Location = new System.Drawing.Point(331, 22);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(200, 23);
			this.dtDate.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 277);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Hours Worked:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 5;
			this.label3.Text = "Job Title:";
			// 
			// cbJob
			// 
			this.cbJob.FormattingEnabled = true;
			this.cbJob.Location = new System.Drawing.Point(260, 133);
			this.cbJob.Name = "cbJob";
			this.cbJob.Size = new System.Drawing.Size(186, 24);
			this.cbJob.TabIndex = 4;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(260, 99);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(186, 23);
			this.txtEmployeeName.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Employee Name:";
			// 
			// txtEmployeeID
			// 
			this.txtEmployeeID.Location = new System.Drawing.Point(260, 63);
			this.txtEmployeeID.Name = "txtEmployeeID";
			this.txtEmployeeID.Size = new System.Drawing.Size(186, 23);
			this.txtEmployeeID.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee ID:";
			// 
			// Add_Time_Sheet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(555, 416);
			this.Controls.Add(this.groupBox1);
			this.Name = "Add_Time_Sheet";
			this.Text = "Add_Time_Sheet";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSaveTimeSheet;
		private System.Windows.Forms.DateTimePicker dtEndOfShift;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtStartOfShift;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtHoursWorked;
		private System.Windows.Forms.DateTimePicker dtDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbJob;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmployeeID;
		private System.Windows.Forms.Label label1;
	}
}