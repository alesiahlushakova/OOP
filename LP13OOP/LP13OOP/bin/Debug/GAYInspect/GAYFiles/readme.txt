                       DjVu Browser Plug-in 6.1.0
              	   Copyright (c) 2006 LizardTech, Inc.
                            All rights reserved


-------------------------------------------------------------------
README File Contents
-------------------------------------------------------------------

    I System Requirements
   II Installation Instructions
  III Release Notes
   IV Known Issues
    V Reporting Problems
   VI Licenses and Trademarks

-------------------------------------------------------------------
  I System Requirements
-------------------------------------------------------------------
  Minimum system requirements for the DjVu Web Browser Plug-in
	
	-Windows 98, NT, 2000, ME, XP
	-20 MB available hard disk space.
	-64 MB of RAM
	-IE 5 or later, Mozilla 1.0 or later-based browser 
	-Mouse or other pointing device

-------------------------------------------------------------------
  II Install DjVu Browser Plug-in
-------------------------------------------------------------------
        1. Close all DjVu documents and applications before installing.
        2. Double click on the self-extracting executable to start 
           the install.
        3. Review the license agreement and select Yes if you agree 
           with its terms.
        4. Select Finish to complete the installation.
  
-------------------------------------------------------------------
  III Release Notes
-------------------------------------------------------------------
6.1
	Support for Secure DjVu
	Various printing fixes / enhancements
6.0.1
	Measurement feature.
6.0
	Dual Page View
	Overhaulled GUI
	Dropped support for Leadtools, render new, 
	 natively-implemented annotations
	Unicode support in GUI
	File / Print support from inside of IE.
	Added dedicated application to host control
	 to view local files.
5.0.2
	Minor fixes to COM events.
5.0.1
	Add maintenance mode to installer
	Add mousewheel support
	fixes to COM interface
4.5.2
	Bug fixes and enhancements to support hosting by Document Express Editor
	Manual installer includes shell extension for DjVu Document Thumbnails
4.5.0
	3rd party DLLs (LeadTools, OLEACC) are optional
	Fixed panning performance issue
	Marked control as safe for scripting
	Extensive overhaul of ActiveX scripting interface
	Updated GUI
	"Shrink to Fit" (printing) now expands to "Scale to Fit"
	Various bug fixes.
4.1.0
	Improved Stability under Win98
	Support for Document Outlines
	"508" compliance
4.0.0
	Support for new 4.0 version of annotations
	Print v 4.0 Annotations
	Fixed handle leak (see known issues below)
	Fixed Win98 autoinstall issue (filenames now 8.3 compliant)
	
3.6.2
	Fixed problem with version resource (binary version updated to 3.600.2)
	Fixed display rotated text highlighting
	Fixed multibyte issues with Save As file names.
	Modified some default settings and made cosmetic changes to Print Dialog
	Fixed problem saving Preferences
3.6
	Fixed memory leak associated with incomplete deallocation of plugin
	File caching uses browser settings.
	Fixed aliasing problem when viewing rotated b/w images.
3.5.500
	Corrected support for rotated images (created using Editor 3.5):
	  a. Annotations (highlight areas, hyperlinks) are rendered with correct orientation.
	  b. Images are printed with correct orientation.

3.5.400
	Fixed Problem related to being unable to disable Save and Print tool buttons.

3.5.300
	-Revised Help Documentation.
	-Configurable Toolbar

3.5.200 & 3.5.100

	-Feature update: Improved caching support for Internet Explorer.
	-Feature update: The installer sets your default HTML browser to be the 
	default DjVu application without prompting you for a choice.
	-Feature update: Stability improvements have been made to the ActiveX
	control for DjVu. 
	-Feature update: Copy Image is supported for NT and Win2000.
	-Feature update: The plug-in no longer displays error messages related to
	"Stop" messages for child threads. 
	-Documentation update: To customize the default placement of the toolbar 
	use the <embed> or <object> tags in the HTML text of the web page 
	as follows, TOOLBAR=top/bottom.
	-Documentation Update: To set the default alignment of the DjVu file in 
	the viewing window type the <embed> or <object> tags in the HTML text of the
	web page using DOC_ALIGN="one of nine options".
	-Documentation update: To set the default rotation of a DjVu file in the
	viewing window type the <embed> or <object> tag in the HTML text of the
	document using ROTATE=180 degrees (90 for 90 degree, 270 for 270 degree).
	The document rotates clockwise.
	-Documentation correction: Zoom in increases from 5% to 25%, then 
	follows the settings from the Select Zoom drop down menu to 300%.
	Then the increases occur by 100% to a maximum of 1200%. The reverse
	occurs for Zoom Out.
	-Documentation correction - Zoom selected area only pertains to 
	the Zoom in feature.
        -Document correction - The "passive" attribute, used with the <embed> or 
        <object> tags, has been changed to properly reflect that it is not a binary
        attribute. To use the "passive" attribute, use "&passive" without the 
        "=yes/no" qualifiers. 
	- Documentation correction - The <object> tag may not good for  Win98/ME 
          in combination with IE5.x, as in the following example.
		<object type="image/x.djvu" data="foo.djvu" width=400 height=300>
		<param name="src" value="foo.djvu"   >
		</object>
	  A better way to use object tag is:
		<object classid="clsid:0e8d0700-75df-11d3-8b4a-0008c7450c4a" width=400 height=300>
		<param name="src" value="foo.djvu">
	  However, both examples work properly on WinNT/Win2000/XP and IE6.x

	
-------------------------------------------------------------------
  IV Known Issues
-------------------------------------------------------------------
  The following known issues exist for the DjVu Web Browser Plug-in:
	-Systems which use a "VGA" pallete/theme may observe 
	non-transparent backgrounds on the toolbar.
	-IE 6 SP 1 has a known issue, Q818857, which prevents the 
	control from instantiating until the DjVu file it is 
	viewing has completely downloaded.  A supported fix is
	available from Microsoft.  See http://support.microsoft.com/?id=818857.
	-Occassional rendering problems.  Observed symptoms include (a) Annotations 
	on the first page will not render (b) the image crops to the upper left 
	corner.  The work around is to either reload the page, either 
	by reloading the document or by changing pages.
	-When setting the "Page=<id>" property using the CGI-bin type arguments, the
	Page property must be set *last*.  The problem does not occur when setting
	"Page=#".

-------------------------------------------------------------------
   V Reporting Problems
-------------------------------------------------------------------
To report any comments, problems, or suggestions please see:
	http://www.lizardtech.com/support
 
-------------------------------------------------------------------
  VI Licenses and Trademarks.
-------------------------------------------------------------------

Copyright (c) 2006 LizardTech, Inc.
All rights reserved.
DjVu is a registered trademark of LizardTech, Inc.

This software is based in part on the work of the Independent JPEG Group.  


