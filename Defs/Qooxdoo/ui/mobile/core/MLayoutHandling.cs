// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.core
{
    /// <summary>
	/// <para>This mixin exposes all methods to manage the layout manager of a widget.
	/// It can only be included into instances of <see cref="Widget"/>.</para>
	/// <para>To optimize the method calls the including widget should call the method
	/// <see cref="Remap"/> in its defer function. This will map the protected
	/// methods to the public ones and save one method call for each function.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.core.MLayoutHandling", OmitOptionalParameters = true, Export = false)]
    public partial class MLayoutHandling 
    {
		#region Methods

		public MLayoutHandling() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s layout manager.</para>
		/// </summary>
		/// <returns>The widget&#8217;s layout manager</returns>
		[JsMethod(Name = "getLayout")]
		public qx.ui.mobile.layout.Abstract GetLayout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set a layout manager for the widget. A a layout manager can only be connected
		/// with one widget. Reset the connection with a previous widget first, if you
		/// like to use it in another widget instead.</para>
		/// </summary>
		/// <param name="layout">The new layout or null to reset the layout.</param>
		[JsMethod(Name = "setLayout")]
		public void SetLayout(qx.ui.mobile.layout.Abstract layout) { throw new NotImplementedException(); }

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