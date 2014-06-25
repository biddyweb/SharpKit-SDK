//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout.container.boxOverflow
{
    #region Menu
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Menu : None
    {
        /// <summary>
        /// CSS class added to the Button which shows the overflow menu.
        /// </summary>
        public JsString triggerButtonCls;
        /// <summary>
        /// The expand menu - holds items for every item that cannot be shown
        /// because the container is currently not large enough.
        /// </summary>
        private Ext.menu.Menu menu{get;set;}
        /// <summary>
        /// Array of all items that are currently hidden and should go into the dropdown menu
        /// Defaults to: <c>[]</c>
        /// </summary>
        public JsArray menuItems{get;set;}
        /// <summary>
        /// The expand button which triggers the overflow menu to be shown
        /// </summary>
        private Ext.button.Button menuTrigger{get;set;}
        /// <summary>
        /// HTML fragment to render into the toolbar overflow menu if there are no items to display
        /// </summary>
        public JsString noItemsMenuText{get;set;}
        /// <summary>
        /// Adds the given Toolbar item to the given menu. Buttons inside a buttongroup are added individually.
        /// </summary>
        /// <param name="menu"><p>The menu to add to</p>
        /// </param>
        /// <param name="component"><p>The component to add
        /// TODO: Implement overrides in Ext.layout.container.boxOverflow which create overrides
        /// for SplitButton, Button, ButtonGroup, and TextField. And a generic one for Component
        /// which create clones suitable for use in an overflow menu.</p>
        /// </param>
        private void addComponentToMenu(Ext.menu.Menu menu, Ext.Component component){}
        /// <summary>
        /// Called before the overflow menu is shown. This constructs the menu's items, caching them for as long as it can.
        /// </summary>
        /// <param name="menu">
        /// </param>
        private void beforeMenuShow(object menu){}
        /// <summary>
        /// Finishes the render operation of the trigger Button.
        /// </summary>
        private void captureChildElements(){}
        /// <summary>
        /// Deletes the sub-menu of each item in the expander menu. Submenus are created for items such as
        /// splitbuttons and buttongroups, where the Toolbar item cannot be represented by a single menu item
        /// </summary>
        private void clearMenu(){}
        /// <summary>
        /// Called by the layout, when it determines that there is no overflow.
        /// Also called as an interceptor to the layout's onLayout method to reshow
        /// previously hidden overflowing items.
        /// </summary>
        /// <param name="ownerContext">
        /// </param>
        private void clearOverflow(object ownerContext){}
        /// <summary>
        /// Returns a menu config for a given component. This config is used to create a menu item
        /// to be added to the expander menu
        /// </summary>
        /// <param name="component"><p>The component to create the config for</p>
        /// </param>
        /// <param name="hideOnClick"><p>Passed through to the menu item</p>
        /// </param>
        private void createMenuConfig(Ext.Component component, bool hideOnClick){}
        /// <summary>
        /// </summary>
        private void hideTrigger(){}
        /// <summary>
        /// Shows the overflow trigger when enableOverflow is set to true and the items
        /// in the layout are too wide to fit in the space available
        /// </summary>
        /// <param name="ownerContext">
        /// </param>
        private void showTrigger(object ownerContext){}
        public Menu(Ext.layout.container.boxOverflow.MenuConfig config){}
        public Menu(){}
        public Menu(params object[] args){}
    }
    #endregion
    #region MenuConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MenuConfig : NoneConfig
    {
        /// <summary>
        /// CSS class added to the Button which shows the overflow menu.
        /// </summary>
        public JsString triggerButtonCls;
        public MenuConfig(params object[] args){}
    }
    #endregion
    #region MenuEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class MenuEvents : NoneEvents
    {
        public MenuEvents(params object[] args){}
    }
    #endregion
}
