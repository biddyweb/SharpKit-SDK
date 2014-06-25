// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.handler
{
    /// <summary>
	/// <para>This class provides an unified mouse event handler for Internet Explorer,
	/// Firefox, Opera and Safari</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.handler.Mouse", OmitOptionalParameters = true, Export = false)]
    public partial class Mouse : qx.core.Object
    {
		#region Methods

		public Mouse() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a new instance</para>
		/// </summary>
		/// <param name="manager">Event manager for the window to use</param>
		public Mouse(qx.eventx.Manager manager) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the event handler can handle events of the given type. If the
		/// event handler class has a static variable called IGNORE_CAN_HANDLE
		/// with the value true this function is not called. Whether the
		/// handler can handle the event is them only determined by the static variables
		/// SUPPORTED_TYPES and TARGET_CHECK.</para>
		/// </summary>
		/// <param name="target">The target to, which the event handler should be attached</param>
		/// <param name="type">event type</param>
		/// <returns>Whether the event handler can handle events of the given type.</returns>
		[JsMethod(Name = "canHandleEvent")]
		public bool CanHandleEvent(object target, string type) { throw new NotImplementedException(); }

		#endregion Methods
    }
}