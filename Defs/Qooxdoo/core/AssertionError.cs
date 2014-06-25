// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.core
{
    /// <summary>
	/// <para>Assertion errors are thrown if an assertion in <see cref="qx.core.Assert"/>
	/// fails.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.core.AssertionError", OmitOptionalParameters = true, Export = false)]
    public partial class AssertionError : qx.type.BaseError
    {
		#region Methods

		public AssertionError() { throw new NotImplementedException(); }

		/// <param name="comment">Comment passed to the assertion call</param>
		/// <param name="failMessage">Fail message provided by the assertion</param>
		public AssertionError(string comment, string failMessage) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Stack trace of the error</para>
		/// </summary>
		/// <returns>The stack trace of the location the exception was thrown</returns>
		[JsMethod(Name = "getStackTrace")]
		public string GetStackTrace() { throw new NotImplementedException(); }

		#endregion Methods
    }
}