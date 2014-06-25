// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.core
{
    /// <summary>
	/// <para>This class provides the domupdated event. The event is
	/// delegated to all widget instances that have a
	/// listener for the domupdated event registered.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.core.DomUpdatedHandler", OmitOptionalParameters = true, Export = false)]
    public partial class DomUpdatedHandler : qx.core.Object, qx.eventx.IEventHandler
    {
		#region Methods

		public DomUpdatedHandler() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a new instance</para>
		/// </summary>
		/// <param name="manager">Event manager for the window to use</param>
		public DomUpdatedHandler(qx.eventx.Manager manager) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Informs all handlers. Useful after massive DOM manipulations e.g.
		/// through <see cref="qx.ui.mobile.core.Widget"/>.</para>
		/// </summary>
		[JsMethod(Name = "refresh")]
		public static void RefreshS() { throw new NotImplementedException(); }

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

		/// <summary>
		/// <para>This method is called by all DOM tree modifying routines
		/// to inform the widgets.</para>
		/// </summary>
		[JsMethod(Name = "refresh")]
		public void Refresh() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called each time an event listener, for one of the
		/// supported events, is added using <see cref="qx.event.Manager.AddListener"/>.</para>
		/// </summary>
		/// <param name="target">The target to, which the event handler should be attached</param>
		/// <param name="type">event type</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event.</param>
		[JsMethod(Name = "registerEvent")]
		public void RegisterEvent(object target, string type, bool capture) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called each time an event listener, for one of the
		/// supported events, is removed by using <see cref="qx.event.Manager.RemoveListener"/>
		/// and no other event listener is listening on this type.</para>
		/// </summary>
		/// <param name="target">The target from, which the event handler should be removed</param>
		/// <param name="type">event type</param>
		/// <param name="capture">Whether to attach the event to the capturing phase or the bubbling phase of the event.</param>
		[JsMethod(Name = "unregisterEvent")]
		public void UnregisterEvent(object target, string type, bool capture) { throw new NotImplementedException(); }

		#endregion Methods
    }
}