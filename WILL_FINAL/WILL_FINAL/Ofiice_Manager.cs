using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WILL_FINAL
{
	public partial class Ofiice_Manager : Form
	{
		public Ofiice_Manager()
		{
			InitializeComponent();
		}

		private void btnAddNewEmployee_Click(object sender, EventArgs e)
		{
			AddNewEmployee newEmployee = new AddNewEmployee();
			newEmployee.Show();
		}

		private void btnModifyEmployee_Click(object sender, EventArgs e)
		{
			Modify_Employee_Details modify_Employee_Details = new Modify_Employee_Details();
			modify_Employee_Details.Show();
		}
	}
}
