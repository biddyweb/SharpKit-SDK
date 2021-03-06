//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.tab
{
    #region Tab
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents a single Tab in a <see cref="Ext.tab.Panel">TabPanel</see>. A Tab is simply a slightly customized <see cref="Ext.button.Button">Button</see>,
    /// styled to look like a tab. Tabs are optionally closable, and can also be disabled. 99% of the time you will not
    /// need to create Tabs manually as the framework does so automatically when you use a <see cref="Ext.tab.Panel">TabPanel</see></p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Tab : Ext.button.Button
    {
        /// <summary>
        /// The CSS class to be applied to a Tab when it is active.
        /// Providing your own CSS for this class enables you to customize the active state.
        /// Defaults to: <c>&quot;active&quot;</c>
        /// </summary>
        public JsString activeCls;
        /// <summary>
        /// The CSS class which is added to the tab when it is closable
        /// Defaults to: <c>&quot;closable&quot;</c>
        /// </summary>
        public JsString closableCls;
        /// <summary>
        /// The accessible text label for the close button link; only used when closable = true.
        /// Defaults to: <c>&quot;Close Tab&quot;</c>
        /// </summary>
        public JsString closeText;
        /// <summary>
        /// Indicates that this tab is currently active. This is NOT a public configuration.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool active{get;set;}
        /// <summary>
        /// True if the tab is currently closable
        /// </summary>
        public bool closable{get;set;}
        /// <summary>
        /// true in this class to identify an object as an instantiated Tab, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isTab{get;set;}
        /// <summary>
        /// Fires the close event on the tab.
        /// </summary>
        private void fireClose(){}
        /// <summary>
        /// Listener attached to click events on the Tab's close button
        /// </summary>
        private void onCloseClick(){}
        /// <summary>
        /// Parameters<li><span>e</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="e">
        /// </param>
        private void onDeleteKey(object e){}
        /// <summary>
        /// Parameters<li><span>e</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="e">
        /// </param>
        private void onEnterKey(object e){}
        /// <summary>
        /// Sets this tab's attached card. Usually this is handled automatically by the Ext.tab.Panel that this Tab
        /// belongs to and would not need to be done by the developer
        /// </summary>
        /// <param name="card"><p>The card to set</p>
        /// </param>
        public void setCard(Ext.Component card){}
        /// <summary>
        /// Sets the tab as either closable or not.
        /// </summary>
        /// <param name="closable"><p>Pass false to make the tab not closable. Otherwise the tab will be made closable (eg a
        /// close button will appear on the tab)</p>
        /// </param>
        public void setClosable(bool closable){}
        /// <summary>
        /// This method ensures that the closeBtn element exists or not based on 'closable'.
        /// </summary>
        private void syncClosableElements(){}
        /// <summary>
        /// This method ensures that the UI classes are added or removed based on 'closable'.
        /// </summary>
        private void syncClosableUI(){}
        public Tab(Ext.tab.TabConfig config){}
        public Tab(){}
        public Tab(params object[] args){}
    }
    #endregion
    #region TabConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TabConfig : Ext.button.ButtonConfig
    {
        /// <summary>
        /// The CSS class to be applied to a Tab when it is active.
        /// Providing your own CSS for this class enables you to customize the active state.
        /// Defaults to: <c>&quot;active&quot;</c>
        /// </summary>
        public JsString activeCls;
        /// <summary>
        /// True to make the Tab start closable (the close icon will be visible).
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool closable;
        /// <summary>
        /// The CSS class which is added to the tab when it is closable
        /// Defaults to: <c>&quot;closable&quot;</c>
        /// </summary>
        public JsString closableCls;
        /// <summary>
        /// The accessible text label for the close button link; only used when closable = true.
        /// Defaults to: <c>&quot;Close Tab&quot;</c>
        /// </summary>
        public JsString closeText;
        public TabConfig(params object[] args){}
    }
    #endregion
    #region TabEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TabEvents : Ext.button.ButtonEvents
    {
        /// <summary>
        /// Fires if the user clicks on the Tab's close button, but before the close event is fired. Return
        /// false from any listener to stop the close event being fired
        /// </summary>
        /// <param name="tab"><p>The Tab object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeclose(Ext.tab.Tab tab, object eOpts){}
        /// <summary>
        /// Fires to indicate that the tab is to be closed, usually because the user has clicked the close button.
        /// </summary>
        /// <param name="tab"><p>The Tab object</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void close(Ext.tab.Tab tab, object eOpts){}
        public TabEvents(params object[] args){}
    }
    #endregion
}
