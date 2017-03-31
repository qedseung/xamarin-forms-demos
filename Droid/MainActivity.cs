using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace formTest.Droid
{
	[Activity(Label = "formTest.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			Vibrator v = (Vibrator)this.BaseContext.GetSystemService(Context.VibratorService);

			App.NativeVibe = () => { v.Vibrate(1000); };

			//App.NativeVibe = () => Console.WriteLine("Vibrate Push");

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());

		}
	}
}
