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
    /// Wraps some common Selection/Range functionality into a simple object
    /// </summary>
    public partial class EditorSelection
    {
        /// <summary>
        /// Called from Editor keydown to remove the "extra" space before the cursor.
        /// </summary>
        public void cleanCursor(){}
        /// <summary>
        /// Wrapper for the different range creation methods.
        /// </summary>
        public object createRange(){return null;}
        /// <summary>
        /// Performs a prefilter on all nodes in the editor. Looks for nodes with a style: fontFamily or font face
        /// It then creates a dynamic class assigns it and removed the property. This is so that we don't lose
        /// the fontFamily when selecting nodes.
        /// </summary>
        public void filter(){}
        /// <summary>
        /// Method attempts to replace all "orphined" text nodes in the main body by wrapping them with a <p>. Called from filter.
        /// </summary>
        public void filterBlocks(){}
        /// <summary>
        /// Gets a stored cursor and focuses it for editing, must be called sometime after setCursor
        /// </summary>
        public Node focusCursor(){return null;}
        /// <summary>
        /// Get the placeholder in the DOM at the current cursor position.
        /// </summary>
        public Node getCursor(){return null;}
        /// <summary>
        /// Get all the nodes in the current selection. This method will actually perform a filter first.
        /// Then it calls doc.execCommand('fontname', null, 'yui-tmp') to touch all nodes in the selection.
        /// The it compiles a list of all nodes affected by the execCommand and builds a NodeList to return.
        /// </summary>
        public NodeList getSelected(){return null;}
        /// <summary>
        /// Returns the innerHTML of a node with all HTML tags removed.
        /// </summary>
        public object getText(Node node){return null;}
        /// <summary>
        /// Insert HTML at the current cursor position, this method gives you control over the text node to insert into and the offset where to put it.
        /// </summary>
        public Node insertAtCursor(object html, Node node, Y_.DataType_.Number offset, object collapse){return null;}
        /// <summary>
        /// Insert HTML at the current cursor position and return a Node instance of the newly inserted element.
        /// </summary>
        public Node insertContent(object html){return null;}
        /// <summary>
        /// Destroy the range.
        /// </summary>
        public EditorSelection remove(){return null;}
        /// <summary>
        /// Remove the cursor placeholder from the DOM.
        /// </summary>
        public Node removeCursor(object keep){return null;}
        /// <summary>
        /// Utility method to remove dead font-family styles from an element.
        /// </summary>
        public void removeFontFamily(){}
        /// <summary>
        /// Find and replace a string inside a text node and replace it with HTML focusing the node after
        /// to allow you to continue to type.
        /// </summary>
        public Node replace(object se, object re){return null;}
        /// <summary>
        /// Resolve a node from the selection object and return a Node instance
        /// </summary>
        public Node resolve(object n){return null;}
        /// <summary>
        /// Select a Node (hilighting it).
        /// </summary>
        public EditorSelection selectNode(Node node, object collapse){return null;}
        /// <summary>
        /// Put a placeholder in the DOM at the current cursor position.
        /// </summary>
        public Node setCursor(){return null;}
        /// <summary>
        /// Generic toString for logging.
        /// </summary>
        public object toString(){return null;}
        /// <summary>
        /// Undoes what filter does enough to return the HTML from the Editor, then re-applies the filter.
        /// </summary>
        public object unfilter(){return null;}
        /// <summary>
        /// Get all elements inside a selection and wrap them with a new element and return a NodeList of all elements touched.
        /// </summary>
        public NodeList wrapContent(object tag){return null;}
        /// <summary>
        /// The selector to use when looking for Nodes to cache the value of: [style],font[face]
        /// </summary>
        public object ALL{get;set;}
        /// <summary>
        /// A Node instance of the parentNode of the anchorNode of the range
        /// </summary>
        public Node anchorNode{get;set;}
        /// <summary>
        /// The offset from the range object
        /// </summary>
        public Y_.DataType_.Number anchorOffset{get;set;}
        /// <summary>
        /// A Node instance of the actual textNode of the range.
        /// </summary>
        public Node anchorTextNode{get;set;}
        /// <summary>
        /// The selector to use when looking for block level items.
        /// </summary>
        public object BLOCKS{get;set;}
        /// <summary>
        /// The id used to wrap the inner space of the cursor position
        /// </summary>
        public object CUR_WRAPID{get;set;}
        /// <summary>
        /// The default HTML used to focus the cursor..
        /// </summary>
        public object CURSOR{get;set;}
        /// <summary>
        /// The default tag to use when creating elements: span
        /// </summary>
        public object DEFAULT_TAG{get;set;}
        /// <summary>
        /// A Node instance of the parentNode of the focusNode of the range
        /// </summary>
        public Node focusNode{get;set;}
        /// <summary>
        /// The offset from the range object
        /// </summary>
        public Y_.DataType_.Number focusOffset{get;set;}
        /// <summary>
        /// A Node instance of the actual textNode of the range.
        /// </summary>
        public Node focusTextNode{get;set;}
        /// <summary>
        /// Regular Expression to determine if a string has a character in it
        /// </summary>
        public object REG_CHAR{get;set;}
        /// <summary>
        /// Regular Expression used to find dead font-family styles
        /// </summary>
        public object REG_FONTFAMILY{get;set;}
        /// <summary>
        /// Regular Expression to remove all HTML from a string
        /// </summary>
        public object REG_NOHTML{get;set;}
        /// <summary>
        /// Regular Expression to determine if a string has a non-character in it
        /// </summary>
        public object REG_NON{get;set;}
        /// <summary>
        /// The temporary fontname applied to a selection to retrieve their values: yui-tmp
        /// </summary>
        public object TMP{get;set;}
    }
}
