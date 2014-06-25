// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>Cross browser abstractions to work with iframes.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Iframe", OmitOptionalParameters = true, Export = false)]
    public partial class Iframe 
    {
		#region Methods

		public Iframe() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates an DOM element.</para>
		/// <para>Attributes may be given directly with this call. This is critical
		/// for some attributes e.g. name, type, ... in many clients.</para>
		/// </summary>
		/// <param name="attributes">Map of attributes to apply</param>
		/// <param name="win">Window to create the element for</param>
		/// <returns>The created iframe node</returns>
		[JsMethod(Name = "create")]
		public static qx.html.Element Create(object attributes = null, Window win = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the HTML body element of the iframe.</para>
		/// </summary>
		/// <param name="iframe">DOM element of the iframe.</param>
		/// <returns>The DOM node of the body element of the iframe.</returns>
		[JsMethod(Name = "getBody")]
		public static qx.html.Element GetBody(qx.html.Element iframe) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the DOM document object of an iframe.</para>
		/// </summary>
		/// <param name="iframe">DOM element of the iframe.</param>
		/// <returns>The DOM document object of the iframe.</returns>
		[JsMethod(Name = "getDocument")]
		public static Document GetDocument(qx.html.Element iframe) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the DOM window object of an iframe.</para>
		/// </summary>
		/// <param name="iframe">DOM element of the iframe.</param>
		/// <returns>The DOM window object of the iframe or null.</returns>
		[JsMethod(Name = "getWindow")]
		public static Window GetWindow(qx.html.Element iframe) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current (served) URL inside the iframe</para>
		/// </summary>
		/// <param name="iframe">DOM element of the iframe.</param>
		/// <returns>Returns the location href or null (if a query is not possible/allowed)</returns>
		[JsMethod(Name = "queryCurrentUrl")]
		public static string QueryCurrentUrl(qx.html.Element iframe) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets iframe&#8217;s source attribute to given value</para>
		/// </summary>
		/// <param name="iframe">DOM element of the iframe.</param>
		/// <param name="source">URL to be set.</param>
		[JsMethod(Name = "setSource")]
		public static void SetSource(qx.html.Element iframe, string source) { throw new NotImplementedException(); }

		#endregion Methods
    }
}