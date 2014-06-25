// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.treevirtual
{
    /// <summary>
	/// <para>A data row renderer for a simple tree row</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.treevirtual.SimpleTreeDataRowRenderer", OmitOptionalParameters = true, Export = false)]
    public partial class SimpleTreeDataRowRenderer : qx.ui.table.rowrenderer.Default
    {
		#region Methods

		public SimpleTreeDataRowRenderer() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Updates a data row.</para>
		/// <para>The rowInfo map contains the following properties:
		/// <list type="bullet">
		/// <item>rowData (var): contains the row data for the row.
		/// The kind of this object depends on the table model, see
		/// <see cref="ITableModel.GetRowData()"/></item>
		/// <item>row (int): the model index of the row.</item>
		/// <item>selected (boolean): whether a cell in this row is selected.</item>
		/// <item>focusedRow (boolean): whether the focused cell is in this row.</item>
		/// <item>table (qx.ui.table.Table): the table the row belongs to.</item>
		/// </list</para>
		/// </summary>
		/// <param name="rowInfo">A map containing the information about the row to update.</param>
		/// <param name="rowElement">the DOM element that renders the data row.</param>
		[JsMethod(Name = "updateDataRowElement")]
		public void UpdateDataRowElement(object rowInfo, qx.html.Element rowElement) { throw new NotImplementedException(); }

		#endregion Methods
    }
}