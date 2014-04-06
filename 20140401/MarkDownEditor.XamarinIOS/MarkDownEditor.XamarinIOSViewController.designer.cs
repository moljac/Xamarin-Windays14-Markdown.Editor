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
	[Register ("MarkDownEditor_XamarinIOSViewController")]
	partial class MarkDownEditor_XamarinIOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITextView textBoxMarkDown { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textBoxMarkDown != null) {
				textBoxMarkDown.Dispose ();
				textBoxMarkDown = null;
			}
		}
	}
}
