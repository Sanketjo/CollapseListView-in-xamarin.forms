using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace CollapseListView.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public static Enums.DeviceType DeviceType = UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone ? Enums.DeviceType.IPHONE : Enums.DeviceType.IPAD;
		public static double DeviceWidth = UIScreen.MainScreen.Bounds.Width * 2;
		public static double DeviceHeight = UIScreen.MainScreen.Bounds.Height * 2;


		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);
		}
	}
}

