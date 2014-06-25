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
    /// ChartLegend provides a legend for a chart.
    /// </summary>
    public partial class ChartLegend : Widget
    {
        [JsMethod(JsonInitializers=true)]
        public ChartLegend(){}
        /// <summary>
        /// Returns the default hash for the `styles` attribute.
        /// </summary>
        protected object _getDefaultStyles(){return null;}
        /// <summary>
        /// Gets the default values for series that use the utility. This method is used by
        /// the class' `styles` attribute's getter to get build default values.
        /// </summary>
        protected object _getPlotDefaults(){return null;}
        /// <summary>
        /// Destructor implementation ChartLegend class. Removes all items and the Graphic instance from the widget.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Background for the legend.
        /// </summary>
        public Rect background{get;set;}
        /// <summary>
        /// Reference to the `Chart` instance.
        /// </summary>
        public Chart chart{get;set;}
        /// <summary>
        /// The height of the legend. Depending on the implementation of the ChartLegend, this value is `readOnly`. By default, the legend is included in the layout of the `Chart` that
        /// it references. Under this circumstance, `height` is always `readOnly`. When the legend is rendered in its own dom element, the `readOnly` status is determined by the
        /// direction of the legend. If the `position` is `top` or `bottom` or the `direction` is `horizontal`, height is `readOnly`. If the position is `left` or `right` or the `direction`
        /// is `vertical`, height can be explicitly set. If height is not explicitly set, the height will be determined by the width of the legend's parent element.
        /// </summary>
        public Y_.DataType_.Number height{get;set;}
        /// <summary>
        /// Properties used to display and style the ChartLegend.  This attribute is inherited from `Renderer`. Below are the default values:
        /// <dl>
        /// <dt>gap</dt><dd>Distance, in pixels, between the `ChartLegend` instance and the chart's content. When `ChartLegend` is rendered within a `Chart` instance this value is applied.</dd>
        /// <dt>hAlign</dt><dd>Defines the horizontal alignment of the `items` in a `ChartLegend` rendered in a horizontal direction. This value is applied when the instance's `position` is set to top or bottom. This attribute can be set to left, center or right. The default value is center.</dd>
        /// <dt>vAlign</dt><dd>Defines the vertical alignment of the `items` in a `ChartLegend` rendered in vertical direction. This value is applied when the instance's `position` is set to left or right. The attribute can be set to top, middle or bottom. The default value is middle.</dd>
        /// <dt>item</dt><dd>Set of style properties applied to the `items` of the `ChartLegend`.
        /// <dl>
        /// <dt>hSpacing</dt><dd>Horizontal distance, in pixels, between legend `items`.</dd>
        /// <dt>vSpacing</dt><dd>Vertical distance, in pixels, between legend `items`.</dd>
        /// <dt>label</dt><dd>Properties for the text of an `item`.
        /// <dl>
        /// <dt>color</dt><dd>Color of the text. The default values is "#808080".</dd>
        /// <dt>fontSize</dt><dd>Font size for the text. The default value is "85%".</dd>
        /// </dl>
        /// </dd>
        /// <dt>marker</dt><dd>Properties for the `item` markers.
        /// <dl>
        /// <dt>width</dt><dd>Specifies the width of the markers.</dd>
        /// <dt>height</dt><dd>Specifies the height of the markers.</dd>
        /// </dl>
        /// </dd>
        /// </dl>
        /// </dd>
        /// <dt>background</dt><dd>Properties for the `ChartLegend` background.
        /// <dl>
        /// <dt>fill</dt><dd>Properties for the background fill.
        /// <dl>
        /// <dt>color</dt><dd>Color for the fill. The default value is "#faf9f2".</dd>
        /// </dl>
        /// </dd>
        /// <dt>border</dt><dd>Properties for the background border.
        /// <dl>
        /// <dt>color</dt><dd>Color for the border. The default value is "#dad8c9".</dd>
        /// <dt>weight</dt><dd>Weight of the border. The default values is 1.</dd>
        /// </dl>
        /// </dd>
        /// </dl>
        /// </dd>
        /// </dl>
        /// </summary>
        public object styles{get;set;}
        /// <summary>
        /// The width of the legend. Depending on the implementation of the ChartLegend, this value is `readOnly`. By default, the legend is included in the layout of the `Chart` that
        /// it references. Under this circumstance, `width` is always `readOnly`. When the legend is rendered in its own dom element, the `readOnly` status is determined by the
        /// direction of the legend. If the `position` is `left` or `right` or the `direction` is `vertical`, width is `readOnly`. If the position is `top` or `bottom` or the `direction`
        /// is `horizontal`, width can be explicitly set. If width is not explicitly set, the width will be determined by the width of the legend's parent element.
        /// </summary>
        public Y_.DataType_.Number width{get;set;}
        /// <summary>
        /// Indicates the x position of legend.
        /// </summary>
        public Y_.DataType_.Number x{get;private set;}
        /// <summary>
        /// Indicates the y position of legend.
        /// </summary>
        public Y_.DataType_.Number y{get;private set;}
    }
}
