// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MarkDownEditor.XamarinIOS
{
	[Register ("ViewControllerHTML")]
	partial class ViewControllerHTML
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonMarkDown { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView textBoxHTML { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonMarkDown != null) {
				buttonMarkDown.Dispose ();
				buttonMarkDown = null;
			}

			if (textBoxHTML != null) {
				textBoxHTML.Dispose ();
				textBoxHTML = null;
			}
		}
	}
}
