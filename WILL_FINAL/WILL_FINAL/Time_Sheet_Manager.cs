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
	public partial class Time_Sheet_Manager : Form
	{
		public Time_Sheet_Manager()
		{
			InitializeComponent();
		}

		private void btnAddNewTimeSheet_Click(object sender, EventArgs e)
		{
			Add_Time_Sheet add_Time_Sheet = new Add_Time_Sheet();
			add_Time_Sheet.Show();
		}

		private void btnModifyTimeSheet_Click(object sender, EventArgs e)
		{
			Update_Time_Sheet update_Time_Sheet = new Update_Time_Sheet();
			update_Time_Sheet.Show();
		}

		private void btnLog_Out_Click(object sender, EventArgs e)
		{

		}
	}
}
