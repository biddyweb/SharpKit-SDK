// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util
{
    /// <summary>
	/// <para>This singleton manages global resource aliases.</para>
	/// <para>The AliasManager supports simple prefix replacement on strings. There are
	/// some pre-defined aliases, and you can register your own with <see cref="Add"/>.
	/// The AliasManager is automatically invoked in various situations, e.g. when
	/// resolving the icon image for a button, so it is common to register aliases for
	/// resource id&#8217;s.
	/// You can of course call the AliasManager&#8217;s <see cref="Resolve"/>
	/// explicitly to get an alias resolution in any situation, but keep that
	/// automatic invocation of the AliasManager in mind when defining new aliases as
	/// they will be applied globally in many classes, not only your own.</para>
	/// <para>Examples:
	/// <list type="bullet">
	/// <item> foo -> bar/16pt/baz  (resolves e.g. &#8220;foo/a/b/c.png&#8221; to
	/// &#8220;bar/16pt/baz/a/b/c.png&#8221;)
	/// <item> imgserver -> http&#058;&#047;&#047;imgs03.myserver.com/my/app/
	/// (resolves e.g. &#8220;imgserver/a/b/c.png&#8221; to
	/// &#8220;http&#058;&#047;&#047;imgs03.myserver.com/my/app/a/b/c.png&#8221;)
	/// </list</para>
	/// <para>For resources, only aliases that resolve to proper resource id&#8217;s can be managed
	/// resources, and will be considered unmanaged resources otherwise.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.AliasManager", OmitOptionalParameters = true, Export = false)]
    public partial class AliasManager : qx.util.ValueManager
    {
		#region Methods

		public AliasManager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Define an alias to a resource path</para>
		/// </summary>
		/// <param name="alias">alias name for the resource path/url</param>
		/// <param name="basex">first part of URI for all images which use this alias</param>
		[JsMethod(Name = "add")]
		public void Add(string alias, string basex) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get registered aliases</para>
		/// </summary>
		/// <returns>the map of the currently registered alias:resolution pairs</returns>
		[JsMethod(Name = "getAliases")]
		public object GetAliases() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Remove a previously defined alias</para>
		/// </summary>
		/// <param name="alias">alias name for the resource path/url</param>
		[JsMethod(Name = "remove")]
		public void Remove(string alias) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resolves a given path</para>
		/// </summary>
		/// <param name="path">input path</param>
		/// <returns>resulting path (with interpreted aliases)</returns>
		[JsMethod(Name = "resolve")]
		public string Resolve(string path) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.util.AliasManager GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}