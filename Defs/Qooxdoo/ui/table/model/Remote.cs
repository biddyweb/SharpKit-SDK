// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.table.model
{
    /// <summary>
	/// <para>A table model that loads its data from a backend.</para>
	/// <para>Only a subset of the available rows, those which are within or near the
	/// currently visible area, are loaded. If a quick scroll operation occurs,
	/// rows will soon be displayed using asynchronous loading in the background.
	/// All loaded data is managed through a cache which automatically removes
	/// the oldest used rows when it gets full.</para>
	/// <para>This class is abstract: The actual loading of row data must be done by
	/// subclasses.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.table.model.Remote", OmitOptionalParameters = true, Export = false)]
    public partial class Remote : qx.ui.table.model.Abstract
    {
		#region Properties

		/// <summary>
		/// <para>Whether to block remote requests for the row count while a request for
		/// the row count is pending. Row counts are requested at various times and
		/// from various parts of the code, resulting in numerous requests to the
		/// user-provided _loadRowCount() method, often while other requests are
		/// already pending. The default behavior now ignores requests to load a
		/// new row count if such a request is already pending. It is therefore now
		/// conceivable that the row count changes between an initial request for
		/// the row count and a later (ignored) request. Since the chance of this
		/// is low, the desirability of reducing the server requests outweighs the
		/// slight possibility of an altered count (which will, by the way, be
		/// detected soon thereafter upon the next request for the row count). If
		/// the old behavior is desired, set this property to false.</para>
		/// </summary>
		[JsProperty(Name = "blockConcurrentLoadRowCount", NativeField = true)]
		public bool BlockConcurrentLoadRowCount { get; set; }

		/// <summary>
		/// <para>The number of rows that are stored in one cache block.</para>
		/// </summary>
		[JsProperty(Name = "blockSize", NativeField = true)]
		public double BlockSize { get; set; }

		/// <summary>
		/// <para>Whether to clear the cache when some rows are removed.
		/// If true the rows are removed locally in the cache.</para>
		/// </summary>
		[JsProperty(Name = "clearCacheOnRemove", NativeField = true)]
		public bool ClearCacheOnRemove { get; set; }

		/// <summary>
		/// <para>The maximum number of row blocks kept in the cache.</para>
		/// </summary>
		[JsProperty(Name = "maxCachedBlockCount", NativeField = true)]
		public double MaxCachedBlockCount { get; set; }

		#endregion Properties

		#region Methods

		public Remote() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the cache.</para>
		/// </summary>
		[JsMethod(Name = "clearCache")]
		public void ClearCache() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockConcurrentLoadRowCount.</para>
		/// </summary>
		[JsMethod(Name = "getBlockConcurrentLoadRowCount")]
		public bool GetBlockConcurrentLoadRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property blockSize.</para>
		/// </summary>
		[JsMethod(Name = "getBlockSize")]
		public double GetBlockSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the current state of the cache.</para>
		/// <para>Do not change anything in the returned data. This breaks the model state.
		/// Use this method only together with <see cref="RestoreCacheContent"/> for backing
		/// up state for a later restore.</para>
		/// </summary>
		/// <returns>the current cache state.</returns>
		[JsMethod(Name = "getCacheContent")]
		public object GetCacheContent() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property clearCacheOnRemove.</para>
		/// </summary>
		[JsMethod(Name = "getClearCacheOnRemove")]
		public bool GetClearCacheOnRemove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maxCachedBlockCount.</para>
		/// </summary>
		[JsMethod(Name = "getMaxCachedBlockCount")]
		public double GetMaxCachedBlockCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the number of rows in the model.</para>
		/// </summary>
		/// <returns>the number of rows.</returns>
		[JsMethod(Name = "getRowCount")]
		public double GetRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>See overridden method for details.</para>
		/// </summary>
		/// <param name="rowIndex">the model index of the row.</param>
		/// <returns>Map containing a value for each column.</returns>
		[JsMethod(Name = "getRowData")]
		public object GetRowData(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the column index the model is sorted by. If the model is not sorted
		/// -1 is returned.</para>
		/// </summary>
		/// <returns>the column index the model is sorted by.</returns>
		[JsMethod(Name = "getSortColumnIndex")]
		public double GetSortColumnIndex() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">the index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <returns>The value of the cell.</returns>
		[JsMethod(Name = "getValue")]
		public object GetValue(double columnIndex, double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockConcurrentLoadRowCount
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockConcurrentLoadRowCount.</param>
		[JsMethod(Name = "initBlockConcurrentLoadRowCount")]
		public void InitBlockConcurrentLoadRowCount(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property blockSize
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property blockSize.</param>
		[JsMethod(Name = "initBlockSize")]
		public void InitBlockSize(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property clearCacheOnRemove
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property clearCacheOnRemove.</param>
		[JsMethod(Name = "initClearCacheOnRemove")]
		public void InitClearCacheOnRemove(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maxCachedBlockCount
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maxCachedBlockCount.</param>
		[JsMethod(Name = "initMaxCachedBlockCount")]
		public void InitMaxCachedBlockCount(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property blockConcurrentLoadRowCount equals true.</para>
		/// </summary>
		[JsMethod(Name = "isBlockConcurrentLoadRowCount")]
		public void IsBlockConcurrentLoadRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property clearCacheOnRemove equals true.</para>
		/// </summary>
		[JsMethod(Name = "isClearCacheOnRemove")]
		public void IsClearCacheOnRemove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is editable.</returns>
		[JsMethod(Name = "isColumnEditable")]
		public bool IsColumnEditable(double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether a column is sortable.</para>
		/// </summary>
		/// <param name="columnIndex">the column to check.</param>
		/// <returns>whether the column is sortable.</returns>
		[JsMethod(Name = "isColumnSortable")]
		public bool IsColumnSortable(double columnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the model is sorted ascending.</para>
		/// </summary>
		/// <returns>whether the model is sorted ascending.</returns>
		[JsMethod(Name = "isSortAscending")]
		public bool IsSortAscending() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Iterates through all cached rows.</para>
		/// <para>The iterator will be called for each cached row with two parameters: The row
		/// index of the current row (Integer) and the row data of that row (var[]). If
		/// the iterator returns something this will be used as new row data.</para>
		/// <para>The iterator is called in the same order as the rows are in the model
		/// (the row index is always ascending).</para>
		/// </summary>
		/// <param name="iterator">The iterator function to call.</param>
		/// <param name="objectx">context of the iterator</param>
		[JsMethod(Name = "iterateCachedRows")]
		public void IterateCachedRows(Action<object> iterator, object objectx) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Prefetches some rows. This is a hint to the model that the specified rows
		/// will be read soon.</para>
		/// </summary>
		/// <param name="firstRowIndex">the index of first row.</param>
		/// <param name="lastRowIndex">the index of last row.</param>
		[JsMethod(Name = "prefetchRows")]
		public void PrefetchRows(double firstRowIndex, double lastRowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Reloads the model and clears the local cache.</para>
		/// </summary>
		[JsMethod(Name = "reloadData")]
		public void ReloadData() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes a row from the model.</para>
		/// </summary>
		/// <param name="rowIndex">the index of the row to remove.</param>
		[JsMethod(Name = "removeRow")]
		public void RemoveRow(double rowIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockConcurrentLoadRowCount.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockConcurrentLoadRowCount")]
		public void ResetBlockConcurrentLoadRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property blockSize.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetBlockSize")]
		public void ResetBlockSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property clearCacheOnRemove.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetClearCacheOnRemove")]
		public void ResetClearCacheOnRemove() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maxCachedBlockCount.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaxCachedBlockCount")]
		public void ResetMaxCachedBlockCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Restores a cache state created by <see cref="GetCacheContent"/>.</para>
		/// </summary>
		/// <param name="cacheContent">An old cache state.</param>
		[JsMethod(Name = "restoreCacheContent")]
		public void RestoreCacheContent(object cacheContent) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockConcurrentLoadRowCount.</para>
		/// </summary>
		/// <param name="value">New value for property blockConcurrentLoadRowCount.</param>
		[JsMethod(Name = "setBlockConcurrentLoadRowCount")]
		public void SetBlockConcurrentLoadRowCount(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property blockSize.</para>
		/// </summary>
		/// <param name="value">New value for property blockSize.</param>
		[JsMethod(Name = "setBlockSize")]
		public void SetBlockSize(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property clearCacheOnRemove.</para>
		/// </summary>
		/// <param name="value">New value for property clearCacheOnRemove.</param>
		[JsMethod(Name = "setClearCacheOnRemove")]
		public void SetClearCacheOnRemove(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a column is editable.</para>
		/// </summary>
		/// <param name="columnIndex">the column of which to set the editable state.</param>
		/// <param name="editable">whether the column should be editable.</param>
		[JsMethod(Name = "setColumnEditable")]
		public void SetColumnEditable(double columnIndex, bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets whether a column is sortable.</para>
		/// </summary>
		/// <param name="columnIndex">the column of which to set the sortable state.</param>
		/// <param name="sortable">whether the column should be sortable.</param>
		[JsMethod(Name = "setColumnSortable")]
		public void SetColumnSortable(double columnIndex, bool sortable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets all columns editable or not editable.</para>
		/// </summary>
		/// <param name="editable">whether all columns are editable.</param>
		[JsMethod(Name = "setEditable")]
		public void SetEditable(bool editable) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maxCachedBlockCount.</para>
		/// </summary>
		/// <param name="value">New value for property maxCachedBlockCount.</param>
		[JsMethod(Name = "setMaxCachedBlockCount")]
		public void SetMaxCachedBlockCount(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the direction of the sorting without sorting the data.
		/// Use this method, if you want to set the direction of sorting, (e.g
		/// for appearance reason), but the sorting of the data will be done in
		/// another step.</para>
		/// </summary>
		/// <param name="sortAscending">whether the sorting direction is ascending (true) or not (false).</param>
		[JsMethod(Name = "setSortAscendingWithoutSortingData")]
		public void SetSortAscendingWithoutSortingData(bool sortAscending) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the sorted column without sorting the data.
		/// Use this method, if you want to mark the column as the sorted column,
		/// (e.g. for appearance reason), but the sorting of the data will be done
		/// in another step.</para>
		/// </summary>
		/// <param name="sortColumnIndex">the column, which shall be marked as the sorted column.</param>
		[JsMethod(Name = "setSortColumnIndexWithoutSortingData")]
		public void SetSortColumnIndexWithoutSortingData(double sortColumnIndex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets a cell value by column index.</para>
		/// </summary>
		/// <param name="columnIndex">The index of the column.</param>
		/// <param name="rowIndex">the index of the row.</param>
		/// <param name="value">The new value.</param>
		[JsMethod(Name = "setValue")]
		public void SetValue(double columnIndex, double rowIndex, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sorts the model by a column.</para>
		/// </summary>
		/// <param name="columnIndex">the column to sort by.</param>
		/// <param name="ascending">whether to sort ascending.</param>
		[JsMethod(Name = "sortByColumn")]
		public void SortByColumn(double columnIndex, bool ascending) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property blockConcurrentLoadRowCount.</para>
		/// </summary>
		[JsMethod(Name = "toggleBlockConcurrentLoadRowCount")]
		public void ToggleBlockConcurrentLoadRowCount() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property clearCacheOnRemove.</para>
		/// </summary>
		[JsMethod(Name = "toggleClearCacheOnRemove")]
		public void ToggleClearCacheOnRemove() { throw new NotImplementedException(); }

		#endregion Methods
    }
}