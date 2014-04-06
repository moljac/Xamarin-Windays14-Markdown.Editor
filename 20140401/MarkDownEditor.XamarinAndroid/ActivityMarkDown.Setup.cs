using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MarkDownEditor.XamarinAndroid
{
	public partial class ActivityMarkDown 
	{

		# region	MarkDown
		// ========================================================================================

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
		// ========================================================================================
		# endregion	MarkDown
	}
}

