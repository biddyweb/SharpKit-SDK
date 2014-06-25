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
    /// RightAxisLayout contains algorithms for rendering a right axis.
    /// </summary>
    public partial class RightAxisLayout
    {
        /// <summary>
        /// Returns the transformOrigin to use for an axis label based on the position of the axis
        /// and the rotation of the label.
        /// </summary>
        protected Y_.Array _getTransformOrigin(Y_.DataType_.Number rot){return null;}
        /// <summary>
        /// Adjusts the coordinates of an axis label based on the rotation.
        /// </summary>
        protected void _setRotationCoords(object props){}
        /// <summary>
        /// Draws a tick
        /// </summary>
        protected void drawTick(Path path, object pt, object _Object_){}
        /// <summary>
        /// Determines the available label width when the axis width has been explicitly set.
        /// </summary>
        protected object getExplicitlySized(){return null;}
        /// <summary>
        /// Calculates the point for a label.
        /// </summary>
        protected object getLabelPoint(object point){return null;}
        /// <summary>
        /// Calculates the coordinates for the first point on an axis.
        /// </summary>
        protected object getLineStart(){return null;}
        /// <summary>
        /// Adjusts position for inner ticks.
        /// </summary>
        protected void offsetNodeForTick(Node cb){}
        /// <summary>
        /// Rotate and position labels.
        /// </summary>
        protected void positionLabel(object label, object pt){}
        /// <summary>
        /// Rotate and position title.
        /// </summary>
        protected void positionTitle(object label){}
        /// <summary>
        /// Assigns a height based on the size of the contents.
        /// </summary>
        protected void setCalculatedSize(){}
        /// <summary>
        /// Sets the length of the tick on either side of the axis line.
        /// </summary>
        protected void setTickOffset(){}
        /// <summary>
        /// Updates the value for the `maxLabelSize` for use in calculating total size.
        /// </summary>
        protected void updateMaxLabelSize(object label){}
    }
}
