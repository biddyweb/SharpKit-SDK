// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>The is a template class which can be used for HTML templating. In fact,
	/// this is a wrapper for mustache.js which is a &#8220;framework-agnostic way to
	/// render logic-free views&#8221;.</para>
	/// <para>Here is a basic example how to use it:
	/// Template:</para>
	/// <code>
	/// var template = "Hi, my name is {{name}}!";
	/// var view = {name: "qooxdoo"};
	/// qx.bom.Template.render(template, view);
	/// // return "Hi, my name is qooxdoo!"
	/// </code>
	/// https://github.com/janl/mustache.js/blob/master/README.md</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.Template", OmitOptionalParameters = true, Export = false)]
    public partial class Template 
    {
		#region Methods

		public Template() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Helper method which provides you with a direct access to templates
		/// stored as HTML in the DOM. The DOM node with the given ID will be used
		/// as a template, parsed and a new DOM node will be returned containing the
		/// parsed data. Keep in mind to have only one root DOM element in the the
		/// template.
		/// Additionally, you should not put the template into a regular, hidden
		/// DOM element because the template may not be valid HTML due to the containing
		/// mustache tags. We suggest to put it into a script tag with the type
		/// text/template.</para>
		/// </summary>
		/// <param name="id">The id of the HTML template in the DOM.</param>
		/// <param name="view">The object holding the data to render.</param>
		/// <param name="partials">Object holding parts of a template.</param>
		/// <returns>A DOM element holding the parsed template data.</returns>
		[JsMethod(Name = "get")]
		public static qx.html.Element Get(string id, object view, object partials) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Original and only template method of mustache.js. For further
		/// documentation, please visit https://github.com/janl/mustache.js</para>
		/// </summary>
		/// <param name="template">The String containing the template.</param>
		/// <param name="view">The object holding the data to render.</param>
		/// <param name="partials">Object holding parts of a template.</param>
		/// <returns>The parsed template.</returns>
		[JsMethod(Name = "render")]
		public static string Render(string template, object view, object partials) { throw new NotImplementedException(); }

		#endregion Methods
    }
}