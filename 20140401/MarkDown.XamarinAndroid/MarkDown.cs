using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MarkDown.XamarinAndroid
{
	public partial class MarkDown
	{
		# region	MarkDown
		// ========================================================================================
		public static string ContentMarkDown = "";
		public static string ContentHTML = "";

		static MarkdownDeep.Markdown markdowndeep = null;

		static MarkDown()
		{
			markdowndeep = new MarkdownDeep.Markdown();
		}

		public static string ToHtml(string md, string assemblyname)
		{
			ContentMarkDown = md;
			ContentHTML = markdowndeep.Transform(md);

			string html_template = HtmlTemplate(assemblyname);
			
			ContentHTML =  html_template.Replace(placeholder, ContentHTML);

			return ContentHTML;
		}
		
		
		static string placeholder = @"%PLACEHOLDER%";
		
		public static string HtmlTemplate(string assemblyname)
		{
			string filename = ".template.c1.x.html";
			string resourcename = assemblyname + filename;

			string text = "";

			System.IO.Stream stream = 
				System.Reflection.Assembly.GetExecutingAssembly()
						.GetManifestResourceStream(resourcename);
			using(var reader = new System.IO.StreamReader(stream))
			{
				text = reader.ReadToEnd();
			}
			//string path = System.IO.Path.Combine
			//					(
			//					  System.Environment.SpecialFolder.Personal.ToString()
			//					, "template.c1.x.html"
			//					);
			//string text = System.IO.File.ReadAllText(path);

			return text;
		}
		// ========================================================================================
		# endregion	MarkDown
	}
}