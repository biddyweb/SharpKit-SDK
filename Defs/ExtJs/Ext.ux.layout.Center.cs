//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.layout
{
    #region Center
    /// <inheritdocs />
    /// <summary>
    /// <p>This layout manager is used to center contents within a container. As a subclass of
    /// <see cref="Ext.layout.container.Fit">fit layout</see>, CenterLayout expects to have one child
    /// item; multiple items will be placed overlapping. The layout does not require any config
    /// options. Items in the container can use percentage width or height rather than be fit
    /// to the full size of the container.</p>
    /// <p>Example usage:</p>
    /// <pre><code> // The content panel is centered in the container
    /// var p = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.panel.Panel">Ext.Panel</see>', {
    /// title: 'Center Layout',
    /// layout: 'ux.center',
    /// items: [{
    /// title: 'Centered Content',
    /// width: '75%',  // assign 75% of the container width to the item
    /// html: 'Some content'
    /// }]
    /// });
    /// </code></pre>
    /// <p>If you leave the title blank and specify no border you can create a non-visual, structural
    /// container just for centering the contents.</p>
    /// <pre><code> var p = <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.container.Container">Ext.Container</see>', {
    /// layout: 'ux.center',
    /// items: [{
    /// title: 'Centered Content',
    /// width: 300,
    /// height: '90%', // assign 90% of the container height to the item
    /// html: 'Some content'
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Center : Ext.layout.container.Fit
    {
        public Center(CenterConfig config){}
        public Center(){}
        public Center(params object[] args){}
    }
    #endregion
    #region CenterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CenterConfig : Ext.layout.container.FitConfig
    {
        public CenterConfig(params object[] args){}
    }
    #endregion
    #region CenterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CenterEvents : Ext.layout.container.FitEvents
    {
        public CenterEvents(params object[] args){}
    }
    #endregion
}
