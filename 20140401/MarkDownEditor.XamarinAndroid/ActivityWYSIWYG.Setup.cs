using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MarkDownEditor.XamarinAndroid
{
	public partial class ActivityWYSIWYG 
	{
		# region	WYSIYG
		// ========================================================================================
		Button 					buttonHTML = null;
		Android.Webkit.WebView 	webViewWYSIWYG = null;
		
		private void Setup()
		{
			buttonHTML = FindViewById<Button>(Resource.Id.buttonHTML);
			buttonHTML.Click += buttoHTML_Click;

			string assemblyname = "MarkDown.XamarinAndroid"; // Assembly name not namespace!!!!
			string markdown = MarkDown.XamarinAndroid.MarkDown.ContentMarkDown;

			webViewWYSIWYG = FindViewById<Android.Webkit.WebView>(Resource.Id.webViewWYSIWYG);			
			webViewWYSIWYG.Settings.JavaScriptEnabled = true;
			webViewWYSIWYG.LoadDataWithBaseURL
									(
									  ""
									, MarkDown.XamarinAndroid.MarkDown.ToHtml(markdown, assemblyname)
									, "text/html"
									, "UTF-8"
									, ""
									);
			
			return;
		}

		void buttoHTML_Click(object sender, EventArgs e)
		{
			this.Finish();
		}
		// ========================================================================================
		# endregion	WYSIYG
	}
}

