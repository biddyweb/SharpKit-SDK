//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// A base class for widgets, providing:
    /// <ul>
    /// <li>The render lifecycle method, in addition to the init and destroy
    /// lifecycle methods provide by Base</li>
    /// <li>Abstract methods to support consistent MVC structure across
    /// widgets: renderer, renderUI, bindUI, syncUI</li>
    /// <li>Support for common widget attributes, such as boundingBox, contentBox, visible,
    /// disabled, focused, strings</li>
    /// </ul>
    /// </summary>
    public partial class Widget : Y_.Base
    {
        /// <summary>
        /// Default attribute change listener for the <code>selected</code>
        /// attribute, responsible for updating the UI, in response to
        /// attribute changes.
        /// </summary>
        protected void _afterChildSelectedChange(EventFacade @event){}
        protected object _applyParsedConfig(){return null;}
        /// <summary>
        /// Utilitity method used to apply the <code>HTML_PARSER</code> configuration for the
        /// instance, to retrieve config data values.
        /// </summary>
        protected void _applyParser(object config){}
        /// <summary>
        /// Sets up DOM listeners, on elements rendered by the widget.
        /// </summary>
        protected void _bindDOM(){}
        /// <summary>
        /// Sets up DOM and CustomEvent listeners for the widget.
        /// </summary>
        protected void _bindUI(){}
        /// <summary>
        /// Binds event listeners responsible for updating the UI state in response
        /// to WidgetChild related state changes.
        /// <p>
        /// This method is invoked after bindUI is invoked for the Widget class
        /// using YUI's aop infrastructure.
        /// </p>
        /// </summary>
        protected void _bindUIChild(){}
        [JsMethod(JsonInitializers=true)]
        public Widget(){}
        /// <summary>
        /// Returns the default value for the contentBox attribute.
        /// For the Widget class, this will be the srcNode if provided, otherwise null (resulting in
        /// a new contentBox node instance being created)
        /// </summary>
        protected void _defaultCB(){}
        /// <summary>
        /// Default render handler
        /// </summary>
        protected void _defRenderFn(EventFacade e, Node parentNode){}
        /// <summary>
        /// Removes and destroys the widgets rendered boundingBox, contentBox,
        /// and detaches bound UI events.
        /// </summary>
        protected void _destroyBox(){}
        protected Node _getSrcNode(){return null;}
        /// <summary>
        /// Returns the strings key/value hash for a paricular locale, without locale lookup applied.
        /// </summary>
        protected void _getStrings(object locale){}
        /// <summary>
        /// Returns the node on which to bind delegate listeners.
        /// Override of Widget's implementation of _getUIEventNode() to ensure that
        /// all event listeners are bound to the Widget's topmost DOM element.
        /// This ensures that the firing of each type of Widget UI event (click,
        /// mousedown, etc.) is facilitated by a single, top-level, delegated DOM
        /// event listener.
        /// </summary>
        protected void _getUIEventNode(){}
        protected void _guid(){}
        /// <summary>
        /// Utility method used to add an entry to the boundingBox id to instance map.
        /// This method can be used to populate the instance with lazily created boundingBox Node references.
        /// </summary>
        protected void _mapInstance(object The){}
        /// <summary>
        /// DOM focus event handler, used to sync the state of the Widget with the DOM
        /// </summary>
        protected void _onDocFocus(EventFacade evt){}
        /// <summary>
        /// "mousedown" event handler for the owner document of the
        /// widget's bounding box.
        /// </summary>
        protected void _onDocMouseDown(EventFacade evt){}
        /// <summary>
        /// Removes class names representative of the widget's loading state from
        /// the boundingBox.
        /// </summary>
        protected void _removeLoadingClassNames(){}
        /// <summary>
        /// Applies standard class names to the boundingBox and contentBox
        /// </summary>
        protected void _renderBoxClassNames(){}
        /// <summary>
        /// Initializes the UI state for the Widget's bounding/content boxes.
        /// </summary>
        protected void _renderUI(){}
        /// <summary>
        /// Sets strings for a particular locale, merging with any existing
        /// strings which may already be defined for the locale.
        /// </summary>
        protected void _setStrings(object strings, object locale){}
        /// <summary>
        /// The default setter for the strings attribute. Merges partial sets
        /// into the full string set, to allow users to partial sets of strings
        /// </summary>
        protected object _strSetter(object strings){return null;}
        /// <summary>
        /// Updates the widget UI to reflect the attribute state.
        /// </summary>
        protected void _syncUI(){}
        /// <summary>
        /// Synchronizes the UI to match the WidgetChild state.
        /// <p>
        /// This method is invoked after bindUI is invoked for the Widget class
        /// using YUI's aop infrastructure.
        /// </p>
        /// </summary>
        protected void _syncUIChild(){}
        /// <summary>
        /// Updates the UI to reflect the <code>selected</code> attribute value.
        /// </summary>
        protected void _uiSetChildSelected(Y_.DataType_.Number selected){}
        /// <summary>
        /// Sets the disabled state for the UI
        /// </summary>
        protected void _uiSetDisabled(object val){}
        /// <summary>
        /// Sets the focused state for the UI
        /// </summary>
        protected void _uiSetFocused(object val, object src){}
        /// <summary>
        /// Sets the height on the widget's bounding box element
        /// </summary>
        protected void _uiSetHeight(object val){}
        /// <summary>
        /// Set the tabIndex on the widget's rendered UI
        /// </summary>
        protected void _uiSetTabIndex(object Number){}
        /// <summary>
        /// Sets the visible state for the UI
        /// </summary>
        protected void _uiSetVisible(object val){}
        /// <summary>
        /// Sets the width on the widget's bounding box element
        /// </summary>
        protected void _uiSetWidth(object val){}
        protected void _uiSizeCB(object expand){}
        protected void _unbindDOM(){}
        protected void _unbindUI(){}
        protected void _validTabIndex(Y_.DataType_.Number tabIndex){}
        /// <summary>
        /// Returns the Widget instance at the specified depth.
        /// </summary>
        public Widget ancestor(Y_.DataType_.Number depth){return null;}
        /// <summary>
        /// Configures/Sets up listeners to bind Widget State to UI/DOM
        /// This method is not called by framework and is not chained
        /// automatically for the class hierarchy.
        /// </summary>
        protected void bindUI(){}
        /// <summary>
        /// Causes the Widget to lose focus by setting the "focused" attribute
        /// to "false"
        /// </summary>
        public void blur(){}
        /// <summary>
        /// <p>
        /// Destroy lifecycle method. Fires the destroy
        /// event, prior to invoking destructors for the
        /// class hierarchy.
        /// Overrides Base's implementation, to support arguments to destroy
        /// </p>
        /// <p>
        /// Subscribers to the destroy
        /// event can invoke preventDefault on the event object, to prevent destruction
        /// from proceeding.
        /// </p>
        /// </summary>
        public Widget destroy(object destroyAllNodes){return null;}
        /// <summary>
        /// Destructor lifecycle implementation for the Widget class. Purges events attached
        /// to the bounding box and content box, removes them from the DOM and removes
        /// the Widget from the list of registered widgets.
        /// </summary>
        protected void destructor(){}
        /// <summary>
        /// Set the Widget's "disabled" attribute to "true".
        /// </summary>
        public void disable(){}
        /// <summary>
        /// Set the Widget's "disabled" attribute to "false".
        /// </summary>
        public void enable(){}
        /// <summary>
        /// Causes the Widget to receive the focus by setting the "focused"
        /// attribute to "true".
        /// </summary>
        public void focus(){}
        /// <summary>
        /// Returns the widget instance whose bounding box contains, or is, the given node.
        /// <p>
        /// In the case of nested widgets, the nearest bounding box ancestor is used to
        /// return the widget instance.
        /// </p>
        /// </summary>
        public Widget getByNode(object node){return null;}
        /// <summary>
        /// Generate a standard prefixed classname for the Widget, prefixed by the default prefix defined
        /// by the <code>Y.config.classNamePrefix</code> attribute used by <code>ClassNameManager</code> and
        /// <code>Widget.NAME.toLowerCase()</code> (e.g. "yui-widget-xxxxx-yyyyy", based on default values for
        /// the prefix and widget class name).
        /// <p>
        /// The instance based version of this method can be used to generate standard prefixed classnames,
        /// based on the instances NAME, as opposed to Widget.NAME. This method should be used when you
        /// need to use a constant class name across different types instances.
        /// </p>
        /// </summary>
        public void getClassName(object args){}
        /// <summary>
        /// Returns the default locale for the widget (the locale value defined by the
        /// widget class, or provided by the user during construction).
        /// </summary>
        public object getDefaultLocale(){return null;}
        /// <summary>
        /// Returns the name of the skin that's currently applied to the widget.
        /// This is only really useful after the widget's DOM structure is in the
        /// document, either by render or by progressive enhancement.  Searches up
        /// the Widget's ancestor axis for a class yui3-skin-(name), and returns the
        /// (name) portion.  Otherwise, returns null.
        /// </summary>
        public object getSkinName(){return null;}
        /// <summary>
        /// Helper method to get a specific string value
        /// </summary>
        public object getString(object key){return null;}
        /// <summary>
        /// Gets the string for a particular key, for a particular locale, performing locale lookup.
        /// <p>
        /// If no values if defined for the key, for the given locale, the value for the
        /// default locale (in initial locale set for the class) is returned.
        /// </p>
        /// </summary>
        public void getString(object key, object locale){}
        /// <summary>
        /// Gets the entire strings hash for a particular locale, performing locale lookup.
        /// <p>
        /// If no values of the key are defined for a particular locale the value for the
        /// default locale (in initial locale set for the class) is returned.
        /// </p>
        /// </summary>
        public void getStrings(object locale){}
        /// <summary>
        /// Hides the Widget by setting the "visible" attribute to "false".
        /// </summary>
        public void hide(){}
        /// <summary>
        /// Initializer lifecycle implementation for the Widget class. Registers the
        /// widget instance, and runs through the Widget's HTML_PARSER definition.
        /// </summary>
        protected void initializer(object config){}
        /// <summary>
        /// Determines if the Widget is the root Widget in the
        /// object hierarchy.
        /// </summary>
        public object isRoot(){return null;}
        /// <summary>
        /// Returns the Widget's next sibling.
        /// </summary>
        public Widget next(object circular){return null;}
        /// <summary>
        /// Returns the Widget's previous sibling.
        /// </summary>
        public Widget previous(object circular){return null;}
        /// <summary>
        /// Establishes the initial DOM for the widget. Invoking this
        /// method will lead to the creating of all DOM elements for
        /// the widget (or the manipulation of existing DOM elements
        /// for the progressive enhancement use case).
        /// <p>
        /// This method should only be invoked once for an initialized
        /// widget.
        /// </p>
        /// <p>
        /// It delegates to the widget specific renderer method to do
        /// the actual work.
        /// </p>
        /// </summary>
        public void render(object parentNode){}
        /// <summary>
        /// Creates DOM (or manipulates DOM for progressive enhancement)
        /// This method is invoked by render() and is not chained
        /// automatically for the class hierarchy (unlike initializer, destructor)
        /// so it should be chained manually for subclasses if required.
        /// </summary>
        protected void renderer(){}
        /// <summary>
        /// Adds nodes to the DOM
        /// This method is not called by framework and is not chained
        /// automatically for the class hierarchy.
        /// </summary>
        protected void renderUI(){}
        /// <summary>
        /// Shows the Widget by setting the "visible" attribute to "true".
        /// </summary>
        public void show(){}
        /// <summary>
        /// Refreshes the rendered UI, based on Widget State
        /// This method is not called by framework and is not chained
        /// automatically for the class hierarchy.
        /// </summary>
        protected void syncUI(){}
        /// <summary>
        /// Generic toString implementation for all widgets.
        /// </summary>
        public object toString(){return null;}
        /// <summary>
        /// Static property used to define the default attribute
        /// configuration for the Widget.
        /// </summary>
        public object ATTRS{get;set;}
        /// <summary>
        /// Object hash, defining how attribute values are to be parsed from
        /// markup contained in the widget's content box. e.g.:
        /// <pre>
        /// {
        /// // Set single Node references using selector syntax
        /// // (selector is run through node.one)
        /// titleNode: "span.yui-title",
        /// // Set NodeList references using selector syntax
        /// // (array indicates selector is to be run through node.all)
        /// listNodes: ["li.yui-item"],
        /// // Set other attribute types, using a parse function.
        /// // Context is set to the widget instance.
        /// label: function(contentBox) {
        /// return contentBox.one("span.title").get("innerHTML");
        /// }
        /// }
        /// </pre>
        /// </summary>
        public object HTML_PARSER{get;set;}
        /// <summary>
        /// Collection of strings used to label elements of the Widget's UI.
        /// </summary>
        public object strings{get;set;}
        /// <summary>
        /// Number (between -32767 to 32767) indicating the widget's
        /// position in the default tab flow.  The value is used to set the
        /// "tabIndex" attribute on the widget's bounding box.  Negative values allow
        /// the widget to receive DOM focus programmatically (by calling the focus
        /// method), while being removed from the default tab flow.  A value of
        /// null removes the "tabIndex" attribute from the widget's bounding box.
        /// </summary>
        public Y_.DataType_.Number tabIndex{get;set;}
        /// <summary>
        /// Map of DOM events that should be fired as Custom Events by the
        /// Widget instance.
        /// </summary>
        public object UI_EVENTS{get;set;}
    }
}
