//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext
{
    #region Version
    /// <summary>
    /// <p>A utility class that wrap around a string version number and provide convenient
    /// method to perform comparison. See also: <see cref="Ext.Version.compare">compare</see>. Example:</p>
    /// <pre><code>var version = new <see cref="Ext.Version">Ext.Version</see>('1.0.2beta');
    /// console.log("Version is " + version); // Version is 1.0.2beta
    /// console.log(version.getMajor()); // 1
    /// console.log(version.getMinor()); // 0
    /// console.log(version.getPatch()); // 2
    /// console.log(version.getBuild()); // 0
    /// console.log(version.getRelease()); // beta
    /// console.log(version.isGreaterThan('1.0.1')); // True
    /// console.log(version.isGreaterThan('1.0.2alpha')); // True
    /// console.log(version.isGreaterThan('1.0.2RC')); // False
    /// console.log(version.isGreaterThan('1.0.2')); // False
    /// console.log(version.isLessThan('1.0.2')); // True
    /// console.log(version.match(1.0)); // True
    /// console.log(version.match('1.0.2')); // True
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Version
    {
        /// <summary>
        /// Parameters<li><span>version</span> : <see cref="String">String</see>/<see cref="Number">Number</see><div><p>The version number in the following standard format:</p>
        /// <pre><code>major[.minor[.patch[.build[release]]]]
        /// </code></pre>
        /// <p>Examples:</p>
        /// <pre><code>1.0
        /// 1.2.3beta
        /// 1.2.3.4RC
        /// </code></pre>
        /// </div></li>
        /// </summary>
        /// <param name="version"><p>The version number in the following standard format:</p>
        /// <pre><code>major[.minor[.patch[.build[release]]]]
        /// </code></pre>
        /// <p>Examples:</p>
        /// <pre><code>1.0
        /// 1.2.3beta
        /// 1.2.3.4RC
        /// </code></pre>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Version">Ext.Version</see></span><div><p>this</p>
        /// </div>
        /// </returns>
        public Version(object version){}
        /// <summary>
        /// Returns whether this version equals to the supplied argument
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version equals to the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool equals(object target){return false;}
        /// <summary>
        /// Returns the build component value
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>build</p>
        /// </div>
        /// </returns>
        public JsNumber getBuild(){return null;}
        /// <summary>
        /// Returns the major component value
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>major</p>
        /// </div>
        /// </returns>
        public JsNumber getMajor(){return null;}
        /// <summary>
        /// Returns the minor component value
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>minor</p>
        /// </div>
        /// </returns>
        public JsNumber getMinor(){return null;}
        /// <summary>
        /// Returns the patch component value
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>patch</p>
        /// </div>
        /// </returns>
        public JsNumber getPatch(){return null;}
        /// <summary>
        /// Returns the release component value
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>release</p>
        /// </div>
        /// </returns>
        public JsNumber getRelease(){return null;}
        /// <summary>
        /// Returns shortVersion version without dots and release
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div>
        /// </div>
        /// </returns>
        public JsString getShortVersion(){return null;}
        /// <summary>
        /// Convenient alias to isGreaterThan
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool gt(object target){return false;}
        /// <summary>
        /// Convenient alias to isGreaterThanOrEqual
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool gtEq(object target){return false;}
        /// <summary>
        /// Returns whether this version if greater than the supplied argument
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version if greater than the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool isGreaterThan(object target){return false;}
        /// <summary>
        /// Returns whether this version if greater than or equal to the supplied argument
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version if greater than or equal to the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool isGreaterThanOrEqual(object target){return false;}
        /// <summary>
        /// Returns whether this version if smaller than the supplied argument
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version if smaller than the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool isLessThan(object target){return false;}
        /// <summary>
        /// Returns whether this version if less than or equal to the supplied argument
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version if less than or equal to the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool isLessThanOrEqual(object target){return false;}
        /// <summary>
        /// Convenient alias to isLessThan
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool lt(object target){return false;}
        /// <summary>
        /// Convenient alias to isLessThanOrEqual
        /// </summary>
        /// <param name="target">
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div>
        /// </div>
        /// </returns>
        public bool ltEq(object target){return false;}
        /// <summary>
        /// Returns whether this version matches the supplied argument. Example:
        /// <code>var version = new <see cref="Ext.Version">Ext.Version</see>('1.0.2beta');
        /// console.log(version.match(1)); // True
        /// console.log(version.match(1.0)); // True
        /// console.log(version.match('1.0.2')); // True
        /// console.log(version.match('1.0.2RC')); // False
        /// </code>
        /// </summary>
        /// <param name="target"><p>The version to compare with</p>
        /// </param>
        /// <returns>
        /// <span><see cref="bool">Boolean</see></span><div><p>True if this version matches the target, false otherwise</p>
        /// </div>
        /// </returns>
        public bool match(object target){return false;}
        /// <summary>
        /// Returns this format: [major, minor, patch, build, release]. Useful for comparison
        /// </summary>
        /// <returns>
        /// <span><see cref="Number">Number</see>[]</span><div>
        /// </div>
        /// </returns>
        public JsNumber[] toArray(){return null;}
        /// <summary>
        /// Override the native toString method
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>version</p>
        /// </div>
        /// </returns>
        private JsString toString(){return null;}
        /// <summary>
        /// Override the native valueOf method
        /// </summary>
        /// <returns>
        /// <span><see cref="String">String</see></span><div><p>version</p>
        /// </div>
        /// </returns>
        private JsString valueOf(){return null;}
        /// <summary>
        /// Compare 2 specified versions, starting from left to right. If a part contains special version strings,
        /// they are handled in the following order:
        /// 'dev' &lt; 'alpha' = 'a' &lt; 'beta' = 'b' &lt; 'RC' = 'rc' &lt; '#' &lt; 'pl' = 'p' &lt; 'anything else'
        /// </summary>
        /// <param name="current"><p>The current version to compare to</p>
        /// </param>
        /// <param name="target"><p>The target version to compare to</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Number">Number</see></span><div><p>Returns -1 if the current version is smaller than the target version, 1 if greater, and 0 if they're equivalent</p>
        /// </div>
        /// </returns>
        public static JsNumber compare(JsString current, JsString target){return null;}
        /// <summary>
        /// Converts a version component to a comparable value
        /// </summary>
        /// <param name="value"><p>The value to convert</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public static object getComponentValue(object value){return null;}
        public Version(VersionConfig config){}
        public Version(){}
        public Version(params object[] args){}
    }
    #endregion
    #region VersionConfig
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class VersionConfig
    {
        public VersionConfig(params object[] args){}
    }
    #endregion
    #region VersionEvents
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class VersionEvents
    {
        public VersionEvents(params object[] args){}
    }
    #endregion
}
