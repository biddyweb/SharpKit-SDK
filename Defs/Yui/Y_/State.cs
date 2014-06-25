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
    /// The State class maintains state for a collection of named items, with
    /// a varying number of properties defined.
    /// It avoids the need to create a separate class for the item, and separate instances
    /// of these classes for each item, by storing the state in a 2 level hash table,
    /// improving performance when the number of items is likely to be large.
    /// </summary>
    public partial class State
    {
        /// <summary>
        /// Adds a property to an item.
        /// </summary>
        public void add(object name, object key, object val){}
        /// <summary>
        /// Adds multiple properties to an item.
        /// </summary>
        public void addAll(object name, object o){}
        /// <summary>
        /// For a given item, returns the value of the property requested, or undefined if not found.
        /// </summary>
        public object get(object name, object key){return null;}
        /// <summary>
        /// For the given item, returns an object with all of the
        /// item's property/value pairs. By default the object returned
        /// is a shallow copy of the stored data, but passing in true
        /// as the second parameter will return a reference to the stored
        /// data.
        /// </summary>
        public object getAll(object name, object reference){return null;}
        /// <summary>
        /// Removes a property from an item.
        /// </summary>
        public void remove(object name, object key){}
        /// <summary>
        /// Removes multiple properties from an item, or remove the item completely.
        /// </summary>
        public void removeAll(object name, object o){}
        /// <summary>
        /// Hash of attributes
        /// </summary>
        public object data{get;set;}
    }
}
