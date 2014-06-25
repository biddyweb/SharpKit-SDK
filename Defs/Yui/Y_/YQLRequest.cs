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
    /// Utility Class used under the hood my the YQL class
    /// </summary>
    public partial class YQLRequest
    {
        /// <summary>
        /// The method that executes the YQL Request.
        /// </summary>
        public YQLRequest send(){return null;}
        /// <summary>
        /// The base URL to query: query.yahooapis.com/v1/public/yql?
        /// </summary>
        public object BASE_URL{get;set;}
        /// <summary>
        /// The environment file to load: http://datatables.org/alltables.env
        /// </summary>
        public object ENV{get;set;}
        /// <summary>
        /// Default format to use: json
        /// </summary>
        public object FORMAT{get;set;}
        /// <summary>
        /// Default protocol to use: http
        /// </summary>
        public object PROTO{get;set;}
    }
}
