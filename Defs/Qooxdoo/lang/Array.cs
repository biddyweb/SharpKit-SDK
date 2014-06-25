// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.lang
{
    /// <summary>
	/// <para>Static helper functions for arrays with a lot of often used convenience
	/// methods like remove or contains.</para>
	/// <para>The native JavaScript Array is not modified by this class. However,
	/// there are modifications to the native Array in <see cref="qx.lang.normalize.Array"/> for
	/// browsers that do not support certain JavaScript features natively .</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.lang.Array", OmitOptionalParameters = true, Export = false)]
    public partial class Array 
    {
		#region Methods

		public Array() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Append the elements of an array to the array</para>
		/// </summary>
		/// <param name="arr1">the array</param>
		/// <param name="arr2">the elements of this array will be appended to other one</param>
		/// <returns>The modified array.</returns>
		[JsMethod(Name = "append")]
		public static JsArray Append(JsArray arr1, JsArray arr2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts an array like object to any other array like
		/// object.</para>
		/// <para>Attention: The returned array may be same
		/// instance as the incoming one if the constructor is identical!</para>
		/// </summary>
		/// <param name="objectx">any array-like object</param>
		/// <param name="constructor">constructor of the new instance</param>
		/// <param name="offset">position to start from</param>
		/// <returns>the converted array</returns>
		[JsMethod(Name = "cast")]
		public static JsArray Cast(object objectx, Action<object> constructor, double offset = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return a copy of the given array</para>
		/// </summary>
		/// <param name="arr">the array to copy</param>
		/// <returns>copy of the array</returns>
		[JsMethod(Name = "clone")]
		public static JsArray Clone(JsArray arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the array contains the given element</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="obj">object to look for</param>
		/// <returns>whether the arr contains the element</returns>
		[JsMethod(Name = "contains")]
		public static bool Contains(JsArray arr, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the two arrays have the same content. Checks only the
		/// equality of the arrays&#8217; content.</para>
		/// </summary>
		/// <param name="arr1">first array</param>
		/// <param name="arr2">second array</param>
		/// <returns>Whether the two arrays are equal</returns>
		[JsMethod(Name = "equals")]
		public static bool Equals(JsArray arr1, JsArray arr2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Modifies the first array as it removes all elements
		/// which are listed in the second array as well.</para>
		/// </summary>
		/// <param name="arr1">the array</param>
		/// <param name="arr2">the elements of this array will be excluded from the other one</param>
		/// <returns>The modified array.</returns>
		[JsMethod(Name = "exclude")]
		public static JsArray Exclude(JsArray arr1, JsArray arr2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Convert an arguments object into an array.</para>
		/// </summary>
		/// <param name="args">arguments object</param>
		/// <param name="offset">position to start from</param>
		/// <returns>a newly created array (copy) with the content of the arguments object.</returns>
		[JsMethod(Name = "fromArguments")]
		public static JsArray FromArguments(JsArguments args, double offset = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Convert a (node) collection into an array</para>
		/// </summary>
		/// <param name="coll">node collection</param>
		/// <returns>a newly created array (copy) with the content of the node collection.</returns>
		[JsMethod(Name = "fromCollection")]
		public static JsArray FromCollection(object coll) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Expand shorthand definition to a four element list.
		/// This is an utility function for padding/margin and all other shorthand handling.</para>
		/// </summary>
		/// <param name="input">arr with one to four elements</param>
		/// <returns>an arr with four elements</returns>
		[JsMethod(Name = "fromShortHand")]
		public static JsArray FromShortHand(JsArray input) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element into the array after a given second element.</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="obj">object to be inserted</param>
		/// <param name="obj2">insert obj1 after this object</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertAfter")]
		public static JsArray InsertAfter(JsArray arr, object obj, object obj2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element at a given position into the array</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="obj">the element to insert</param>
		/// <param name="i">position where to insert the element into the array</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertAt")]
		public static JsArray InsertAt(JsArray arr, object obj, double i) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Insert an element into the array before a given second element.</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="obj">object to be inserted</param>
		/// <param name="obj2">insert obj1 before this object</param>
		/// <returns>the array</returns>
		[JsMethod(Name = "insertBefore")]
		public static JsArray InsertBefore(JsArray arr, object obj, object obj2) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the highest value in the given array. Supports
		/// numeric values only.</para>
		/// </summary>
		/// <param name="arr">Array to process</param>
		/// <returns>The highest of all values or undefined if array is empty.</returns>
		[JsMethod(Name = "max")]
		public static double Max(double arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the lowest value in the given array. Supports
		/// numeric values only.</para>
		/// </summary>
		/// <param name="arr">Array to process</param>
		/// <returns>The lowest of all values or undefined if array is empty.</returns>
		[JsMethod(Name = "min")]
		public static double Min(double arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an element from the array.</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="obj">element to be removed from the array</param>
		/// <returns>the removed element</returns>
		[JsMethod(Name = "remove")]
		public static object Remove(JsArray arr, object obj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove all elements from the array</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <returns>empty array</returns>
		[JsMethod(Name = "removeAll")]
		public static JsArray RemoveAll(JsArray arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove an element from the array at the given index</para>
		/// </summary>
		/// <param name="arr">the array</param>
		/// <param name="i">index of the element to be removed</param>
		/// <returns>The removed element.</returns>
		[JsMethod(Name = "removeAt")]
		public static object RemoveAt(JsArray arr, double i) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the sum of all values in the given array. Supports
		/// numeric values only.</para>
		/// </summary>
		/// <param name="arr">Array to process</param>
		/// <returns>The sum of all values.</returns>
		[JsMethod(Name = "sum")]
		public static double Sum(double arr) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Converts array like constructions like the argument object,
		/// node collections like the ones returned by getElementsByTagName
		/// or extended array objects like qx.type.BaseArray to an
		/// native Array instance.</para>
		/// </summary>
		/// <param name="objectx">any array like object</param>
		/// <param name="offset">position to start from</param>
		/// <returns>New array with the content of the incoming object</returns>
		[JsMethod(Name = "toArray")]
		public static JsArray ToArray(object objectx, double offset = 0) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Recreates an array which is free of all duplicate elements from the original.</para>
		/// <para>This method do not modifies the original array!</para>
		/// <para>Keep in mind that this methods deletes undefined indexes.</para>
		/// </summary>
		/// <param name="arr">Incoming array</param>
		/// <returns>Returns a copy with no duplicates or the original array if no duplicates were found</returns>
		[JsMethod(Name = "unique")]
		public static JsArray Unique(JsArray arr) { throw new NotImplementedException(); }

		#endregion Methods
    }
}