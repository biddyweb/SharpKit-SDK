// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Includes library functions to work with the current document.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Document", OmitOptionalParameters = true, Export = false)]
    public partial class Document 
    {
		#region Methods

		public Document() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the height of the document.</para>
		/// <para>Internet Explorer in standard mode stores the proprietary scrollHeight property
		/// on the documentElement, but in quirks mode on the body element. All
		/// other known browsers simply store the correct value on the documentElement.</para>
		/// <para>If the viewport is higher than the document the viewport height is returned.</para>
		/// <para>As the html element has no visual appearance it also can not scroll. This
		/// means that we must use the body scrollHeight in all non mshtml clients.</para>
		/// <para>Verified to correctly work with:</para>
		/// <list type="bullet">
		/// <item>Mozilla Firefox 2.0.0.4</item>
		/// <item>Opera 9.2.1</item>
		/// <item>Safari 3.0 beta (3.0.2)</item>
		/// <item>Internet Explorer 7.0</item>
		/// </list
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>The height of the actual document (which includes the body and its margin).  NOTE: Opera 9.5x and 9.6x have wrong value for the scrollWidth property, if an element use negative value for top and left to be outside the viewport! See: http://bugzilla.qooxdoo.org/show_bug.cgi?id=2869</returns>
		[JsMethod(Name = "getHeight")]
		public static double GetHeight(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the width of the document.</para>
		/// <para>Internet Explorer in standard mode stores the proprietary scrollWidth property
		/// on the documentElement, but in quirks mode on the body element. All
		/// other known browsers simply store the correct value on the documentElement.</para>
		/// <para>If the viewport is wider than the document the viewport width is returned.</para>
		/// <para>As the html element has no visual appearance it also can not scroll. This
		/// means that we must use the body scrollWidth in all non mshtml clients.</para>
		/// <para>Verified to correctly work with:</para>
		/// <list type="bullet">
		/// <item>Mozilla Firefox 2.0.0.4</item>
		/// <item>Opera 9.2.1</item>
		/// <item>Safari 3.0 beta (3.0.2)</item>
		/// <item>Internet Explorer 7.0</item>
		/// </list
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>The width of the actual document (which includes the body and its margin).  NOTE: Opera 9.5x and 9.6x have wrong value for the scrollWidth property, if an element use negative value for top and left to be outside the viewport! See: http://bugzilla.qooxdoo.org/show_bug.cgi?id=2869</returns>
		[JsMethod(Name = "getWidth")]
		public static double GetWidth(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the document is in quirks mode (e.g. non XHTML, HTML4 Strict or missing doctype)</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>true when containing document is in quirks mode</returns>
		[JsMethod(Name = "isQuirksMode")]
		public static bool IsQuirksMode(Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the document is in standard mode (e.g. XHTML, HTML4 Strict or doctype defined)</para>
		/// </summary>
		/// <param name="win">The window to query</param>
		/// <returns>true when containing document is in standard mode</returns>
		[JsMethod(Name = "isStandardMode")]
		public static bool IsStandardMode(Window win = null) { throw new NotImplementedException(); }

		#endregion Methods
    }
}