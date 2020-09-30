using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PrintBill
{
	// Token: 0x0200000E RID: 14
	public partial class Loading : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000232C File Offset: 0x0000052C
		public Loading()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002918 File Offset: 0x00000B18
		private void btn_Click(object sender, EventArgs e)
		{
			if (this.txtClearText.Text == "")
			{
				this.error.SetError(this.txtClearText, "Vui lòng nhập mật khẩu!");
				return;
			}
			this.error.Clear();
			string address = "https://ip.songhanh.vn/" + this.txtClearText.Text.Trim() + "?get_comments";
			string data = this.txtClearText.Text.Trim() + "?get_comments#" + DateTime.Now.ToString("yyyyddmm");
			try
			{
				if (new WebClient().DownloadString(address) != this.GetMD5HashData(data))
				{
					MessageBox.Show("Xác nhận thất bại, vui lòng nhập lại mật khẩu!");
				}
				else
				{
					base.Hide();
					Main main = new Main();
					main.Closed += delegate(object s, EventArgs args)
					{
						base.Close();
					};
					main.Show();
				}
			}
			catch
			{
				MessageBox.Show("Không thể kết nối với máy chủ, vui lòng kiểm tra kết nối mạng!");
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002C70 File Offset: 0x00000E70
		private string GetMD5HashData(string data)
		{
			HashAlgorithm hashAlgorithm = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Default.GetBytes(data);
			return Regex.Replace(BitConverter.ToString(hashAlgorithm.ComputeHash(bytes)), "[^0-9]", "");
		}
	}
}
