using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MarkDownEditor.XamarinIOS
{
	partial class ViewControllerWYSIWYG : UIViewController
	{
		public ViewControllerWYSIWYG (IntPtr handle) : base (handle)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			Setup();
			
		}
	}
}
