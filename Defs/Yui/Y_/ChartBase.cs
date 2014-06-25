//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// The ChartBase class is an abstract class used to create charts.
    /// </summary>
    public partial class ChartBase
    {
        [JsMethod(JsonInitializers=true)]
        public ChartBase(){}
        /// <summary>
        /// Returns an `Axis` instance by key reference. If the axis was explicitly set through the `axes` attribute,
        /// the key will be the same as the key used in the `axes` object. For default axes, the key for
        /// the category axis is the value of the `categoryKey` (`category`). For the value axis, the default
        /// key is `values`.
        /// </summary>
        public Axis getAxisByKey(object val){return null;}
        /// <summary>
        /// Returns the category axis for the chart.
        /// </summary>
        public Axis getCategoryAxis(){return null;}
        /// <summary>
        /// Returns a series instance by index or key value.
        /// </summary>
        public CartesianSeries getSeries(object val){return null;}
        /// <summary>
        /// Hides the default tooltip
        /// </summary>
        public void hideTooltip(){}
        /// <summary>
        /// Event listener for toggling the tooltip. If a tooltip is visible, hide it. If not, it
        /// will create and show a tooltip based on the event object.
        /// </summary>
        public void toggleTooltip(object e){}
        /// <summary>
        /// Reference to all the axes in the chart.
        /// </summary>
        public Y_.Array axesCollection{get;set;}
        /// <summary>
        /// Data used to generate the chart.
        /// </summary>
        public Y_.Array dataProvider{get;set;}
        /// <summary>
        /// Reference to graph instance.
        /// </summary>
        public Graph graph{get;set;}
        /// <summary>
        /// A collection of keys that map to the series axes. If no keys are set,
        /// they will be generated automatically depending on the data structure passed into
        /// the chart.
        /// </summary>
        public Y_.Array seriesKeys{get;set;}
        /// <summary>
        /// Reference to the default tooltip available for the chart.
        /// <p>Contains the following properties:</p>
        /// <dl>
        /// <dt>node</dt><dd>Reference to the actual dom node</dd>
        /// <dt>showEvent</dt><dd>Event that should trigger the tooltip</dd>
        /// <dt>hideEvent</dt><dd>Event that should trigger the removal of a tooltip (can be an event or an array of events)</dd>
        /// <dt>styles</dt><dd>A hash of style properties that will be applied to the tooltip node</dd>
        /// <dt>show</dt><dd>Indicates whether or not to show the tooltip</dd>
        /// <dt>markerEventHandler</dt><dd>Displays and hides tooltip based on marker events</dd>
        /// <dt>planarEventHandler</dt><dd>Displays and hides tooltip based on planar events</dd>
        /// <dt>markerLabelFunction</dt><dd>Reference to the function used to format a marker event triggered tooltip's text. The method contains
        /// the following arguments:
        /// <dl>
        /// <dt>categoryItem</dt><dd>An object containing the following:
        /// <dl>
        /// <dt>axis</dt><dd>The axis to which the category is bound.</dd>
        /// <dt>displayName</dt><dd>The display name set to the category (defaults to key if not provided).</dd>
        /// <dt>key</dt><dd>The key of the category.</dd>
        /// <dt>value</dt><dd>The value of the category.</dd>
        /// </dl>
        /// </dd>
        /// <dt>valueItem</dt><dd>An object containing the following:
        /// <dl>
        /// <dt>axis</dt><dd>The axis to which the item's series is bound.</dd>
        /// <dt>displayName</dt><dd>The display name of the series. (defaults to key if not provided)</dd>
        /// <dt>key</dt><dd>The key for the series.</dd>
        /// <dt>value</dt><dd>The value for the series item.</dd>
        /// </dl>
        /// </dd>
        /// <dt>itemIndex</dt><dd>The index of the item within the series.</dd>
        /// <dt>series</dt><dd> The `CartesianSeries` instance of the item.</dd>
        /// <dt>seriesIndex</dt><dd>The index of the series in the `seriesCollection`.</dd>
        /// </dl>
        /// The method returns an `HTMLElement` which is written into the DOM using `appendChild`. If you override this method and choose to return an html string, you
        /// will also need to override the tooltip's `setTextFunction` method to accept an html string.
        /// </dd>
        /// <dt>planarLabelFunction</dt><dd>Reference to the function used to format a planar event triggered tooltip's text
        /// <dl>
        /// <dt>categoryAxis</dt><dd> `CategoryAxis` Reference to the categoryAxis of the chart.
        /// <dt>valueItems</dt><dd>Array of objects for each series that has a data point in the coordinate plane of the event. Each object contains the following data:
        /// <dl>
        /// <dt>axis</dt><dd>The value axis of the series.</dd>
        /// <dt>key</dt><dd>The key for the series.</dd>
        /// <dt>value</dt><dd>The value for the series item.</dd>
        /// <dt>displayName</dt><dd>The display name of the series. (defaults to key if not provided)</dd>
        /// </dl>
        /// </dd>
        /// <dt>index</dt><dd>The index of the item within its series.</dd>
        /// <dt>seriesArray</dt><dd>Array of series instances for each value item.</dd>
        /// <dt>seriesIndex</dt><dd>The index of the series in the `seriesCollection`.</dd>
        /// </dl>
        /// </dd>
        /// </dl>
        /// The method returns an `HTMLElement` which is written into the DOM using `appendChild`. If you override this method and choose to return an html string, you
        /// will also need to override the tooltip's `setTextFunction` method to accept an html string.
        /// </dd>
        /// <dt>setTextFunction</dt><dd>Method that writes content returned from `planarLabelFunction` or `markerLabelFunction` into the the tooltip node.
        /// has the following signature:
        /// <dl>
        /// <dt>label</dt><dd>The `HTMLElement` that the content is to be added.</dd>
        /// <dt>val</dt><dd>The content to be rendered into tooltip. This can be a `String` or `HTMLElement`. If an HTML string is used, it will be rendered as a
        /// string.</dd>
        /// </dl>
        /// </dd>
        /// </dl>
        /// </summary>
        public object tooltip{get;set;}
    }
}
