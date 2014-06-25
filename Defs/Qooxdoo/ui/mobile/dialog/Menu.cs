// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.mobile.dialog
{
    /// <summary>
	/// <para>This widget displays a menu. A dialog menu extends a dialog and contains a
	/// list, which provides the user the possibility to select one value.
	/// The selected value is identified through selected index.</para>
	/// <para>Example</para>
	/// <code>
	/// var model = new qx.data.Array(["item1","item2","item3"]);
	/// var menu = new qx.ui.mobile.dialog.Menu(model);
	/// menu.show();
	/// menu.addListener("changeSelection", function(evt){
	/// var selectedIndex = evt.getData().index;
	/// var selectedItem = evt.getData().item;
	/// }, this);
	/// </code>
	/// <para>This example creates a menu with several choosable items.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.mobile.dialog.Menu", OmitOptionalParameters = true, Export = false)]
    public partial class Menu : qx.ui.mobile.dialog.Dialog
    {
		#region Events

		/// <summary>
		/// <para>Fired when the selection is changed.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The label of the null value entry of the list. Only relevant
		/// when nullable property is set to true.</para>
		/// </summary>
		[JsProperty(Name = "clearButtonLabel", NativeField = true)]
		public string ClearButtonLabel { get; set; }

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
		/// <para>Indicates whether the menu should disappear when tap/click on blocker.</para>
		/// </summary>
		[JsProperty(Name = "hideOnBlockerClick", NativeField = true)]
		public bool HideOnBlockerClick { get; set; }

		/// <summary>
		/// <para>Defines if the menu has a null value in the list, which can be chosen
		/// by the user. The label</para>
		/// </summary>
		[JsProperty(Name = "nullable", NativeField = true)]
		public bool Nullable { get; set; }

		/// <summary>
		/// <para>Class which is assigned to selected items.
		/// Useful for re-styling your menu via LESS.</para>
		/// </summary>
		[JsProperty(Name = "selectedItemClass", NativeField = true)]
		public object SelectedItemClass { get; set; }

		/// <summary>
		/// <para>Class which is assigned to unselected items.
		/// Useful for re-styling your menu via LESS.</para>
		/// </summary>
		[JsProperty(Name = "unselectedItemClass", NativeField = true)]
		public object UnselectedItemClass { get; set; }

		#endregion Properties

		#region Methods

		public Menu() { throw new NotImplementedException(); }

		/// <param name="itemsModel">, the model which contains the choosable items of the menu.</param>
		/// <param name="anchor">The anchor widget for this item. If no anchor is available, the menu will be displayed modal and centered on screen.</param>
		public Menu(qx.data.Array itemsModel, qx.ui.mobile.core.Widget anchor) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property clearButtonLabel.</para>
		/// </summary>
		[JsMethod(Name = "getClearButtonLabel")]
		public string GetClearButtonLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property hideOnBlockerClick.</para>
		/// </summary>
		[JsMethod(Name = "getHideOnBlockerClick")]
		public bool GetHideOnBlockerClick() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property nullable.</para>
		/// </summary>
		[JsMethod(Name = "getNullable")]
		public bool GetNullable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selectedItemClass.</para>
		/// </summary>
		[JsMethod(Name = "getSelectedItemClass")]
		public object GetSelectedItemClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property unselectedItemClass.</para>
		/// </summary>
		[JsMethod(Name = "getUnselectedItemClass")]
		public object GetUnselectedItemClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property clearButtonLabel
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property clearButtonLabel.</param>
		[JsMethod(Name = "initClearButtonLabel")]
		public void InitClearButtonLabel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property hideOnBlockerClick
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property hideOnBlockerClick.</param>
		[JsMethod(Name = "initHideOnBlockerClick")]
		public void InitHideOnBlockerClick(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property nullable
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property nullable.</param>
		[JsMethod(Name = "initNullable")]
		public void InitNullable(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selectedItemClass
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selectedItemClass.</param>
		[JsMethod(Name = "initSelectedItemClass")]
		public void InitSelectedItemClass(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property unselectedItemClass
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property unselectedItemClass.</param>
		[JsMethod(Name = "initUnselectedItemClass")]
		public void InitUnselectedItemClass(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property hideOnBlockerClick equals true.</para>
		/// </summary>
		[JsMethod(Name = "isHideOnBlockerClick")]
		public void IsHideOnBlockerClick() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property nullable equals true.</para>
		/// </summary>
		[JsMethod(Name = "isNullable")]
		public void IsNullable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property clearButtonLabel.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetClearButtonLabel")]
		public void ResetClearButtonLabel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property hideOnBlockerClick.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetHideOnBlockerClick")]
		public void ResetHideOnBlockerClick() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property nullable.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetNullable")]
		public void ResetNullable() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selectedItemClass.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelectedItemClass")]
		public void ResetSelectedItemClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property unselectedItemClass.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetUnselectedItemClass")]
		public void ResetUnselectedItemClass() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property clearButtonLabel.</para>
		/// </summary>
		/// <param name="value">New value for property clearButtonLabel.</param>
		[JsMethod(Name = "setClearButtonLabel")]
		public void SetClearButtonLabel(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property hideOnBlockerClick.</para>
		/// </summary>
		/// <param name="value">New value for property hideOnBlockerClick.</param>
		[JsMethod(Name = "setHideOnBlockerClick")]
		public void SetHideOnBlockerClick(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the choosable items of the menu.</para>
		/// </summary>
		/// <param name="itemsModel">, the model of choosable items in the menu.</param>
		[JsMethod(Name = "setItems")]
		public void SetItems(qx.data.Array itemsModel) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property nullable.</para>
		/// </summary>
		/// <param name="value">New value for property nullable.</param>
		[JsMethod(Name = "setNullable")]
		public void SetNullable(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the pre-selected item.
		/// Set selectedIndex before model, because changing model triggers rendering of list.</para>
		/// </summary>
		/// <param name="selectedIndex">, the index of the item which should be pre-selected.</param>
		[JsMethod(Name = "setSelectedIndex")]
		public void SetSelectedIndex(double selectedIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selectedItemClass.</para>
		/// </summary>
		/// <param name="value">New value for property selectedItemClass.</param>
		[JsMethod(Name = "setSelectedItemClass")]
		public void SetSelectedItemClass(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property unselectedItemClass.</para>
		/// </summary>
		/// <param name="value">New value for property unselectedItemClass.</param>
		[JsMethod(Name = "setUnselectedItemClass")]
		public void SetUnselectedItemClass(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property hideOnBlockerClick.</para>
		/// </summary>
		[JsMethod(Name = "toggleHideOnBlockerClick")]
		public void ToggleHideOnBlockerClick() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property nullable.</para>
		/// </summary>
		[JsMethod(Name = "toggleNullable")]
		public void ToggleNullable() { throw new NotImplementedException(); }

		#endregion Methods
    }
}