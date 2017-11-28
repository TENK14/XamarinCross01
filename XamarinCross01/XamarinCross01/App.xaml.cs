using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace XamarinCross01
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new XamarinCross01.MainPage();

			AppCenter.Start("ios=e65368d5-e47a-4b84-a144-734e2fe069ff;" + "uwp={Your UWP App secret here};" +
			                "android={Your Android App secret here}",
				typeof(Analytics), typeof(Crashes));
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
