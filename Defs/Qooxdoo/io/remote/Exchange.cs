// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.io.remote
{
    /// <summary>
	/// <para>Transport layer to control which transport class (XmlHttp, Iframe or Script)
	/// can be used.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.io.remote.Exchange", OmitOptionalParameters = true, Export = false)]
    public partial class Exchange : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired whenever a request is aborted</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnAborted;

		/// <summary>
		/// Fired on change of the property <see cref="State"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeState;

		/// <summary>
		/// <para>Fired whenever a request is completed</para>
		/// </summary>
		public event Action<qx.io.remote.Response> OnCompleted;

		/// <summary>
		/// <para>Fired whenever a request has failed</para>
		/// </summary>
		public event Action<qx.io.remote.Response> OnFailed;

		/// <summary>
		/// <para>Fired whenever a request is received</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnReceiving;

		/// <summary>
		/// <para>Fired whenever a request is send</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnSending;

		/// <summary>
		/// <para>Fired whenever a request has timed out</para>
		/// </summary>
		public event Action<qx.io.remote.Response> OnTimeout;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Set the implementation to use to send the request with.</para>
		/// <para>The implementation should be a subclass of qx.io.remote.transport.Abstract and
		/// must implement all methods in the transport API.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "implementation", NativeField = true)]
		public qx.io.remote.transport.Abstract Implementation { get; set; }

		/// <summary>
		/// <para>Set the request to send with this transport.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "request", NativeField = true)]
		public qx.io.remote.Request Request { get; set; }

		/// <summary>
		/// <para>Current state of the transport layer.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "configured","sending","receiving","completed","aborted","timeout","failed"
		/// </remarks>
		[JsProperty(Name = "state", NativeField = true)]
		public object State { get; set; }

		#endregion Properties

		#region Methods

		public Exchange() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Constructor method.</para>
		/// </summary>
		/// <param name="vRequest">request object</param>
		public Exchange(qx.io.remote.Request vRequest) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Checks which supported transport class can handle the request with the
		/// given content type.</para>
		/// </summary>
		/// <param name="vImpl">transport implementation</param>
		/// <param name="vNeeds">requirements for the request like e.g. &#8220;cross-domain&#8221;</param>
		/// <param name="vResponseType">content type</param>
		/// <returns>true if the transport implementation supports the request's requirements</returns>
		[JsMethod(Name = "canHandle")]
		public static bool CanHandle(object vImpl, object vNeeds, string vResponseType) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Initializes the available type of transport classes and
		/// checks for the supported ones.</para>
		/// </summary>
		[JsMethod(Name = "initTypes")]
		public static void InitTypes() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Registers a transport type.
		/// At the moment one out of XmlHttp, Iframe or Script.</para>
		/// </summary>
		/// <param name="vClass">transport class</param>
		/// <param name="vId">unique id</param>
		[JsMethod(Name = "registerType")]
		public static void RegisterType(object vClass, string vId) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Status code to string conversion</para>
		/// </summary>
		/// <param name="vStatusCode">request status code</param>
		/// <returns>String presentation of status code</returns>
		[JsMethod(Name = "statusCodeToString")]
		public static string StatusCodeToString(double vStatusCode) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Called from the transport class when a request was completed.</para>
		/// </summary>
		/// <param name="vStatusCode">status code of the request</param>
		/// <param name="vReadyState">readystate of the request</param>
		/// <param name="vIsLocal">whether the request is a local one</param>
		/// <returns>Returns boolean value depending on the status code</returns>
		[JsMethod(Name = "wasSuccessful")]
		public static object WasSuccessful(double vStatusCode, string vReadyState, bool vIsLocal) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the transport into the aborted (&#8220;aborted&#8221;)
		/// state.</para>
		/// </summary>
		[JsMethod(Name = "abort")]
		public void Abort() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property implementation.</para>
		/// </summary>
		[JsMethod(Name = "getImplementation")]
		public qx.io.remote.transport.Abstract GetImplementation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property request.</para>
		/// </summary>
		[JsMethod(Name = "getRequest")]
		public qx.io.remote.Request GetRequest() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property state.</para>
		/// </summary>
		[JsMethod(Name = "getState")]
		public object GetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property implementation
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property implementation.</param>
		[JsMethod(Name = "initImplementation")]
		public void InitImplementation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property request
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property request.</param>
		[JsMethod(Name = "initRequest")]
		public void InitRequest(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property state
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property state.</param>
		[JsMethod(Name = "initState")]
		public void InitState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property implementation.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetImplementation")]
		public void ResetImplementation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property request.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequest")]
		public void ResetRequest() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property state.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetState")]
		public void ResetState() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sends the request.</para>
		/// </summary>
		/// <returns>Returns true if the request was sent.</returns>
		[JsMethod(Name = "send")]
		public object Send() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property implementation.</para>
		/// </summary>
		/// <param name="value">New value for property implementation.</param>
		[JsMethod(Name = "setImplementation")]
		public void SetImplementation(qx.io.remote.transport.Abstract value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property request.</para>
		/// </summary>
		/// <param name="value">New value for property request.</param>
		[JsMethod(Name = "setRequest")]
		public void SetRequest(qx.io.remote.Request value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property state.</para>
		/// </summary>
		/// <param name="value">New value for property state.</param>
		[JsMethod(Name = "setState")]
		public void SetState(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Force the transport into the timeout state.</para>
		/// </summary>
		[JsMethod(Name = "timeout")]
		public void Timeout() { throw new NotImplementedException(); }

		#endregion Methods
    }
}