// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.virtualx.core
{
    /// <summary>
	/// <para>EXPERIMENTAL!</para>
	/// <para>The Pane provides a window of a larger virtual grid.</para>
	/// <para>The actual rendering is performed by one or several layers (<see cref="ILayer"/>.
	/// The pane computes, which cells of the virtual area is visible and instructs
	/// the layers to render these cells.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.virtual.core.Pane", OmitOptionalParameters = true, Export = false)]
    public partial class Pane : qx.ui.core.Widget
    {
		#region Events

		/// <summary>
		/// <para>Fired if a cell is clicked.</para>
		/// </summary>
		public event Action<qx.ui.virtualx.core.CellEvent> OnCellClick;

		/// <summary>
		/// <para>Fired if a cell is right-clicked.</para>
		/// </summary>
		public event Action<qx.ui.virtualx.core.CellEvent> OnCellContextmenu;

		/// <summary>
		/// <para>Fired if a cell is double-clicked.</para>
		/// </summary>
		public event Action<qx.ui.virtualx.core.CellEvent> OnCellDblclick;

		/// <summary>
		/// <para>Fired if the pane is scrolled horizontally.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnScrollX;

		/// <summary>
		/// <para>Fired if the pane is scrolled vertically.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnScrollY;

		/// <summary>
		/// <para>Fired on resize of either the container or the (virtual) content.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnUpdate;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The item&#8217;s preferred height.</para>
		/// <para>The computed height may differ from the given height due to
		/// stretching. Also take a look at the related properties
		/// <see cref="MinHeight"/> and <see cref="MaxHeight"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "height", NativeField = true)]
		public double Height { get; set; }

		/// <summary>
		/// <para>The LayoutItem&#8216;s preferred width.</para>
		/// <para>The computed width may differ from the given width due to
		/// stretching. Also take a look at the related properties
		/// <see cref="MinWidth"/> and <see cref="MaxWidth"/>.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "width", NativeField = true)]
		public double Width { get; set; }

		#endregion Properties

		#region Methods

		public Pane() { throw new NotImplementedException(); }

		/// <param name="rowCount">The number of rows of the virtual grid.</param>
		/// <param name="columnCount">The number of columns of the virtual grid.</param>
		/// <param name="cellHeight">The default cell height.</param>
		/// <param name="cellWidth">The default cell width.</param>
		public Pane(double rowCount = 0, double columnCount = 0, double cellHeight = 10, double cellWidth = 10) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a layer to the layer container.</para>
		/// </summary>
		/// <param name="layer">The layer to add.</param>
		[JsMethod(Name = "addLayer")]
		public void AddLayer(ILayer layer) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Schedule a full update on all visible layers.</para>
		/// </summary>
		[JsMethod(Name = "fullUpdate")]
		public void FullUpdate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the grid cell at the given absolute document coordinates. This method
		/// can be used to convert the mouse position returned by
		/// <see cref="qx.event.type.Mouse.GetDocumentLeft"/> and
		/// <see cref="qx.event.type.Mouse.GetDocumentLeft"/> into cell coordinates.</para>
		/// </summary>
		/// <param name="documentX">The x coordinate relative to the viewport origin.</param>
		/// <param name="documentY">The y coordinate relative to the viewport origin.</param>
		/// <returns>A map containing the row and column of the found cell. If the coordinate is outside of the pane&#8217;s bounds or there is no cell at the coordinate null is returned.</returns>
		[JsMethod(Name = "getCellAtPosition")]
		public object GetCellAtPosition(double documentX, double documentY) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns an array containing the layer container.</para>
		/// </summary>
		/// <returns>The layer container array.</returns>
		[JsMethod(Name = "getChildren")]
		public object GetChildren() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the axis object, which defines the column numbers and the column sizes.</para>
		/// </summary>
		/// <returns>The column configuration.</returns>
		[JsMethod(Name = "getColumnConfig")]
		public Axis GetColumnConfig() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of all layers.</para>
		/// </summary>
		/// <returns>List of the pane&#8217;s layers.</returns>
		[JsMethod(Name = "getLayers")]
		public ILayer GetLayers() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the axis object, which defines the row numbers and the row sizes.</para>
		/// </summary>
		/// <returns>The row configuration.</returns>
		[JsMethod(Name = "getRowConfig")]
		public Axis GetRowConfig() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The maximum horizontal scroll position.</para>
		/// </summary>
		/// <returns>Maximum horizontal scroll position.</returns>
		[JsMethod(Name = "getScrollMaxX")]
		public double GetScrollMaxX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The maximum vertical scroll position.</para>
		/// </summary>
		/// <returns>Maximum vertical scroll position.</returns>
		[JsMethod(Name = "getScrollMaxY")]
		public double GetScrollMaxY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>The (virtual) size of the content.</para>
		/// </summary>
		/// <returns>Size of the content (keys: width and height).</returns>
		[JsMethod(Name = "getScrollSize")]
		public object GetScrollSize() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the horizontal scroll offset.</para>
		/// </summary>
		/// <returns>The horizontal scroll offset.</returns>
		[JsMethod(Name = "getScrollX")]
		public double GetScrollX() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the vertical scroll offset.</para>
		/// </summary>
		/// <returns>The vertical scroll offset.</returns>
		[JsMethod(Name = "getScrollY")]
		public double GetScrollY() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get a list of all visible layers.</para>
		/// </summary>
		/// <returns>List of the pane&#8217;s visible layers.</returns>
		[JsMethod(Name = "getVisibleLayers")]
		public ILayer GetVisibleLayers() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a full update is scheduled.</para>
		/// </summary>
		/// <returns>Whether a full update is scheduled.</returns>
		[JsMethod(Name = "isUpdatePending")]
		public bool IsUpdatePending() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Increase the layers width beyond the needed width to improve
		/// horizontal scrolling. The layers are only resized if invisible parts
		/// left/right of the pane window are smaller than minLeft/minRight.</para>
		/// </summary>
		/// <param name="minLeft">Only prefetch if the invisible part left of the pane window if smaller than this (pixel) value.</param>
		/// <param name="maxLeft">The amount of pixel the layers should reach left of the pane window.</param>
		/// <param name="minRight">Only prefetch if the invisible part right of the pane window if smaller than this (pixel) value.</param>
		/// <param name="maxRight">The amount of pixel the layers should reach right of the pane window.</param>
		[JsMethod(Name = "prefetchX")]
		public void PrefetchX(double minLeft, double maxLeft, double minRight, double maxRight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Increase the layers height beyond the needed height to improve
		/// vertical scrolling. The layers are only resized if invisible parts
		/// above/below the pane window are smaller than minAbove/minBelow.</para>
		/// </summary>
		/// <param name="minAbove">Only prefetch if the invisible part above the pane window if smaller than this (pixel) value.</param>
		/// <param name="maxAbove">The amount of pixel the layers should reach above the pane window.</param>
		/// <param name="minBelow">Only prefetch if the invisible part below the pane window if smaller than this (pixel) value.</param>
		/// <param name="maxBelow">The amount of pixel the layers should reach below the pane window.</param>
		[JsMethod(Name = "prefetchY")]
		public void PrefetchY(double minAbove, double maxAbove, double minBelow, double maxBelow) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls a grid cell into the visible area of the pane.</para>
		/// </summary>
		/// <param name="column">The cell&#8217;s column index.</param>
		/// <param name="row">The cell&#8217;s row index.</param>
		[JsMethod(Name = "scrollCellIntoView")]
		public void ScrollCellIntoView(double column, double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls a column into the visible area of the pane.</para>
		/// </summary>
		/// <param name="column">The column&#8217;s index.</param>
		[JsMethod(Name = "scrollColumnIntoView")]
		public void ScrollColumnIntoView(double column) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls a row into the visible area of the pane.</para>
		/// </summary>
		/// <param name="row">The row&#8217;s index.</param>
		[JsMethod(Name = "scrollRowIntoView")]
		public void ScrollRowIntoView(double row) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the content to the given top coordinate.</para>
		/// </summary>
		/// <param name="value">The horizontal position to scroll to.</param>
		[JsMethod(Name = "setScrollX")]
		public void SetScrollX(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls the content to the given left coordinate.</para>
		/// </summary>
		/// <param name="value">The vertical position to scroll to.</param>
		[JsMethod(Name = "setScrollY")]
		public void SetScrollY(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called during the flush of the
		/// <see cref="qx.ui.core.queue.Widget widget queue"/>.</para>
		/// </summary>
		/// <param name="jobs">A map of jobs.</param>
		[JsMethod(Name = "syncWidget")]
		public void SyncWidget(object jobs) { throw new NotImplementedException(); }

		#endregion Methods
    }
}