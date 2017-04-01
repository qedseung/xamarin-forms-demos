//Author: Steven Seung
//Demos Xamarin Forms
using Xamarin.Forms;
using System.Diagnostics;
using System;

namespace formTest
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			// create page instance to access button event
			var gp = new GreetPage();
			gp.vib.Clicked+= Vib_Clicked;
			MainPage = gp; //new GreetPage();

		}

		protected override void OnStart()
		{
			// Handle when your app starts
			Debug.WriteLine("on start");
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			Debug.WriteLine("on sleep");
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
			Debug.WriteLine("on resume");
		}

		void Vib_Clicked(object sender, System.EventArgs e)
		{
			//invoke action to be set in AppDelegate(iOS) and MainActivity(Android)
			NativeVibe?.Invoke();
		}

		public static Action NativeVibe { get; set; }
	}
}
