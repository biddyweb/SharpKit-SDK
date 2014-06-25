//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.data
{
    #region NodeInterface
    /// <inheritdocs />
    /// <summary>
    /// <p>This class is used as a set of methods that are applied to the prototype of a
    /// Model to decorate it with a Node API. This means that models used in conjunction with a tree
    /// will have all of the tree related methods available on the model. In general this class will
    /// not be used directly by the developer. This class also creates extra fields on the model if
    /// they do not exist, to help maintain the tree state and UI. These fields are documented as
    /// config options.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class NodeInterface : Ext.Base
    {
        /// <summary>
        /// Set to false to deny dragging of this node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDrag;
        /// <summary>
        /// Set to false to deny dropping on this node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDrop;
        /// <summary>
        /// Set to true or false to show a checkbox alongside this node.
        /// Defaults to: <c>null</c>
        /// </summary>
        public bool @checked;
        /// <summary>
        /// Array of child nodes.
        /// </summary>
        public NodeInterface children;
        /// <summary>
        /// CSS class to apply for this node.
        /// </summary>
        public JsString cls;
        /// <summary>
        /// The number of parents this node has. A root node has depth 0, a child of it depth 1, and so on...
        /// </summary>
        public JsNumber depth;
        /// <summary>
        /// Set to true to allow for expanding/collapsing of this node.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expandable;
        /// <summary>
        /// True if the node is expanded.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expanded;
        /// <summary>
        /// An URL for a link that's created when this config is specified.
        /// </summary>
        public JsString href;
        /// <summary>
        /// Target for link. Only applicable when href also specified.
        /// </summary>
        public JsString hrefTarget;
        /// <summary>
        /// URL for this node's icon.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// CSS class to apply for this node's icon.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// The position of the node inside its parent. When parent has 4 children and the node is third amongst them,
        /// index will be 2.
        /// </summary>
        public JsNumber index;
        /// <summary>
        /// Set to true to indicate that this child can have no children. The expand icon/arrow will then not be
        /// rendered for this node.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool leaf;
        /// <summary>
        /// True if the node has finished loading.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool loaded;
        /// <summary>
        /// True if the node is currently loading.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool loading;
        /// <summary>
        /// ID of parent node.
        /// </summary>
        public JsString parentId;
        /// <summary>
        /// Tooltip text to show on this node.
        /// </summary>
        public JsString qtip;
        /// <summary>
        /// Tooltip title.
        /// </summary>
        public JsString qtitle;
        /// <summary>
        /// True if this is the root node.
        /// </summary>
        public bool root;
        /// <summary>
        /// The text for to show on node label.
        /// </summary>
        public JsString text;
        /// <summary>
        /// An array of this nodes children.  Array will be empty if this node has no chidren.
        /// </summary>
        public JsObject childNodes{get;set;}
        /// <summary>
        /// A reference to this node's first child node. null if this node has no children.
        /// </summary>
        public JsObject firstChild{get;set;}
        /// <summary>
        /// true in this class to identify an object as an instantiated Node, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isNode{get;set;}
        /// <summary>
        /// A reference to this node's last child node. null if this node has no children.
        /// </summary>
        public JsObject lastChild{get;set;}
        /// <summary>
        /// A reference to this node's next sibling node. null if this node does not have a next sibling.
        /// </summary>
        public JsObject nextSibling{get;set;}
        /// <summary>
        /// A reference to this node's parent node. null if this node is the root node.
        /// </summary>
        public JsObject parentNode{get;set;}
        /// <summary>
        /// A reference to this node's previous sibling node. null if this node does not have a previous sibling.
        /// </summary>
        public JsObject previousSibling{get;set;}
        /// <summary>
        /// Inserts node(s) as the last child node of this node.
        /// If the node was previously a child node of another parent node, it will be removed from that node first.
        /// </summary>
        /// <param name="node"><p>The node or Array of nodes to append</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The appended node if single append, or null if an array was passed</p>
        /// </div>
        /// </returns>
        public NodeInterface appendChild(object node){return null;}
        /// <summary>
        /// Bubbles up the tree from this node, calling the specified function with each node. The arguments to the function
        /// will be the args provided or the current node. If the function returns false at any point,
        /// the bubble is stopped.
        /// </summary>
        /// <param name="fn"><p>The function to call</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed. Defaults to the current Node.</p>
        /// </param>
        /// <param name="args"><p>The args to call the function with. Defaults to passing the current Node.</p>
        /// </param>
        public void bubble(System.Delegate fn, object scope=null, object args=null){}
        /// <summary>
        /// Cascades down the tree from this node, calling the specified function with each node. The arguments to the function
        /// will be the args provided or the current node. If the function returns false at any point,
        /// the cascade is stopped on that branch.
        /// </summary>
        /// <param name="fn"><p>The function to call</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed. Defaults to the current Node.</p>
        /// </param>
        /// <param name="args"><p>The args to call the function with. Defaults to passing the current Node.</p>
        /// </param>
        public void cascadeBy(System.Delegate fn, object scope=null, object args=null){}
        /// <summary>
        /// Clears the node.
        /// </summary>
        /// <param name="destroy"><p>True to destroy the node.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        private void clear(object destroy=null){}
        /// <summary>
        /// Collapse this node.
        /// </summary>
        /// <param name="recursive"><p>True to recursively collapse all the children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="callback"><p>The function to execute once the collapse completes</p>
        /// </param>
        /// <param name="scope"><p>The scope to run the callback in</p>
        /// </param>
        public void collapse(object recursive=null, object callback=null, object scope=null){}
        /// <summary>
        /// Collapse all the children of this node.
        /// </summary>
        /// <param name="recursive"><p>True to recursively collapse all the children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="callback"><p>The function to execute once all the children are collapsed</p>
        /// </param>
        /// <param name="scope"><p>The scope to run the callback in</p>
        /// </param>
        public void collapseChildren(object recursive=null, object callback=null, object scope=null){}
        /// <summary>
        /// Returns true if this node is an ancestor (at any point) of the passed node.
        /// </summary>
        /// <param name="node">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool contains(NodeInterface node){return false;}
        /// <summary>
        /// Creates a copy (clone) of this Node.
        /// </summary>
        /// <param name="id"><p>A new id, defaults to this Node's id.</p>
        /// </param>
        /// <param name="deep"><p>True to recursively copy all child Nodes into the new Node.
        /// False to copy without child Nodes.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>A copy of this Node.</p>
        /// </div>
        /// </returns>
        public NodeInterface copy(object id=null, object deep=null){return null;}
        /// <summary>
        /// Ensures that the passed object is an instance of a Record with the NodeInterface applied
        /// </summary>
        /// <param name="node">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div>
        /// </div>
        /// </returns>
        public NodeInterface createNode(object node){return null;}
        /// <summary>
        /// Destroys the node.
        /// </summary>
        /// <param name="silent">
        /// </param>
        public void destroy(object silent){}
        /// <summary>
        /// Interates the child nodes of this node, calling the specified function with each node. The arguments to the function
        /// will be the args provided or the current node. If the function returns false at any point,
        /// the iteration stops.
        /// </summary>
        /// <param name="fn"><p>The function to call</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed. Defaults to the current Node in iteration.</p>
        /// </param>
        /// <param name="args"><p>The args to call the function with. Defaults to passing the current Node.</p>
        /// </param>
        public void eachChild(System.Delegate fn, object scope=null, object args=null){}
        /// <summary>
        /// Expand this node.
        /// </summary>
        /// <param name="recursive"><p>True to recursively expand all the children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="callback"><p>The function to execute once the expand completes</p>
        /// </param>
        /// <param name="scope"><p>The scope to run the callback in</p>
        /// </param>
        public void expand(object recursive=null, object callback=null, object scope=null){}
        /// <summary>
        /// Expand all the children of this node.
        /// </summary>
        /// <param name="recursive"><p>True to recursively expand all the children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="callback"><p>The function to execute once all the children are expanded</p>
        /// </param>
        /// <param name="scope"><p>The scope to run the callback in</p>
        /// </param>
        public void expandChildren(object recursive=null, object callback=null, object scope=null){}
        /// <summary>
        /// Finds the first child that has the attribute with the specified value.
        /// </summary>
        /// <param name="attribute"><p>The attribute name</p>
        /// </param>
        /// <param name="value"><p>The value to search for</p>
        /// </param>
        /// <param name="deep"><p>True to search through nodes deeper than the immediate children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The found child or null if none was found</p>
        /// </div>
        /// </returns>
        public NodeInterface findChild(JsString attribute, object value, object deep=null){return null;}
        /// <summary>
        /// Finds the first child by a custom function. The child matches if the function passed returns true.
        /// </summary>
        /// <param name="fn"><p>A function which must return true if the passed Node is the required Node.</p>
        /// </param>
        /// <param name="scope"><p>The scope (this reference) in which the function is executed. Defaults to the Node being tested.</p>
        /// </param>
        /// <param name="deep"><p>True to search through nodes deeper than the immediate children</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The found child or null if none was found</p>
        /// </div>
        /// </returns>
        public NodeInterface findChildBy(System.Delegate fn, object scope=null, object deep=null){return null;}
        /// <summary>
        /// Returns the bubble target for this node
        /// </summary>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The bubble target</p>
        /// </div>
        /// </returns>
        private object getBubbleTarget(){return null;}
        /// <summary>
        /// Returns the child node at the specified index.
        /// </summary>
        /// <param name="index">
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div>
        /// </div>
        /// </returns>
        public NodeInterface getChildAt(JsNumber index){return null;}
        /// <summary>
        /// Returns depth of this node (the root node has a depth of 0)
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div>
        /// </div>
        /// </returns>
        public JsNumber getDepth(){return null;}
        /// <summary>
        /// Gets the hierarchical path from the root of the current node.
        /// </summary>
        /// <param name="field"><p>The field to construct the path from. Defaults to the model idProperty.</p>
        /// </param>
        /// <param name="separator"><p>A separator to use.</p>
        /// <p>Defaults to: <c>&quot;/&quot;</c></p></param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The node path</p>
        /// </div>
        /// </returns>
        public JsString getPath(object field=null, object separator=null){return null;}
        /// <summary>
        /// Returns true if this node has one or more child nodes, else false.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool hasChildNodes(){return false;}
        /// <summary>
        /// Returns the index of a child node
        /// </summary>
        /// <param name="node">
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The index of the node or -1 if it was not found</p>
        /// </div>
        /// </returns>
        public JsNumber indexOf(NodeInterface node){return null;}
        /// <summary>
        /// Returns the index of a child node that matches the id
        /// </summary>
        /// <param name="id"><p>The id of the node to find</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>The index of the node or -1 if it was not found</p>
        /// </div>
        /// </returns>
        public JsNumber indexOfId(JsString id){return null;}
        /// <summary>
        /// Inserts the first node before the second node in this nodes childNodes collection.
        /// </summary>
        /// <param name="node"><p>The node to insert</p>
        /// </param>
        /// <param name="refNode"><p>The node to insert before (if null the node is appended)</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The inserted node</p>
        /// </div>
        /// </returns>
        public NodeInterface insertBefore(NodeInterface node, NodeInterface refNode){return null;}
        /// <summary>
        /// Inserts a node into this node.
        /// </summary>
        /// <param name="index"><p>The zero-based index to insert the node at</p>
        /// </param>
        /// <param name="node"><p>The node to insert</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The node you just inserted</p>
        /// </div>
        /// </returns>
        public NodeInterface insertChild(JsNumber index, NodeInterface node){return null;}
        /// <summary>
        /// Returns true if the passed node is an ancestor (at any point) of this node.
        /// </summary>
        /// <param name="node">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isAncestor(NodeInterface node){return false;}
        /// <summary>
        /// Returns true if this node has one or more child nodes, or if the expandable
        /// node attribute is explicitly specified as true, otherwise returns false.
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isExpandable(){return false;}
        /// <summary>
        /// Returns true if this node is expaned
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isExpanded(){return false;}
        /// <summary>
        /// Returns true if this node is the first child of its parent
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isFirst(){return false;}
        /// <summary>
        /// Returns true if this node is the last child of its parent
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isLast(){return false;}
        /// <summary>
        /// Returns true if this node is a leaf
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isLeaf(){return false;}
        /// <summary>
        /// Returns true if this node is loaded
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isLoaded(){return false;}
        /// <summary>
        /// Returns true if this node is loading
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isLoading(){return false;}
        /// <summary>
        /// Returns true if this node is the root node
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isRoot(){return false;}
        /// <summary>
        /// Returns true if this node is visible
        /// </summary>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool isVisible(){return false;}
        /// <summary>
        /// Removes this node from its parent
        /// </summary>
        /// <param name="destroy"><p>True to destroy the node upon removal.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public NodeInterface remove(object destroy=null){return null;}
        /// <summary>
        /// Removes all child nodes from this node.
        /// </summary>
        /// <param name="destroy"><p>&lt;True to destroy the node upon removal.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public NodeInterface removeAll(object destroy=null){return null;}
        /// <summary>
        /// Removes a child node from this node.
        /// </summary>
        /// <param name="node"><p>The node to remove</p>
        /// </param>
        /// <param name="destroy"><p>True to destroy the node upon removal.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The removed node</p>
        /// </div>
        /// </returns>
        public NodeInterface removeChild(NodeInterface node, object destroy=null){return null;}
        /// <summary>
        /// Replaces one child node in this node with another.
        /// </summary>
        /// <param name="newChild"><p>The replacement node</p>
        /// </param>
        /// <param name="oldChild"><p>The node to replace</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.data.NodeInterface">Ext.data.NodeInterface</see></span><div><p>The replaced node</p>
        /// </div>
        /// </returns>
        public NodeInterface replaceChild(NodeInterface newChild, NodeInterface oldChild){return null;}
        /// <summary>
        /// Sets the first child of this node
        /// </summary>
        /// <param name="node">
        /// </param>
        private void setFirstChild(NodeInterface node){}
        /// <summary>
        /// Sets the last child of this node
        /// </summary>
        /// <param name="node">
        /// </param>
        private void setLastChild(NodeInterface node){}
        /// <summary>
        /// Sorts this nodes children using the supplied sort function.
        /// </summary>
        /// <param name="fn"><p>A function which, when passed two Nodes, returns -1, 0 or 1 depending upon required sort order.</p>
        /// </param>
        /// <param name="recursive"><p>True to apply this sort recursively</p>
        /// <p>Defaults to: <c>false</c></p></param>
        /// <param name="suppressEvent"><p>True to not fire a sort event.</p>
        /// <p>Defaults to: <c>false</c></p></param>
        public void sort(System.Delegate fn, object recursive=null, object suppressEvent=null){}
        /// <summary>
        /// Updates general data of this node like isFirst, isLast, depth. This
        /// method is internally called after a node is moved. This shouldn't
        /// have to be called by the developer unless they are creating custom
        /// Tree plugins.
        /// </summary>
        /// <param name="commit">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool updateInfo(object commit){return false;}
        /// <summary>
        /// This method allows you to decorate a Model's class to implement the NodeInterface.
        /// This adds a set of methods, new events, new properties and new fields on every Record.
        /// </summary>
        /// <param name="modelClass"><p>The Model class or an instance of the Model class you want to
        /// decorate the prototype of.</p>
        /// </param>
        public static void decorate(object modelClass){}
        public NodeInterface(NodeInterfaceConfig config){}
        public NodeInterface(){}
        public NodeInterface(params object[] args){}
    }
    #endregion
    #region NodeInterfaceConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NodeInterfaceConfig : Ext.BaseConfig
    {
        /// <summary>
        /// Set to false to deny dragging of this node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDrag;
        /// <summary>
        /// Set to false to deny dropping on this node.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool allowDrop;
        /// <summary>
        /// Set to true or false to show a checkbox alongside this node.
        /// Defaults to: <c>null</c>
        /// </summary>
        public bool @checked;
        /// <summary>
        /// Array of child nodes.
        /// </summary>
        public NodeInterface children;
        /// <summary>
        /// CSS class to apply for this node.
        /// </summary>
        public JsString cls;
        /// <summary>
        /// The number of parents this node has. A root node has depth 0, a child of it depth 1, and so on...
        /// </summary>
        public JsNumber depth;
        /// <summary>
        /// Set to true to allow for expanding/collapsing of this node.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expandable;
        /// <summary>
        /// True if the node is expanded.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool expanded;
        /// <summary>
        /// An URL for a link that's created when this config is specified.
        /// </summary>
        public JsString href;
        /// <summary>
        /// Target for link. Only applicable when href also specified.
        /// </summary>
        public JsString hrefTarget;
        /// <summary>
        /// URL for this node's icon.
        /// </summary>
        public JsString icon;
        /// <summary>
        /// CSS class to apply for this node's icon.
        /// </summary>
        public JsString iconCls;
        /// <summary>
        /// The position of the node inside its parent. When parent has 4 children and the node is third amongst them,
        /// index will be 2.
        /// </summary>
        public JsNumber index;
        /// <summary>
        /// True if this is the first node.
        /// </summary>
        public bool isFirst;
        /// <summary>
        /// True if this is the last node.
        /// </summary>
        public bool isLast;
        /// <summary>
        /// Set to true to indicate that this child can have no children. The expand icon/arrow will then not be
        /// rendered for this node.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool leaf;
        /// <summary>
        /// True if the node has finished loading.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool loaded;
        /// <summary>
        /// True if the node is currently loading.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool loading;
        /// <summary>
        /// ID of parent node.
        /// </summary>
        public JsString parentId;
        /// <summary>
        /// Tooltip text to show on this node.
        /// </summary>
        public JsString qtip;
        /// <summary>
        /// Tooltip title.
        /// </summary>
        public JsString qtitle;
        /// <summary>
        /// True if this is the root node.
        /// </summary>
        public bool root;
        /// <summary>
        /// The text for to show on node label.
        /// </summary>
        public JsString text;
        public NodeInterfaceConfig(params object[] args){}
    }
    #endregion
    #region NodeInterfaceEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NodeInterfaceEvents : Ext.BaseEvents
    {
        /// <summary>
        /// Fires when a new child node is appended
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The newly appended node</p>
        /// </param>
        /// <param name="index"><p>The index of the newly appended node</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void append(NodeInterface @this, NodeInterface node, JsNumber index, object eOpts){}
        /// <summary>
        /// Fires before a new child is appended, return false to cancel the append.
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The child node to be appended</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeappend(NodeInterface @this, NodeInterface node, object eOpts){}
        /// <summary>
        /// Fires before this node is collapsed.
        /// </summary>
        /// <param name="this"><p>The collapsing node</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforecollapse(NodeInterface @this, object eOpts){}
        /// <summary>
        /// Fires before this node is expanded.
        /// </summary>
        /// <param name="this"><p>The expanding node</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeexpand(NodeInterface @this, object eOpts){}
        /// <summary>
        /// Fires before a new child is inserted, return false to cancel the insert.
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The child node to be inserted</p>
        /// </param>
        /// <param name="refNode"><p>The child node the node is being inserted before</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeinsert(NodeInterface @this, NodeInterface node, NodeInterface refNode, object eOpts){}
        /// <summary>
        /// Fires before this node is moved to a new location in the tree. Return false to cancel the move.
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="oldParent"><p>The parent of this node</p>
        /// </param>
        /// <param name="newParent"><p>The new parent this node is moving to</p>
        /// </param>
        /// <param name="index"><p>The index it is being moved to</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforemove(NodeInterface @this, NodeInterface oldParent, NodeInterface newParent, JsNumber index, object eOpts){}
        /// <summary>
        /// Fires before a child is removed, return false to cancel the remove.
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The child node to be removed</p>
        /// </param>
        /// <param name="isMove"><p><c>true</c> if the child node is being removed so it can be moved to another position in the tree.
        /// (a side effect of calling <see cref="Ext.data.NodeInterface.appendChild">appendChild</see> or
        /// <see cref="Ext.data.NodeInterface.insertBefore">insertBefore</see> with a node that already has a parentNode)</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void beforeremove(NodeInterface @this, NodeInterface node, bool isMove, object eOpts){}
        /// <summary>
        /// Fires when this node is collapsed.
        /// </summary>
        /// <param name="this"><p>The collapsing node</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void collapse(NodeInterface @this, object eOpts){}
        /// <summary>
        /// Fires when this node is expanded.
        /// </summary>
        /// <param name="this"><p>The expanding node</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void expand(NodeInterface @this, object eOpts){}
        /// <summary>
        /// Fires when a new child node is inserted.
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The child node inserted</p>
        /// </param>
        /// <param name="refNode"><p>The child node the node was inserted before</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void insert(NodeInterface @this, NodeInterface node, NodeInterface refNode, object eOpts){}
        /// <summary>
        /// Fires when this node is moved to a new location in the tree
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="oldParent"><p>The old parent of this node</p>
        /// </param>
        /// <param name="newParent"><p>The new parent of this node</p>
        /// </param>
        /// <param name="index"><p>The index it was moved to</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void move(NodeInterface @this, NodeInterface oldParent, NodeInterface newParent, JsNumber index, object eOpts){}
        /// <summary>
        /// Fires when a child node is removed
        /// </summary>
        /// <param name="this"><p>This node</p>
        /// </param>
        /// <param name="node"><p>The removed node</p>
        /// </param>
        /// <param name="isMove"><p><c>true</c> if the child node is being removed so it can be moved to another position in the tree.
        /// (a side effect of calling <see cref="Ext.data.NodeInterface.appendChild">appendChild</see> or
        /// <see cref="Ext.data.NodeInterface.insertBefore">insertBefore</see> with a node that already has a parentNode)</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void remove(NodeInterface @this, NodeInterface node, bool isMove, object eOpts){}
        /// <summary>
        /// Fires when this node's childNodes are sorted.
        /// </summary>
        /// <param name="this"><p>This node.</p>
        /// </param>
        /// <param name="childNodes"><p>The childNodes of this node.</p>
        /// </param>
        /// <param name="eOpts"><p>The options object passed to <see cref="Ext.util.Observable.addListener">Ext.util.Observable.addListener</see>.</p>
        /// </param>
        public void sort(NodeInterface @this, JsArray<Ext.data.NodeInterface> childNodes, object eOpts){}
        public NodeInterfaceEvents(params object[] args){}
    }
    #endregion
}
