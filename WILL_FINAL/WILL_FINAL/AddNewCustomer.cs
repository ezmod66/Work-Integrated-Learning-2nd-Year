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
	public partial class AddNewCustomer : Form
	{
		public AddNewCustomer()
		{
			InitializeComponent();
		}

		private void groupBox5_Enter(object sender, EventArgs e)
		{

		}

		private void btnAddNewCustomer_Click(object sender, EventArgs e)
		{
			NewOrder order = new NewOrder();
			order.Show();
		}
	}
}
