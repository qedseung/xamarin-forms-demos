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

			var gp = new GreetPage();
			gp.vib.Clicked+= Vib_Clicked;
			MainPage = gp; //new GreetPage(); //formTestPage();

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
			NativeVibe?.Invoke();
		}

		public static Action NativeVibe { get; set; }
	}
}
