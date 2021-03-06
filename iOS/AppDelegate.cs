﻿using System;
using System.Collections.Generic;
using System.Linq;
using AudioToolbox;
using Foundation;
using UIKit;

namespace formTest.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			//App.NativeVibe = () => Console.WriteLine("Vibrator");

			//set App static action to a function i.e. Native API, in this case vibration
			App.NativeVibe = () => { SystemSound.Vibrate.PlaySystemSound(); };

			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
