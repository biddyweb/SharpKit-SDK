//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.Test_
{
    /// <summary>
    /// ComparisonFailure is subclass of Error that is thrown whenever
    /// a comparison between two values fails. It provides mechanisms to retrieve
    /// both the expected and actual value.
    /// </summary>
    public partial class ComparisonFailure : AssertionError
    {
        /// <summary>
        /// Returns a fully formatted error for an assertion failure. This message
        /// provides information about the expected and actual values.
        /// </summary>
        public object getMessage(){return null;}
        /// <summary>
        /// The actual value.
        /// </summary>
        public object actual{get;set;}
        /// <summary>
        /// The expected value.
        /// </summary>
        public object expected{get;set;}
    }
}
