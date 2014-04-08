# Xamarin-Windays14

Windays14 sample demoing Xamarin mobile technologies

## Samples

1.	20140401	
	Pre-prepared **running** sample: 		
	1.	MarkDown Editor 
	2.	inserts generated HTML into template .html file		
		HTML file is embedded into app package (apk, ipa) as EmbeddedRessource
	3.	Web Browser as WYSIWYG	
2.	20140408		
	steps done during presentation and Q&Aa
	1.	project linking	(source-linking)		
		1.	Project Linker (modified for ste #2)
		2. 	MarkDown.XamarinAndroid 	- source project			
		3.	MarkDown.XamarinIOS 		- target project
	2.	project linking - extras HolisticWare extension for file suffix		
		Class1.MA.cs is not source-linked from source project
	
		
### Common

1.	PCL 

#### Business Logic

1.	Native libraries - source linked
2.	MarkDown class
	1.	generates HTML from MarkDown
	2.	inserts generated HTML into html template
	
#### UI

1. Screens / Pages / Scenes / Activities			
	1. 	MarkDown		
	2.	HTML		
	3. 	WYSIWYG - Browser		
2. Controls / Widgets / Views / UIViews
	1. MarkDown			
		1. 	textBoxMarkDown		
		2.	buttonHTML			
	2. HTML
		1.	textBoxHTML			
		2.	buttonWYSIWYG				
		3.	buttonMarkDown			
	3. WYSIWYG			
		1.	webViewWYSIWYG		
		2.	buttonWYSIWYG	

### Android

1. Activities			
	1. 	ActivityMarkDown		
	2.	ActivityHTML			
	3. 	ActivityWYSIWYG			
2.	Layouts
	1.	MarkDown.axml		
	2.	HTML.axml			
	3. 	WYSIWYG.axml
	
### iOS


	


## Links