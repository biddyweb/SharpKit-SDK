// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.dev.unit
{
    /// <summary>
	/// <para>This class stores the information needed to instruct a running test to wait.
	/// It is thrown as an exception to be caught by the method executing the test.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.dev.unit.AsyncWrapper", OmitOptionalParameters = true, Export = false)]
    public partial class AsyncWrapper : qx.core.Object
    {
		#region Properties

		/// <summary>
		/// <para>The context in which the timeout function should be executed</para>
		/// </summary>
		[JsProperty(Name = "context", NativeField = true)]
		public object Context { get; set; }

		/// <summary>
		/// <para>The function to run after the timeout has expired</para>
		/// </summary>
		[JsProperty(Name = "deferredFunction", NativeField = true)]
		public Action<object> DeferredFunction { get; set; }

		/// <summary>
		/// <para>The amount of time in milliseconds to wait</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "delay", NativeField = true)]
		public double Delay { get; set; }

		#endregion Properties

		#region Methods

		public AsyncWrapper() { throw new NotImplementedException(); }

		/// <param name="delay">The amount of time in milliseconds to wait</param>
		/// <param name="deferredFunction">The function to run after the timeout has expired.</param>
		/// <param name="context">Optional execution context for deferredFunction</param>
		public AsyncWrapper(double delay, Action<object> deferredFunction, object context = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property context.</para>
		/// </summary>
		[JsMethod(Name = "getContext")]
		public object GetContext() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property deferredFunction.</para>
		/// </summary>
		[JsMethod(Name = "getDeferredFunction")]
		public Action<object> GetDeferredFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delay.</para>
		/// </summary>
		[JsMethod(Name = "getDelay")]
		public double GetDelay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property context
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property context.</param>
		[JsMethod(Name = "initContext")]
		public void InitContext(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property deferredFunction
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property deferredFunction.</param>
		[JsMethod(Name = "initDeferredFunction")]
		public void InitDeferredFunction(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delay
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delay.</param>
		[JsMethod(Name = "initDelay")]
		public void InitDelay(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property context.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContext")]
		public void ResetContext() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property deferredFunction.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDeferredFunction")]
		public void ResetDeferredFunction() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delay.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelay")]
		public void ResetDelay() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property context.</para>
		/// </summary>
		/// <param name="value">New value for property context.</param>
		[JsMethod(Name = "setContext")]
		public void SetContext(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property deferredFunction.</para>
		/// </summary>
		/// <param name="value">New value for property deferredFunction.</param>
		[JsMethod(Name = "setDeferredFunction")]
		public void SetDeferredFunction(Action<object> value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delay.</para>
		/// </summary>
		/// <param name="value">New value for property delay.</param>
		[JsMethod(Name = "setDelay")]
		public void SetDelay(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}