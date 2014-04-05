// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace MarkDownDeep.iOS
{
	[Register ("MarkUpController")]
	partial class MarkUpController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonReturnToMarkdown { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webViewMarkUp { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonReturnToMarkdown != null) {
				buttonReturnToMarkdown.Dispose ();
				buttonReturnToMarkdown = null;
			}

			if (webViewMarkUp != null) {
				webViewMarkUp.Dispose ();
				webViewMarkUp = null;
			}
		}
	}
}
