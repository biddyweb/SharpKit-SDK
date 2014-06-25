// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.webfonts
{
    /// <summary>
	/// <para>Requests web fonts from <see cref="qx.bom.webfonts.Manager"/> and fires events
	/// when their loading status is known.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.webfonts.WebFont", OmitOptionalParameters = true, Export = false)]
    public partial class WebFont : qx.bom.Font
    {
		#region Events

		/// <summary>
		/// <para>Fired when the status of a web font has been determined. The event data
		/// is a map with the keys &#8220;family&#8221; (the font-family name) and &#8220;valid&#8221;
		/// (Boolean).</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeStatus;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The source of the webfont.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "sources", NativeField = true)]
		public object Sources { get; set; }

		#endregion Properties

		#region Methods

		public WebFont() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property sources.</para>
		/// </summary>
		[JsMethod(Name = "getSources")]
		public object GetSources() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property sources
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property sources.</param>
		[JsMethod(Name = "initSources")]
		public void InitSources(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property sources.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSources")]
		public void ResetSources() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property sources.</para>
		/// </summary>
		/// <param name="value">New value for property sources.</param>
		[JsMethod(Name = "setSources")]
		public void SetSources(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}