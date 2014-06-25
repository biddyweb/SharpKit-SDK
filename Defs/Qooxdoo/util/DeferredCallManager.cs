// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>This class manages the timer used for deferred calls. All
	/// <see cref="qx.util.DeferredCall"/> instances use the single timer from this class.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.DeferredCallManager", OmitOptionalParameters = true, Export = false)]
    public partial class DeferredCallManager : qx.core.Object
    {
		#region Methods

		public DeferredCallManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Cancel a scheduled deferred call</para>
		/// </summary>
		/// <param name="deferredCall">The call to schedule</param>
		[JsMethod(Name = "cancel")]
		public void Cancel(qx.util.DeferredCall deferredCall) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Schedule a deferred call</para>
		/// </summary>
		/// <param name="deferredCall">The call to schedule</param>
		[JsMethod(Name = "schedule")]
		public void Schedule(qx.util.DeferredCall deferredCall) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.util.DeferredCallManager GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}