using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MarkDownEditor.XamarinIOS
{
	partial class ViewControllerHTML : UIViewController
	{
		public ViewControllerHTML (IntPtr handle) : base (handle)
		{
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			Setup();
			
		}
		
		void Setup()
		{
			buttonMarkDown.TouchUpInside += buttonMarkDownL_TouchUpInside;
		}

		void buttonMarkDownL_TouchUpInside (object sender, EventArgs e)
		{
			DismissModalViewControllerAnimated(true);
			
			return;
		}
	}
}
