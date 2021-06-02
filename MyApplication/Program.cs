namespace MyApplication
{
	static class Program
	{
		//******************************************
		#region Static Constructure
		//******************************************
		/// <summary>
		/// Static Constructure
		/// </summary>
		static Program()
		{
		}
		//******************************************
		#endregion /Static Constructure
		//******************************************

		//******************************************
		#region Main [ Method ]
		//******************************************
		[System.STAThread]
		internal static void Main()
		{
			//***************************************
			System.Windows.Forms.Application.EnableVisualStyles();

			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			//***************************************

			//***************************************
			Infrastructure.BaseForm startupForm = new StartupForm();

			System.Windows.Forms.Application.Run(mainForm: startupForm);
			//***************************************

			//***************************************
			if (startupForm != null)
			{
				if (startupForm.IsDisposed is false)
				{
					startupForm.Dispose();
					//startupForm = null;
				}
			}
			//***************************************
		}
		//******************************************
		#endregion Main [ Method ]
		//******************************************
	}
}
