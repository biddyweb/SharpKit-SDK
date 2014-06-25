// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>Each focus root delegates the focus handling to instances of the FocusHandler.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.FocusHandler", OmitOptionalParameters = true, Export = false)]
    public partial class FocusHandler : qx.core.Object
    {
		#region Methods

		public FocusHandler() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Registers a widget as a focus root. A focus root comes
		/// with an separate tab sequence handling.</para>
		/// </summary>
		/// <param name="widget">The widget to register</param>
		[JsMethod(Name = "addRoot")]
		public void AddRoot(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Connects to a top-level root element (which initially receives
		/// all events of the root). This are normally all page and application
		/// roots, but no inline roots (they are typically sitting inside
		/// another root).</para>
		/// </summary>
		/// <param name="root">Any root</param>
		[JsMethod(Name = "connectTo")]
		public void ConnectTo(qx.ui.root.Abstract root) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the active widget</para>
		/// </summary>
		/// <returns>The active widget or null if no widget is active</returns>
		[JsMethod(Name = "getActiveWidget")]
		public qx.ui.core.Widget GetActiveWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the focused widget</para>
		/// </summary>
		/// <returns>The focused widget or null if no widget has the focus</returns>
		[JsMethod(Name = "getFocusedWidget")]
		public qx.ui.core.Widget GetFocusedWidget() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the given widget is the active one</para>
		/// </summary>
		/// <param name="widget">The widget to check</param>
		/// <returns>true if the given widget is active</returns>
		[JsMethod(Name = "isActive")]
		public bool IsActive(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the given widget is the focused one.</para>
		/// </summary>
		/// <param name="widget">The widget to check</param>
		/// <returns>true if the given widget is focused</returns>
		[JsMethod(Name = "isFocused")]
		public bool IsFocused(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the given widgets acts as a focus root.</para>
		/// </summary>
		/// <param name="widget">The widget to check</param>
		/// <returns>true if the given widget is a focus root</returns>
		[JsMethod(Name = "isFocusRoot")]
		public bool IsFocusRoot(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Deregisters a previous added widget.</para>
		/// </summary>
		/// <param name="widget">The widget to deregister</param>
		[JsMethod(Name = "removeRoot")]
		public void RemoveRoot(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.ui.core.FocusHandler GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}