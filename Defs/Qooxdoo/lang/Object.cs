// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.lang
{
    /// <summary>
	/// <para>Helper functions to handle Object as a Hash map.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.lang.Object", OmitOptionalParameters = true, Export = false)]
    public partial class Object 
    {
		#region Methods

		public Object() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Inserts all key/value pairs of the source object into the
		/// target object but doesn&#8217;t override existing keys</para>
		/// </summary>
		/// <param name="target">target object</param>
		/// <param name="source">object to be merged</param>
		/// <returns>target with merged values from source</returns>
		[JsMethod(Name = "carefullyMergeWith")]
		public static object CarefullyMergeWith(object target, object source) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return a copy of an Object</para>
		/// </summary>
		/// <param name="source">Object to copy</param>
		/// <param name="deep">If the clone should be a deep clone.</param>
		/// <returns>A copy of the object</returns>
		[JsMethod(Name = "clone")]
		public static object Clone(object source, bool deep) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the map contains the given value.</para>
		/// </summary>
		/// <param name="map">Map to search for the value</param>
		/// <param name="value">Value to look for</param>
		/// <returns>Whether the value was found in the map.</returns>
		[JsMethod(Name = "contains")]
		public static bool Contains(object map, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Clears the map from all values</para>
		/// </summary>
		/// <param name="map">the map to clear</param>
		[JsMethod(Name = "empty")]
		public static void Empty(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Convert an array into a map.</para>
		/// <para>All elements of the array become keys of the returned map by
		/// calling toString on the array elements. The values of the
		/// map are set to true</para>
		/// </summary>
		/// <param name="array">array to convert</param>
		/// <returns>the array converted to a map.</returns>
		[JsMethod(Name = "fromArray")]
		public static object FromArray(JsArray array) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the key of the given value from a map.
		/// If the map has more than one key matching the value, the first match is returned.
		/// If the map does not contain the value, null is returned.</para>
		/// </summary>
		/// <param name="map">Map to search for the key</param>
		/// <param name="value">Value to look for</param>
		/// <returns>Name of the key (null if not found).</returns>
		[JsMethod(Name = "getKeyFromValue")]
		public static string GetKeyFromValue(object map, object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the keys of a map as array as returned by a &#8220;for&#8230; in&#8221; statement.</para>
		/// </summary>
		/// <param name="map">the map</param>
		/// <returns>array of the keys of the map</returns>
		[JsMethod(Name = "getKeys")]
		public static JsArray GetKeys(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the keys of a map as string</para>
		/// </summary>
		/// <param name="map">the map</param>
		/// <returns>String of the keys of the map The keys are separated by &#8221;, &#8221;</returns>
		[JsMethod(Name = "getKeysAsString")]
		public static string GetKeysAsString(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the number of objects in the map</para>
		/// </summary>
		/// <param name="map">the map</param>
		/// <returns>number of objects in the map</returns>
		[JsMethod(Name = "getLength")]
		public static double GetLength(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the values of a map as array</para>
		/// </summary>
		/// <param name="map">the map</param>
		/// <returns>array of the values of the map</returns>
		[JsMethod(Name = "getValues")]
		public static JsArray GetValues(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the number of objects in the maps is at least &#8220;length&#8221;</para>
		/// </summary>
		/// <param name="map">the map to check</param>
		/// <param name="minLength">minimum number of objects in the map</param>
		/// <returns>whether the map contains at least &#8220;length&#8221; objects.</returns>
		[JsMethod(Name = "hasMinLength")]
		public static bool HasMinLength(object map, double minLength) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Inverts a map by exchanging the keys with the values.</para>
		/// <para>If the map has the same values for different keys, information will get lost.
		/// The values will be converted to strings using the toString methods.</para>
		/// </summary>
		/// <param name="map">Map to invert</param>
		/// <returns>inverted Map</returns>
		[JsMethod(Name = "invert")]
		public static object Invert(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check if the hash has any keys</para>
		/// </summary>
		/// <param name="map">the map to check</param>
		/// <returns>whether the map has any keys</returns>
		[JsMethod(Name = "isEmpty")]
		public static bool IsEmpty(object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Merge a number of objects.</para>
		/// </summary>
		/// <param name="target">target object</param>
		/// <param name="varargs">variable number of objects to merged with target</param>
		/// <returns>target with merged values from the other objects</returns>
		[JsMethod(Name = "merge")]
		public static object Merge(object target, object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Inserts all keys of the source object into the
		/// target objects. Attention: The target map gets modified.</para>
		/// </summary>
		/// <param name="target">target object</param>
		/// <param name="source">object to be merged</param>
		/// <param name="overwrite">If enabled existing keys will be overwritten</param>
		/// <returns>Target with merged values from the source object</returns>
		[JsMethod(Name = "mergeWith")]
		public static object MergeWith(object target, object source, bool overwrite = true) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Selects the value with the given key from the map.</para>
		/// </summary>
		/// <param name="key">name of the key to get the value from</param>
		/// <param name="map">map to get the value from</param>
		/// <returns>value for the given key from the map</returns>
		[JsMethod(Name = "select")]
		public static object Select(string key, object map) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Serializes an object to URI parameters (also known as query string).</para>
		/// <para>Escapes characters that have a special meaning in URIs as well as
		/// umlauts. Uses the global function encodeURIComponent, see
		/// https://developer.mozilla.org/en/JavaScript/Reference/Global_Objects/encodeURIComponent</para>
		/// <para>Note: For URI parameters that are to be sent as
		/// application/x-www-form-urlencoded (POST), spaces should be encoded
		/// with &#8221;+&#8221;.</para>
		/// </summary>
		/// <param name="obj">Object to serialize.</param>
		/// <param name="post">Whether spaces should be encoded with &#8221;+&#8221;.</param>
		/// <returns>Serialized object. Safe to append to URIs or send as URL encoded string.</returns>
		[JsMethod(Name = "toUriParameter")]
		public static string ToUriParameter(object obj, bool post) { throw new NotImplementedException(); }

		#endregion Methods
    }
}