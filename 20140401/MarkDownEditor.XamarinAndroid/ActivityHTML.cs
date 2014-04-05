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
	public class ActivityHTML : Activity
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
			
			this.textBoxHTML.Text = MarkDown.XamarinAndroid.MarkDown.ToHtml(text);
			
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

