//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE.util
{
    /// <summary>
    /// This class contains simple cookie manangement functions.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinymce.util.Cookie", Export=false)]
    public static  partial class Cookie
    {
        /// <summary>
        /// Gets the raw data of a cookie by name.
        /// </summary>
        /// <param name="n">Name of cookie to retrive.</param>
        public static string get(string n){return null;}
        /// <summary>
        /// Parses the specified query string into an name/value object.
        /// </summary>
        /// <param name="n">String to parse into a n Hashtable object.</param>
        public static object getHash(string n){return null;}
        /// <summary>
        /// Removes/deletes a cookie by name.
        /// </summary>
        /// <param name="name">Cookie name to remove/delete.</param>
        /// <param name="path">Optional path to remove the cookie from.</param>
        /// <param name="domain">Optional domain to restrict the cookie to.</param>
        public static object remove(string name, object path, object domain){return null;}
        /// <summary>
        /// Sets a raw cookie string.
        /// </summary>
        /// <param name="n">Name of the cookie.</param>
        /// <param name="v">Raw cookie data.</param>
        /// <param name="e">Optional date object for the expiration of the cookie.</param>
        /// <param name="p">Optional path to restrict the cookie to.</param>
        /// <param name="d">Optional domain to restrict the cookie to.</param>
        /// <param name="s">Is the cookie secure or not.</param>
        public static object set(string n, string v, object e, string p, string d, string s){return null;}
        /// <summary>
        /// Sets a hashtable name/value object to a cookie.
        /// </summary>
        /// <param name="n">Name of the cookie.</param>
        /// <param name="v">Hashtable object to set as cookie.</param>
        /// <param name="e">Optional date object for the expiration of the cookie.</param>
        /// <param name="p">Optional path to restrict the cookie to.</param>
        /// <param name="d">Optional domain to restrict the cookie to.</param>
        /// <param name="s">Is the cookie secure or not.</param>
        public static object setHash(string n, object v, object e, string p, string d, string s){return null;}
    }
}
