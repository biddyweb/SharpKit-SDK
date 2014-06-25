//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region Point
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents a 2D point with x and y properties, useful for comparison and instantiation
    /// from an event:</p>
    /// <pre><code>var point = <see cref="Ext.util.Point.fromEvent">Ext.util.Point.fromEvent</see>(e);
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Point : Region
    {
        /// <summary>
        /// Creates a point from two coordinates.
        /// </summary>
        /// <param name="x"><p>X coordinate.</p>
        /// </param>
        /// <param name="y"><p>Y coordinate.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Point(JsNumber x, JsNumber y){}
        /// <summary>
        /// Whether the given point is not away from this point within the given threshold amount.
        /// </summary>
        /// <param name="p"><p>The point to check with, either an instance
        /// of <see cref="Ext.util.Point">Ext.util.Point</see> or an object with left and top properties</p>
        /// </param>
        /// <param name="threshold"><p>Can be either an object with x and y properties or a number</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isWithin(object p, object threshold){return false;}
        /// <summary>
        /// Compare this point with another point when the x and y values of both points are rounded. E.g:
        /// [100.3,199.8] will equals to [100, 200]
        /// </summary>
        /// <param name="p"><p>The point to compare with, either an instance
        /// of <see cref="Ext.util.Point">Ext.util.Point</see> or an object with x and y properties</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool roundedEquals(object p){return false;}
        /// <summary>
        /// Returns a human-eye-friendly string that represents this point,
        /// useful for debugging
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public JsString toString(){return null;}
        /// <summary>
        /// Alias for translateBy
        /// Translate this region by the given offset amount
        /// </summary>
        /// <param name="x"><p>Object containing the <c>x</c> and <c>y</c> properties.
        /// Or the x value is using the two argument form.</p>
        /// </param>
        /// <param name="y"><p>The y value unless using an Offset object.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.Region">Ext.util.Region</see></span><div><p>this This Region</p>
        /// </div>
        /// </returns>
        public Region translate(object x, JsNumber y){return null;}
        /// <summary>
        /// Returns a new instance of Ext.util.Point base on the pageX / pageY values of the given event
        /// </summary>
        /// <param name="e"><p>The event</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.util.Point">Ext.util.Point</see></span><div>
        /// </div>
        /// </returns>
        public static Point fromEvent(object e){return null;}
        public Point(PointConfig config){}
        public Point(){}
        public Point(params object[] args){}
    }
    #endregion
    #region PointConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PointConfig : RegionConfig
    {
        public PointConfig(params object[] args){}
    }
    #endregion
    #region PointEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class PointEvents : RegionEvents
    {
        public PointEvents(params object[] args){}
    }
    #endregion
}
