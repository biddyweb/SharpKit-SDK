// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.html
{
    /// <summary>
	/// <para>An element preconfigured with a decorator. The decorator cannot be changed
	/// after creation. This class is used to render the backgrounds, shadows and
	/// separators in widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.html.Decorator", OmitOptionalParameters = true, Export = false)]
    public partial class Decorator : qx.html.Element
    {
		#region Methods

		public Decorator() { throw new NotImplementedException(); }

		/// <param name="decorator">The decorator to use</param>
		/// <param name="decoratorId">An optional id for the decorator.</param>
		public Decorator(qx.ui.decoration.IDecorator decorator, string decoratorId) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the decorator</para>
		/// </summary>
		/// <returns>the decorator used</returns>
		[JsMethod(Name = "getDecorator")]
		public qx.ui.decoration.IDecorator GetDecorator() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the decorator&#8217;s id</para>
		/// </summary>
		/// <returns>the id</returns>
		[JsMethod(Name = "getId")]
		public string GetId() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the amount of space, the decoration needs for its border on each
		/// side.</para>
		/// </summary>
		/// <returns>the desired insets. A map with the keys top, right, bottom, left.</returns>
		[JsMethod(Name = "getInsets")]
		public object GetInsets() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resizes the element respecting the configured borders
		/// to the given width and height. Should automatically
		/// respect the box model of the client to correctly
		/// compute the dimensions.</para>
		/// </summary>
		/// <param name="width">Width of the element</param>
		/// <param name="height">Height of the element</param>
		[JsMethod(Name = "resize")]
		public void Resize(double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the given background color to the element
		/// or fallback to the background color defined
		/// by the decoration itself.</para>
		/// </summary>
		/// <param name="color">The color to apply or null</param>
		[JsMethod(Name = "tint")]
		public void Tint(string color) { throw new NotImplementedException(); }

		#endregion Methods
    }
}