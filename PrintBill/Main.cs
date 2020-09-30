using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PrintBill
{
	// Token: 0x02000002 RID: 2
	public partial class Main : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000022E8 File Offset: 0x000004E8
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002364 File Offset: 0x00000564
		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			if (this.txtClearText.Text == "")
			{
				this.error.SetError(this.txtClearText, "Nhập thông tin cần đổi ở đây!");
				return;
			}
			this.error.Clear();
			string text = this.txtClearText.Text.Trim();
			this.txtDecryptedText.Visible = false;
			this.label3.Visible = false;
			this.txtCipherText.Text = text;
			this.btnDecrypt.Enabled = true;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000023EC File Offset: 0x000005EC
		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			string text = this.txtCipherText.Text.Trim();
			this.txtDecryptedText.Text = text;
			this.txtDecryptedText.Visible = true;
			this.label3.Visible = true;
		}
	}
}
