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
	public partial class Vehicle_Admin : Form
	{
		public Vehicle_Admin()
		{
			InitializeComponent();
		}

		private void btnAddNewVehicle_Click(object sender, EventArgs e)
		{
			Register_New_Vehicle new_Vehicle = new Register_New_Vehicle();
			new_Vehicle.Show();

		}

		private void btnModifyVehicle_Click(object sender, EventArgs e)
		{
			Modify_Vehicle_Information modify_Vehicle_Information = new Modify_Vehicle_Information();
			modify_Vehicle_Information.Show();
		}
	}
}
