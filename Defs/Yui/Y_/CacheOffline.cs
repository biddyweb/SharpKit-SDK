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
    /// Extends Cache utility with offline functionality.
    /// </summary>
    public partial class CacheOffline : Y_.Cache
    {
        [JsMethod(JsonInitializers=true)]
        public CacheOffline(){}
        /// <summary>
        /// Adds entry to cache.
        /// </summary>
        protected void _defAddFn(object e){}
        /// <summary>
        /// Flushes cache.
        /// </summary>
        protected void _defFlushFn(object e){}
        /// <summary>
        /// Gets all entries.
        /// </summary>
        protected void _getEntries(){}
        /// <summary>
        /// Gets size.
        /// </summary>
        protected void _getSize(){}
        /// <summary>
        /// Always return null.
        /// </summary>
        protected void _setMax(){}
        /// <summary>
        /// Adds a new entry to the cache of the format
        /// {request:request, response:response, cached:cached, expires: expires}.
        /// </summary>
        public void add(object request, object response){}
        /// <summary>
        /// Removes all items from all sandboxes. Useful if localStorage has
        /// exceeded quota. Only supported on browsers that implement HTML 5
        /// localStorage.
        /// </summary>
        public void flushAll(){}
        /// <summary>
        /// Retrieves cached object for given request, if available.
        /// Returns null if there is no cache match.
        /// </summary>
        public object retrieve(object request){return null;}
        /// <summary>
        /// Disabled.
        /// </summary>
        public object max{get;private set;}
        /// <summary>
        /// Always true for CacheOffline.
        /// </summary>
        public object uniqueKeys{get;private set;}
    }
}
