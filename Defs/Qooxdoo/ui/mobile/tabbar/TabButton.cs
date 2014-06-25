// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.tabbar
{
    /// <summary>
	/// <para>A tab button widget.</para>
	/// <para>A tab button can be added to the tab bar and is associated with a
	/// <see cref="View"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.tabbar.TabButton", OmitOptionalParameters = true, Export = false)]
    public partial class TabButton : qx.ui.mobile.form.Button
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="View"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeView;

		#endregion Events

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

		/// <summary>
		/// <para>The associated view.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "view", NativeField = true)]
		public qx.ui.mobile.core.Widget View { get; set; }

		#endregion Properties

		#region Methods

		public TabButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property view.</para>
		/// </summary>
		[JsMethod(Name = "getView")]
		public qx.ui.mobile.core.Widget GetView() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property view
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property view.</param>
		[JsMethod(Name = "initView")]
		public void InitView(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property view.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetView")]
		public void ResetView() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property view.</para>
		/// </summary>
		/// <param name="value">New value for property view.</param>
		[JsMethod(Name = "setView")]
		public void SetView(qx.ui.mobile.core.Widget value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}