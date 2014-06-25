// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.dev.unit
{
    /// <summary>
	/// <para>The test result class runs the test functions and fires events depending on
	/// the result of the test run.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.dev.unit.TestResult", OmitOptionalParameters = true, Export = false)]
    public partial class TestResult : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired if a performance test returned results.</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnEndMeasurement;

		/// <summary>
		/// <para>Fired after the test has finished</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnEndTest;

		/// <summary>
		/// <para>Fired if the test raised an <see cref="qx.core.AssertionError"/></para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnError;

		/// <summary>
		/// <para>Fired if the test failed with a different exception</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnFailure;

		/// <summary>
		/// <para>Fired if the test was skipped, e.g. because a requirement was not met.</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnSkip;

		/// <summary>
		/// <para>Fired before the test is started</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnStartTest;

		/// <summary>
		/// <para>Fired if an asynchronous test sets a timeout</para>
		/// <para>Event data: The test <see cref="qx.dev.unit.TestFunction"/></para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnWait;

		#endregion Events

		#region Methods

		public TestResult() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Run a test function using a given test result</para>
		/// </summary>
		/// <param name="testResult">The test result to use to run the test</param>
		/// <param name="test">The test</param>
		/// <param name="testFunction">The test function</param>
		[JsMethod(Name = "run")]
		public static void RunS(TestResult testResult, object test, object testFunction) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Run the test</para>
		/// </summary>
		/// <param name="test">The test</param>
		/// <param name="testFunction">The test function</param>
		/// <param name="self">The context in which to run the test function</param>
		/// <param name="resume">Resume a currently waiting test</param>
		[JsMethod(Name = "run")]
		public void Run(object test, Action<object> testFunction, object self, bool resume) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the generic tearDown method on the test class, then the specific
		/// tearDown for the test, if one is defined.</para>
		/// </summary>
		/// <param name="test">The test object (first argument of #run)</param>
		[JsMethod(Name = "tearDown")]
		public void TearDown(object test) { throw new NotImplementedException(); }

		#endregion Methods
    }
}