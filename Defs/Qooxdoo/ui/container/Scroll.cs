// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.container
{
    /// <summary>
	/// <para>Container, which allows vertical and horizontal scrolling if the contents is
	/// larger than the container.</para>
	/// <para>Note that this class can only have one child widget. This container has a
	/// fixed layout, which cannot be changed.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// // create scroll container
	/// var scroll = new qx.ui.container.Scroll().set({
	/// width: 300,
	/// height: 200
	/// });
	/// // add a widget which is larger than the container
	/// scroll.add(new qx.ui.core.Widget().set({
	/// width: 600,
	/// minWidth: 600,
	/// height: 400,
	/// minHeight: 400
	/// });
	/// this.getRoot().add(scroll);
	/// </code>
	/// <para>This example creates a scroll container and adds a widget, which is larger
	/// than the container. This will cause the container to display vertical
	/// and horizontal toolbars.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.container.Scroll", OmitOptionalParameters = true, Export = false)]
    public partial class Scroll : qx.ui.core.scroll.AbstractScrollArea
    {
		#region Properties

		/// <summary>
		/// <para>The &#8216;contentPadding&#8217; property is a shorthand property for setting &#8216;contentPaddingTop&#8217;,
		/// &#8216;contentPaddingRight&#8217;, &#8216;contentPaddingBottom&#8217; and &#8216;contentPaddingLeft&#8217;
		/// at the same time.</para>
		/// <para>If four values are specified they apply to top, right, bottom and left respectively.
		/// If there is only one value, it applies to all sides, if there are two or three,
		/// the missing values are taken from the opposite side.</para>
		/// </summary>
		[JsProperty(Name = "contentPadding", NativeField = true)]
		public object ContentPadding { get; set; }

		/// <summary>
		/// <para>Bottom padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingBottom", NativeField = true)]
		public double ContentPaddingBottom { get; set; }

		/// <summary>
		/// <para>Left padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingLeft", NativeField = true)]
		public double ContentPaddingLeft { get; set; }

		/// <summary>
		/// <para>Right padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingRight", NativeField = true)]
		public double ContentPaddingRight { get; set; }

		/// <summary>
		/// <para>Top padding of the content pane</para>
		/// </summary>
		[JsProperty(Name = "contentPaddingTop", NativeField = true)]
		public double ContentPaddingTop { get; set; }

		#endregion Properties

		#region Methods

		public Scroll() { throw new NotImplementedException(); }

		/// <param name="content">The content widget of the scroll container.</param>
		public Scroll(qx.ui.core.LayoutItem content = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the content of the scroll container. Scroll containers
		/// may only have one child, so it always replaces the current
		/// child with the given one.</para>
		/// </summary>
		/// <param name="widget">Widget to insert</param>
		[JsMethod(Name = "add")]
		public void Add(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the content of the scroll container.</para>
		/// <para>Scroll containers may only have one child. This
		/// method returns an array containing the child or an empty array.</para>
		/// </summary>
		/// <returns>The child array</returns>
		[JsMethod(Name = "getChildren")]
		public object GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the content of the scroll area.</para>
		/// </summary>
		/// <param name="widget">Widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingBottom.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingBottom")]
		public double GetContentPaddingBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingLeft.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingLeft")]
		public double GetContentPaddingLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingRight.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingRight")]
		public double GetContentPaddingRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property contentPaddingTop.</para>
		/// </summary>
		[JsMethod(Name = "getContentPaddingTop")]
		public double GetContentPaddingTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingBottom
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingBottom.</param>
		[JsMethod(Name = "initContentPaddingBottom")]
		public void InitContentPaddingBottom(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingLeft.</param>
		[JsMethod(Name = "initContentPaddingLeft")]
		public void InitContentPaddingLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingRight.</param>
		[JsMethod(Name = "initContentPaddingRight")]
		public void InitContentPaddingRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property contentPaddingTop
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property contentPaddingTop.</param>
		[JsMethod(Name = "initContentPaddingTop")]
		public void InitContentPaddingTop(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPadding.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPadding")]
		public void ResetContentPadding() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingBottom.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingBottom")]
		public void ResetContentPaddingBottom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingLeft")]
		public void ResetContentPaddingLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingRight")]
		public void ResetContentPaddingRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property contentPaddingTop.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContentPaddingTop")]
		public void ResetContentPaddingTop() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group contentPadding.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="contentPaddingTop">Sets the value of the property #contentPaddingTop.</param>
		/// <param name="contentPaddingRight">Sets the value of the property #contentPaddingRight.</param>
		/// <param name="contentPaddingBottom">Sets the value of the property #contentPaddingBottom.</param>
		/// <param name="contentPaddingLeft">Sets the value of the property #contentPaddingLeft.</param>
		[JsMethod(Name = "setContentPadding")]
		public void SetContentPadding(object contentPaddingTop, object contentPaddingRight, object contentPaddingBottom, object contentPaddingLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingBottom.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingBottom.</param>
		[JsMethod(Name = "setContentPaddingBottom")]
		public void SetContentPaddingBottom(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingLeft.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingLeft.</param>
		[JsMethod(Name = "setContentPaddingLeft")]
		public void SetContentPaddingLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingRight.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingRight.</param>
		[JsMethod(Name = "setContentPaddingRight")]
		public void SetContentPaddingRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property contentPaddingTop.</para>
		/// </summary>
		/// <param name="value">New value for property contentPaddingTop.</param>
		[JsMethod(Name = "setContentPaddingTop")]
		public void SetContentPaddingTop(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}