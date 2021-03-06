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
    /// Create a slider to represent an input control capable of representing a
    /// series of intermediate states based on the position of the slider's thumb.
    /// These states are typically aligned to a value algorithm whereby the thumb
    /// position corresponds to a given value. Sliders may be oriented vertically or
    /// horizontally, based on the <code>axis</code> configuration.
    /// </summary>
    public partial class SliderBase : Widget
    {
        /// <summary>
        /// Locks or unlocks the thumb.
        /// </summary>
        protected void _afterDisabledChange(Event e){}
        /// <summary>
        /// Dispatches the <code>thumbMove</code> event.
        /// </summary>
        protected void _afterDrag(Event e){}
        /// <summary>
        /// Handles changes to the <code>length</code> attribute.  By default, it
        /// triggers an update to the UI.
        /// </summary>
        protected void _afterLengthChange(Event e){}
        /// <summary>
        /// Makes the thumb draggable and constrains it to the rail.
        /// </summary>
        protected void _bindThumbDD(){}
        /// <summary>
        /// Stub implementation.  Override this (presumably in a class extension) to
        /// initialize any value logic that depends on the presence of the Drag
        /// instance.
        /// </summary>
        protected void _bindValueLogic(){}
        /// <summary>
        /// decrements Slider value by a major increment
        /// </summary>
        protected void _decrMajor(){}
        /// <summary>
        /// decrements Slider value by a minor increment
        /// </summary>
        protected void _decrMinor(){}
        /// <summary>
        /// increments Slider value by a major increment
        /// </summary>
        protected void _incrMajor(){}
        /// <summary>
        /// increments Slider value by a minor increment
        /// </summary>
        protected void _incrMinor(){}
        /// <summary>
        /// <p>Defaults the thumbURL attribute according to the current skin, or
        /// &quot;sam&quot; if none can be determined.  Horizontal Sliders will have
        /// their <code>thumbUrl</code> attribute set to</p>
        /// <p><code>&quot;/<em>configured</em>/<em>yu</em>i/<em>builddi</em>r/slider-base/assets/skins/sam/thumb-x.png&quot;</code></p>
        /// <p>And vertical thumbs will get</p>
        /// <p><code>&quot;/<em>configured</em>/<em>yui</em>/<em>builddir</em>/slider-base/assets/skins/sam/thumb-y.png&quot;</code></p>
        /// </summary>
        protected void _initThumbUrl(){}
        /// <summary>
        /// sets the Slider's value in response to key events.
        /// Left and right keys are in a separate method
        /// in case an implementation wants to increment values
        /// but needs left and right arrow keys for other purposes.
        /// </summary>
        protected void _onDirectionKey(Event e){}
        /// <summary>
        /// Dispatches the <code>slideEnd</code> event.
        /// </summary>
        protected void _onDragEnd(Event e){}
        /// <summary>
        /// Dispatches the <code>slideStart</code> event.
        /// </summary>
        protected void _onDragStart(Event e){}
        /// <summary>
        /// sets the Slider's value in response to left or right key events
        /// </summary>
        protected void _onLeftRightKey(Event e){}
        /// <summary>
        /// sets the Slider's value in response to left or right key events when a meta (mac command/apple) key is also pressed
        /// </summary>
        protected void _onLeftRightKeyMeta(Event e){}
        /// <summary>
        /// Gives focus to the thumb enabling keyboard access after clicking thumb
        /// </summary>
        protected void _onThumbClick(){}
        /// <summary>
        /// Validates the axis is &quot;x&quot; or &quot;y&quot; (case insensitive).
        /// Converts to lower case for storage.
        /// </summary>
        protected object _setAxis(object v){return null;}
        /// <summary>
        /// <p>Ensures the stored length value is a string with a quantity and unit.
        /// Unit will be defaulted to &quot;px&quot; if not included.  Rejects
        /// values less than or equal to 0 and those that don't at least start with
        /// a number.</p>
        /// <p>Currently only pixel lengths are supported.</p>
        /// </summary>
        protected object _setLength(object v){return null;}
        /// <summary>
        /// sets the Slider value to the max value.
        /// </summary>
        protected void _setToMax(){}
        /// <summary>
        /// sets the Slider value to the min value.
        /// </summary>
        protected void _setToMin(){}
        /// <summary>
        /// Stub implementation.  Override this (presumably in a class extension) to
        /// ensure the thumb is in the correct position according to the value
        /// alogorithm.
        /// instance.
        /// </summary>
        protected void _syncThumbPosition(){}
        /// <summary>
        /// Moves the thumb to pixel offset position along the rail.
        /// </summary>
        protected void _uiMoveThumb(Y_.DataType_.Number offset){}
        /// <summary>
        /// Moves the thumb to pixel offset position along the rail.
        /// </summary>
        protected void _uiMoveThumb(Y_.DataType_.Number offset, object options){}
        /// <summary>
        /// Sets the rail length according to the <code>length</code> attribute.
        /// </summary>
        protected void _uiSetRailLength(object length){}
        /// <summary>
        /// Creates the Y.DD.Drag instance used to handle the thumb movement and
        /// binds Slider interaction to the configured value model.
        /// </summary>
        protected void bindUI(){}
        /// <summary>
        /// Construction logic executed during Slider instantiation.
        /// </summary>
        protected void initializer(){}
        /// <summary>
        /// Creates the Slider rail DOM subtree for insertion into the Slider's
        /// <code>contentBox</code>.  Override this method if you want to provide
        /// the rail element (presumably from existing markup).
        /// </summary>
        public Node renderRail(){return null;}
        /// <summary>
        /// Creates the Slider thumb DOM subtree for insertion into the Slider's
        /// rail.  Override this method if you want to provide the thumb element
        /// (presumably from existing markup).
        /// </summary>
        public Node renderThumb(){return null;}
        /// <summary>
        /// Create the DOM structure for the Slider.
        /// </summary>
        protected void renderUI(){}
        /// <summary>
        /// Synchronizes the DOM state with the attribute settings.
        /// </summary>
        public void syncUI(){}
    }
}
