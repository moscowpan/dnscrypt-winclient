﻿using System;
using System.Windows.Forms;

namespace dnscrypt_winclient_ru
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ApplicationForm());
		}
	}
}
