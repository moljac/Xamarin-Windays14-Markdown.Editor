using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MarkDownEditor.XamarinAndroid
{
	[Activity(Label = "MarkDownEditor.XamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
	public partial class ActivityMarkDown : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.MarkDown);

			// Get our button from the layout resource,
			// and attach an event to it
			
			Setup();
		}

	}
}

