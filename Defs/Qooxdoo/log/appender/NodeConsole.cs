// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.log.appender
{
    /// <summary>
	/// <para>Log appender for qooxdoo applications running in Node.js. Writes log
	/// messages to STDOUT/STDERR.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.log.appender.NodeConsole", OmitOptionalParameters = true, Export = false)]
    public partial class NodeConsole 
    {
		#region Methods

		public NodeConsole() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Logs a debug message</para>
		/// </summary>
		/// <param name="logMessage">Message to be logged</param>
		[JsMethod(Name = "debug")]
		public static void Debug(string logMessage) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Logs an error message</para>
		/// </summary>
		/// <param name="logMessage">Message to be logged</param>
		[JsMethod(Name = "error")]
		public static void Error(string logMessage) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Logs an info message</para>
		/// </summary>
		/// <param name="logMessage">Message to be logged</param>
		[JsMethod(Name = "info")]
		public static void Info(string logMessage) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Writes a message to the shell. Errors will be sent to STDERR, everything
		/// else goes to STDOUT</para>
		/// </summary>
		/// <param name="logMessage">Message to be logged</param>
		/// <param name="level">Log level. One of &#8220;debug&#8221;, &#8220;info&#8221;, &#8220;warn&#8221;, &#8220;error&#8221;</param>
		[JsMethod(Name = "log")]
		public static void Log(string logMessage, string level) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Process a log entry object from qooxdoo&#8217;s logging system.</para>
		/// </summary>
		/// <param name="entry">Log entry object</param>
		[JsMethod(Name = "process")]
		public static void Process(object entry) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Logs a warning message</para>
		/// </summary>
		/// <param name="logMessage">Message to be logged</param>
		[JsMethod(Name = "warn")]
		public static void Warn(string logMessage) { throw new NotImplementedException(); }

		#endregion Methods
    }
}