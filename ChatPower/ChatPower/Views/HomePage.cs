using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin.Forms;


namespace ChatPower
{
	public class HomePage : ContentPage
	{
		public HomePage ()
		{
			Padding = new Thickness (0, Device.OnPlatform (0, 0, 0), 0, 0);
			Title = "Organize a Power Meeting";

			var fabianlist = new[] {
				"alpha",
				"bravo",
				"charlie",
				"delta",
				"echo",
				"foxtrot",
				"golf",
				"hotel",
				"india",
				"juliet"

			};

			var listview1 = new ListView ();
			//using the below line it will set it to everything in the array

			listview1.ItemsSource = fabianlist;

			listview1.ItemSelected += (sender, e) => {
				Debug.WriteLine("You clicked: " + e.SelectedItem);
			};

			Content = new StackLayout {

				Children = { listview1,

				}

			};

		}
	}
}

