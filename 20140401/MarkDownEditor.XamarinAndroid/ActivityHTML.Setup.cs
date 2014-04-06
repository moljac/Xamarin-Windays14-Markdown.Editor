using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MarkDownEditor.XamarinAndroid
{
	public partial class ActivityHTML 
	{

		# region	HTML 
		// ========================================================================================
		Button		buttonWYSIWYG	= null;
		Button		buttoWMarkDown	= null;
		EditText	textBoxHTML		= null;

		string html = "";
		string markdown = "";

		private void Setup()
		{
			buttonWYSIWYG	= FindViewById<Button>(Resource.Id.buttonWYSIWYG);
			buttoWMarkDown	= FindViewById<Button>(Resource.Id.buttonMarkDown);
			textBoxHTML		= FindViewById<EditText>(Resource.Id.texBoxHTML);

			buttonWYSIWYG.Click		+= buttonWYSIWYG_Click;
			buttoWMarkDown.Click	+= buttoWMarkDown_Click;

			//-------------------------------------------------------
			// Data handover
			//		.net way
			markdown = MarkDown.XamarinAndroid.MarkDown.ContentMarkDown;
			//		Android Way
			string text = Intent.GetStringExtra("markdown") ?? "Data not available";
			//-------------------------------------------------------
			
			string assemblyname = "MarkDown.XamarinAndroid"; // Assembly name not namespace!!!!
			this.textBoxHTML.Text = MarkDown.XamarinAndroid.MarkDown.ToHtml(text, assemblyname);
			
			return;
		}

		void buttoWMarkDown_Click(object sender, EventArgs e)
		{
			this.Finish();
		}

		void buttonWYSIWYG_Click(object sender, EventArgs e)
		{
			Intent intent = new Intent();
			intent.SetClass(this, typeof(ActivityWYSIWYG));
			StartActivity(intent);
		}
		// ========================================================================================
		# endregion	HTML
	}
}

