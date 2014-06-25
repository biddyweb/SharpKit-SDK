// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module
{
    /// <summary>
	/// <para>The module supplies a fallback implementation for placeholders, which is
	/// used on input and textarea elements. If the browser supports native placeholders
	/// the API silently ignores all calls. If not, an element will be created for every
	/// given input element and acts as placeholder. Most modern browsers support
	/// placeholders which makes the fallback only relevant for IE 
	/// <list type="bullet">
	/// <item>HTML Spec</item>
	/// </list
	/// <list type="bullet">
	/// <item>Browser Support</item>
	/// </list
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.Placeholder", OmitOptionalParameters = true, Export = false)]
    public partial class Placeholder 
    {
		#region Methods

		public Placeholder() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Updates the placeholders for input&#8217;s and textarea&#8217;s in the collection.
		/// This includes positioning, styles and DOM positioning.
		/// In case the browser supports native placeholders, this methods simply
		/// does nothing.</para>
		/// </summary>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "updatePlaceholder")]
		public static qxWeb UpdatePlaceholder() { throw new NotImplementedException(); }

		#endregion Methods
    }
}