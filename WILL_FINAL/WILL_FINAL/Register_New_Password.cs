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
	public partial class Register_New_Password : Form
	{
		public Register_New_Password()
		{
			InitializeComponent();
		}

		private void btnRegisterPassword_Click(object sender, EventArgs e)
		{
			Form1 logIn = new Form1();
			logIn.Show();
		}
	}
}
