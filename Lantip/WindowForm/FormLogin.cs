using Lantip.Service;
using Lantip.Model;
using Lantip.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lantip.WindowForm
{
	public partial class FormLogin : Form
	{
		private static int VALIDATE_OK = 0;
		private static int MISSING_USERNAME_PASSWORD = 11;

		private UserService service;

		public FormLogin()
		{
			InitializeComponent();

			service = new UserService();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			doLogin();
		}

		/// <summary>
		/// Login mechanism
		/// </summary>
		private void doLogin()
		{
			//validation
			var validate = doValidation();
			if (validate != VALIDATE_OK)
			{
				MessageBox.Show("Username atau password masih kosong");
				return;
			}

			string username = txtUsername.Text;
			string password = txtPassword.Text;
			int loginResult = service.CheckLogin(username, password);

			if (loginResult != UserService.LOGIN_OK)
			{
				MessageBox.Show("Username atau password salah");
				return;
			}

			User user = service.GetUser(username);

			//save user to CurrentOperator
			CurrentOperator.CURRENT_OPERATOR = user;

			//move to home and close this form
			//new FormHome().Show();
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// Do form validation
		/// </summary>
		/// <returns>validation result</returns>
		private int doValidation()
		{
			if (txtUsername.Text == "" || txtPassword.Text == "") return MISSING_USERNAME_PASSWORD;

			return VALIDATE_OK;
		}

		private void btnBatal_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void txtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				doLogin();
			}
		}
	}
}
