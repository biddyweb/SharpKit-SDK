//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.menu
{
    #region Item
    /// <inheritdocs />
    /// <summary>
    /// <p>A base class for all menu items that require menu-related functionality such as click handling,
    /// sub-menus, icons, etc.</p>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.menu.Menu">Ext.menu.Menu</see>', {
    /// width: 100,
    /// height: 100,
    /// floating: false,  // usually you want this set to True (default)
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>(),  // usually rendered by it's containing component
    /// items: [{
    /// text: 'icon item',
    /// iconCls: 'add16'
    /// },{
    /// text: 'text item'
    /// },{
    /// text: 'plain item',
    /// plain: true
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Item : Ext.Component
    {
        /// <summary>
        /// The CSS class added to the menu item when the item is activated (focused/mouseover).
        /// Defaults to: <c>&quot;x-menu-item-active&quot;</c>
        /// </summary>
        public JsString activeCls;
        /// <summary>
        /// Defaults to: <c>&quot;menuitem&quot;</c>
        /// </summary>
        public JsString ariaRole;
        /// <summary>
        /// Whether or not this menu item can be activated when focused/mouseovered.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool canActivate;
        /// <summary>
        /// The delay in milliseconds to wait before hiding the menu after clicking the menu item.
        /// This only has an effect when hideOnClick: true.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber clickHideDelay;
        /// <summary>
        /// Whether or not to destroy any associated sub-menu when this item is destroyed.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool destroyMenu;
        /// <summary>
        /// A function called when the menu item is clicked (can be used instead of click event).
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// Whether to not to hide the owning menu when this item is clicked.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hideOnClick;
        /// <summary>
        /// The href attribute to use for the underlying anchor link.
        /// Defaults to: <c>&quot;#&quot;</c>
        /// </summary>
        public JsString href;
        /// <summary>
        /// The target attribute to use for the underlying anchor link.
        /// </summary>
        public JsString hrefTarget;
        /// <summary>
        /// The path to an icon to display in this item.
        /// Defaults to <c>Ext.BLANK_IMAGE_URL</c>.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// A CSS class that specifies a background-image to use as the icon for this item.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// The default Ext.Element.getAlignToXY anchor position value for this
        /// item's sub-menu relative to this item's position.
        /// Defaults to: <c>&quot;tl-tr?&quot;</c>
        /// </summary>
        public JsString menuAlign;
        /// <summary>
        /// The delay in milliseconds before this item's sub-menu expands after this item is moused over.
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber menuExpandDelay;
        /// <summary>
        /// The delay in milliseconds before this item's sub-menu hides after this item is moused out.
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber menuHideDelay;
        /// <summary>
        /// Whether or not this item is plain text/html with no icon or visual activation.
        /// </summary>
        public bool plain;
        /// <summary>
        /// The text/html to display in this item.
        /// </summary>
        public JsString text;
        /// <summary>
        /// The tooltip for the button - can be a string to be used as innerHTML (html tags are accepted) or
        /// QuickTips config object.
        /// </summary>
        public object tooltip;
        /// <summary>
        /// The type of tooltip to use. Either 'qtip' for QuickTips or 'title' for title attribute.
        /// Defaults to: <c>&quot;qtip&quot;</c>
        /// </summary>
        public JsString tooltipType;
        /// <summary>
        /// Whether or not this item is currently activated
        /// </summary>
        public bool activated{get;set;}
        /// <summary>
        /// The sub-menu associated with this item, if one was configured.
        /// </summary>
        public Ext.menu.Menu menu{get;set;}
        /// <summary>
        /// The parent Menu of this item.
        /// </summary>
        public Ext.menu.Menu parentMenu{get;set;}
        /// <summary>
        /// Sets the click handler of this item
        /// </summary>
        /// <param name="fn"><p>The handler function</p>
        /// </param>
        /// <param name="scope"><p>The scope of the handler function</p>
        /// </param>
        public void setHandler(System.Delegate fn, object scope=null){}
        /// <summary>
        /// Sets the icon on this item.
        /// </summary>
        /// <param name="icon"><p>The new icon</p>
        /// </param>
        public void setIcon(JsString icon){}
        /// <summary>
        /// Sets the iconCls of this item
        /// </summary>
        /// <param name="iconCls"><p>The CSS class to set to <see cref="Ext.menu.ItemConfig.iconCls">iconCls</see></p>
        /// </param>
        public void setIconCls(JsString iconCls){}
        /// <summary>
        /// Set a child menu for this item. See the menu configuration.
        /// </summary>
        /// <param name="menu"><p>A menu, or menu configuration. null may be
        /// passed to remove the menu.</p>
        /// </param>
        /// <param name="destroyMenu"><p>True to destroy any existing menu. False to
        /// prevent destruction. If not specified, the <see cref="Ext.menu.ItemConfig.destroyMenu">destroyMenu</see> configuration
        /// will be used.</p>
        /// </param>
        public void setMenu(object menu, object destroyMenu=null){}
        /// <summary>
        /// Sets the text of this item
        /// </summary>
        /// <param name="text"><p>The <see cref="Ext.menu.ItemConfig.text">text</see></p>
        /// </param>
        public void setText(JsString text){}
        /// <summary>
        /// Sets the tooltip for this menu item.
        /// </summary>
        /// <param name="tooltip"><p>This may be:</p>
        /// <ul>
        /// <li><strong>String</strong> : A string to be used as innerHTML (html tags are accepted) to show in a tooltip</li>
        /// <li><strong>Object</strong> : A configuration object for <see cref="Ext.tip.QuickTipManager.register">Ext.tip.QuickTipManager.register</see>.</li>
        /// </ul>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.menu.Item">Ext.menu.Item</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.menu.Item setTooltip(object tooltip){return null;}
        public Item(Ext.menu.ItemConfig config){}
        public Item(){}
        public Item(params object[] args){}
    }
    #endregion
    #region ItemConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ItemConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// The CSS class added to the menu item when the item is activated (focused/mouseover).
        /// Defaults to: <c>&quot;x-menu-item-active&quot;</c>
        /// </summary>
        public JsString activeCls;
        /// <summary>
        /// Defaults to: <c>&quot;menuitem&quot;</c>
        /// </summary>
        public JsString ariaRole;
        /// <summary>
        /// Whether or not this menu item can be activated when focused/mouseovered.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool canActivate;
        /// <summary>
        /// The delay in milliseconds to wait before hiding the menu after clicking the menu item.
        /// This only has an effect when hideOnClick: true.
        /// Defaults to: <c>1</c>
        /// </summary>
        public JsNumber clickHideDelay;
        /// <summary>
        /// Whether or not to destroy any associated sub-menu when this item is destroyed.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool destroyMenu;
        /// <summary>
        /// A function called when the menu item is clicked (can be used instead of click event).
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// Whether to not to hide the owning menu when this item is clicked.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool hideOnClick;
        /// <summary>
        /// The href attribute to use for the underlying anchor link.
        /// Defaults to: <c>&quot;#&quot;</c>
        /// </summary>
        public JsString href;
        /// <summary>
        /// The target attribute to use for the underlying anchor link.
        /// </summary>
        public JsString hrefTarget;
        /// <summary>
        /// The path to an icon to display in this item.
        /// Defaults to <c>Ext.BLANK_IMAGE_URL</c>.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// A CSS class that specifies a background-image to use as the icon for this item.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// Either an instance of Ext.menu.Menu or a config object for an Ext.menu.Menu
        /// which will act as a sub-menu to this item.
        /// </summary>
        public object menu;
        /// <summary>
        /// The default Ext.Element.getAlignToXY anchor position value for this
        /// item's sub-menu relative to this item's position.
        /// Defaults to: <c>&quot;tl-tr?&quot;</c>
        /// </summary>
        public JsString menuAlign;
        /// <summary>
        /// The delay in milliseconds before this item's sub-menu expands after this item is moused over.
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber menuExpandDelay;
        /// <summary>
        /// The delay in milliseconds before this item's sub-menu hides after this item is moused out.
        /// Defaults to: <c>200</c>
        /// </summary>
        public JsNumber menuHideDelay;
        /// <summary>
        /// Whether or not this item is plain text/html with no icon or visual activation.
        /// </summary>
        public bool plain;
        /// <summary>
        /// The text/html to display in this item.
        /// </summary>
        public JsString text;
        /// <summary>
        /// The tooltip for the button - can be a string to be used as innerHTML (html tags are accepted) or
        /// QuickTips config object.
        /// </summary>
        public object tooltip;
        /// <summary>
        /// The type of tooltip to use. Either 'qtip' for QuickTips or 'title' for title attribute.
        /// Defaults to: <c>&quot;qtip&quot;</c>
        /// </summary>
        public JsString tooltipType;
        public ItemConfig(params object[] args){}
    }
    #endregion
    #region ItemEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ItemEvents : Ext.ComponentEvents
    {
        /// <summary>
        /// Fires when this item is clicked
        /// </summary>
        /// <param name="item"><p>The item that was clicked</p>
        /// </param>
        /// <param name="e"><p>The underyling <see cref="Ext.EventObject">Ext.EventObject</see>.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void click(Ext.menu.Item item, EventObject e, object eOpts){}
        public ItemEvents(params object[] args){}
    }
    #endregion
}
