using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MarkDownDeep.iOS
{
	public partial class MainViewController : 
		UIViewController
		//UINavigationController
	{
		MarkUpController markup_controller = null;
		
		static bool UserInterfaceIdiomIsPhone
		{
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		UIPopoverController flipsidePopoverController;

		public MainViewController()
			: base (UserInterfaceIdiomIsPhone ? "MainViewController_iPhone" : "MainViewController_iPad" , null)
		{
			// Custom initialization
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			
			// Perform any additional setup after loading the view, typically from a nib.
			markup_controller = new MarkUpController();
			
			var button_markup = new UIBarButtonItem(UIBarButtonSystemItem.Play);
			button_markup.Clicked += HandleClicked;
			this.NavigationItem.RightBarButtonItem = button_markup; 

            textViewMarkDown.Text = BusinessLogicObject.MarkDown;
            
			return;
		}

		void HandleClicked (object sender, EventArgs e)
		{
			BusinessLogicObject.MarkDown = textViewMarkDown.Text;
			BusinessLogicObject.MarkUpHTML =
					BusinessLogicObject.MarkDownEngine.Transform(BusinessLogicObject.MarkDown);


			this.NavigationController.PushViewController(markup_controller,true);

			return;            
		}

		
		public override void ViewDidAppear(bool animated)
		{
			base.ViewDidAppear(animated);

			
			return;
		}
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear(animated);
			
			return;
		}

		void HandleTouchUpInside (object sender, EventArgs e)
		{            
			this.NavigationController.PushViewController(markup_controller,true);
			//this.PresentViewController(markup_controller, true, PresentViewControllerCompleted);
			
			return;
		}
		
		public void PresentViewControllerCompleted()
		{
			//System.Diagnostics.Trace.WriteLine("PresentViewControllerCompleted");
		
			return;
		}
		
	   
		public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone)
			{
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else
			{
				return true;
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		partial void showInfo(NSObject sender)
		{
			if (UserInterfaceIdiomIsPhone)
			{
				var controller = new FlipsideViewController()
				{
					ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
				};
				
				controller.Done += delegate
				{
					this.DismissModalViewControllerAnimated(true);
				};
				
				this.PresentModalViewController(controller, true);
			} else
			{
				if (flipsidePopoverController == null)
				{
					var controller = new FlipsideViewController();
					flipsidePopoverController = new UIPopoverController(controller);
					controller.Done += delegate
					{
						flipsidePopoverController.Dismiss(true);
					};
				}
				
				if (flipsidePopoverController.PopoverVisible)
				{
					flipsidePopoverController.Dismiss(true);
				} else
				{
					flipsidePopoverController.PresentFromBarButtonItem((UIBarButtonItem)sender, UIPopoverArrowDirection.Any, true);
				}
			}
		}
	}
}

