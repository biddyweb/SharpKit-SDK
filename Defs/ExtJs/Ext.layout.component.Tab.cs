//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout.component
{
    #region Tab
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Component layout for tabs</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Tab : Ext.layout.component.Button
    {
        public Tab(Ext.layout.component.TabConfig config){}
        public Tab(){}
        public Tab(params object[] args){}
    }
    #endregion
    #region TabConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TabConfig : Ext.layout.component.ButtonConfig
    {
        public TabConfig(params object[] args){}
    }
    #endregion
    #region TabEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TabEvents : Ext.layout.component.ButtonEvents
    {
        public TabEvents(params object[] args){}
    }
    #endregion
}
