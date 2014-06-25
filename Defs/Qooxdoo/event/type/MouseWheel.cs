// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.type
{
    /// <summary>
	/// <para>Mouse wheel event object.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.type.MouseWheel", OmitOptionalParameters = true, Export = false)]
    public partial class MouseWheel : qx.eventx.type.Mouse
    {
		#region Methods

		public MouseWheel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the amount the wheel has been scrolled</para>
		/// </summary>
		/// <param name="axis">Optional parameter which definex the scroll axis. The value can either be &#8220;x&#8221; or &#8220;y&#8221;.</param>
		/// <returns>Scroll wheel movement for the given axis. If no axis is given, the y axis is used.</returns>
		[JsMethod(Name = "getWheelDelta")]
		public double GetWheelDelta(string axis) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stops event from all further processing. Execute this when the
		/// current handler should have &#8220;exclusive rights&#8221; to the event
		/// and no further reaction by anyone else should happen.</para>
		/// </summary>
		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		#endregion Methods
    }
}