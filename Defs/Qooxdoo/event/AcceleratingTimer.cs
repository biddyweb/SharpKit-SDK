// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx
{
    /// <summary>
	/// <para>Timer, which accelerates after each interval. The initial delay and the
	/// interval time can be set using the properties <see cref="FirstInterval"/>
	/// and <see cref="Interval"/>. The <see cref="Interval"/> events will be fired with
	/// decreasing interval times while the timer is running, until the <see cref="Minimum"/>
	/// is reached. The <see cref="Decrease"/> property sets the amount of milliseconds
	/// which will decreased after every firing.</para>
	/// <para>This class is e.g. used in the <see cref="qx.ui.form.RepeatButton"/> and
	/// <see cref="qx.ui.form.HoverButton"/> widgets.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.AcceleratingTimer", OmitOptionalParameters = true, Export = false)]
    public partial class AcceleratingTimer : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>This event if fired each time the interval time has elapsed</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnInterval;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Decrease of the timer on each interval (for the next interval) until minTimer reached.</para>
		/// </summary>
		[JsProperty(Name = "decrease", NativeField = true)]
		public double Decrease { get; set; }

		/// <summary>
		/// <para>Interval used for the first run of the timer. Usually a greater value
		/// than the &#8220;interval&#8221; property value to a little delayed reaction at the first
		/// time.</para>
		/// </summary>
		[JsProperty(Name = "firstInterval", NativeField = true)]
		public double FirstInterval { get; set; }

		/// <summary>
		/// <para>Interval used after the first run of the timer. Usually a smaller value
		/// than the &#8220;firstInterval&#8221; property value to get a faster reaction.</para>
		/// </summary>
		[JsProperty(Name = "interval", NativeField = true)]
		public double Interval { get; set; }

		/// <summary>
		/// <para>This configures the minimum value for the timer interval.</para>
		/// </summary>
		[JsProperty(Name = "minimum", NativeField = true)]
		public double Minimum { get; set; }

		#endregion Properties

		#region Methods

		public AcceleratingTimer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property decrease.</para>
		/// </summary>
		[JsMethod(Name = "getDecrease")]
		public double GetDecrease() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property firstInterval.</para>
		/// </summary>
		[JsMethod(Name = "getFirstInterval")]
		public double GetFirstInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property interval.</para>
		/// </summary>
		[JsMethod(Name = "getInterval")]
		public double GetInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property minimum.</para>
		/// </summary>
		[JsMethod(Name = "getMinimum")]
		public double GetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property decrease
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property decrease.</param>
		[JsMethod(Name = "initDecrease")]
		public void InitDecrease(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property firstInterval
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property firstInterval.</param>
		[JsMethod(Name = "initFirstInterval")]
		public void InitFirstInterval(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property interval
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property interval.</param>
		[JsMethod(Name = "initInterval")]
		public void InitInterval(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property minimum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minimum.</param>
		[JsMethod(Name = "initMinimum")]
		public void InitMinimum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property decrease.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDecrease")]
		public void ResetDecrease() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property firstInterval.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetFirstInterval")]
		public void ResetFirstInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property interval.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInterval")]
		public void ResetInterval() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property minimum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinimum")]
		public void ResetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property decrease.</para>
		/// </summary>
		/// <param name="value">New value for property decrease.</param>
		[JsMethod(Name = "setDecrease")]
		public void SetDecrease(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property firstInterval.</para>
		/// </summary>
		/// <param name="value">New value for property firstInterval.</param>
		[JsMethod(Name = "setFirstInterval")]
		public void SetFirstInterval(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property interval.</para>
		/// </summary>
		/// <param name="value">New value for property interval.</param>
		[JsMethod(Name = "setInterval")]
		public void SetInterval(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property minimum.</para>
		/// </summary>
		/// <param name="value">New value for property minimum.</param>
		[JsMethod(Name = "setMinimum")]
		public void SetMinimum(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reset and start the timer.</para>
		/// </summary>
		[JsMethod(Name = "start")]
		public void Start() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stop the timer</para>
		/// </summary>
		[JsMethod(Name = "stop")]
		public void Stop() { throw new NotImplementedException(); }

		#endregion Methods
    }
}