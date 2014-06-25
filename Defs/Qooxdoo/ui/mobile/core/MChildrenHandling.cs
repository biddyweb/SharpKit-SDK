// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.core
{
    /// <summary>
	/// <para>This mixin exposes all basic methods to manage widget children as public methods.
	/// It can only be included into instances of <see cref="Widget"/>.</para>
	/// <para>To optimize the method calls the including widget should call the method
	/// <see cref="Remap"/> in its defer function. This will map the protected
	/// methods to the public ones and save one method call for each function.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.core.MChildrenHandling", OmitOptionalParameters = true, Export = false)]
    public partial class MChildrenHandling 
    {
		#region Methods

		public MChildrenHandling() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(Widget child, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget after another already inserted widget</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="after">Widget, after which the new widget will be inserted</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(Widget child, Widget after, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child widget at the specified index</para>
		/// </summary>
		/// <param name="child">widget to add</param>
		/// <param name="index">Index, at which the widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(Widget child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget before another already inserted widget</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="before">Widget before the new widget will be inserted.</param>
		/// <param name="layoutProperties">Optional layout data for widget.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(Widget child, Widget before, object layoutProperties = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public Widget GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given widget if it is
		/// a child widget. Otherwise it returns -1.</para>
		/// </summary>
		/// <param name="child">the widget to query for</param>
		/// <returns>The index position or -1 when the given widget is no child of this layout.</returns>
		[JsMethod(Name = "indexOf")]
		public double IndexOf(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the given child widget.</para>
		/// </summary>
		/// <param name="child">the widget to remove</param>
		[JsMethod(Name = "remove")]
		public void Remove(Widget child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		[JsMethod(Name = "removeAll")]
		public void RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the widget at the specified index.</para>
		/// </summary>
		/// <param name="index">Index of the widget to remove.</param>
		[JsMethod(Name = "removeAt")]
		public void RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		#endregion Methods
    }
}