// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.element
{
    /// <summary>
	/// <para>This class is responsible for applying CSS3 transforms to plain DOM elements.
	/// The implementation is mostly a cross browser wrapper for applying the
	/// transforms.
	/// The API is keep to the spec as close as possible.</para>
	/// <para>http://www.w3.org/TR/css3-3d-transforms/</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.element.Transform", OmitOptionalParameters = true, Export = false)]
    public partial class Transform 
    {
		#region Methods

		public Transform() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the backface-visibility property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#backface-visibility-property</para>
		/// </summary>
		/// <param name="el">The dom element to read the property.</param>
		/// <returns>true, if the backface is visible.</returns>
		[JsMethod(Name = "getBackfaceVisibility")]
		public static bool GetBackfaceVisibility(qx.html.Element el) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts the given map to a string which could be added to a css
		/// stylesheet.</para>
		/// </summary>
		/// <param name="transforms">The transforms map. For a detailed description, take a look at the #transform method.</param>
		/// <returns>The CSS value.</returns>
		[JsMethod(Name = "getCss")]
		public static string GetCss(object transforms) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the transform-origin property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#transform-origin-property</para>
		/// </summary>
		/// <param name="el">The dom element to read the property.</param>
		/// <returns>The set property, e.g. 50% 50%</returns>
		[JsMethod(Name = "getOrigin")]
		public static string GetOrigin(qx.html.Element el) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the perspective property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#perspective-property</para>
		/// </summary>
		/// <param name="el">The dom element to read the property.</param>
		/// <returns>The set property, e.g. 500</returns>
		[JsMethod(Name = "getPerspective")]
		public static string GetPerspective(qx.html.Element el) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the perspective-origin property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#perspective-origin-property</para>
		/// </summary>
		/// <param name="el">The dom element to read the property.</param>
		/// <returns>The set property, e.g. 50% 50%</returns>
		[JsMethod(Name = "getPerspectiveOrigin")]
		public static string GetPerspectiveOrigin(qx.html.Element el) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the transform-style property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#transform-style-property</para>
		/// </summary>
		/// <param name="el">The dom element to read the property.</param>
		/// <returns>The set property, either flat or preserve-3d.</returns>
		[JsMethod(Name = "getStyle")]
		public static string GetStyle(qx.html.Element el) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Rotates the given element by the given value. For further details, take
		/// a look at the <see cref="Transform"/> method.</para>
		/// </summary>
		/// <param name="el">The element to apply the transformation.</param>
		/// <param name="value">The value to rotate e.g. &#8220;90deg&#8221;.</param>
		[JsMethod(Name = "rotate")]
		public static void Rotate(qx.html.Element el, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scales the given element by the given value. For further details, take
		/// a look at the <see cref="Transform"/> method.</para>
		/// </summary>
		/// <param name="el">The element to apply the transformation.</param>
		/// <param name="value">The value to scale.</param>
		[JsMethod(Name = "scale")]
		public static void Scale(qx.html.Element el, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the backface-visibility property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#backface-visibility-property</para>
		/// </summary>
		/// <param name="el">The dom element to set the property.</param>
		/// <param name="value">true if the backface should be visible.</param>
		[JsMethod(Name = "setBackfaceVisibility")]
		public static void SetBackfaceVisibility(qx.html.Element el, bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the transform-origin property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#transform-origin-property</para>
		/// </summary>
		/// <param name="el">The dom element to set the property.</param>
		/// <param name="value">CSS position values like 50% 50% or left top.</param>
		[JsMethod(Name = "setOrigin")]
		public static void SetOrigin(qx.html.Element el, string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the perspective property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#perspective-property</para>
		/// </summary>
		/// <param name="el">The dom element to set the property.</param>
		/// <param name="value">The perspective layer. Numbers between 100 and 5000 give the best results.</param>
		[JsMethod(Name = "setPerspective")]
		public static void SetPerspective(qx.html.Element el, double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the perspective-origin property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#perspective-origin-property</para>
		/// </summary>
		/// <param name="el">The dom element to set the property.</param>
		/// <param name="value">CSS position values like 50% 50% or left top.</param>
		[JsMethod(Name = "setPerspectiveOrigin")]
		public static void SetPerspectiveOrigin(qx.html.Element el, string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the transform-style property of the given element.</para>
		/// <para>Spec: http://www.w3.org/TR/css3-3d-transforms/#transform-style-property</para>
		/// </summary>
		/// <param name="el">The dom element to set the property.</param>
		/// <param name="value">Either flat or preserve-3d.</param>
		[JsMethod(Name = "setStyle")]
		public static void SetStyle(qx.html.Element el, string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Skews the given element by the given value. For further details, take
		/// a look at the <see cref="Transform"/> method.</para>
		/// </summary>
		/// <param name="el">The element to apply the transformation.</param>
		/// <param name="value">The value to skew e.g. &#8220;90deg&#8221;.</param>
		[JsMethod(Name = "skew")]
		public static void Skew(qx.html.Element el, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Method to apply multiple transforms at once to the given element. It
		/// takes a map containing the transforms you want to apply plus the values
		/// e.g.{scale: 2, rotate: &#8220;5deg&#8221;}.
		/// The values can be either singular, which means a single value will
		/// be added to the CSS. If you give an array, the values will be split up
		/// and each array entry will be used for the X, Y or Z dimension in that
		/// order e.g. {scale: [2, 0.5]} will result in a element
		/// double the size in X direction and half the size in Y direction.
		/// Make sure your browser supports all transformations you apply.</para>
		/// </summary>
		/// <param name="el">The element to apply the transformation.</param>
		/// <param name="transforms">The map containing the transforms and value.</param>
		[JsMethod(Name = "transform")]
		public static void Transformx(qx.html.Element el, object transforms) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Translates the given element by the given value. For further details, take
		/// a look at the <see cref="Transform"/> method.</para>
		/// </summary>
		/// <param name="el">The element to apply the transformation.</param>
		/// <param name="value">The value to translate e.g. &#8220;10px&#8221;.</param>
		[JsMethod(Name = "translate")]
		public static void Translate(qx.html.Element el, object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}