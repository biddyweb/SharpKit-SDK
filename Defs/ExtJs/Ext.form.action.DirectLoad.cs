//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.action
{
    #region DirectLoad
    /// <inheritdocs />
    /// <summary>
    /// <p>Provides <see cref="Ext.direct.Manager">Ext.direct.Manager</see> support for loading form data.</p>
    /// <p>This example illustrates usage of Ext.direct.Direct to <strong>load</strong> a form through <see cref="Ext.direct.Manager">Ext.Direct</see>.</p>
    /// <pre><code>var myFormPanel = new <see cref="Ext.form.Panel">Ext.form.Panel</see>({
    /// // configs for FormPanel
    /// title: 'Basic Information',
    /// renderTo: document.body,
    /// width: 300, height: 160,
    /// padding: 10,
    /// // configs apply to child items
    /// defaults: {anchor: '100%'},
    /// defaultType: 'textfield',
    /// items: [{
    /// fieldLabel: 'Name',
    /// name: 'name'
    /// },{
    /// fieldLabel: 'Email',
    /// name: 'email'
    /// },{
    /// fieldLabel: 'Company',
    /// name: 'company'
    /// }],
    /// // configs for BasicForm
    /// api: {
    /// // The server-side method to call for load() requests
    /// load: Profile.getBasicInfo,
    /// // The server-side must mark the submit handler as a 'formHandler'
    /// submit: Profile.updateBasicInfo
    /// },
    /// // specify the order for the passed params
    /// paramOrder: ['uid', 'foo']
    /// });
    /// // load the form
    /// myFormPanel.getForm().load({
    /// // pass 2 arguments to server side getBasicInfo method (len=2)
    /// params: {
    /// foo: 'bar',
    /// uid: 34
    /// }
    /// });
    /// </code></pre>
    /// <p>The data packet sent to the server will resemble something like:</p>
    /// <pre><code>[
    /// {
    /// "action":"Profile","method":"getBasicInfo","type":"rpc","tid":2,
    /// "data":[34,"bar"] // note the order of the params
    /// }
    /// ]
    /// </code></pre>
    /// <p>The form will process a data packet returned by the server that is similar to the following format:</p>
    /// <pre><code>[
    /// {
    /// "action":"Profile","method":"getBasicInfo","type":"rpc","tid":2,
    /// "result":{
    /// "success":true,
    /// "data":{
    /// "name":"Fred Flintstone",
    /// "company":"Slate Rock and Gravel",
    /// "email":"fred.flintstone@slaterg.com"
    /// }
    /// }
    /// }
    /// ]
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DirectLoad : Load
    {
        public DirectLoad(DirectLoadConfig config){}
        public DirectLoad(){}
        public DirectLoad(params object[] args){}
    }
    #endregion
    #region DirectLoadConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DirectLoadConfig : LoadConfig
    {
        public DirectLoadConfig(params object[] args){}
    }
    #endregion
    #region DirectLoadEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DirectLoadEvents : LoadEvents
    {
        public DirectLoadEvents(params object[] args){}
    }
    #endregion
}
