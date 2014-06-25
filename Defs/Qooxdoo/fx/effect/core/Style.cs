// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.fx.effect.core
{
    /// <summary>
	/// <para>A simple effect which changes the given CSS attribute during the
	/// duration of the animation. A function can be given to modify the
	/// incoming numeric value.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.fx.effect.core.Style", OmitOptionalParameters = true, Export = false)]
    public partial class Style : qx.fx.Base
    {
		#region Methods

		public Style() { throw new NotImplementedException(); }

		/// <param name="element">The DOM element</param>
		/// <param name="cssAttribute">Name of the CSS attribute to animate.</param>
		/// <param name="func">Function which modifies the numeric value given by update().</param>
		public Style(object element, string cssAttribute, Action<object> func) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This internal function is called
		/// each time the effect performs an
		/// step of the animation.</para>
		/// <para>Sub classes will overwrite this to
		/// perform the actual changes on element
		/// properties.</para>
		/// </summary>
		/// <param name="position">Animation setup as Number between 0 and 1.</param>
		[JsMethod(Name = "update")]
		public void Update(double position) { throw new NotImplementedException(); }

		#endregion Methods
    }
}