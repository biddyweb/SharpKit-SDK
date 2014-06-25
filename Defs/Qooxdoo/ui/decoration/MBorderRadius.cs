// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>Mixin for the border radius CSS property.
	/// This mixin is usually used by <see cref="qx.ui.decoration.DynamicDecorator"/>.</para>
	/// <para>Keep in mind that this is not supported by all browsers:</para>
	/// <list type="bullet">
	/// <item>Firefox 3,5+</item>
	/// <item>IE9+</item>
	/// <item>Safari 3.0+</item>
	/// <item>Opera 10.5+</item>
	/// <item>Chrome 4.0+</item>
	/// </list
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.MBorderRadius", OmitOptionalParameters = true, Export = false)]
    public partial class MBorderRadius 
    {
		#region Properties

		/// <summary>
		/// <para>Property group to set the corner radius of all sides</para>
		/// </summary>
		[JsProperty(Name = "radius", NativeField = true)]
		public object Radius { get; set; }

		/// <summary>
		/// <para>bottom left corner radius</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "radiusBottomLeft", NativeField = true)]
		public double RadiusBottomLeft { get; set; }

		/// <summary>
		/// <para>bottom right corner radius</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "radiusBottomRight", NativeField = true)]
		public double RadiusBottomRight { get; set; }

		/// <summary>
		/// <para>top left corner radius</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "radiusTopLeft", NativeField = true)]
		public double RadiusTopLeft { get; set; }

		/// <summary>
		/// <para>top right corner radius</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "radiusTopRight", NativeField = true)]
		public double RadiusTopRight { get; set; }

		#endregion Properties

		#region Methods

		public MBorderRadius() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property radiusBottomLeft.</para>
		/// </summary>
		[JsMethod(Name = "getRadiusBottomLeft")]
		public double GetRadiusBottomLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property radiusBottomRight.</para>
		/// </summary>
		[JsMethod(Name = "getRadiusBottomRight")]
		public double GetRadiusBottomRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property radiusTopLeft.</para>
		/// </summary>
		[JsMethod(Name = "getRadiusTopLeft")]
		public double GetRadiusTopLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property radiusTopRight.</para>
		/// </summary>
		[JsMethod(Name = "getRadiusTopRight")]
		public double GetRadiusTopRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property radiusBottomLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property radiusBottomLeft.</param>
		[JsMethod(Name = "initRadiusBottomLeft")]
		public void InitRadiusBottomLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property radiusBottomRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property radiusBottomRight.</param>
		[JsMethod(Name = "initRadiusBottomRight")]
		public void InitRadiusBottomRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property radiusTopLeft
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property radiusTopLeft.</param>
		[JsMethod(Name = "initRadiusTopLeft")]
		public void InitRadiusTopLeft(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property radiusTopRight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property radiusTopRight.</param>
		[JsMethod(Name = "initRadiusTopRight")]
		public void InitRadiusTopRight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property radius.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRadius")]
		public void ResetRadius() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property radiusBottomLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRadiusBottomLeft")]
		public void ResetRadiusBottomLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property radiusBottomRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRadiusBottomRight")]
		public void ResetRadiusBottomRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property radiusTopLeft.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRadiusTopLeft")]
		public void ResetRadiusTopLeft() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property radiusTopRight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRadiusTopRight")]
		public void ResetRadiusTopRight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group radius.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="radiusTopLeft">Sets the value of the property #radiusTopLeft.</param>
		/// <param name="radiusTopRight">Sets the value of the property #radiusTopRight.</param>
		/// <param name="radiusBottomRight">Sets the value of the property #radiusBottomRight.</param>
		/// <param name="radiusBottomLeft">Sets the value of the property #radiusBottomLeft.</param>
		[JsMethod(Name = "setRadius")]
		public void SetRadius(object radiusTopLeft, object radiusTopRight, object radiusBottomRight, object radiusBottomLeft) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property radiusBottomLeft.</para>
		/// </summary>
		/// <param name="value">New value for property radiusBottomLeft.</param>
		[JsMethod(Name = "setRadiusBottomLeft")]
		public void SetRadiusBottomLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property radiusBottomRight.</para>
		/// </summary>
		/// <param name="value">New value for property radiusBottomRight.</param>
		[JsMethod(Name = "setRadiusBottomRight")]
		public void SetRadiusBottomRight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property radiusTopLeft.</para>
		/// </summary>
		/// <param name="value">New value for property radiusTopLeft.</param>
		[JsMethod(Name = "setRadiusTopLeft")]
		public void SetRadiusTopLeft(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property radiusTopRight.</para>
		/// </summary>
		/// <param name="value">New value for property radiusTopRight.</param>
		[JsMethod(Name = "setRadiusTopRight")]
		public void SetRadiusTopRight(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}