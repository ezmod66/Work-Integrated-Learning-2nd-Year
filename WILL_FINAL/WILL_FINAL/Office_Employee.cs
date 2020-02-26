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
	public partial class Office_Employee : Form
	{
		public Office_Employee()
		{
			InitializeComponent();
		}

		private void btnAddNewCustomer_Click(object sender, EventArgs e)
		{
			AddNewCustomer newCustomer = new AddNewCustomer();
			newCustomer.Show();
		}

		private void btnModify_Customer_Details_Click(object sender, EventArgs e)
		{
			Modify_Customer_Details modifyCustomer = new Modify_Customer_Details();
			modifyCustomer.Show();
		}

		private void btnModify_Order_Click(object sender, EventArgs e)
		{
			Mdify_Order mdify_Order = new Mdify_Order();
			mdify_Order.Show();
		}

		private void btnNew_Order_Click(object sender, EventArgs e)
		{
			NewOrder newOrder = new NewOrder();
			newOrder.Show();
		}
	}
}
