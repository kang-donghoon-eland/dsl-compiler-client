﻿using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace DSLPlatform
{
	public partial class ConfigurationPortableControl : UserControl
	{
		public ConfigurationPortableControl()
		{
			InitializeComponent();
		}

		private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
		{
			try
			{
				Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
			}
			catch { }
			e.Handled = true;
		}
	}
}
