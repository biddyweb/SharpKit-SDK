// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.container
{
    /// <summary>
	/// <para>Mixin for the <see cref="Scroll"/> container. Used when the variant
	/// qx.mobile.nativescroll is set to &#8220;off&#8221;. Uses the iScroll script to simulate
	/// the CSS position:fixed style. Position fixed is not available in iOS and
	/// Android 
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.container.MIScroll", OmitOptionalParameters = true, Export = false)]
    public partial class MIScroll 
    {
		#region Methods

		public MIScroll() { throw new NotImplementedException(); }

		/// <param name="useTransform">Whether iScroll should use transforms or not. Set this to false when input fields are used inside the scroll container.</param>
		public MIScroll(bool useTransform) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Delegation method for iScroll. Disabled the iScroll objects.
		/// Prevents any further scrolling of this container.</para>
		/// </summary>
		[JsMethod(Name = "disable")]
		public void Disable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Delegation method for iScroll. Enables the iScroll object.</para>
		/// </summary>
		[JsMethod(Name = "enable")]
		public void Enable() { throw new NotImplementedException(); }

		#endregion Methods
    }
}