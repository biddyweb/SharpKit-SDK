// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.form;

namespace qx.ui.toolbar
{
    /// <summary>
	/// <para>Radio buttons are used to manage a single selection. Radio buttons only
	/// make sense used in a group of two or more of them. They are managed (connected)
	/// to a <see cref="qx.ui.form.RadioGroup"/> to handle the selection.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.toolbar.RadioButton", OmitOptionalParameters = true, Export = false)]
    public partial class RadioButton : qx.ui.toolbar.CheckBox, qx.ui.form.IModel, qx.ui.form.IRadioItem
    {
		#region Events

		/// <summary>
		/// <para>Fired when the model data changes</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>Model property for storing additional information for the including
		/// object. It can act as value property on form items for example.</para>
		/// <para>Be careful using that property as this is used for the
		/// <see cref="qx.ui.form.MModelSelection"/> it has some restrictions:</para>
		/// <list type="bullet">
		/// <item>Don&#8217;t use equal models in one widget using the
		/// <see cref="qx.ui.form.MModelSelection"/>.</item>
		/// </list
		/// <list type="bullet">
		/// <item>Avoid setting only some model properties if the widgets are added to
		/// a <see cref="qx.ui.form.MModelSelection"/> widge.</item>
		/// </list
		/// <para>Both restrictions result of the fact, that the set models are deputies
		/// for their widget.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public object Model { get; set; }

		#endregion Properties

		#region Methods

		public RadioButton() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the representative data for the item</para>
		/// </summary>
		/// <returns>The data.</returns>
		[JsMethod(Name = "getModel")]
		public object GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the representative data to null.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Set the representative data for the item.</para>
		/// </summary>
		/// <param name="value">The data.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}