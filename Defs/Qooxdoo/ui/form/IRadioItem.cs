// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>Each object, which should be managed by a <see cref="RadioGroup"/> have to
	/// implement this interface.</para>
	/// </summary>
	public interface IRadioItem
    {
		#region Events

		/// <summary>
		/// <para>Fired when the item was checked or unchecked</para>
		/// </summary>
		event Action<qx.eventx.type.Data> OnChangeValue;

		#endregion Events

		#region Methods

		/// <summary>
		/// <para>Get the radiogroup, which manages this item</para>
		/// </summary>
		/// <returns>The radiogroup, which manages the item.</returns>
		qx.ui.form.RadioGroup GetGroup();

		/// <summary>
		/// <para>Get whether the item is checked</para>
		/// </summary>
		/// <returns>whether the item it checked</returns>
		bool GetValue();

		/// <summary>
		/// <para>Set the radiogroup, which manages this item</para>
		/// </summary>
		/// <param name="value">The radiogroup, which should manage the item.</param>
		void SetGroup(qx.ui.form.RadioGroup value);

		/// <summary>
		/// <para>Set whether the item is checked</para>
		/// </summary>
		/// <param name="value">whether the item should be checked</param>
		void SetValue(bool value);

		#endregion Methods
    }
}