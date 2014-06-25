// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.form
{
    /// <summary>
	/// <para>The HoverButton is an <see cref="qx.ui.basic.Atom"/>, which fires repeatedly
	/// execute events while the mouse is over the widget.</para>
	/// <para>The rate at which the execute event is fired accelerates is the mouse keeps
	/// inside of the widget. The initial delay and the interval time can be set using
	/// the properties <see cref="FirstInterval"/> and <see cref="Interval"/>. The
	/// <see cref="Execute"/> events will be fired in a shorter amount of time if the mouse
	/// remains over the widget, until the min <see cref="MinTimer"/> is reached.
	/// The <see cref="TimerDecrease"/> property sets the amount of milliseconds which will
	/// decreased after every firing.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var button = new qx.ui.form.HoverButton("Hello World");
	/// button.addListener("execute", function(e) {
	/// alert("Button is hovered");
	/// }, this);
	/// this.getRoot.add(button);
	/// </code>
	/// <para>This example creates a button with the label &#8220;Hello World&#8221; and attaches an
	/// event listener to the <see cref="Execute"/> event.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.HoverButton", OmitOptionalParameters = true, Export = false)]
    public partial class HoverButton : qx.ui.basic.Atom, qx.ui.form.IExecutable
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Command"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeCommand;

		/// <summary>
		/// <para>Fired when the widget is executed. Sets the &#8220;data&#8221; property of the
		/// event to the object that issued the command.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnExecute;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

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
		[JsProperty(Name = "minTimer", NativeField = true)]
		public double MinTimer { get; set; }

		/// <summary>
		/// <para>Decrease of the timer on each interval (for the next interval) until minTimer reached.</para>
		/// </summary>
		[JsProperty(Name = "timerDecrease", NativeField = true)]
		public double TimerDecrease { get; set; }

		/// <summary>
		/// <para>A command called if the <see cref="Execute"/> method is called, e.g. on a
		/// button click.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "command", NativeField = true)]
		public qx.ui.core.Command Command { get; set; }

		#endregion Properties

		#region Methods

		public HoverButton() { throw new NotImplementedException(); }

		/// <param name="label">Label to use</param>
		/// <param name="icon">Icon to use</param>
		public HoverButton(string label, string icon = null) { throw new NotImplementedException(); }

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
		/// <para>Returns the (computed) value of the property minTimer.</para>
		/// </summary>
		[JsMethod(Name = "getMinTimer")]
		public double GetMinTimer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property timerDecrease.</para>
		/// </summary>
		[JsMethod(Name = "getTimerDecrease")]
		public double GetTimerDecrease() { throw new NotImplementedException(); }

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
		/// <para>Calls the apply method and dispatches the change event of the property minTimer
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minTimer.</param>
		[JsMethod(Name = "initMinTimer")]
		public void InitMinTimer(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property timerDecrease
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property timerDecrease.</param>
		[JsMethod(Name = "initTimerDecrease")]
		public void InitTimerDecrease(object value) { throw new NotImplementedException(); }

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
		/// <para>Resets the user value of the property minTimer.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinTimer")]
		public void ResetMinTimer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property timerDecrease.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTimerDecrease")]
		public void ResetTimerDecrease() { throw new NotImplementedException(); }

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
		/// <para>Sets the user value of the property minTimer.</para>
		/// </summary>
		/// <param name="value">New value for property minTimer.</param>
		[JsMethod(Name = "setMinTimer")]
		public void SetMinTimer(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property timerDecrease.</para>
		/// </summary>
		/// <param name="value">New value for property timerDecrease.</param>
		[JsMethod(Name = "setTimerDecrease")]
		public void SetTimerDecrease(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Fire the &#8220;execute&#8221; event on the command.</para>
		/// </summary>
		[JsMethod(Name = "execute")]
		public void Execute() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set command of this executable.</para>
		/// </summary>
		/// <returns>The current set command.</returns>
		[JsMethod(Name = "getCommand")]
		public qx.ui.core.Command GetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property command
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property command.</param>
		[JsMethod(Name = "initCommand")]
		public void InitCommand(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property command.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetCommand")]
		public void ResetCommand() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the command of this executable.</para>
		/// </summary>
		/// <param name="command">The command.</param>
		[JsMethod(Name = "setCommand")]
		public void SetCommand(qx.ui.core.Command command) { throw new NotImplementedException(); }

		#endregion Methods
    }
}