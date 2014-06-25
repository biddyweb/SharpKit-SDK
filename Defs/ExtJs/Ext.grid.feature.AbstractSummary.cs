//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.grid.feature
{
    #region AbstractSummary
    /// <summary>
    /// <p>A small abstract class that contains the shared behaviour for any summary
    /// calculations to be used in the grid.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface AbstractSummary
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        JsString @className{get;set;}
        /// <summary>
        /// Most features will not modify the data returned to the view.
        /// This is limited to one feature that manipulates the data per grid view.
        /// Defaults to: <c>false</c>
        /// </summary>
        bool collectData{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        JsObject configMap{get;set;}
        /// <summary>
        /// True when feature is disabled.
        /// Defaults to: <c>false</c>
        /// </summary>
        bool disabled{get;set;}
        /// <summary>
        /// Prefix to use when firing events on the view.
        /// For example a prefix of group would expose "groupclick", "groupcontextmenu", "groupdblclick".
        /// Defaults to: <c>null</c>
        /// </summary>
        JsString eventPrefix{get;set;}
        /// <summary>
        /// Selector used to determine when to fire the event with the eventPrefix.
        /// Defaults to: <c>null</c>
        /// </summary>
        JsString eventSelector{get;set;}
        /// <summary>
        /// Reference to the grid panel
        /// Defaults to: <c>null</c>
        /// </summary>
        Ext.grid.Panel grid{get;set;}
        /// <summary>
        /// Most features will expose additional events, some may not and will
        /// need to change this to false.
        /// Defaults to: <c>true</c>
        /// </summary>
        bool hasFeatureEvent{get;set;}
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
        /// <summary>
        /// Reference to the TableView.
        /// Defaults to: <c>null</c>
        /// </summary>
        Ext.view.Table view{get;set;}
        /// <summary>
        /// Gets the value for the column from the attached data.
        /// </summary>
        /// <param name="column"><p>The header</p>
        /// </param>
        /// <param name="data"><p>The current data</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The value to be rendered</p>
        /// </div>
        /// </returns>
        JsString getColumnValue(Ext.grid.column.Column column, object data);
        /// <summary>
        /// Get the summary data for a field.
        /// </summary>
        /// <param name="store"><p>The store to get the data from</p>
        /// </param>
        /// <param name="type"><p>The type of aggregation. If a function is specified it will
        /// be passed to the stores aggregate function.</p>
        /// </param>
        /// <param name="field"><p>The field to aggregate on</p>
        /// </param>
        /// <param name="group"><p>True to aggregate in grouped mode</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see>/<see cref="String">String</see>/<see cref="Object">Object</see></span><div><p>See the return type for the store functions.</p>
        /// </div>
        /// </returns>
        object getSummary(Ext.data.Store store, object type, JsString field, bool group);
        /// <summary>
        /// Gets any fragments to be used in the tpl
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The fragments</p>
        /// </div>
        /// </returns>
        object getSummaryFragments();
        /// <summary>
        /// Prints a summary row
        /// </summary>
        /// <param name="index"><p>The index in the template</p>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The value of the summary row</p>
        /// </div>
        /// </returns>
        JsString printSummaryRow(object index);
        /// <summary>
        /// Toggle whether or not to show the summary row.
        /// </summary>
        /// <param name="visible"><p>True to show the summary row</p>
        /// </param>
        void toggleSummaryRow(bool visible);
    }
    #endregion
    #region AbstractSummaryConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractSummaryConfig : FeatureConfig
    {
        /// <summary>
        /// True to show the summary row.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool showSummaryRow;
        public AbstractSummaryConfig(params object[] args){}
    }
    #endregion
    #region AbstractSummaryEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractSummaryEvents : FeatureEvents
    {
        public AbstractSummaryEvents(params object[] args){}
    }
    #endregion
}
