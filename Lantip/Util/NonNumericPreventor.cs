using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lantip.Util
{
	public class NonNumericPreventor
	{
		public static void PreventNonNumberKey(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if (e.KeyChar == '.'
				&& (sender as TextBox).Text.IndexOf('.') > -1)
			{
				e.Handled = true;
			}
		}
	}
}
