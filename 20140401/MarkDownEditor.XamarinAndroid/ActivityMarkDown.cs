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
	public class ActivityMarkDown : Activity
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

		# region	Code ============================================================================
		Button		buttoHTML			= null;
		EditText	textBoxMarkDown		= null;

		string markdown  = "";

		private void Setup()
		{
			buttoHTML		= FindViewById<Button>(Resource.Id.buttonHTML);
			textBoxMarkDown = FindViewById<EditText>(Resource.Id.texBoxMarkDown);

			markdown = MarkDown.XamarinAndroid.MarkDown.ContentMarkDown;

			buttoHTML.Click += 
							(sender, e) => 
							{	

								Intent intent = new Intent();
								intent.SetClass(this, typeof(ActivityHTML));

								//-------------------------------------------------------
								// Data handover
								//		.net way
								markdown = textBoxMarkDown.Text;
								MarkDown.XamarinAndroid.MarkDown.ContentMarkDown = markdown;
								//		Android Way
								intent.PutExtra("markdown", markdown);
								//-------------------------------------------------------

								StartActivity(intent);
							};
			/*
			 Java Code
			buttoHTML.setOnClickListener
						(
							new OnClickListener() 
			 				{
								public void onClick(View v) 
			 					{
									// Perform action on clicks
									Intent intent = new Intent();
									intent.SetClass(this, typeof(ActivityHTML));
									startActivity(intent);
								}
							}
						);
			*/
		}
		# endregion	Code ============================================================================
	}
}

