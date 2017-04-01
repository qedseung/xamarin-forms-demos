//Author: Steven Seung
//Demos Xamarin Forms 
using System;
using Xamarin.Forms;
using System.Diagnostics;

namespace formTest
{
	public partial class GreetPage : ContentPage
	{
		/*
		 * Most UI elements defined in GreetPage.xaml file
		 * lo = stack layout
		 * tb = timer button
		 * tl = timer label
		 * but = counting clicks button
		 * slid = slider
		 * sl = slider label
		*/
		int n = 1;
		bool timer_on = false;
		float elapsed = 0;
		const double period = 0.1;
		public Button vib; //vibrate button needs to be public
		public GreetPage()
		{
			InitializeComponent();
			slid.Value = 0.5;
			//events can be connected to methods in xaml or manually
			tb.Clicked += Handle_Timer; //manual event connection
			vib = new Button { Text = "Vibrate" };
			lo.Children.Add(vib);
		}

		void Handle_Clicked(object sender, EventArgs e)
		{
			DisplayAlert("Title","Greetings","Ok");
		}
		void Handle_ClickedCount(object sender, EventArgs e)
		{
			but.Text = string.Format("{0} clicks!", n++);
		}
		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			sl.Text = string.Format("slider: {0:F2}", e.NewValue);
		}
		async void Handle_Sheet(object sender, EventArgs e)
		{
			var action = await DisplayActionSheet("Social Media?", "Cancel", null, "Facebook", "Twitter", "MySpace?");
			Debug.WriteLine("Action: " + action);
		}

		void Handle_Timer(object sender, EventArgs e)
		{
			timer_on = !timer_on;
			if (timer_on)
			{
				tb.Text = "Stop";
			}
			else {
				tb.Text = "Start";
			}
			//to my relif this timer function doesn't seem to block, repeats until HandleFunc returns false
			Device.StartTimer(TimeSpan.FromSeconds(period),HandleFunc);
		}

		bool HandleFunc()
		{
			if (!timer_on){
				return false;
			}
			elapsed += (float)period;
			tl.Text = string.Format("{0:F3}", elapsed);
			return true;
		}
	}
}
