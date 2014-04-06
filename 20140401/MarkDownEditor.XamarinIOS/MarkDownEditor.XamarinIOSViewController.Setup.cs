using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MarkDownEditor.XamarinIOS
{
	public partial class MarkDownEditor_XamarinIOSViewController
	{
		# region	MarkDown
		// ========================================================================================
		string markdown = "";

		public override void ViewWillDisappear (bool animated) 
		{
	    	base.ViewWillDisappear (animated);
	    
			//this.NavigationController.SetNavigationBarHidden (false, animated);
			
			//-------------------------------------------------------
			// Data handover
			//		.net way
			markdown = textBoxMarkDown.Text;
			MarkDown.XamarinAndroid.MarkDown.ContentMarkDown = markdown;
			//-------------------------------------------------------
			
			return;
		}
		// ========================================================================================
		# endregion	MarkDown

	}
}

