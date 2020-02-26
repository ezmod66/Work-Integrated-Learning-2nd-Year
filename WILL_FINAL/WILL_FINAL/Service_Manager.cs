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
	public partial class Service_Manager : Form
	{
		public Service_Manager()
		{
			InitializeComponent();
		}

		private void btnAddNewEmployee_Click(object sender, EventArgs e)
		{
			Schedule_Service_Appointment service_Appointment = new Schedule_Service_Appointment();
			service_Appointment.Show();
		}

		private void btnModifyEmployee_Click(object sender, EventArgs e)
		{
			Update_Service_Appointment update_Service_Appointment = new Update_Service_Appointment();
			update_Service_Appointment.Show();

		}
	}
}
