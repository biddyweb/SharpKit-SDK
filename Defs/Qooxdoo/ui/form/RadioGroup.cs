// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.core;

namespace qx.ui.form
{
    /// <summary>
	/// <para>The radio group handles a collection of items from which only one item
	/// can be selected. Selection another item will deselect the previously selected
	/// item.</para>
	/// <para>This class is e.g. used to create radio groups or <see cref="qx.ui.form.RadioButton"/>
	/// or <see cref="qx.ui.toolbar.RadioButton"/> instances.</para>
	/// <para>We also offer a widget for the same purpose which uses this class. So if
	/// you like to act with a widget instead of a pure logic coupling of the
	/// widgets, take a look at the <see cref="qx.ui.form.RadioButtonGroup"/> widget.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.form.RadioGroup", OmitOptionalParameters = true, Export = false)]
    public partial class RadioGroup : qx.core.Object, qx.ui.core.ISingleSelection, qx.ui.form.IForm, qx.ui.form.IModelSelection
    {
		#region Events

		/// <summary>
		/// <para>Fired when the enabled state was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeEnabled;

		/// <summary>
		/// <para>Fired when the invalidMessage was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeInvalidMessage;

		/// <summary>
		/// <para>Fired when the required was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeRequired;

		/// <summary>
		/// <para>Fired when the valid state was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeValid;

		/// <summary>
		/// <para>Fires after the selection was modified</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		/// <summary>
		/// <para>Pseudo event. It will never be fired because the array itself can not
		/// be changed. But the event description is needed for the data binding.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModelSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>If is set to true the selection could be empty,
		/// otherwise is always one RadioButton selected.</para>
		/// </summary>
		[JsProperty(Name = "allowEmptySelection", NativeField = true)]
		public bool AllowEmptySelection { get; set; }

		/// <summary>
		/// <para>Whether the radio group is enabled</para>
		/// </summary>
		[JsProperty(Name = "enabled", NativeField = true)]
		public bool Enabled { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip.</para>
		/// </summary>
		[JsProperty(Name = "invalidMessage", NativeField = true)]
		public string InvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if the group is required.</para>
		/// </summary>
		[JsProperty(Name = "required", NativeField = true)]
		public bool Required { get; set; }

		/// <summary>
		/// <para>Message which is shown in an invalid tooltip if the <see cref="Required"/> is
		/// set to true.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "requiredInvalidMessage", NativeField = true)]
		public string RequiredInvalidMessage { get; set; }

		/// <summary>
		/// <para>Flag signaling if the group at all is valid. All children will have the
		/// same state.</para>
		/// </summary>
		[JsProperty(Name = "valid", NativeField = true)]
		public bool Valid { get; set; }

		/// <summary>
		/// <para>Whether the selection should wrap around. This means that the successor of
		/// the last item is the first item.</para>
		/// </summary>
		[JsProperty(Name = "wrap", NativeField = true)]
		public bool Wrap { get; set; }

		#endregion Properties

		#region Methods

		public RadioGroup() { throw new NotImplementedException(); }

		/// <param name="varargs">A variable number of items, which are initially added to the radio group, the first item will be selected.</param>
		public RadioGroup(qx.core.Object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add the passed items to the radio group.</para>
		/// </summary>
		/// <param name="varargs">A variable number of items to add.</param>
		[JsMethod(Name = "add")]
		public void Add(qx.ui.form.IRadioItem varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property allowEmptySelection.</para>
		/// </summary>
		[JsMethod(Name = "getAllowEmptySelection")]
		public bool GetAllowEmptySelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array containing the group&#8217;s items.</para>
		/// </summary>
		/// <returns>The item array</returns>
		[JsMethod(Name = "getChildren")]
		public qx.ui.form.IRadioItem GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current set enabled state.</para>
		/// </summary>
		/// <returns>If the widget is enabled.</returns>
		[JsMethod(Name = "getEnabled")]
		public bool GetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getInvalidMessage")]
		public string GetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get all managed items</para>
		/// </summary>
		/// <returns>All managed items.</returns>
		[JsMethod(Name = "getItems")]
		public qx.ui.form.IRadioItem GetItems() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the current required state of the widget.</para>
		/// </summary>
		/// <returns>True, if the widget is required.</returns>
		[JsMethod(Name = "getRequired")]
		public bool GetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the invalid message if required of the widget.</para>
		/// </summary>
		/// <returns>The current set message.</returns>
		[JsMethod(Name = "getRequiredInvalidMessage")]
		public string GetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the valid state of the widget.</para>
		/// </summary>
		/// <returns>If the state of the widget is valid.</returns>
		[JsMethod(Name = "getValid")]
		public bool GetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property wrap.</para>
		/// </summary>
		[JsMethod(Name = "getWrap")]
		public bool GetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property allowEmptySelection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property allowEmptySelection.</param>
		[JsMethod(Name = "initAllowEmptySelection")]
		public void InitAllowEmptySelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property enabled
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property enabled.</param>
		[JsMethod(Name = "initEnabled")]
		public void InitEnabled(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property invalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property invalidMessage.</param>
		[JsMethod(Name = "initInvalidMessage")]
		public void InitInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property required
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property required.</param>
		[JsMethod(Name = "initRequired")]
		public void InitRequired(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property requiredInvalidMessage
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property requiredInvalidMessage.</param>
		[JsMethod(Name = "initRequiredInvalidMessage")]
		public void InitRequiredInvalidMessage(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property valid
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property valid.</param>
		[JsMethod(Name = "initValid")]
		public void InitValid(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property wrap
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property wrap.</param>
		[JsMethod(Name = "initWrap")]
		public void InitWrap(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property allowEmptySelection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isAllowEmptySelection")]
		public void IsAllowEmptySelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property enabled equals true.</para>
		/// </summary>
		[JsMethod(Name = "isEnabled")]
		public void IsEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property required equals true.</para>
		/// </summary>
		[JsMethod(Name = "isRequired")]
		public void IsRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property valid equals true.</para>
		/// </summary>
		[JsMethod(Name = "isValid")]
		public void IsValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property wrap equals true.</para>
		/// </summary>
		[JsMethod(Name = "isWrap")]
		public void IsWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an item from the radio group.</para>
		/// </summary>
		/// <param name="item">The item to remove.</param>
		[JsMethod(Name = "remove")]
		public void Remove(qx.ui.form.IRadioItem item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property allowEmptySelection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAllowEmptySelection")]
		public void ResetAllowEmptySelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property enabled.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEnabled")]
		public void ResetEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property invalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetInvalidMessage")]
		public void ResetInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property required.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequired")]
		public void ResetRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property requiredInvalidMessage.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetRequiredInvalidMessage")]
		public void ResetRequiredInvalidMessage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property valid.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetValid")]
		public void ResetValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property wrap.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetWrap")]
		public void ResetWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Select the item following the given item.</para>
		/// </summary>
		[JsMethod(Name = "selectNext")]
		public void SelectNext() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Select the item previous the given item.</para>
		/// </summary>
		[JsMethod(Name = "selectPrevious")]
		public void SelectPrevious() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property allowEmptySelection.</para>
		/// </summary>
		/// <param name="value">New value for property allowEmptySelection.</param>
		[JsMethod(Name = "setAllowEmptySelection")]
		public void SetAllowEmptySelection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the enabled state of the widget.</para>
		/// </summary>
		/// <param name="enabled">The enabled state.</param>
		[JsMethod(Name = "setEnabled")]
		public void SetEnabled(bool enabled) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setInvalidMessage")]
		public void SetInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the required state of a widget.</para>
		/// </summary>
		/// <param name="required">A flag signaling if the widget is required.</param>
		[JsMethod(Name = "setRequired")]
		public void SetRequired(bool required) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the invalid message if required of the widget.</para>
		/// </summary>
		/// <param name="message">The invalid message.</param>
		[JsMethod(Name = "setRequiredInvalidMessage")]
		public void SetRequiredInvalidMessage(string message) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the valid state of the widget.</para>
		/// </summary>
		/// <param name="valid">The valid state of the widget.</param>
		[JsMethod(Name = "setValid")]
		public void SetValid(bool valid) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property wrap.</para>
		/// </summary>
		/// <param name="value">New value for property wrap.</param>
		[JsMethod(Name = "setWrap")]
		public void SetWrap(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property allowEmptySelection.</para>
		/// </summary>
		[JsMethod(Name = "toggleAllowEmptySelection")]
		public void ToggleAllowEmptySelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property enabled.</para>
		/// </summary>
		[JsMethod(Name = "toggleEnabled")]
		public void ToggleEnabled() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property required.</para>
		/// </summary>
		[JsMethod(Name = "toggleRequired")]
		public void ToggleRequired() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property valid.</para>
		/// </summary>
		[JsMethod(Name = "toggleValid")]
		public void ToggleValid() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property wrap.</para>
		/// </summary>
		[JsMethod(Name = "toggleWrap")]
		public void ToggleWrap() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns all elements which are selectable.</para>
		/// </summary>
		/// <param name="all">true for all selectables, false for the selectables the user can interactively select</param>
		/// <returns>The contained items.</returns>
		[JsMethod(Name = "getSelectables")]
		public qx.ui.core.Widget GetSelectables(bool all) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of currently selected items.</para>
		/// <para>Note: The result is only a set of selected items, so the order can
		/// differ from the sequence in which the items were added.</para>
		/// </summary>
		/// <returns>List of items.</returns>
		[JsMethod(Name = "getSelection")]
		public qx.ui.core.Widget GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects whether the given item is currently selected.</para>
		/// </summary>
		/// <param name="item">Any valid selectable item</param>
		/// <returns>Whether the item is selected.</returns>
		[JsMethod(Name = "isSelected")]
		public bool IsSelected(qx.ui.core.Widget item) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the selection is empty.</para>
		/// </summary>
		/// <returns>Whether the selection is empty.</returns>
		[JsMethod(Name = "isSelectionEmpty")]
		public bool IsSelectionEmpty() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the whole selection at once.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Replaces current selection with the given items.</para>
		/// </summary>
		/// <param name="items">Items to select.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.ui.core.Widget items) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array of the selected models.</para>
		/// </summary>
		/// <returns>An array containing the models of the currently selected items.</returns>
		[JsMethod(Name = "getModelSelection")]
		public JsArray GetModelSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Tries to set the selection using the given array containing the
		/// representative models for the selectables.</para>
		/// </summary>
		/// <param name="value">An array of models.</param>
		[JsMethod(Name = "setModelSelection")]
		public void SetModelSelection(JsArray value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}