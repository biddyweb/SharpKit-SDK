// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>All event dispatchers must implement this interface. Event dispatchers must
	/// register themselves at the event Manager using
	/// <see cref="qx.event.Registration.AddDispatcher"/>.</para>
	/// </summary>
	public interface IEventDispatcher
    {
		#region Methods

		/// <summary>
		/// <para>Whether the dispatcher is responsible for the this event.</para>
		/// </summary>
		/// <param name="target">The event dispatch target</param>
		/// <param name="eventx">The event object</param>
		/// <param name="type">the event type</param>
		/// <returns>Whether the event dispatcher is responsible for the this event</returns>
		bool CanDispatchEvent(object target, qx.eventx.type.Event eventx, string type);

		/// <summary>
		/// <para>This function dispatches the event to the event listeners.</para>
		/// </summary>
		/// <param name="target">The event dispatch target</param>
		/// <param name="eventx">event object to dispatch</param>
		/// <param name="type">the event type</param>
		void DispatchEvent(object target, qx.eventx.type.Event eventx, string type);

		#endregion Methods
    }
}