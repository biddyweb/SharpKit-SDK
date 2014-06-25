// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.html
{
    /// <summary>
	/// <para>Managed wrapper for the HTML Flash tag.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.html.Flash", OmitOptionalParameters = true, Export = false)]
    public partial class Flash : qx.html.Element
    {
		#region Methods

		public Flash() { throw new NotImplementedException(); }

		/// <param name="styles">optional map of CSS styles, where the key is the name of the style and the value is the value to use.</param>
		/// <param name="attributes">optional map of element attributes, where the key is the name of the attribute and the value is the value to use.</param>
		public Flash(object styles = null, object attributes = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates the DOM Flash movie with all needed attributes and
		/// FlashVars.</para>
		/// </summary>
		[JsMethod(Name = "createFlash")]
		public void CreateFlash() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the attributes for the Flash DOM element.</para>
		/// </summary>
		/// <returns>Attributes for the DOM element.</returns>
		[JsMethod(Name = "getAttributes")]
		public object GetAttributes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the created DOM Flash movie.</para>
		/// </summary>
		/// <returns>The DOM Flash element, otherwise null.</returns>
		[JsMethod(Name = "getFlashElement")]
		public qx.html.Element GetFlashElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the params for the Flash DOM element.</para>
		/// </summary>
		/// <returns>Map with key/value pairs for the Flash DOM element.</returns>
		[JsMethod(Name = "getParams")]
		public object GetParams() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the FlashVars for the Flash movie.</para>
		/// </summary>
		/// <returns>Map with key/value pairs for passing FlashVars}</returns>
		[JsMethod(Name = "getVariables")]
		public object GetVariables() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set an attribute for the Flash DOM element.</para>
		/// </summary>
		/// <param name="key">Key name.</param>
		/// <param name="value">Value or null to remove attribute.</param>
		[JsMethod(Name = "setAttribute")]
		public void SetAttribute(string key, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the URL from the Flash movie to display.</para>
		/// </summary>
		/// <param name="value">URL from the Flash movie.</param>
		[JsMethod(Name = "setId")]
		public void SetId(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the param for the Flash DOM element, also called attribute.</para>
		/// </summary>
		/// <param name="key">Key name.</param>
		/// <param name="value">Value or null to remove param</param>
		[JsMethod(Name = "setParam")]
		public void SetParam(string key, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the URL from the Flash movie to display.</para>
		/// </summary>
		/// <param name="value">URL from the Flash movie.</param>
		[JsMethod(Name = "setSource")]
		public void SetSource(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the FlashVars to pass variables to the Flash movie.</para>
		/// </summary>
		/// <param name="value">Map with key/value pairs for passing FlashVars</param>
		[JsMethod(Name = "setVariables")]
		public void SetVariables(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}