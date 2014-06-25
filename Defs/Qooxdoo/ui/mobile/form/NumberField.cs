// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.form
{
    /// <summary>
	/// <para>The NumberField is a single-line number input field. It uses HTML5 input field type
	/// &#8220;number&#8221;.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.form.NumberField", OmitOptionalParameters = true, Export = false)]
    public partial class NumberField : qx.ui.mobile.form.Input, qx.ui.form.IStringForm
    {
		#region Events

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValue;

		/// <summary>
		/// <para>The event is fired on every keystroke modifying the value of the field.</para>
		/// <para>The method <see cref="qx.event.type.Data.GetData"/> returns the
		/// current value of the text field.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnInput;

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
		/// <para>The maximum text field value (may be negative). This value must be larger
		/// than <see cref="Maximum"/>.</para>
		/// </summary>
		[JsProperty(Name = "maximum", NativeField = true)]
		public double Maximum { get; set; }

		/// <summary>
		/// <para>The minimum text field value (may be negative). This value must be smaller
		/// than <see cref="Minimum"/>.</para>
		/// </summary>
		[JsProperty(Name = "minimum", NativeField = true)]
		public double Minimum { get; set; }

		/// <summary>
		/// <para>The amount to increment on each event.</para>
		/// </summary>
		[JsProperty(Name = "step", NativeField = true)]
		public double Step { get; set; }

		/// <summary>
		/// <para>Whether the <see cref="ChangeValue"/> event should be fired on every key
		/// input. If set to true, the changeValue event is equal to the
		/// <see cref="Input"/> event.</para>
		/// </summary>
		[JsProperty(Name = "liveUpdate", NativeField = true)]
		public bool LiveUpdate { get; set; }

		/// <summary>
		/// <para>Maximal number of characters that can be entered in the input field.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "maxLength", NativeField = true)]
		public double MaxLength { get; set; }

		/// <summary>
		/// <para>String value which will be shown as a hint if the field is all of:
		/// unset, unfocused and enabled. Set to null to not show a placeholder
		/// text.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "placeholder", NativeField = true)]
		public string Placeholder { get; set; }

		/// <summary>
		/// <para>Whether the field is read only</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "readOnly", NativeField = true)]
		public bool ReadOnly { get; set; }

		#endregion Properties

		#region Methods

		public NumberField() { throw new NotImplementedException(); }

		/// <param name="value">The value of the widget.</param>
		public NumberField(object value = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maximum.</para>
		/// </summary>
		[JsMethod(Name = "getMaximum")]
		public double GetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property minimum.</para>
		/// </summary>
		[JsMethod(Name = "getMinimum")]
		public double GetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property step.</para>
		/// </summary>
		[JsMethod(Name = "getStep")]
		public double GetStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maximum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maximum.</param>
		[JsMethod(Name = "initMaximum")]
		public void InitMaximum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property minimum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property minimum.</param>
		[JsMethod(Name = "initMinimum")]
		public void InitMinimum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property step
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property step.</param>
		[JsMethod(Name = "initStep")]
		public void InitStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maximum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaximum")]
		public void ResetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property minimum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMinimum")]
		public void ResetMinimum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property step.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetStep")]
		public void ResetStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maximum.</para>
		/// </summary>
		/// <param name="value">New value for property maximum.</param>
		[JsMethod(Name = "setMaximum")]
		public void SetMaximum(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property minimum.</para>
		/// </summary>
		/// <param name="value">New value for property minimum.</param>
		[JsMethod(Name = "setMinimum")]
		public void SetMinimum(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property step.</para>
		/// </summary>
		/// <param name="value">New value for property step.</param>
		[JsMethod(Name = "setStep")]
		public void SetStep(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "getLiveUpdate")]
		public bool GetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		[JsMethod(Name = "getValue")]
		public string GetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property liveUpdate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property liveUpdate.</param>
		[JsMethod(Name = "initLiveUpdate")]
		public void InitLiveUpdate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property liveUpdate equals true.</para>
		/// </summary>
		[JsMethod(Name = "isLiveUpdate")]
		public void IsLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property liveUpdate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLiveUpdate")]
		public void ResetLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		[JsMethod(Name = "resetValue")]
		public void ResetValue() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property liveUpdate.</para>
		/// </summary>
		/// <param name="value">New value for property liveUpdate.</param>
		[JsMethod(Name = "setLiveUpdate")]
		public void SetLiveUpdate(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property liveUpdate.</para>
		/// </summary>
		[JsMethod(Name = "toggleLiveUpdate")]
		public void ToggleLiveUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the focus from this widget.</para>
		/// </summary>
		[JsMethod(Name = "blur")]
		public void Blur() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Points the focus of the form to this widget.</para>
		/// </summary>
		[JsMethod(Name = "focus")]
		public void Focus() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxLength.</para>
		/// </summary>
		[JsMethod(Name = "getMaxLength")]
		public double GetMaxLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property placeholder.</para>
		/// </summary>
		[JsMethod(Name = "getPlaceholder")]
		public string GetPlaceholder() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property readOnly.</para>
		/// </summary>
		[JsMethod(Name = "getReadOnly")]
		public bool GetReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxLength
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxLength.</param>
		[JsMethod(Name = "initMaxLength")]
		public void InitMaxLength(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property placeholder
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property placeholder.</param>
		[JsMethod(Name = "initPlaceholder")]
		public void InitPlaceholder(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property readOnly
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property readOnly.</param>
		[JsMethod(Name = "initReadOnly")]
		public void InitReadOnly(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property readOnly equals true.</para>
		/// </summary>
		[JsMethod(Name = "isReadOnly")]
		public void IsReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxLength.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxLength")]
		public void ResetMaxLength() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property placeholder.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPlaceholder")]
		public void ResetPlaceholder() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property readOnly.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetReadOnly")]
		public void ResetReadOnly() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxLength.</para>
		/// </summary>
		/// <param name="value">New value for property maxLength.</param>
		[JsMethod(Name = "setMaxLength")]
		public void SetMaxLength(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property placeholder.</para>
		/// </summary>
		/// <param name="value">New value for property placeholder.</param>
		[JsMethod(Name = "setPlaceholder")]
		public void SetPlaceholder(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property readOnly.</para>
		/// </summary>
		/// <param name="value">New value for property readOnly.</param>
		[JsMethod(Name = "setReadOnly")]
		public void SetReadOnly(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property readOnly.</para>
		/// </summary>
		[JsMethod(Name = "toggleReadOnly")]
		public void ToggleReadOnly() { throw new NotImplementedException(); }

		#endregion Methods
    }
}