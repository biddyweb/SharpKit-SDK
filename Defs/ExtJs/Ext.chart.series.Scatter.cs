//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart.series
{
    #region Scatter
    /// <inheritdocs />
    /// <summary>
    /// <p>Creates a Scatter Chart. The scatter plot is useful when trying to display more than two variables in the same visualization.
    /// These variables can be mapped into x, y coordinates and also to an element's radius/size, color, etc.
    /// As with all other series, the Scatter Series must be appended in the <em>series</em> Chart array configuration. See the Chart
    /// documentation for more information on creating charts. A typical configuration object for the scatter could be:</p>
    /// <pre><code>var store = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.data.JsonStore">Ext.data.JsonStore</see>', {
    /// fields: ['name', 'data1', 'data2', 'data3', 'data4', 'data5'],
    /// data: [
    /// { 'name': 'metric one',   'data1': 10, 'data2': 12, 'data3': 14, 'data4': 8,  'data5': 13 },
    /// { 'name': 'metric two',   'data1': 7,  'data2': 8,  'data3': 16, 'data4': 10, 'data5': 3  },
    /// { 'name': 'metric three', 'data1': 5,  'data2': 2,  'data3': 14, 'data4': 12, 'data5': 7  },
    /// { 'name': 'metric four',  'data1': 2,  'data2': 14, 'data3': 6,  'data4': 1,  'data5': 23 },
    /// { 'name': 'metric five',  'data1': 27, 'data2': 38, 'data3': 36, 'data4': 13, 'data5': 33 }
    /// ]
    /// });
    /// <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.chart.Chart">Ext.chart.Chart</see>', {
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),
    /// width: 500,
    /// height: 300,
    /// animate: true,
    /// theme:'Category2',
    /// store: store,
    /// axes: [{
    /// type: 'Numeric',
    /// position: 'left',
    /// fields: ['data2', 'data3'],
    /// title: 'Sample Values',
    /// grid: true,
    /// minimum: 0
    /// }, {
    /// type: 'Category',
    /// position: 'bottom',
    /// fields: ['name'],
    /// title: 'Sample Metrics'
    /// }],
    /// series: [{
    /// type: 'scatter',
    /// markerConfig: {
    /// radius: 5,
    /// size: 5
    /// },
    /// axis: 'left',
    /// xField: 'name',
    /// yField: 'data2'
    /// }, {
    /// type: 'scatter',
    /// markerConfig: {
    /// radius: 5,
    /// size: 5
    /// },
    /// axis: 'left',
    /// xField: 'name',
    /// yField: 'data3'
    /// }]
    /// });
    /// </code></pre>
    /// <p>In this configuration we add three different categories of scatter series. Each of them is bound to a different field of the same data store,
    /// <c>data1</c>, <c>data2</c> and <c>data3</c> respectively. All x-fields for the series must be the same field, in this case <c>name</c>.
    /// Each scatter series has a different styling configuration for markers, specified by the <c>markerConfig</c> object. Finally we set the left axis as
    /// axis to show the current values of the elements.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Scatter : Cartesian
    {
        /// <summary>
        /// The display style for the scatter series markers.
        /// </summary>
        public JsObject markerConfig;
        /// <summary>
        /// Append styling properties to this object for it to override theme properties.
        /// </summary>
        public JsObject style;
        /// <summary>
        /// Draws the series for the current chart.
        /// </summary>
        public void drawSeries(){}
        public Scatter(ScatterConfig config){}
        public Scatter(){}
        public Scatter(params object[] args){}
    }
    #endregion
    #region ScatterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ScatterConfig : CartesianConfig
    {
        /// <summary>
        /// The display style for the scatter series markers.
        /// </summary>
        public JsObject markerConfig;
        /// <summary>
        /// Append styling properties to this object for it to override theme properties.
        /// </summary>
        public JsObject style;
        public ScatterConfig(params object[] args){}
    }
    #endregion
    #region ScatterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ScatterEvents : CartesianEvents
    {
        public ScatterEvents(params object[] args){}
    }
    #endregion
}
