// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.container
{
    /// <summary>
	/// <para>The stack container puts its child widgets on top of each other and only the
	/// topmost widget is visible.</para>
	/// <para>This is used e.g. in the tab view widget. Which widget is visible can be
	/// controlled by using the <see cref="GetSelection"/> method.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// // create stack container
	/// var stack = new qx.ui.container.Stack();
	/// // add some children
	/// stack.add(new qx.ui.core.Widget().set({
	/// backgroundColor: "red"
	/// }));
	/// stack.add(new qx.ui.core.Widget().set({
	/// backgroundColor: "green"
	/// }));
	/// stack.add(new qx.ui.core.Widget().set({
	/// backgroundColor: "blue"
	/// }));
	/// // select green widget
	/// stack.setSelection([stack.getChildren()[1]]);
	/// this.getRoot().add(stack);
	/// </code>
	/// <para>This example creates an stack with three children. Only the selected &#8220;green&#8221;
	/// widget is visible.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.container.Stack", OmitOptionalParameters = true, Export = false)]
    public partial class Stack : qx.ui.core.Widget, qx.ui.core.ISingleSelection
    {
		#region Events

		/// <summary>
		/// <para>Fires after the selection was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Whether the size of the widget depends on the selected child. When
		/// disabled (default) the size is configured to the largest child.</para>
		/// </summary>
		[JsProperty(Name = "dynamic", NativeField = true)]
		public bool Dynamic { get; set; }

		#endregion Properties

		#region Methods

		public Stack() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property dynamic.</para>
		/// </summary>
		[JsMethod(Name = "getDynamic")]
		public bool GetDynamic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property dynamic
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property dynamic.</param>
		[JsMethod(Name = "initDynamic")]
		public void InitDynamic(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property dynamic equals true.</para>
		/// </summary>
		[JsMethod(Name = "isDynamic")]
		public void IsDynamic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Go to the next child in the children list.</para>
		/// </summary>
		[JsMethod(Name = "next")]
		public void Next() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Go to the previous child in the children list.</para>
		/// </summary>
		[JsMethod(Name = "previous")]
		public void Previous() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property dynamic.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDynamic")]
		public void ResetDynamic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property dynamic.</para>
		/// </summary>
		/// <param name="value">New value for property dynamic.</param>
		[JsMethod(Name = "setDynamic")]
		public void SetDynamic(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property dynamic.</para>
		/// </summary>
		[JsMethod(Name = "toggleDynamic")]
		public void ToggleDynamic() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns all elements which are selectable.</para>
		/// </summary>
		/// <param name="all">true for all selectables, false for the selectables the user can interactively select</param>
		/// <returns>The contained items.</returns>
		[JsMethod(Name = "getSelectables")]
		public qx.ui.core.Widget GetSelectables(bool all) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of currently selected items.</para>
		/// <para>Note: The result is only a set of selected items, so the order can
		/// differ from the sequence in which the items were added.</para>
		/// </summary>
		/// <returns>List of items.</returns>
		[JsMethod(Name = "getSelection")]
		public qx.ui.core.Widget GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects whether the given item is currently selected.</para>
		/// </summary>
		/// <param name="item">Any valid selectable item</param>
		/// <returns>Whether the item is selected.</returns>
		[JsMethod(Name = "isSelected")]
		public bool IsSelected(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the selection is empty.</para>
		/// </summary>
		/// <returns>Whether the selection is empty.</returns>
		[JsMethod(Name = "isSelectionEmpty")]
		public bool IsSelectionEmpty() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the whole selection at once.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Replaces current selection with the given items.</para>
		/// </summary>
		/// <param name="items">Items to select.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.ui.core.Widget items) { throw new NotImplementedException(); }

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

		#endregion Methods
    }
}