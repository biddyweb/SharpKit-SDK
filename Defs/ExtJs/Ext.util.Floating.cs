//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.util
{
    #region Floating
    /// <summary>
    /// <p>A mixin to add floating capability to a Component.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial interface Floating
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
        /// <summary>
        /// Aligns this floating Component to the specified element
        /// </summary>
        /// <param name="element"><p>The element or <see cref="Ext.Component">Ext.Component</see> to align to. If passing a component, it must be a
        /// component instance. If a string id is passed, it will be used as an element id.</p>
        /// </param>
        /// <param name="position"><p>The position to align to
        /// (see <see cref="Ext.dom.Element.alignTo">Ext.Element.alignTo</see> for more details).</p>
        /// <p>Defaults to: <c>&quot;tl-bl?&quot;</c></p></param>
        /// <param name="offsets"><p>Offset the positioning by [x, y]</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        Ext.Component alignTo(object element, object position=null, object offsets=null);
        /// <summary>
        /// Center this Component in its container.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        Ext.Component center();
        /// <summary>
        /// Moves this floating Component into a constrain region.
        /// By default, this Component is constrained to be within the container it was added to, or the element it was
        /// rendered to.
        /// An alternative constraint may be passed.
        /// </summary>
        /// <param name="constrainTo"><p>The Element or <see cref="Ext.util.Region">Region</see>
        /// into which this Component is to be constrained. Defaults to the element into which this floating Component
        /// was rendered.</p>
        /// </param>
        void doConstrain(object constrainTo=null);
        /// <summary>
        /// Gets the x/y offsets to constrain this float
        /// </summary>
        /// <param name="constrainTo"><p>The Element or <see cref="Ext.util.Region">Region</see>
        /// into which this Component is to be constrained.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see>[]</span><div><p>The x/y constraints</p>
        /// </div>
        /// </returns>
        JsNumber[] getConstrainVector(object constrainTo=null);
        /// <summary>
        /// This method is called internally by Ext.ZIndexManager to signal that a floating Component has either been
        /// moved to the top of its zIndex stack, or pushed from the top of its zIndex stack.
        /// If a <em>Window</em> is superceded by another Window, deactivating it hides its shadow.
        /// This method also fires the <see cref="Ext.ComponentEvents.activate">activate</see> or
        /// <see cref="Ext.ComponentEvents.deactivate">deactivate</see> event depending on which action occurred.
        /// </summary>
        /// <param name="active"><p>True to activate the Component, false to deactivate it.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="newActive"><p>The newly active Component which is taking over topmost zIndex position.</p>
        /// </param>
        void setActive(object active=null, object newActive=null);
        /// <summary>
        /// Sends this Component to the back of (lower z-index than) any other visible windows
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        Ext.Component toBack();
        /// <summary>
        /// Brings this floating Component to the front of any other visible, floating Components managed by the same
        /// ZIndexManager
        /// If this Component is modal, inserts the modal mask just below this Component in the z-index stack.
        /// </summary>
        /// <param name="preventFocus"><p>Specify <c>true</c> to prevent the Component from being focused.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        Ext.Component toFront(object preventFocus=null);
    }
    #endregion
    #region FloatingConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FloatingConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Specifies whether the floated component should be automatically focused when
        /// it is brought to the front.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool focusOnToFront;
        /// <summary>
        /// Specifies whether the floating component should be given a shadow. Set to true to automatically create an
        /// Ext.Shadow, or a string indicating the shadow's display Ext.Shadow.mode. Set to false to
        /// disable the shadow.
        /// Defaults to: <c>&quot;sides&quot;</c>
        /// </summary>
        public object shadow;
        /// <summary>
        /// Number of pixels to offset the shadow.
        /// </summary>
        public object shadowOffset;
        public FloatingConfig(params object[] args){}
    }
    #endregion
    #region FloatingEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FloatingEvents : Ext.BaseEvents
    {
        public FloatingEvents(params object[] args){}
    }
    #endregion
}
