using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MarkDownEditor.XamarinAndroid
{
	[Activity()]
	public partial class ActivityHTML : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.HTML);

			// Get our button from the layout resource,
			// and attach an event to it

			Setup();
		}
	}
}

