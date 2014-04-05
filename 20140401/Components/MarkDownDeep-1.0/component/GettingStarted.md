# Getting Started #


# Markdown #

MarkdownDeep implements all the features defined by Markdown.

MarkdownDeep produces equivalent HTML to other Markdown implementations, it makes 
no attempt  to match the whitespace of those implementations. Also, it may escape some HTML 
entities differently (eg: &quot; instead of actual quote characters), but in the end the 
output is equivalent.


Markdown is of great interest on mobile devices, because it allows HTML generation without
HTML editors.


The [syntax page] [s] provides complete, detailed documentation for
every feature, but Markdown should be very easy to pick up simply by
looking at a few examples of it in action. The examples on this page
are written in a before/after style, showing example syntax and the
HTML output produced by Markdown.

It's also helpful to simply try Markdown out; the [Dingus] [d] is a
web application that allows you type your own Markdown-formatted text
and translate it to XHTML.

**Note:** This document is itself written using Markdown; you
can [see the source for it by adding '.text' to the URL] [src].

  [s]: /projects/markdown/syntax  "Markdown Syntax"
  [d]: /projects/markdown/dingus  "Markdown Dingus"
  [src]: /projects/markdown/basics.text


## Paragraphs, Headers, Blockquotes ##

A paragraph is simply one or more consecutive lines of text, separated
by one or more blank lines. (A blank line is any line that looks like
a blank line -- a line containing nothing but spaces or tabs is
considered blank.) Normal paragraphs should not be indented with
spaces or tabs.

Markdown offers two styles of headers: *Setext* and *atx*.
Setext-style headers for `<h1>` and `<h2>` are created by
"underlining" with equal signs (`=`) and hyphens (`-`), respectively.
To create an atx-style header, you put 1-6 hash marks (`#`) at the
beginning of the line -- the number of hashes equals the resulting
HTML header level.

Blockquotes are indicated using email-style '`>`' angle brackets.

Markdown:

	A First Level Header
	====================
	
	A Second Level Header
	---------------------

	Now is the time for all good men to come to
	the aid of their country. This is just a
	regular paragraph.

	The quick brown fox jumped over the lazy
	dog's back.
	
	### Header 3

	> This is a blockquote.
	> 
	> This is the second paragraph in the blockquote.
	>
	> ## This is an H2 in a blockquote


Output:

	<h1>A First Level Header</h1>
	
	<h2>A Second Level Header</h2>
	
	<p>Now is the time for all good men to come to
	the aid of their country. This is just a
	regular paragraph.</p>
	
	<p>The quick brown fox jumped over the lazy
	dog's back.</p>
	
	<h3>Header 3</h3>
	
	<blockquote>
		<p>This is a blockquote.</p>
		
		<p>This is the second paragraph in the blockquote.</p>
		
		<h2>This is an H2 in a blockquote</h2>
	</blockquote>



### Phrase Emphasis ###

Markdown uses asterisks and underscores to indicate spans of emphasis.

Markdown:

	Some of these words *are emphasized*.
	Some of these words _are emphasized also_.
	
	Use two asterisks for **strong emphasis**.
	Or, if you prefer, __use two underscores instead__.

Output:

	<p>Some of these words <em>are emphasized</em>.
	Some of these words <em>are emphasized also</em>.</p>
	
	<p>Use two asterisks for <strong>strong emphasis</strong>.
	Or, if you prefer, <strong>use two underscores instead</strong>.</p>
   


## Lists ##

Unordered (bulleted) lists use asterisks, pluses, and hyphens (`*`,
`+`, and `-`) as list markers. These three markers are
interchangable; this:

	*   Candy.
	*   Gum.
	*   Booze.

this:

	+   Candy.
	+   Gum.
	+   Booze.

and this:

	-   Candy.
	-   Gum.
	-   Booze.

all produce the same output:

	<ul>
	<li>Candy.</li>
	<li>Gum.</li>
	<li>Booze.</li>
	</ul>

Ordered (numbered) lists use regular numbers, followed by periods, as
list markers:

	1.  Red
	2.  Green
	3.  Blue

Output:

	<ol>
	<li>Red</li>
	<li>Green</li>
	<li>Blue</li>
	</ol>

If you put blank lines between items, you'll get `<p>` tags for the
list item text. You can create multi-paragraph list items by indenting
the paragraphs by 4 spaces or 1 tab:

	*   A list item.
	
		With multiple paragraphs.

	*   Another item in the list.

Output:

	<ul>
	<li><p>A list item.</p>
	<p>With multiple paragraphs.</p></li>
	<li><p>Another item in the list.</p></li>
	</ul>
	


### Links ###

Markdown supports two styles for creating links: *inline* and
*reference*. With both styles, you use square brackets to delimit the
text you want to turn into a link.

Inline-style links use parentheses immediately after the link text.
For example:

	This is an [example link](http://example.com/).

Output:

	<p>This is an <a href="http://example.com/">
	example link</a>.</p>

Optionally, you may include a title attribute in the parentheses:

	This is an [example link](http://example.com/ "With a Title").

Output:

	<p>This is an <a href="http://example.com/" title="With a Title">
	example link</a>.</p>

Reference-style links allow you to refer to your links by names, which
you define elsewhere in your document:

	I get 10 times more traffic from [Google][1] than from
	[Yahoo][2] or [MSN][3].

	[1]: http://google.com/        "Google"
	[2]: http://search.yahoo.com/  "Yahoo Search"
	[3]: http://search.msn.com/    "MSN Search"

Output:

	<p>I get 10 times more traffic from <a href="http://google.com/"
	title="Google">Google</a> than from <a href="http://search.yahoo.com/"
	title="Yahoo Search">Yahoo</a> or <a href="http://search.msn.com/"
	title="MSN Search">MSN</a>.</p>

The title attribute is optional. Link names may contain letters,
numbers and spaces, but are *not* case sensitive:

	I start my morning with a cup of coffee and
	[The New York Times][NY Times].

	[ny times]: http://www.nytimes.com/

Output:

	<p>I start my morning with a cup of coffee and
	<a href="http://www.nytimes.com/">The New York Times</a>.</p>


### Images ###

Image syntax is very much like link syntax.

Inline (titles are optional):

	![alt text](/path/to/img.jpg "Title")

Reference-style:

	![alt text][id]

	[id]: /path/to/img.jpg "Title"

Both of the above examples produce the same output:

	<img src="/path/to/img.jpg" alt="alt text" title="Title" />



### Code ###

In a regular paragraph, you can create code span by wrapping text in
backtick quotes. Any ampersands (`&`) and angle brackets (`<` or
`>`) will automatically be translated into HTML entities. This makes
it easy to use Markdown to write about HTML example code:

	I strongly recommend against using any `<blink>` tags.

	I wish SmartyPants used named entities like `&mdash;`
	instead of decimal-encoded entites like `&#8212;`.

Output:

	<p>I strongly recommend against using any
	<code>&lt;blink&gt;</code> tags.</p>
	
	<p>I wish SmartyPants used named entities like
	<code>&amp;mdash;</code> instead of decimal-encoded
	entites like <code>&amp;#8212;</code>.</p>


To specify an entire block of pre-formatted code, indent every line of
the block by 4 spaces or 1 tab. Just like with code spans, `&`, `<`,
and `>` characters will be escaped automatically.

Markdown:

	If you want your page to validate under XHTML 1.0 Strict,
	you've got to put paragraph tags in your blockquotes:

		<blockquote>
			<p>For example.</p>
		</blockquote>

Output:

	<p>If you want your page to validate under XHTML 1.0 Strict,
	you've got to put paragraph tags in your blockquotes:</p>
	
	<pre><code>&lt;blockquote&gt;
		&lt;p&gt;For example.&lt;/p&gt;
	&lt;/blockquote&gt;
	</code></pre>



## API ##

### Easy integration ###

Using MarkdownDeep is trivially easy. Both the .NET and JavaScript editions have an a
lmost identical API.

Note: This page covers the Markdown to HTML text transformation APIs. For instructions 
on integrating the client side editor GUI, see here.


### .NET Edition ###

To use the .NET edition of MarkdownDeep:

Before using MarkdownDeep, user must add a reference to the MarkdownDeep.dll assembly 
from your .NET project. Depending on chosen development environment this might be done 
in any of a number of different ways - please consult the documentation for 
development tool.

Create an instance of the MarkdownDeep object. eg:

```csharp
	// Create an instance of Markdown
	var md = new MarkdownDeep.Markdown();
	Set required options. eg:
```

```csharp
	// Set options
	md.ExtraMode = true;
	md.SafeMode = false;
```

Transform the Markdown content:

```csharp
	string output = md.Transform(input);

```

## Other Resources

* 	[http://daringfireball.net/projects/markdown/](http://daringfireball.net/projects/markdown/)
*	[http://daringfireball.net/projects/markdown/dingus](http://daringfireball.net/projects/markdown/dingus)
* 	[http://www.toptensoftware.com/markdowndeep/api](http://www.toptensoftware.com/markdowndeep/api)
* 	[http://www.toptensoftware.com/markdowndeep/editor](http://www.toptensoftware.com/markdowndeep/editor)


## Port ##


Cross-platform port by HolisticWare:

* 	Xamarin.iOS
* 	Xamarin.Android

* 	[http://holisticware.net](http://holisticware.net)
