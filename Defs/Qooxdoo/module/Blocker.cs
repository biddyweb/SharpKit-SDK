// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.module
{
    /// <summary>
	/// <para>Provides a way to block elements so they will no longer receive (native)
	/// events by overlaying them with a div.
	/// For Internet Explorer, an additional Iframe element will be overlayed since
	/// native form controls cannot be blocked otherwise.</para>
	/// <para>The blocker can also be applied to the entire document, e.g.:</para>
	/// <code>
	/// q(document).block();
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.module.Blocker", OmitOptionalParameters = true, Export = false)]
    public partial class Blocker 
    {
		#region Methods

		public Blocker() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Adds an overlay to all items in the collection that intercepts mouse
		/// events.</para>
		/// </summary>
		/// <param name="color">The color for the blocker element (any CSS color value)</param>
		/// <param name="opacity">The CSS opacity value for the blocker</param>
		/// <param name="zIndex">The zIndex value for the blocker</param>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "block")]
		public static qxWeb Block(string color = "transparent", double opacity = 0, double zIndex = 10000) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Removes the blockers from all items in the collection</para>
		/// </summary>
		/// <returns>The collection for chaining</returns>
		[JsMethod(Name = "unblock")]
		public static qxWeb Unblock() { throw new NotImplementedException(); }

		#endregion Methods
    }
}