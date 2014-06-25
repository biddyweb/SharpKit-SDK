// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.container
{
    /// <summary>
	/// <para>The Composite is a generic container widget.</para>
	/// <para>It exposes all methods to set layouts and to manage child widgets
	/// as public methods. You must configure this widget with a layout manager to
	/// define the way the widget&#8217;s children are positioned.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// // create the composite
	/// var composite = new qx.ui.container.Composite()
	/// // configure it with a horizontal box layout with a spacing of '5'
	/// composite.setLayout(new qx.ui.layout.HBox(5));
	/// // add some children
	/// composite.add(new qx.ui.basic.Label("Name: "));
	/// composite.add(new qx.ui.form.TextField());
	/// this.getRoot().add(composite);
	/// </code>
	/// <para>This example horizontally groups a label and text field by using a
	/// Composite configured with a horizontal box layout as a container.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.container.Composite", OmitOptionalParameters = true, Export = false)]
    public partial class Composite : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// <para>This event is fired after a child widget was added to this widget. The
		/// <see cref="qx.event.type.Data.GetData"/> method of the event returns the
		/// added child.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnAddChildWidget;

		/// <summary>
		/// <para>This event is fired after a child widget has been removed from this widget.
		/// The <see cref="qx.event.type.Data.GetData"/> method of the event returns the
		/// removed child.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnRemoveChildWidget;

		#endregion Events

		#region Methods

		public Composite() { throw new NotImplementedException(); }

		/// <param name="layout">A layout instance to use to place widgets on the screen.</param>
		public Composite(qx.ui.layout.Abstract layout) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds a new child widget.</para>
		/// <para>The supported keys of the layout options map depend on the layout manager
		/// used to position the widget. The options are documented in the class
		/// documentation of each layout manager <see cref="qx.ui.layout"/>.</para>
		/// </summary>
		/// <param name="child">the widget to add.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "add")]
		public void Add(LayoutItem child, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget after another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="after">Widget, after which the new widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAfter")]
		public void AddAfter(LayoutItem child, LayoutItem after, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a child widget at the specified index</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="index">Index, at which the widget will be inserted</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addAt")]
		public void AddAt(LayoutItem child, double index, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a widget before another already inserted widget</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="child">Widget to add</param>
		/// <param name="before">Widget before the new widget will be inserted.</param>
		/// <param name="options">Optional layout data for widget.</param>
		[JsMethod(Name = "addBefore")]
		public void AddBefore(LayoutItem child, LayoutItem before, object options = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the children list</para>
		/// </summary>
		/// <returns>The children array (Arrays are reference types, please to not modify them in-place)</returns>
		[JsMethod(Name = "getChildren")]
		public LayoutItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the widget contains children.</para>
		/// </summary>
		/// <returns>Returns true when the widget has children.</returns>
		[JsMethod(Name = "hasChildren")]
		public bool HasChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the index position of the given widget if it is
		/// a child widget. Otherwise it returns -1.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
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
		public void Remove(LayoutItem child) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all children.</para>
		/// </summary>
		/// <returns>An array of the removed children.</returns>
		[JsMethod(Name = "removeAll")]
		public JsArray RemoveAll() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove the widget at the specified index.</para>
		/// <para>This method works on the widget&#8217;s children list. Some layout managers
		/// (e.g. <see cref="qx.ui.layout.HBox"/>) use the children order as additional
		/// layout information. Other layout manager (e.g. <see cref="qx.ui.layout.Grid"/>)
		/// ignore the children order for the layout process.</para>
		/// </summary>
		/// <param name="index">Index of the widget to remove.</param>
		/// <returns>The child removed.</returns>
		[JsMethod(Name = "removeAt")]
		public LayoutItem RemoveAt(double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mapping of protected methods to public.
		/// This omits an additional function call when using these methods. Call
		/// this methods in the defer block of the including class.</para>
		/// </summary>
		/// <param name="members">The including classes members map</param>
		[JsMethod(Name = "remap")]
		public static void Remap(object members) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a layout manager for the widget. A a layout manager can only be connected
		/// with one widget. Reset the connection with a previous widget first, if you
		/// like to use it in another widget instead.</para>
		/// </summary>
		/// <param name="layout">The new layout or null to reset the layout.</param>
		[JsMethod(Name = "setLayout")]
		public void SetLayout(qx.ui.layout.Abstract layout) { throw new NotImplementedException(); }

		#endregion Methods
    }
}