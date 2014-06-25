// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core
{
    /// <summary>
	/// <para>This class blocks events and can be included into all widgets.</para>
	/// <para>The <see cref="Block"/> and <see cref="Unblock"/> methods provided by this class can be used
	/// to block any event from the widget. When blocked,
	/// the blocker widget overlays the widget to block, including the padding area.</para>
	/// <para>The second set of methods (<see cref="BlockContent"/>, <see cref="UnblockContent"/>)
	/// can be used to block child widgets with a zIndex below a certain value.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.Blocker", OmitOptionalParameters = true, Export = false)]
    public partial class Blocker : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fires after <see cref="Block"/> or <see cref="BlockContent"/> executed.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnBlocked;

		/// <summary>
		/// <para>Fires after <see cref="Unblock"/> or <see cref="UnblockContent"/> executed.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnUnblocked;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Color of the blocker</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "color", NativeField = true)]
		public string Color { get; set; }

		/// <summary>
		/// <para>If this property is enabled, the blocker created with <see cref="Block"/>
		/// will always stay activated. This means that the blocker then gets all keyboard
		/// events, this is useful to block keyboard input on other widgets.
		/// Take care that only one blocker instance will be kept active, otherwise your
		/// browser will freeze.</para>
		/// </summary>
		[JsProperty(Name = "keepBlockerActive", NativeField = true)]
		public bool KeepBlockerActive { get; set; }

		/// <summary>
		/// <para>Opacity of the blocker</para>
		/// </summary>
		[JsProperty(Name = "opacity", NativeField = true)]
		public double Opacity { get; set; }

		#endregion Properties

		#region Methods

		public Blocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates a blocker for the passed widget.</para>
		/// </summary>
		/// <param name="widget">Widget which should be added the blocker</param>
		public Blocker(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block all events from this widget by placing a transparent overlay widget,
		/// which receives all events, exactly over the widget.</para>
		/// </summary>
		[JsMethod(Name = "block")]
		public void Block() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Block direct child widgets with a zIndex below zIndex</para>
		/// </summary>
		/// <param name="zIndex">All child widgets with a zIndex below this value will be blocked</param>
		[JsMethod(Name = "blockContent")]
		public void BlockContent(double zIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it doesn&#8217;t take care of
		/// the amount of <see cref="Block"/> calls. The blocker is directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblock")]
		public void ForceUnblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it doesn&#8217;t take
		/// care of the amount of <see cref="BlockContent"/> calls. The blocker is
		/// directly removed.</para>
		/// </summary>
		[JsMethod(Name = "forceUnblockContent")]
		public void ForceUnblockContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get/create the blocker element</para>
		/// </summary>
		/// <returns>The blocker element</returns>
		[JsMethod(Name = "getBlockerElement")]
		public qx.html.Element GetBlockerElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property color.</para>
		/// </summary>
		[JsMethod(Name = "getColor")]
		public string GetColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get/create the content blocker element</para>
		/// </summary>
		/// <returns>The blocker element</returns>
		[JsMethod(Name = "getContentBlockerElement")]
		public qx.html.Element GetContentBlockerElement() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property keepBlockerActive.</para>
		/// </summary>
		[JsMethod(Name = "getKeepBlockerActive")]
		public bool GetKeepBlockerActive() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property opacity.</para>
		/// </summary>
		[JsMethod(Name = "getOpacity")]
		public double GetOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property color
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property color.</param>
		[JsMethod(Name = "initColor")]
		public void InitColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property keepBlockerActive
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property keepBlockerActive.</param>
		[JsMethod(Name = "initKeepBlockerActive")]
		public void InitKeepBlockerActive(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property opacity
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property opacity.</param>
		[JsMethod(Name = "initOpacity")]
		public void InitOpacity(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the widget is blocked.</para>
		/// </summary>
		/// <returns>Whether the widget is blocked.</returns>
		[JsMethod(Name = "isBlocked")]
		public bool IsBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the content is blocked</para>
		/// </summary>
		/// <returns>Whether the content is blocked</returns>
		[JsMethod(Name = "isContentBlocked")]
		public bool IsContentBlocked() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property keepBlockerActive equals true.</para>
		/// </summary>
		[JsMethod(Name = "isKeepBlockerActive")]
		public void IsKeepBlockerActive() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property color.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetColor")]
		public void ResetColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property keepBlockerActive.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetKeepBlockerActive")]
		public void ResetKeepBlockerActive() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property opacity.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOpacity")]
		public void ResetOpacity() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property color.</para>
		/// </summary>
		/// <param name="value">New value for property color.</param>
		[JsMethod(Name = "setColor")]
		public void SetColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property keepBlockerActive.</para>
		/// </summary>
		/// <param name="value">New value for property keepBlockerActive.</param>
		[JsMethod(Name = "setKeepBlockerActive")]
		public void SetKeepBlockerActive(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property opacity.</para>
		/// </summary>
		/// <param name="value">New value for property opacity.</param>
		[JsMethod(Name = "setOpacity")]
		public void SetOpacity(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property keepBlockerActive.</para>
		/// </summary>
		[JsMethod(Name = "toggleKeepBlockerActive")]
		public void ToggleKeepBlockerActive() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the widget blocked by <see cref="Block"/>, but it takes care of
		/// the amount of <see cref="Block"/> calls. The blocker is only removed if
		/// the numer of <see cref="Unblock"/> calls is identical to <see cref="Block"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblock")]
		public void Unblock() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Unblock the content blocked by <see cref="BlockContent"/>, but it takes care of
		/// the amount of <see cref="BlockContent"/> calls. The blocker is only removed if
		/// the numer of <see cref="UnblockContent"/> calls is identical to
		/// <see cref="BlockContent"/> calls.</para>
		/// </summary>
		[JsMethod(Name = "unblockContent")]
		public void UnblockContent() { throw new NotImplementedException(); }

		#endregion Methods
    }
}