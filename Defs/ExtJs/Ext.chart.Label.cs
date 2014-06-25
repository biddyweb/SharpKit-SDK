//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart
{
    #region Label
    /// <summary>
    /// <p>Labels is a mixin to the Series class. Labels methods are implemented
    /// in each of the Series (Pie, Bar, etc) for label creation and placement.</p>
    /// <p>The methods implemented by the Series are:</p>
    /// <ul>
    /// <li><p><strong><c>onCreateLabel(storeItem, item, i, display)</c></strong> Called each time a new label is created.
    /// The arguments of the method are:</p>
    /// <ul>
    /// <li><em><c>storeItem</c></em> The element of the store that is related to the label sprite.</li>
    /// <li><em><c>item</c></em> The item related to the label sprite. An item is an object containing the position of the shape
    /// used to describe the visualization and also pointing to the actual shape (circle, rectangle, path, etc).</li>
    /// <li><em><c>i</c></em> The index of the element created (i.e the first created label, second created label, etc)</li>
    /// <li><em><c>display</c></em> The display type. May be <b>false</b> if the label is hidden</li>
    /// </ul>
    /// </li>
    /// <li><p><strong><c>onPlaceLabel(label, storeItem, item, i, display, animate)</c></strong> Called for updating the position of the label.
    /// The arguments of the method are:</p>
    /// <ul>
    /// <li><em><c>label</c></em> The sprite label.</li></ul></li>
    /// <li><em><c>storeItem</c></em> The element of the store that is related to the label sprite</li>
    /// <li><em><c>item</c></em> The item related to the label sprite. An item is an object containing the position of the shape
    /// used to describe the visualization and also pointing to the actual shape (circle, rectangle, path, etc).</li>
    /// <li><em><c>i</c></em> The index of the element to be updated (i.e. whether it is the first, second, third from the labelGroup)</li>
    /// <li><em><c>display</c></em> The display type. May be <b>false</b> if the label is hidden.</li>
    /// <li><em><c>animate</c></em> A boolean value to set or unset animations for the labels.</li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface Label
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        JsString @className{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject configMap{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        bool isInstance{get;set;}
        /// <summary>
        /// Get the reference to the current class from which this object was instantiated. Unlike statics,
        /// this.self is scope-dependent and it's meant to be used for dynamic inheritance. See statics
        /// for a detailed comparison
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// alert(this.self.speciesName); // dependent on 'this'
        /// },
        /// clone: function() {
        /// return new this.self();
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'         // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// }
        /// });
        /// var cat = new My.Cat();                     // alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard();     // alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));             // alerts 'My.SnowLeopard'
        /// </code>
        /// </summary>
        Class self{get;set;}
    }
    #endregion
    #region LabelConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LabelConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Object with the following properties:
        /// <li><p><strong>display</strong> : String</p>
        /// <p>Specifies the presence and position of labels for each pie slice. Either "rotate", "middle", "insideStart",
        /// "insideEnd", "outside", "over", "under", or "none" to prevent label rendering.
        /// Default value: 'none'.</p></li>
        /// <li><p><strong>color</strong> : String</p>
        /// <p>The color of the label text.
        /// Default value: '#000' (black).</p></li>
        /// <li><p><strong>contrast</strong> : Boolean</p>
        /// <p>True to render the label in contrasting color with the backround.
        /// Default value: false.</p></li>
        /// <li><p><strong>field</strong> : String</p>
        /// <p>The name of the field to be displayed in the label.
        /// Default value: 'name'.</p></li>
        /// <li><p><strong>minMargin</strong> : Number</p>
        /// <p>Specifies the minimum distance from a label to the origin of the visualization.
        /// This parameter is useful when using PieSeries width variable pie slice lengths.
        /// Default value: 50.</p></li>
        /// <li><p><strong>font</strong> : String</p>
        /// <p>The font used for the labels.
        /// Default value: "11px Helvetica, sans-serif".</p></li>
        /// <li><p><strong>orientation</strong> : String</p>
        /// <p>Either "horizontal" or "vertical".
        /// Dafault value: "horizontal".</p></li>
        /// <li><p><strong>renderer</strong> : Function</p>
        /// <p>Optional function for formatting the label into a displayable value.
        /// Default value: function(v) { return v; }</p></li>
        /// </summary>
        public JsObject label;
        public LabelConfig(params object[] args){}
    }
    #endregion
    #region LabelEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LabelEvents : Ext.BaseEvents
    {
        public LabelEvents(params object[] args){}
    }
    #endregion
}
