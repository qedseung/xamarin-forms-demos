//Author: Steven Seung
//Demos Xamarin Forms 
using System;
using Xamarin.Forms;
using System.Collections.Generic;


namespace formTest
{
	public partial class GreetPage : ContentPage
	{
		int n = 1;
		bool timer_on = false;
		float elapsed = 0;
		const double period = 0.1;
		public Button vib;
		public GreetPage()
		{
			InitializeComponent();
			slid.Value = 0.5;
			tb.Clicked += Handle_Timer;
			vib = new Button { Text = "Vibrate" };
			lo.Children.Add(vib);
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			DisplayAlert("Title","Greetings","Ok");
		}

		void Handle_ClickedCount(object sender, System.EventArgs e)
		{
			butt.Text = string.Format("{0} clicks!", n++);
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			val.Text = string.Format("slider: {0:F2}", e.NewValue);
		}

		void Handle_Timer(object sender, System.EventArgs e)
		{
			timer_on = !timer_on;
			if (timer_on)
			{
				tb.Text = "Stop";
			}
			else {
				tb.Text = "Start";
			}
			Device.StartTimer(TimeSpan.FromSeconds(period),HandleFunc);
		}

		bool HandleFunc()
		{
			if (!timer_on){
				return false;
			}
			elapsed += (float)period;
			ts.Text = string.Format("{0:F3}", elapsed);
			return true;
		}
	}
}
