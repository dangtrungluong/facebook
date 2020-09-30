namespace PrintBill
{
	// Token: 0x0200000E RID: 14
	public partial class Loading : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000233A File Offset: 0x0000053A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002A14 File Offset: 0x00000C14
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.btnEncrypt = new global::System.Windows.Forms.Button();
			this.txtClearText = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.error = new global::System.Windows.Forms.ErrorProvider(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.error).BeginInit();
			base.SuspendLayout();
			this.btnEncrypt.Location = new global::System.Drawing.Point(274, 20);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new global::System.Drawing.Size(84, 22);
			this.btnEncrypt.TabIndex = 0;
			this.btnEncrypt.Text = "Đăng nhập";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new global::System.EventHandler(this.btn_Click);
			this.txtClearText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtClearText.Location = new global::System.Drawing.Point(64, 21);
			this.txtClearText.Name = "txtClearText";
			this.txtClearText.Size = new global::System.Drawing.Size(203, 20);
			this.txtClearText.TabIndex = 2;
			this.txtClearText.UseSystemPasswordChar = true;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mật khẩu";
			this.error.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(371, 64);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtClearText);
			base.Controls.Add(this.btnEncrypt);
			this.Font = new global::System.Drawing.Font("Tahoma", 8f);
			base.MaximizeBox = false;
			base.Name = "formMain";
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vui lòng nhập mật khẩu để tiếp tục!";
			((global::System.ComponentModel.ISupportInitialize)this.error).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002C RID: 44
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button btnEncrypt;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TextBox txtClearText;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.ErrorProvider error;
	}
}
