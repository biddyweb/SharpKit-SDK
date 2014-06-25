// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.splitpane
{
    /// <summary>
	/// <para>The slider of the SplitPane (used during drag sessions for fast feedback)</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.splitpane.Slider", OmitOptionalParameters = true, Export = false)]
    public partial class Slider : qx.ui.core.Widget
    {
		#region Properties

		/// <summary>
		/// <para>Whether the item can shrink horizontally.</para>
		/// </summary>
		[JsProperty(Name = "allowShrinkX", NativeField = true)]
		public bool AllowShrinkX { get; set; }

		/// <summary>
		/// <para>Whether the item can shrink vertically.</para>
		/// </summary>
		[JsProperty(Name = "allowShrinkY", NativeField = true)]
		public bool AllowShrinkY { get; set; }

		#endregion Properties

		#region Methods

		public Slider() { throw new NotImplementedException(); }

		#endregion Methods
    }
}