// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.data.controller
{
    /// <summary>
	/// <para>Objects, which are used as delegates for a data binding controller may
	/// implement any of the methods described in this interface. The delegate does
	/// not need implement all of the methods of this interface. If a method is not
	/// implemented the controller provides a default implementation.</para>
	/// <para>Note: This interface is meant to document the delegate but should not be
	/// listed in the implement key of a class unless all methods are
	/// really implemented.</para>
	/// </summary>
	public interface IControllerDelegate
    {
		#region Methods

		/// <summary>
		/// <para>Sets up the binding for the given item and index.</para>
		/// <para>For every property you want to bind, use
		/// <see cref="qx.data.controller.List.BindProperty"/> like this:
		/// 
		/// controller.bindProperty(&#8220;path.in.the.model&#8221;, &#8220;label&#8221;, options, item, id);
		/// </para>
		/// </summary>
		/// <param name="controller">The currently used controller.</param>
		/// <param name="item">The created and used item.</param>
		/// <param name="id">The id for the binding.</param>
		void BindItem(object controller, qx.ui.core.Widget item, double id);

		/// <summary>
		/// <para>Gives the user the opportunity to set individual styles and properties
		/// on the by the controller created widgets.</para>
		/// </summary>
		/// <param name="item">Item to modify.</param>
		void ConfigureItem(object item);

		/// <summary>
		/// <para>Creates an item which will be added to the target as child. Be sure to
		/// implement the <see cref="BindItem"/> function as well to get the needed
		/// properties bound.</para>
		/// </summary>
		/// <returns>A new created widget.</returns>
		qx.ui.core.Widget CreateItem();

		/// <summary>
		/// <para>Filter checks the current data and returns a boolean if the data should
		/// appear in the filtered data set or not.</para>
		/// <para>The filter currently works only with the <see cref="qx.data.controller.List"/>
		/// controller!</para>
		/// </summary>
		/// <param name="data">The data which will be checked.</param>
		/// <returns>True, if the data passes the filter, false otherwise.</returns>
		bool Filter(object data);

		#endregion Methods
    }
}