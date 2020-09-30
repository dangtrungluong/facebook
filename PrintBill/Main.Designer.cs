namespace PrintBill
{
	// Token: 0x02000002 RID: 2
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000004 RID: 4 RVA: 0x000022F6 File Offset: 0x000004F6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002430 File Offset: 0x00000630
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.btnEncrypt = new global::System.Windows.Forms.Button();
			this.btnDecrypt = new global::System.Windows.Forms.Button();
			this.txtClearText = new global::System.Windows.Forms.TextBox();
			this.txtCipherText = new global::System.Windows.Forms.TextBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtDecryptedText = new global::System.Windows.Forms.TextBox();
			this.error = new global::System.Windows.Forms.ErrorProvider(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.error).BeginInit();
			base.SuspendLayout();
			this.btnEncrypt.Location = new global::System.Drawing.Point(94, 134);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new global::System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 0;
			this.btnEncrypt.Text = "Tạo mã";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new global::System.EventHandler(this.btnEncrypt_Click);
			this.btnDecrypt.Location = new global::System.Drawing.Point(206, 134);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new global::System.Drawing.Size(75, 23);
			this.btnDecrypt.TabIndex = 1;
			this.btnDecrypt.Text = "Giải mã";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new global::System.EventHandler(this.btnDecrypt_Click);
			this.txtClearText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtClearText.Location = new global::System.Drawing.Point(94, 21);
			this.txtClearText.Name = "txtClearText";
			this.txtClearText.Size = new global::System.Drawing.Size(394, 20);
			this.txtClearText.TabIndex = 2;
			this.txtCipherText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtCipherText.Location = new global::System.Drawing.Point(94, 55);
			this.txtCipherText.Name = "txtCipherText";
			this.txtCipherText.Size = new global::System.Drawing.Size(394, 20);
			this.txtCipherText.TabIndex = 3;
			this.txtCipherText.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(55, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Thông tin";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 58);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(76, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Đã mã hóa";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(6, 93);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(37, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Đã giải mã";
			this.label3.Visible = false;
			this.txtDecryptedText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtDecryptedText.Location = new global::System.Drawing.Point(94, 90);
			this.txtDecryptedText.Name = "txtDecryptedText";
			this.txtDecryptedText.ReadOnly = true;
			this.txtDecryptedText.Size = new global::System.Drawing.Size(394, 20);
			this.txtDecryptedText.TabIndex = 7;
			this.txtDecryptedText.TabStop = false;
			this.txtDecryptedText.Visible = false;
			this.error.ContainerControl = this;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(516, 201);
			base.Controls.Add(this.txtDecryptedText);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtCipherText);
			base.Controls.Add(this.txtClearText);
			base.Controls.Add(this.btnDecrypt);
			base.Controls.Add(this.btnEncrypt);
			base.Name = "frmMain";
			this.Text = "Thông tin phần mềm";
			base.MaximizeBox = false;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			((global::System.ComponentModel.ISupportInitialize)this.error).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.Forms.Button btnEncrypt;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Button btnDecrypt;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox txtClearText;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.TextBox txtCipherText;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TextBox txtDecryptedText;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ErrorProvider error;
	}
}
