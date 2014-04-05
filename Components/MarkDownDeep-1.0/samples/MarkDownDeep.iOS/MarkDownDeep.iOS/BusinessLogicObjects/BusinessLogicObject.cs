using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarkDownDeep.iOS
{
	public partial class BusinessLogicObject 
	{
		public static MarkdownDeep.Markdown MarkDownEngine = null;

        public static string MarkUpHTML = "";
        public static string MarkDown = 
@"
## Welcome to MarkDownDeep

This demo page lets you try the JavaScript version of MarkDownDeep in your browser.

* Type some text in the area at the top
* See the tranformed HTML below
* Use the checkboxes to change options, or switch to viewing the generated HTML.
* Use the syntax cheatsheet on the right for hints on formatting.

MarkDownDeep is an implementation of Markdown for .NET with a 100% compatible
port for JavaScript for client side use.  MarkDownDeep supports the PHP Markdown Extra
extensions, is open source and has many other useful integration features.

[Read more here](http://www.toptensoftware.com/MarkDownDeep).


*italic*   **bold**
_italic_   __bold__


[HolisticWare site](http://holisticware.net/ ""HolisticWare"")



![HolisticWare logo](http://holisticware.net/Frontend/Images/logo.png ""Title"")



![HolisticWare logo][id]

[id]: http://holisticware.net/Frontend/Images/logo.png ""HolisticWare logo""



Header 1
========


Header 2
--------



# Header 1 #

## Header 2 ##

###### Header 6



1.  Foo
2.  Bar


*   A list item.

    With multiple paragraphs.

*   Bar




*   Abacus
    * answer
*   Bubbles
    1.  bunk
    2.  bupkis
        * BELITTLER
    3. burper
*   Cunning


> Email-style angle brackets
> are used for blockquotes.

> > And, they can be nested.

> #### Headers in blockquotes
> 
> * You can quote a list.
> * Etc.


> Email-style angle brackets
> are used for blockquotes.

> > And, they can be nested.

> #### Headers in blockquotes
> 
> * You can quote a list.
> * Etc.



This is a normal paragraph.

    This is a preformatted
    code block.


---

* * *

- - - - 




<div markdown=""1"">
Markdown **still** works.
</div>




~~~
This is a preformatted
code block
~~~


Fruit    |Color
---------|----------
Apples   |Red
Pears    |Green
Bananas  |Yellow





Term 1
: Definition 1

Term 2
: Definition 2




Body text with a footnote [^1]

[^1]: Footnote text here



MDD <- will have title

*[MDD]: MarkDownDeep

";


		static BusinessLogicObject()
		{
			MarkDownEngine = new MarkdownDeep.Markdown();
		}
	}
}
