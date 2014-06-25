//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region TextMetrics
    /// <inheritdocs />
    /// <summary>
    /// <p>Provides precise pixel measurements for blocks of text so that you can determine exactly how high and
    /// wide, in pixels, a given block of text will be. Note that when measuring text, it should be plain text and
    /// should not contain any HTML, otherwise it may not be measured correctly.</p>
    /// <p>The measurement works by copying the relevant CSS styles that can affect the font related display,
    /// then checking the size of an element that is auto-sized. Note that if the text is multi-lined, you must
    /// provide a <strong>fixed width</strong> when doing the measurement.</p>
    /// <p>If multiple measurements are being done on the same element, you create a new instance to initialize
    /// to avoid the overhead of copying the styles to the element repeatedly.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class TextMetrics : Ext.Base
    {
        /// <summary>
        /// Creates new TextMetrics.
        /// </summary>
        /// <param name="bindTo"><p>The element or its ID to bind to.</p>
        /// </param>
        /// <param name="fixedWidth"><p>A fixed width to apply to the measuring element.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public TextMetrics(object bindTo, object fixedWidth=null){}
        /// <summary>
        /// Binds this TextMetrics instance to a new element
        /// </summary>
        /// <param name="el"><p>The element or its ID.</p>
        /// </param>
        public void bind(object el){}
        /// <summary>
        /// Returns the measured height of the specified text
        /// </summary>
        /// <param name="text"><p>The text to measure</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>height The height in pixels</p>
        /// </div>
        /// </returns>
        public JsNumber getHeight(JsString text){return null;}
        /// <summary>
        /// Returns the size of the specified text based on the internal element's style and width properties
        /// </summary>
        /// <param name="text"><p>The text to measure</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>An object containing the text's size <c>{width: (width), height: (height)}</c></p>
        /// </div>
        /// </returns>
        public object getSize(JsString text){return null;}
        /// <summary>
        /// Returns the measured width of the specified text
        /// </summary>
        /// <param name="text"><p>The text to measure</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>width The width in pixels</p>
        /// </div>
        /// </returns>
        public JsNumber getWidth(JsString text){return null;}
        /// <summary>
        /// Sets a fixed width on the internal measurement element.  If the text will be multiline, you have
        /// to set a fixed width in order to accurately measure the text height.
        /// </summary>
        /// <param name="width"><p>The width to set on the element</p>
        /// </param>
        public void setFixedWidth(JsNumber width){}
        /// <summary>
        /// Measures the size of the specified text
        /// </summary>
        /// <param name="el"><p>The element, dom node or id from which to copy existing CSS styles
        /// that can affect the size of the rendered text</p>
        /// </param>
        /// <param name="text"><p>The text to measure</p>
        /// </param>
        /// <param name="fixedWidth"><p>If the text will be multiline, you have to set a fixed width
        /// in order to accurately measure the text height</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>An object containing the text's size <c>{width: (width), height: (height)}</c></p>
        /// </div>
        /// </returns>
        public static object measure(object el, JsString text, object fixedWidth=null){return null;}
        public TextMetrics(TextMetricsConfig config){}
        public TextMetrics(){}
        public TextMetrics(params object[] args){}
    }
    #endregion
    #region TextMetricsConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TextMetricsConfig : Ext.BaseConfig
    {
        public TextMetricsConfig(params object[] args){}
    }
    #endregion
    #region TextMetricsEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TextMetricsEvents : Ext.BaseEvents
    {
        public TextMetricsEvents(params object[] args){}
    }
    #endregion
}
