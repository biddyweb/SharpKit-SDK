//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region Template
    /// <inheritdocs />
    /// <summary>
    /// <p>Represents an HTML fragment template. Templates may be <see cref="Ext.Template.compile">precompiled</see> for greater performance.</p>
    /// <p>An instance of this class may be created by passing to the constructor either a single argument, or multiple
    /// arguments:</p>
    /// <h1>Single argument: String/Array</h1>
    /// <p>The single argument may be either a String or an Array:</p>
    /// <ul>
    /// <li><p>String:</p>
    /// <pre><code>var t = new <see cref="Ext.Template">Ext.Template</see>("&lt;div&gt;Hello {0}.&lt;/div&gt;");
    /// t.<see cref="Ext.Template.append">append</see>('some-element', ['foo']);
    /// </code></pre></li>
    /// <li><p>Array:</p>
    /// <p>An Array will be combined with <c>join('')</c>.</p>
    /// <pre><code>var t = new <see cref="Ext.Template">Ext.Template</see>([
    /// '&lt;div name="{id}"&gt;',
    /// '&lt;span class="{cls}"&gt;{name:trim} {value:ellipsis(10)}&lt;/span&gt;',
    /// '&lt;/div&gt;',
    /// ]);
    /// t.<see cref="Ext.Template.compile">compile</see>();
    /// t.<see cref="Ext.Template.append">append</see>('some-element', {id: 'myid', cls: 'myclass', name: 'foo', value: 'bar'});
    /// </code></pre></li>
    /// </ul>
    /// <h1>Multiple arguments: String, Object, Array, ...</h1>
    /// <p>Multiple arguments will be combined with <c>join('')</c>.</p>
    /// <pre><code>var t = new <see cref="Ext.Template">Ext.Template</see>(
    /// '&lt;div name="{id}"&gt;',
    /// '&lt;span class="{cls}"&gt;{name} {value}&lt;/span&gt;',
    /// '&lt;/div&gt;',
    /// // a configuration object:
    /// {
    /// compiled: true,      // <see cref="Ext.Template.compile">compile</see> immediately
    /// }
    /// );
    /// </code></pre>
    /// <h1>Notes</h1>
    /// <ul>
    /// <li>For a list of available format functions, see <see cref="Ext.util.Format">Ext.util.Format</see>.</li>
    /// <li><c>disableFormats</c> reduces <c><see cref="Ext.Template.apply">apply</see></c> time when no formatting is required.</li>
    /// </ul>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Template : Ext.Base
    {
        /// <summary>
        /// True to immediately compile the template. Defaults to false.
        /// </summary>
        public bool compiled;
        /// <summary>
        /// True to disable format functions in the template. If the template doesn't contain
        /// format functions, setting disableFormats to true will reduce apply time. Defaults to false.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool disableFormats;
        /// <summary>
        /// true in this class to identify an object as an instantiated Template, or subclass thereof.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool isTemplate{get;set;}
        /// <summary>
        /// Creates new template.
        /// </summary>
        /// <param name="html"><p>List of strings to be concatenated into template.
        /// Alternatively an array of strings can be given, but then no config object may be passed.</p>
        /// </param>
        /// <param name="config"><p>Config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Template(JsString html, object config=null){}
        /// <summary>
        /// Applies the supplied values to the template and appends the new node(s) to the specified el.
        /// For example usage see <see cref="Ext.Template">Ext.Template class docs</see>.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.applyTemplate">applyTemplate</see> for details.</p>
        /// </param>
        /// <param name="returnElement"><p>true to return an <see cref="Ext.dom.Element">Ext.Element</see>.</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node or Element</p>
        /// </div>
        /// </returns>
        public object append(object el, object values, object returnElement=null){return null;}
        /// <summary>
        /// Returns an HTML fragment of this template with the specified values applied.
        /// </summary>
        /// <param name="values"><p>The template values. Can be an array if your params are numeric:</p>
        /// <pre><code>var tpl = new <see cref="Ext.Template">Ext.Template</see>('Name: {0}, Age: {1}');
        /// tpl.apply(['John', 25]);
        /// </code></pre>
        /// <p>or an object:</p>
        /// <pre><code>var tpl = new <see cref="Ext.Template">Ext.Template</see>('Name: {name}, Age: {age}');
        /// tpl.apply({name: 'John', age: 25});
        /// </code></pre>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The HTML fragment</p>
        /// </div>
        /// </returns>
        public JsString apply(object values){return null;}
        /// <summary>
        /// Appends the result of this template to the provided output array.
        /// </summary>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.apply">apply</see>.</p>
        /// </param>
        /// <param name="out"><p>The array to which output is pushed.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Array">Array</see></span><div><p>The given out array.</p>
        /// </div>
        /// </returns>
        public JsArray applyOut(object values, JsArray @out){return null;}
        /// <summary>
        /// Alias for apply.
        /// Returns an HTML fragment of this template with the specified values applied.
        /// </summary>
        /// <param name="values"><p>The template values. Can be an array if your params are numeric:</p>
        /// <pre><code>var tpl = new <see cref="Ext.Template">Ext.Template</see>('Name: {0}, Age: {1}');
        /// tpl.apply(['John', 25]);
        /// </code></pre>
        /// <p>or an object:</p>
        /// <pre><code>var tpl = new <see cref="Ext.Template">Ext.Template</see>('Name: {name}, Age: {age}');
        /// tpl.apply({name: 'John', age: 25});
        /// </code></pre>
        /// </param>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>The HTML fragment</p>
        /// </div>
        /// </returns>
        public JsString applyTemplate(object values){return null;}
        /// <summary>
        /// Compiles the template into an internal function, eliminating the RegEx overhead.
        /// </summary>
        /// <returns>
        /// <span><see cref="Ext.Template">Ext.Template</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.Template compile(){return null;}
        /// <summary>
        /// Applies the supplied values to the template and inserts the new node(s) after el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.applyTemplate">applyTemplate</see> for details.</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see>.</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node or Element</p>
        /// </div>
        /// </returns>
        public object insertAfter(object el, object values, object returnElement=null){return null;}
        /// <summary>
        /// Applies the supplied values to the template and inserts the new node(s) before el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.applyTemplate">applyTemplate</see> for details.</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see>.</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node or Element</p>
        /// </div>
        /// </returns>
        public object insertBefore(object el, object values, object returnElement=null){return null;}
        /// <summary>
        /// Applies the supplied values to the template and inserts the new node(s) as the first child of el.
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.applyTemplate">applyTemplate</see> for details.</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see>.</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node or Element</p>
        /// </div>
        /// </returns>
        public object insertFirst(object el, object values, object returnElement=null){return null;}
        /// <summary>
        /// Applies the supplied values to the template and overwrites the content of el with the new node(s).
        /// </summary>
        /// <param name="el"><p>The context element</p>
        /// </param>
        /// <param name="values"><p>The template values. See <see cref="Ext.Template.applyTemplate">applyTemplate</see> for details.</p>
        /// </param>
        /// <param name="returnElement"><p>true to return a <see cref="Ext.dom.Element">Ext.Element</see>.</p>
        /// </param>
        /// <returns>
        /// <span>HTMLElement/<see cref="Ext.dom.Element">Ext.Element</see></span><div><p>The new node or Element</p>
        /// </div>
        /// </returns>
        public object overwrite(object el, object values, object returnElement=null){return null;}
        /// <summary>
        /// Sets the HTML used as the template and optionally compiles it.
        /// </summary>
        /// <param name="html">
        /// </param>
        /// <param name="compile"><p>True to compile the template.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Template">Ext.Template</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Ext.Template set(JsString html, object compile=null){return null;}
        /// <summary>
        /// Creates a template from the passed element's value (display:none textarea, preferred) or innerHTML.
        /// </summary>
        /// <param name="el"><p>A DOM element or its id</p>
        /// </param>
        /// <param name="config"><p>Config object</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Template">Ext.Template</see></span><div><p>The created template</p>
        /// </div>
        /// </returns>
        public static Ext.Template from(object el, object config=null){return null;}
        public Template(Ext.TemplateConfig config){}
        public Template(){}
        public Template(params object[] args){}
    }
    #endregion
    #region TemplateConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TemplateConfig : Ext.BaseConfig
    {
        /// <summary>
        /// True to immediately compile the template. Defaults to false.
        /// </summary>
        public bool compiled;
        /// <summary>
        /// True to disable format functions in the template. If the template doesn't contain
        /// format functions, setting disableFormats to true will reduce apply time. Defaults to false.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool disableFormats;
        public TemplateConfig(params object[] args){}
    }
    #endregion
    #region TemplateEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class TemplateEvents : Ext.BaseEvents
    {
        public TemplateEvents(params object[] args){}
    }
    #endregion
}
