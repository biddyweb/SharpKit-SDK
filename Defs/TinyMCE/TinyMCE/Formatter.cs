//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE
{
    /// <summary>
    /// Text formatter engine class.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.Formatter", Export=false)]
    public  partial class Formatter
    {
        /// <summary>
        /// Applies the specified format to the current selection or specified node.
        /// </summary>
        /// <param name="name">Name of format to apply.</param>
        /// <param name="vars">Optional list of variables to replace within format before applying it.</param>
        /// <param name="node">Optional node to apply the format to defaults to current selection.</param>
        public object apply(string name, object vars, SharpKit.TinyMCE.html.Node node){return null;}
        /// <summary>
        /// Returns true/false if the specified format can be applied to the current selection or not. It will currently only check the state for selector formats, it returns true on all other format types.
        /// </summary>
        /// <param name="name">Name of format to check.</param>
        public bool canApply(string name){return false;}
        /// <summary>
        /// Executes the specified callback when the current selection matches the formats or not.
        /// </summary>
        /// <param name="formats">Comma separated list of formats to check for.</param>
        /// <param name="callback">Callback with state and args when the format is changed/toggled on/off.</param>
        /// <param name="similar">True/false state if the match should handle similar or exact formats.</param>
        public object formatChanged(string formats, object callback, bool similar){return null;}
        /// <summary>
        /// Returns the format by name or all formats if no name is specified.
        /// </summary>
        /// <param name="name">Optional name to retrive by.</param>
        public Array get(string name){return null;}
        /// <summary>
        /// Matches the current selection or specified node against the specified format name.
        /// </summary>
        /// <param name="name">Name of format to match.</param>
        /// <param name="vars">Optional list of variables to replace before checking it.</param>
        /// <param name="node">Optional node to check.</param>
        public bool match(string name, object vars, SharpKit.TinyMCE.html.Node node){return false;}
        /// <summary>
        /// Matches the current selection against the array of formats and returns a new array with matching formats.
        /// </summary>
        /// <param name="names">Name of format to match.</param>
        /// <param name="vars">Optional list of variables to replace before checking it.</param>
        public Array matchAll(Array names, object vars){return null;}
        /// <summary>
        /// Return true/false if the specified node has the specified format.
        /// </summary>
        /// <param name="node">Node to check the format on.</param>
        /// <param name="name">Format name to check.</param>
        /// <param name="vars">Optional list of variables to replace before checking it.</param>
        /// <param name="similar">Match format that has similar properties.</param>
        public object matchNode(SharpKit.TinyMCE.html.Node node, string name, object vars, bool similar){return null;}
        /// <summary>
        /// Registers a specific format by name.
        /// </summary>
        public object register(){return null;}
        /// <summary>
        /// Removes the specified format from the current selection or specified node.
        /// </summary>
        /// <param name="name">Name of format to remove.</param>
        /// <param name="vars">Optional list of variables to replace within format before removing it.</param>
        public object remove(string name, object vars){return null;}
        /// <summary>
        /// Toggles the specified format on/off.
        /// </summary>
        /// <param name="name">Name of format to apply/remove.</param>
        /// <param name="vars">Optional list of variables to replace within format before applying/removing it.</param>
        /// <param name="node">Optional node to apply the format to or remove from. Defaults to current selection.</param>
        public object toggle(string name, object vars, SharpKit.TinyMCE.html.Node node){return null;}
    }
}
