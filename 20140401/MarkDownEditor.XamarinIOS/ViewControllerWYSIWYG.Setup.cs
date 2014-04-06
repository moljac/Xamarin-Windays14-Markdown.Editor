using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace MarkDownEditor.XamarinIOS
{
	partial class ViewControllerWYSIWYG : UIViewController
	{

		# region	WYSIYG
		// ========================================================================================
		void Setup()
		{
			buttonHTML.TouchUpInside += buttonHTML_TouchUpInside;

			string assemblyname = "MarkDown.XamarinIOS"; // Assembly name not namespace!!!!
			string markdown = MarkDown.XamarinAndroid.MarkDown.ContentMarkDown;
			webViewWYSIWYG.LoadHtmlString
								(
								  MarkDown.XamarinAndroid.MarkDown.ToHtml(markdown, assemblyname)
								, null
								);
		}

		void buttonHTML_TouchUpInside (object sender, EventArgs e)
		{
			DismissModalViewControllerAnimated(true);
			
			return;
		}
		// ========================================================================================
		# endregion	WYSIYG
	}
}
