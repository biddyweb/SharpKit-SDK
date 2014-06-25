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
    /// Fires when a item is added.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.AddOnManager", Export=false)]
    public  partial class AddOnManager
    {
        /// <summary>
        /// Adds a instance of the add-on by it's short name.
        /// </summary>
        /// <param name="id">Short name/id for the add-on.</param>
        public SharpKit.TinyMCE.Theme add(string id){return null;}
        /// <summary>
        /// Returns the specified add on by the short name.
        /// </summary>
        /// <param name="n">Add-on to look for.</param>
        public SharpKit.TinyMCE.Theme get(string n){return null;}
        /// <summary>
        /// Loads an add-on from a specific url.
        /// </summary>
        /// <param name="n">Short name of the add-on that gets loaded.</param>
        /// <param name="u">URL to the add-on that will get loaded.</param>
        /// <param name="cb">Optional callback to execute ones the add-on is loaded.</param>
        /// <param name="s">Optional scope to execute the callback in.</param>
        public object load(string n, string u, object cb, object s){return null;}
        /// <summary>
        /// Loads a language pack for the specified add-on.
        /// </summary>
        /// <param name="n">Short name of the add-on.</param>
        public object requireLangPack(string n){return null;}
    }
}
