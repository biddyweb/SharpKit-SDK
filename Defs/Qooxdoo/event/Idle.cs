// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>A generic singleton that fires an &#8220;interval&#8221; event all 100 miliseconds. It
	/// can be used whenever one needs to run code periodically. The main purpose of
	/// this class is reduce the number of timers.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.Idle", OmitOptionalParameters = true, Export = false)]
    public partial class Idle : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>This event if fired each time the interval time has elapsed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnInterval;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Interval for the timer, which periodically fires the &#8220;interval&#8221; event,
		/// in milliseconds.</para>
		/// </summary>
		[JsProperty(Name = "timeoutInterval", NativeField = true)]
		public double TimeoutInterval { get; set; }

		#endregion Properties

		#region Methods

		public Idle() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property timeoutInterval.</para>
		/// </summary>
		[JsMethod(Name = "getTimeoutInterval")]
		public double GetTimeoutInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property timeoutInterval
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property timeoutInterval.</param>
		[JsMethod(Name = "initTimeoutInterval")]
		public void InitTimeoutInterval(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property timeoutInterval.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTimeoutInterval")]
		public void ResetTimeoutInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property timeoutInterval.</para>
		/// </summary>
		/// <param name="value">New value for property timeoutInterval.</param>
		[JsMethod(Name = "setTimeoutInterval")]
		public void SetTimeoutInterval(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.eventx.Idle GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}