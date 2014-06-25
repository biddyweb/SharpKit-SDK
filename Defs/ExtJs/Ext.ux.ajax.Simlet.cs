//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.ajax
{
    #region Simlet
    /// <inheritdocs />
    /// <summary>
    /// <p>This is a base class for more advanced "simlets" (simulated servers). A simlet is asked
    /// to provide a response given a <see cref="Ext.ux.ajax.SimXhr">Ext.ux.ajax.SimXhr</see> instance.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Simlet : Ext.Base
    {
        /// <summary>
        /// </summary>
        public JsObject responseHeaders;
        /// <summary>
        /// </summary>
        public JsNumber responseText;
        /// <summary>
        /// </summary>
        public JsNumber responseXML;
        /// <summary>
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber status;
        /// <summary>
        /// Defaults to: <c>&quot;OK&quot;</c>
        /// </summary>
        public JsString statusText;
        /// <summary>
        /// Performs the action requested by the given XHR and returns an object to be applied
        /// on to the XHR (containing status, responseText, etc.). For the most part,
        /// this is delegated to doMethod methods on this class, such as doGet.
        /// </summary>
        /// <param name="xhr"><p>The simulated XMLHttpRequest instance.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The response properties to add to the XMLHttpRequest.</p>
        /// </div>
        /// </returns>
        public object exec(SimXhr xhr){return null;}
        public Simlet(SimletConfig config){}
        public Simlet(){}
        public Simlet(params object[] args){}
    }
    #endregion
    #region SimletConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SimletConfig : Ext.BaseConfig
    {
        /// <summary>
        /// </summary>
        public JsObject responseHeaders;
        /// <summary>
        /// </summary>
        public JsNumber responseText;
        /// <summary>
        /// </summary>
        public JsNumber responseXML;
        /// <summary>
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber status;
        /// <summary>
        /// Defaults to: <c>&quot;OK&quot;</c>
        /// </summary>
        public JsString statusText;
        public SimletConfig(params object[] args){}
    }
    #endregion
    #region SimletEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SimletEvents : Ext.BaseEvents
    {
        public SimletEvents(params object[] args){}
    }
    #endregion
}
