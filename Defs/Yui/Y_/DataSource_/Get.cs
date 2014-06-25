//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.DataSource_
{
    /// <summary>
    /// Get Utility subclass for the DataSource Utility.
    /// </summary>
    public partial class Get : Local
    {
        [JsMethod(JsonInitializers=true)]
        public Get(){}
        /// <summary>
        /// Passes query string to Get Utility. Fires <code>response</code> event when
        /// response is received asynchronously.
        /// </summary>
        protected void _defRequestFn(object e){}
        /// <summary>
        /// Default method for adding callback param to url.  See
        /// generateRequestCallback attribute.
        /// </summary>
        protected void _generateRequest(object guid){}
        /// <summary>
        /// Accepts the DataSource instance and a callback ID, and returns a callback
        /// param/value string that gets appended to the script URI. Implementers
        /// can customize this string to match their server's query syntax.
        /// </summary>
        public JsAction generateRequestCallback{get;set;}
    }
}
