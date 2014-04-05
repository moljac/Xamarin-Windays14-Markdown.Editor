# Details #

MarkdownDeep implements all the features defined by Markdown.

MarkdownDeep produces equivalent HTML to other Markdown implementations, it makes 
no attempt  to match the whitespace of those implementations. Also, it may escape some HTML 
entities differently (eg: &quot; instead of actual quote characters), but in the end the 
output is equivalent.


Markdown is of great interest on mobile devices, because it allows HTML generation without
HTML editors.


## API ##

### Easy integration ###

Using MarkdownDeep is trivially easy. Both the .NET and JavaScript editions have an
almost identical API.

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

## References ##
*	[http://www.toptensoftware.com/markdowndeep/](http://www.toptensoftware.com/markdowndeep/)

## Cross-platform port by HolisticWare team: ##

* 	[http://holisticware.net](http://holisticware.net)



