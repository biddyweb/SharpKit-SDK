// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form
{
    /// <summary>
	/// <para>Form interface for all form widgets which have boolean as their primary
	/// data type like a colorchooser.</para>
	/// </summary>
	public interface IColorForm
    {
		#region Events

		/// <summary>
		/// <para>Fired when the value was modified</para>
		/// </summary>
		event Action<qx.eventx.type.Data> OnChangeValue;

		#endregion Events

		#region Methods

		/// <summary>
		/// <para>The element&#8217;s user set value.</para>
		/// </summary>
		/// <returns>The value.</returns>
		string GetValue();

		/// <summary>
		/// <para>Resets the element&#8217;s value to its initial value.</para>
		/// </summary>
		void ResetValue();

		/// <summary>
		/// <para>Sets the element&#8217;s value.</para>
		/// </summary>
		/// <param name="value">The new value of the element.</param>
		void SetValue(string value);

		#endregion Methods
    }
}