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
	public class ActivityWYSIWYG : Activity
	{

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.WYSIWYG);

			// Get our button from the layout resource,
			// and attach an event to it

			Setup();
		}

		# region	HTML
		// ========================================================================================
		Button 					buttonHTML = null;
		Android.Webkit.WebView 	webViewWYSIWYG = null;
		
		private void Setup()
		{
			buttonHTML = FindViewById<Button>(Resource.Id.buttonHTML);
			webViewWYSIWYG = FindViewById<Android.Webkit.WebView>(Resource.Id.webViewWYSIWYG);
			
			webViewWYSIWYG.Settings.JavaScriptEnabled = true;
			webViewWYSIWYG.LoadDataWithBaseURL
									(
									  ""
									, MarkDown.XamarinAndroid.MarkDown.ContentHTML
									, "text/html"
									, "UTF-8"
									, ""
									);
			buttonHTML.Click += buttoHTML_Click;
			
			return;
		}

		void buttoHTML_Click(object sender, EventArgs e)
		{
			this.Finish();
		}
		// ========================================================================================
		# endregion	HTML
	}
}

