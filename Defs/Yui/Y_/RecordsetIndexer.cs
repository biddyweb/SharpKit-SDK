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
    /// Plugin that provides the ability to store multiple custom hash tables referencing records in the recordset.
    /// This utility does not support any collision handling. New hash table entries with a used key overwrite older ones.
    /// </summary>
    public partial class RecordsetIndexer
    {
        [JsMethod(JsonInitializers=true)]
        public RecordsetIndexer(){}
        /// <summary>
        /// Creates a new hash table.
        /// </summary>
        public object createTable(object key){return null;}
        /// <summary>
        /// Get a hash table that hashes records by a given key.
        /// </summary>
        public object getTable(object key){return null;}
        /// <summary>
        /// Collection of all the hashTables created by the plugin.
        /// The individual tables can be accessed by the key they are hashing against.
        /// </summary>
        public object hashTables{get;set;}
    }
}
