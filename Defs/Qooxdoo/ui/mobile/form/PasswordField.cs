// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.form
{
    /// <summary>
	/// <para>The PasswordField is a single-line password input field.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.PasswordField", OmitOptionalParameters = true, Export = false)]
    public partial class PasswordField : qx.ui.mobile.form.TextField
    {
		#region Properties

		/// <summary>
		/// <para>The default CSS class used for this widget. The default CSS class
		/// should contain the common appearance of the widget.
		/// It is set to the container element of the widget. Use <see cref="AddCssClass"/>
		/// to enhance the default appearance of the widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "defaultCssClass", NativeField = true)]
		public string DefaultCssClass { get; set; }

		#endregion Properties

		#region Methods

		public PasswordField() { throw new NotImplementedException(); }

		#endregion Methods
    }
}