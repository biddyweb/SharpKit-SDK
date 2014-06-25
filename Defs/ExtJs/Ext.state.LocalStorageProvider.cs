//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.state
{
    #region LocalStorageProvider
    /// <inheritdocs />
    /// <summary>
    /// <p>A Provider implementation which saves and retrieves state via the HTML5 localStorage object.
    /// If the browser does not support local storage, an exception will be thrown upon instantiating
    /// this class.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class LocalStorageProvider : Ext.state.Provider
    {
        public LocalStorageProvider(LocalStorageProviderConfig config){}
        public LocalStorageProvider(){}
        public LocalStorageProvider(params object[] args){}
    }
    #endregion
    #region LocalStorageProviderConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LocalStorageProviderConfig : Ext.state.ProviderConfig
    {
        public LocalStorageProviderConfig(params object[] args){}
    }
    #endregion
    #region LocalStorageProviderEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class LocalStorageProviderEvents : Ext.state.ProviderEvents
    {
        public LocalStorageProviderEvents(params object[] args){}
    }
    #endregion
}
