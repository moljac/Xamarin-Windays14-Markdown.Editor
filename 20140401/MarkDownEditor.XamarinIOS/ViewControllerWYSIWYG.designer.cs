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
	[Register ("ViewControllerWYSIWYG")]
	partial class ViewControllerWYSIWYG
	{
		[Outlet]
		MonoTouch.UIKit.UIButton buttonHTML { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIWebView webViewWYSIWYG { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonHTML != null) {
				buttonHTML.Dispose ();
				buttonHTML = null;
			}

			if (webViewWYSIWYG != null) {
				webViewWYSIWYG.Dispose ();
				webViewWYSIWYG = null;
			}
		}
	}
}
