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
    /// <a href="http://www.w3.org/TR/html5/the-canvas-element.html">Canvas</a> implementation of the `Graphic` class.
    /// `CanvasGraphic` is not intended to be used directly. Instead, use the <a href="Graphic.html">`Graphic`</a> class.
    /// If the browser lacks <a href="http://www.w3.org/TR/SVG/">SVG</a> capabilities but has
    /// <a href="http://www.w3.org/TR/html5/the-canvas-element.html">Canvas</a> capabilities, the <a href="Graphic.html">`Graphic`</a>
    /// class will point to the `CanvasGraphic` class.
    /// </summary>
    public partial class CanvasGraphic
    {
        /// <summary>
        /// Generates a shape instance by type.
        /// </summary>
        public Shape addShape(object cfg){return null;}
        /// <summary>
        /// Adds a shape to the redraw queue and calculates the contentBounds. Used internally
        /// by `Shape` instances.
        /// </summary>
        protected void addToRedrawQueue(object Shape){}
        /// <summary>
        /// Allows for creating multiple shapes in order to batch appending and redraw operations.
        /// </summary>
        public void batch(JsAction method){}
        /// <summary>
        /// Removes all nodes.
        /// </summary>
        public void destroy(){}
        /// <summary>
        /// Returns a shape based on the id of its dom node.
        /// </summary>
        public Shape getShapeById(object id){return null;}
        /// <summary>
        /// Gets the current position of the graphic instance in page coordinates.
        /// </summary>
        public object getXY(){return null;}
        /// <summary>
        /// Removes all shape instances from the dom.
        /// </summary>
        public void removeAllShapes(){}
        /// <summary>
        /// Removes a shape instance from from the graphic instance.
        /// </summary>
        public void removeShape(object shape){}
        /// <summary>
        /// Adds the graphics node to the dom.
        /// </summary>
        public void render(object parentNode){}
    }
}
