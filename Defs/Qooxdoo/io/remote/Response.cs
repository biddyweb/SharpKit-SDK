// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.remote
{
    /// <summary>
	/// <para>This class is used to work with the result of a HTTP request.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.remote.Response", OmitOptionalParameters = true, Export = false)]
    public partial class Response : qx.eventx.type.Event
    {
		#region Properties

		/// <summary>
		/// <para>Content of the response.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "content", NativeField = true)]
		public object Content { get; set; }

		/// <summary>
		/// <para>The headers of the response.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "responseHeaders", NativeField = true)]
		public object ResponseHeaders { get; set; }

		/// <summary>
		/// <para>State of the response.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "state", NativeField = true)]
		public double State { get; set; }

		/// <summary>
		/// <para>Status code of the response.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "statusCode", NativeField = true)]
		public double StatusCode { get; set; }

		#endregion Properties

		#region Methods

		public Response() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Create a clone of the event object, which is not automatically disposed
		/// or pooled after an event dispatch.</para>
		/// </summary>
		/// <param name="embryo">Optional event class, which will be configured using the data of this event instance. The event must be an instance of this event class. If the value is null, a new pooled instance is created.</param>
		/// <returns>a clone of this class.</returns>
		[JsMethod(Name = "clone")]
		public qx.eventx.type.Event Clone(qx.eventx.type.Event embryo = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property content.</para>
		/// </summary>
		[JsMethod(Name = "getContent")]
		public object GetContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a specific response header</para>
		/// </summary>
		/// <param name="vHeader">Response header name</param>
		/// <returns>The header value or null;</returns>
		[JsMethod(Name = "getResponseHeader")]
		public object GetResponseHeader(string vHeader) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property responseHeaders.</para>
		/// </summary>
		[JsMethod(Name = "getResponseHeaders")]
		public object GetResponseHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property state.</para>
		/// </summary>
		[JsMethod(Name = "getState")]
		public double GetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property statusCode.</para>
		/// </summary>
		[JsMethod(Name = "getStatusCode")]
		public double GetStatusCode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property content
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property content.</param>
		[JsMethod(Name = "initContent")]
		public void InitContent(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property responseHeaders
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property responseHeaders.</param>
		[JsMethod(Name = "initResponseHeaders")]
		public void InitResponseHeaders(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property state
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property state.</param>
		[JsMethod(Name = "initState")]
		public void InitState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property statusCode
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property statusCode.</param>
		[JsMethod(Name = "initStatusCode")]
		public void InitStatusCode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property content.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetContent")]
		public void ResetContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property responseHeaders.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetResponseHeaders")]
		public void ResetResponseHeaders() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property state.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetState")]
		public void ResetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property statusCode.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetStatusCode")]
		public void ResetStatusCode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property content.</para>
		/// </summary>
		/// <param name="value">New value for property content.</param>
		[JsMethod(Name = "setContent")]
		public void SetContent(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property responseHeaders.</para>
		/// </summary>
		/// <param name="value">New value for property responseHeaders.</param>
		[JsMethod(Name = "setResponseHeaders")]
		public void SetResponseHeaders(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property state.</para>
		/// </summary>
		/// <param name="value">New value for property state.</param>
		[JsMethod(Name = "setState")]
		public void SetState(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property statusCode.</para>
		/// </summary>
		/// <param name="value">New value for property statusCode.</param>
		[JsMethod(Name = "setStatusCode")]
		public void SetStatusCode(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}