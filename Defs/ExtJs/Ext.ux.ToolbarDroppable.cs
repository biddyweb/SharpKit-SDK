//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux
{
    #region ToolbarDroppable
    /// <summary>
    /// <p>Plugin which allows items to be dropped onto a toolbar and be turned into new Toolbar items.
    /// To use the plugin, you just need to provide a createItem implementation that takes the drop
    /// data as an argument and returns an object that can be placed onto the toolbar. Example:</p>
    /// <pre><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.ux.ToolbarDroppable">Ext.ux.ToolbarDroppable</see>', {
    /// createItem: function(data) {
    /// return <see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.button.Button">Ext.Button</see>', {text: data.text});
    /// }
    /// });
    /// </pre>
    /// <p>The afterLayout function can also be overridden, and is called after a new item has been
    /// created and inserted into the Toolbar. Use this for any logic that needs to be run after
    /// the item has been created.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ToolbarDroppable
    {
        /// <summary>
        /// The drop target attached to the toolbar instance
        /// </summary>
        public Ext.dd.DropTarget dropTarget{get;set;}
        /// <summary>
        /// The toolbar instance that this plugin is tied to
        /// </summary>
        public Ext.toolbar.Toolbar toolbar{get;set;}
        /// <summary>
        /// Parameters<li><span>config</span> : <see cref="Object">Object</see><div>
        /// </div></li>
        /// </summary>
        /// <param name="config">
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public ToolbarDroppable(object config){}
        /// <summary>
        /// Adds the given DD Group to the drop target
        /// </summary>
        /// <param name="ddGroup"><p>The DD Group</p>
        /// </param>
        public void addDDGroup(JsString ddGroup){}
        /// <summary>
        /// Called after a new button has been created and added to the toolbar. Add any required cleanup logic here
        /// </summary>
        public void afterLayout(){}
        /// <summary>
        /// Calculates the location on the toolbar to create the new sorter button based on the XY of the
        /// drag event
        /// </summary>
        /// <param name="e"><p>The event object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The index at which to insert the new button</p>
        /// </div>
        /// </returns>
        public JsNumber calculateEntryIndex(EventObject e){return null;}
        /// <summary>
        /// Returns true if the drop is allowed on the drop target. This function can be overridden
        /// and defaults to simply return true
        /// </summary>
        /// <param name="data"><p>Arbitrary data from the drag source</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if the drop is allowed</p>
        /// </div>
        /// </returns>
        public bool canDrop(object data){return false;}
        /// <summary>
        /// Creates a drop target on the toolbar
        /// </summary>
        public void createDropTarget(){}
        /// <summary>
        /// Creates the new toolbar item based on drop data. This method must be implemented by the plugin instance
        /// </summary>
        /// <param name="data"><p>Arbitrary data from the drop</p>
        /// </param>
        /// <returns>
        /// <span>Mixed</span><div><p>An item that can be added to a toolbar</p>
        /// </div>
        /// </returns>
        public JsObject createItem(object data){return null;}
        /// <summary>
        /// Initializes the plugin and saves a reference to the toolbar
        /// </summary>
        /// <param name="toolbar"><p>The toolbar instance</p>
        /// </param>
        public void init(Ext.toolbar.Toolbar toolbar){}
        /// <summary>
        /// Called when the drop has been made. Creates the new toolbar item, places it at the correct location
        /// and calls the afterLayout callback.
        /// </summary>
        /// <param name="dragSource">
        /// </param>
        /// <param name="event">
        /// </param>
        /// <param name="data">
        /// </param>
        public void notifyDrop(object dragSource, object @event, object data){}
        /// <summary>
        /// Custom notifyOver method which will be used in the plugin's internal DropTarget
        /// </summary>
        /// <param name="dragSource">
        /// </param>
        /// <param name="event">
        /// </param>
        /// <param name="data">
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The CSS class to add</p>
        /// </div>
        /// </returns>
        public JsString notifyOver(object dragSource, object @event, object data){return null;}
        public ToolbarDroppable(ToolbarDroppableConfig config){}
        public ToolbarDroppable(){}
        public ToolbarDroppable(params object[] args){}
    }
    #endregion
    #region ToolbarDroppableConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ToolbarDroppableConfig
    {
        public ToolbarDroppableConfig(params object[] args){}
    }
    #endregion
    #region ToolbarDroppableEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ToolbarDroppableEvents
    {
        public ToolbarDroppableEvents(params object[] args){}
    }
    #endregion
}
