using Xamarin.Forms;
using System.Diagnostics;

namespace formTest
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new GreetPage(); //formTestPage();
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
	}
}
