//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region Types
    /// <inheritdocs />
    /// <summary>
    /// <p>This is a static class containing the system-supplied data types which may be given to a <see cref="Ext.data.Field">Field</see>.<p>
    /// <p>The properties in this class are used as type indicators in the <see cref="Ext.data.Field">Field</see> class, so to
    /// test whether a Field is of a certain type, compare the <see cref="Ext.data.FieldConfig.type">type</see> property against properties
    /// of this class.</p>
    /// <p>Developers may add their own application-specific data types to this class. Definition names must be UPPERCASE.
    /// each type definition must contain three properties:</p>
    /// <div><ul>
    /// <li><c>convert</c> : <i>Function</i><div>A function to convert raw data values from a data block into the data
    /// to be stored in the Field. The function is passed the collowing parameters:
    /// <div><ul>
    /// <li><b>v</b> : Mixed<div>The data value as read by the Reader, if undefined will use
    /// the configured <tt><see cref="Ext.data.FieldConfig.defaultValue">defaultValue</see></tt>.</div></li>
    /// <li><b>rec</b> : Mixed<div>The data object containing the row as read by the Reader.
    /// Depending on the Reader type, this could be an Array (<see cref="Ext.data.reader.Array">ArrayReader</see>), an object
    /// (<see cref="Ext.data.reader.Json">JsonReader</see>), or an XML element.</div></li>
    /// </ul></div></div></li>
    /// <li><c>sortType</c> : <i>Function</i> <div>A function to convert the stored data into comparable form, as defined by <see cref="Ext.data.SortTypes">Ext.data.SortTypes</see>.</div></li>
    /// <li><c>type</c> : <i>String</i> <div>A textual data type name.</div></li>
    /// </ul></div>
    /// <p>For example, to create a VELatLong field (See the Microsoft Bing Mapping API) containing the latitude/longitude value of a datapoint on a map from a JsonReader data block
    /// which contained the properties <c>lat</c> and <c>long</c>, you would define a new data type like this:</p>
    /// <pre><code>// Add a new Field data type which stores a VELatLong object in the Record.
    /// Ext.data.Types.VELATLONG = {
    /// convert: function(v, data) {
    /// return new VELatLong(data.lat, data.long);
    /// },
    /// sortType: function(v) {
    /// return v.Latitude;  // When sorting, order by latitude
    /// },
    /// type: 'VELatLong'
    /// };
    /// </code></pre>
    /// <p>Then, when declaring a Model, use:
    /// <pre><code>var types = <see cref="Ext.data.Types">Ext.data.Types</see>; // allow shorthand type access
    /// <see cref="Ext.ExtContext.define">Ext.define</see>('Unit',
    /// extend: '<see cref="Ext.data.Model">Ext.data.Model</see>',
    /// fields: [
    /// { name: 'unitName', mapping: 'UnitName' },
    /// { name: 'curSpeed', mapping: 'CurSpeed', type: types.INT },
    /// { name: 'latitude', mapping: 'lat', type: types.FLOAT },
    /// { name: 'longitude', mapping: 'long', type: types.FLOAT },
    /// { name: 'position', type: types.VELATLONG }
    /// ]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Types : Ext.Base
    {
        /// <summary>
        /// Defaults to: <c>&quot;Ext.Base&quot;</c>
        /// </summary>
        [JsProperty(Name="$className")]
        private static JsString @className{get;set;}
        /// <summary>
        /// This data type means that no conversion is applied to the raw data before it is placed into a Record.
        /// </summary>
        public static JsObject AUTO{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a boolean before it is placed into
        /// a Record. The string "true" and the number 1 are converted to boolean true.
        /// The synonym <c>BOOLEAN</c> is equivalent.
        /// </summary>
        public static JsObject BOOL{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a boolean before it is placed into
        /// a Record. The string "true" and the number 1 are converted to boolean true.
        /// The synonym <c>BOOL</c> is equivalent.
        /// </summary>
        public static JsObject BOOLEAN{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a Date before it is placed into a Record.
        /// The date format is specified in the constructor of the Ext.data.Field to which this type is
        /// being applied.
        /// </summary>
        public static JsObject DATE{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a number before it is placed into a Record.
        /// The synonym <c>NUMBER</c> is equivalent.
        /// </summary>
        public static JsObject FLOAT{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into an integer before it is placed into a Record.
        /// The synonym <c>INTEGER</c> is equivalent.
        /// </summary>
        public static JsObject INT{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into an integer before it is placed into a Record.
        /// The synonym <c>INT</c> is equivalent.
        /// </summary>
        public static JsObject INTEGER{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a number before it is placed into a Record.
        /// The synonym <c>FLOAT</c> is equivalent.
        /// </summary>
        public static JsObject NUMBER{get;set;}
        /// <summary>
        /// This data type means that the raw data is converted into a String before it is placed into a Record.
        /// </summary>
        public static JsObject STRING{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject configMap{get;set;}
        /// <summary>
        /// Defaults to: <c>[]</c>
        /// </summary>
        private static JsArray initConfigList{get;set;}
        /// <summary>
        /// Defaults to: <c>{}</c>
        /// </summary>
        private static JsObject initConfigMap{get;set;}
        /// <summary>
        /// Defaults to: <c>true</c>
        /// </summary>
        private static bool isInstance{get;set;}
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
        protected static Class self{get;set;}
        /// <summary>
        /// A regular expression for stripping non-numeric characters from a numeric value. Defaults to /[\$,%]/g.
        /// This should be overridden for localization.
        /// Defaults to: <c>/[\$,%]/g</c>
        /// </summary>
        public static JsRegExp stripRe{get;set;}
        /// <summary>
        /// Call the original method that was previously overridden with override
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// constructor: function() {
        /// alert("I'm a cat!");
        /// }
        /// });
        /// My.Cat.override({
        /// constructor: function() {
        /// alert("I'm going to be a cat!");
        /// this.callOverridden();
        /// alert("Meeeeoooowwww");
        /// }
        /// });
        /// var kitty = new My.Cat(); // alerts "I'm going to be a cat!"
        /// // alerts "I'm a cat!"
        /// // alerts "Meeeeoooowwww"
        /// </code>
        /// <p>This method has been <strong>deprecated</strong> </p>
        /// <p>as of 4.1. Use <see cref="Ext.Base.callParent">callParent</see> instead.</p>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callOverridden(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the overridden method</p>
        /// </div>
        /// </returns>
        protected static object callOverridden(object args=null){return null;}
        /// <summary>
        /// Call the "parent" method of the current method. That is the method previously
        /// overridden by derivation or by an override (see Ext.define).
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Base', {
        /// constructor: function (x) {
        /// this.x = x;
        /// },
        /// statics: {
        /// method: function (x) {
        /// return x;
        /// }
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived', {
        /// extend: 'My.Base',
        /// constructor: function () {
        /// this.callParent([21]);
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // alerts 21
        /// </code>
        /// This can be used with an override as follows:
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.DerivedOverride', {
        /// override: 'My.Derived',
        /// constructor: function (x) {
        /// this.callParent([x*2]); // calls original My.Derived constructor
        /// }
        /// });
        /// var obj = new My.Derived();
        /// alert(obj.x);  // now alerts 42
        /// </code>
        /// This also works with static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2', {
        /// extend: 'My.Base',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Base.method
        /// }
        /// }
        /// });
        /// alert(My.Base.method(10);     // alerts 10
        /// alert(My.Derived2.method(10); // alerts 20
        /// </code>
        /// Lastly, it also works with overridden static methods.
        /// <code> <see cref="Ext.ExtContext.define">Ext.define</see>('My.Derived2Override', {
        /// override: 'My.Derived2',
        /// statics: {
        /// method: function (x) {
        /// return this.callParent([x*2]); // calls My.Derived2.method
        /// }
        /// }
        /// });
        /// alert(My.Derived2.method(10); // now alerts 40
        /// </code>
        /// </summary>
        /// <param name="args"><p>The arguments, either an array or the <c>arguments</c> object
        /// from the current method, for example: <c>this.callParent(arguments)</c></p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>Returns the result of calling the parent method</p>
        /// </div>
        /// </returns>
        protected static object callParent(object args=null){return null;}
        /// <summary>
        /// </summary>
        private static void configClass(){}
        /// <summary>
        /// Overrides: <see cref="Ext.AbstractComponent.destroy">Ext.AbstractComponent.destroy</see>, <see cref="Ext.AbstractPlugin.destroy">Ext.AbstractPlugin.destroy</see>, <see cref="Ext.layout.Layout.destroy">Ext.layout.Layout.destroy</see>
        /// </summary>
        private static void destroy(){}
        /// <summary>
        /// Parameters<li><span>name</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="name">
        /// </param>
        private static void getConfig(object name){}
        /// <summary>
        /// Returns the initial configuration passed to constructor when instantiating
        /// this class.
        /// </summary>
        /// <param name="name"><p>Name of the config option to return.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see>/Mixed</span><div><p>The full config object or a single config value
        /// when <c>name</c> parameter specified.</p>
        /// </div>
        /// </returns>
        public static object getInitialConfig(object name=null){return null;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        private static void hasConfig(object config){}
        /// <summary>
        /// Initialize configuration for this class. a typical example:
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.awesome.Class', {
        /// // The default config
        /// config: {
        /// name: 'Awesome',
        /// isAwesome: true
        /// },
        /// constructor: function(config) {
        /// this.initConfig(config);
        /// }
        /// });
        /// var awesome = new My.awesome.Class({
        /// name: 'Super Awesome'
        /// });
        /// alert(awesome.getName()); // 'Super Awesome'
        /// </code>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Base">Ext.Base</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        protected static Ext.Base initConfig(object config){return null;}
        /// <summary>
        /// Parameters<li><span>names</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>callback</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>scope</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="names">
        /// </param>
        /// <param name="callback">
        /// </param>
        /// <param name="scope">
        /// </param>
        private static void onConfigUpdate(object names, object callback, object scope){}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li><li><span>applyIfNotSet</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <param name="applyIfNotSet">
        /// </param>
        private static void setConfig(object config, object applyIfNotSet){}
        /// <summary>
        /// Get the reference to the class from which this object was instantiated. Note that unlike self,
        /// this.statics() is scope-independent and it always returns the class from which it was called, regardless of what
        /// this points to during run-time
        /// <code><see cref="Ext.ExtContext.define">Ext.define</see>('My.Cat', {
        /// statics: {
        /// totalCreated: 0,
        /// speciesName: 'Cat' // My.Cat.speciesName = 'Cat'
        /// },
        /// constructor: function() {
        /// var statics = this.statics();
        /// alert(statics.speciesName);     // always equals to 'Cat' no matter what 'this' refers to
        /// // equivalent to: My.Cat.speciesName
        /// alert(this.self.speciesName);   // dependent on 'this'
        /// statics.totalCreated++;
        /// },
        /// clone: function() {
        /// var cloned = new this.self;                      // dependent on 'this'
        /// cloned.groupName = this.statics().speciesName;   // equivalent to: My.Cat.speciesName
        /// return cloned;
        /// }
        /// });
        /// <see cref="Ext.ExtContext.define">Ext.define</see>('My.SnowLeopard', {
        /// extend: 'My.Cat',
        /// statics: {
        /// speciesName: 'Snow Leopard'     // My.SnowLeopard.speciesName = 'Snow Leopard'
        /// },
        /// constructor: function() {
        /// this.callParent();
        /// }
        /// });
        /// var cat = new My.Cat();                 // alerts 'Cat', then alerts 'Cat'
        /// var snowLeopard = new My.SnowLeopard(); // alerts 'Cat', then alerts 'Snow Leopard'
        /// var clone = snowLeopard.clone();
        /// alert(<see cref="Ext.ExtContext.getClassName">Ext.getClassName</see>(clone));         // alerts 'My.SnowLeopard'
        /// alert(clone.groupName);                 // alerts 'Cat'
        /// alert(My.Cat.totalCreated);             // alerts 3
        /// </code>
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Class">Ext.Class</see></span><div>
        /// </div>
        /// </returns>
        protected static Class statics(){return null;}
        public Types(TypesConfig config){}
        public Types(){}
        public Types(params object[] args){}
    }
    #endregion
    #region TypesConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TypesConfig : Ext.BaseConfig
    {
        public TypesConfig(params object[] args){}
    }
    #endregion
    #region TypesEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TypesEvents : Ext.BaseEvents
    {
        public TypesEvents(params object[] args){}
    }
    #endregion
}
