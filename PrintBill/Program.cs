using System;
using System.Windows.Forms;

namespace PrintBill
{
	// Token: 0x02000003 RID: 3
	internal static class Program
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002315 File Offset: 0x00000515
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Loading());
		}
	}
}
