// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.form.renderer
{
    /// <summary>
	/// <para>This interface defines the necessary features a form renderer should have.
	/// Keep in mind that all renderes has to be widgets.</para>
	/// </summary>
	public interface IFormRenderer
    {
		#region Methods

		/// <summary>
		/// <para>Adds a button the form renderer.</para>
		/// </summary>
		/// <param name="button">A button which should be added to the form.</param>
		/// <param name="options">The added additional data.</param>
		void AddButton(qx.ui.form.Button button, object options = null);

		/// <summary>
		/// <para>Add a group of form items with the corresponding names. The names should
		/// be displayed as hint for the user what to do with the form item.
		/// The title is optional and can be used as grouping for the given form
		/// items.</para>
		/// </summary>
		/// <param name="items">An array of form items to render.</param>
		/// <param name="names">An array of names for the form items.</param>
		/// <param name="title">A title of the group you are adding.</param>
		/// <param name="itemsOptions">The added additional data.</param>
		/// <param name="headerOptions">The options map as defined by the form for the current group header.</param>
		void AddItems(qx.ui.core.Widget items, string names, string title, JsArray itemsOptions = null, object headerOptions = null);

		#endregion Methods
    }
}