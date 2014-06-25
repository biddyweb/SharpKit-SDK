//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.slider
{
    #region Tip
    /// <inheritdocs />
    /// <summary>
    /// <p>Simple plugin for using an <see cref="Ext.tip.Tip">Ext.tip.Tip</see> with a slider to show the slider value. In general this class is not created
    /// directly, instead pass the <see cref="Ext.slider.MultiConfig.useTips">Ext.slider.Multi.useTips</see> and <see cref="Ext.slider.MultiConfig.tipText">Ext.slider.Multi.tipText</see> configuration
    /// options to the slider directly.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.slider.Single">Ext.slider.Single</see>', {
    /// width: 214,
    /// minValue: 0,
    /// maxValue: 100,
    /// useTips: true,
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// <p>Optionally provide your own tip text by passing tipText:</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.slider.Single">Ext.slider.Single</see>', {
    /// width: 214,
    /// minValue: 0,
    /// maxValue: 100,
    /// useTips: true,
    /// tipText: function(thumb){
    /// return <see cref="Ext.String.format">Ext.String.format</see>('**{0}% complete**', thumb.value);
    /// },
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Tip : Ext.tip.Tip
    {
        /// <summary>
        /// Alignment configuration for the tip to the slider. See Ext.dom.Element.alignTo. Default
        /// values for alignment are provided by specifying the position config.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString align;
        /// <summary>
        /// Offsets for aligning the tip to the slider. See Ext.dom.Element.alignTo. Default values
        /// for offsets are provided by specifying the position config.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsArray offsets;
        /// <summary>
        /// Sets the position for where the tip will be displayed related to the thumb. This sets
        /// defaults for align and offsets configurations. If align or
        /// offsets configurations are specified, they will override the defaults defined
        /// by position.
        /// Defaults to: <c>For horizontal sliders, &quot;top&quot;, for vertical sliders, &quot;left&quot;</c>
        /// </summary>
        public JsString position;
        /// <summary>
        /// Used to create the text that appears in the Tip's body. By default this just returns the value of the Slider
        /// Thumb that the Tip is attached to. Override to customize.
        /// <p>This is a <i>template method</i>.
        /// a hook into the functionality of this class.
        /// Feel free to override it in child classes.</p>
        /// </summary>
        /// <param name="thumb"><p>The Thumb that the Tip is attached to</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The text to display in the tip</p>
        /// </div>
        /// </returns>
        protected virtual JsString getText(Thumb thumb){return null;}
        /// <summary>
        /// Called whenever a dragstart or drag event is received on the associated Thumb.
        /// Aligns the Tip with the Thumb's new position.
        /// </summary>
        /// <param name="slider"><p>The slider</p>
        /// </param>
        /// <param name="e"><p>The Event object</p>
        /// </param>
        /// <param name="thumb"><p>The thumb that the Tip is attached to</p>
        /// </param>
        private void onSlide(Multi slider, EventObject e, Thumb thumb){}
        public Tip(Ext.slider.TipConfig config){}
        public Tip(){}
        public Tip(params object[] args){}
    }
    #endregion
    #region TipConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TipConfig : Ext.tip.TipConfig
    {
        /// <summary>
        /// Alignment configuration for the tip to the slider. See Ext.dom.Element.alignTo. Default
        /// values for alignment are provided by specifying the position config.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsString align;
        /// <summary>
        /// Offsets for aligning the tip to the slider. See Ext.dom.Element.alignTo. Default values
        /// for offsets are provided by specifying the position config.
        /// Defaults to: <c>null</c>
        /// </summary>
        public JsArray offsets;
        /// <summary>
        /// Sets the position for where the tip will be displayed related to the thumb. This sets
        /// defaults for align and offsets configurations. If align or
        /// offsets configurations are specified, they will override the defaults defined
        /// by position.
        /// Defaults to: <c>For horizontal sliders, &quot;top&quot;, for vertical sliders, &quot;left&quot;</c>
        /// </summary>
        public JsString position;
        public TipConfig(params object[] args){}
    }
    #endregion
    #region TipEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TipEvents : Ext.tip.TipEvents
    {
        public TipEvents(params object[] args){}
    }
    #endregion
}
