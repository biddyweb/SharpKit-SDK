// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.layer
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>The Row layer renders row background colors.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.layer.Row", OmitOptionalParameters = true, Export = false)]
    public partial class Row : qx.ui.virtualx.layer.AbstractBackground
    {
		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		#endregion Properties

		#region Methods

		public Row() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the decorator for the given index</para>
		/// </summary>
		/// <param name="index">Index to set the color for</param>
		/// <param name="decorator">the decorator to set. A value of null will reset the decorator.</param>
		[JsMethod(Name = "setBackground")]
		public void SetBackground(double index, qx.html.Decorator decorator) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the color for the given index</para>
		/// </summary>
		/// <param name="index">Index to set the color for</param>
		/// <param name="color">the color to set. A value of null will reset the color.</param>
		[JsMethod(Name = "setColor")]
		public void SetColor(double index, string color) { throw new NotImplementedException(); }

		#endregion Methods
    }
}