// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core.queue
{
    /// <summary>
	/// <para>The layout queue manages all widgets, which need a recalculation of their
	/// layout. The <see cref="Flush"/> method computes the layout of all queued widgets
	/// and their dependent widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.queue.Layout", OmitOptionalParameters = true, Export = false)]
    public partial class Layout 
    {
		#region Methods

		public Layout() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mark a widget&#8217;s layout as invalid and add its layout root to
		/// the queue.</para>
		/// <para>Should only be used by <see cref="qx.ui.core.Widget"/>.</para>
		/// </summary>
		/// <param name="widget">Widget to add.</param>
		[JsMethod(Name = "add")]
		public static void Add(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Update the layout of all widgets, which layout is marked as invalid.</para>
		/// <para>This is used exclusively by the <see cref="qx.ui.core.queue.Manager"/>.</para>
		/// </summary>
		[JsMethod(Name = "flush")]
		public static void Flush() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the widget&#8217;s nesting level. Top level widgets have a nesting level
		/// of 0.</para>
		/// </summary>
		/// <param name="widget">The widget to query.</param>
		/// <returns>The nesting level</returns>
		[JsMethod(Name = "getNestingLevel")]
		public static double GetNestingLevel(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the queue has scheduled changes for a widget.
		/// Note that the layout parent can have changes scheduled that
		/// affect the children widgets.</para>
		/// </summary>
		/// <param name="widget">Widget to check.</param>
		/// <returns>Whether the widget given has layout changes queued.</returns>
		[JsMethod(Name = "isScheduled")]
		public static bool IsScheduled(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the widget from the internal queue. Normally only used
		/// during interims disposes of one or a few widgets.</para>
		/// </summary>
		/// <param name="widget">The widget to clear</param>
		[JsMethod(Name = "remove")]
		public static void Remove(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		#endregion Methods
    }
}