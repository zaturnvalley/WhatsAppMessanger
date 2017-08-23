using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsAppMessenger
{
	public partial class frmRegister : Form
	{
		string password;

		public frmRegister()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnRequest_Click(object sender, EventArgs e)
		{
			if(string.IsNullOrEmpty(txtPhoneNumber.Text))
			{
				MessageBox.Show("Please enter your phone number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtPhoneNumber.Focus();
				return;
			}
			if(string.IsNullOrEmpty(txtFullName.Text))
			{
				MessageBox.Show("Please enter your full name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtFullName.Focus();
				return;
			}
			if(WhatsAppApi.Register.WhatsRegisterV2.RequestCode(txtPhoneNumber.Text,out password, "sms"))
			{

			}
		}

		private void Save()
		{

		}
		private void btnConfirm_Click(object sender, EventArgs e)
		{

		}
	}
}
