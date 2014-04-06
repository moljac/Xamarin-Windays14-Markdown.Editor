using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MarkDownEditor.XamarinIOS
{
	partial class ViewControllerHTML : UIViewController
	{
		# region	HTML
		// ========================================================================================

		string markdown = "";

		void Setup()
		{
			buttonMarkDown.TouchUpInside += buttonMarkDownL_TouchUpInside;

			//-------------------------------------------------------
			// Data handover
			//		.net way
			markdown = MarkDown.XamarinAndroid.MarkDown.ContentMarkDown;
			//-------------------------------------------------------

			string assemblyname = "MarkDown.XamarinIOS"; // Assembly name not namespace!!!!
			this.textBoxHTML.Text = MarkDown.XamarinAndroid.MarkDown.ToHtml(markdown, assemblyname);

			return;
		}

		void buttonMarkDownL_TouchUpInside (object sender, EventArgs e)
		{
			DismissModalViewControllerAnimated(true);
			
			return;
		}
		
		public override void ViewWillDisappear (bool animated) 
		{
	    	base.ViewWillDisappear (animated);
	    
			//this.NavigationController.SetNavigationBarHidden (false, animated);
			
			return;
		}
		// ========================================================================================
		# endregion	HTML
	}
}
