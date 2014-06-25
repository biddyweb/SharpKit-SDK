//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout
{
    #region ClassList
    /// <inheritdocs />
    /// <summary>
    /// <p>This class provides a DOM ClassList API to buffer access to an element's class.
    /// Instances of this class are created by <see cref="Ext.layout.ContextItem.getClassList">Ext.layout.ContextItem.getClassList</see>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class ClassList : Ext.Base
    {
        /// <summary>
        /// Adds a single class to the class list.
        /// </summary>
        /// <param name="cls">
        /// </param>
        public void add(object cls){}
        /// <summary>
        /// Adds one or more classes in an array or space-delimited string to the class list.
        /// </summary>
        /// <param name="classes">
        /// </param>
        public void addMany(object classes){}
        /// <summary>
        /// Removes a single class from the class list.
        /// </summary>
        /// <param name="cls">
        /// </param>
        public void remove(object cls){}
        /// <summary>
        /// Removes one or more classes in an array or space-delimited string from the class
        /// list.
        /// </summary>
        /// <param name="classes">
        /// </param>
        public void removeMany(object classes){}
        public ClassList(ClassListConfig config){}
        public ClassList(){}
        public ClassList(params object[] args){}
    }
    #endregion
    #region ClassListConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ClassListConfig : Ext.BaseConfig
    {
        public ClassListConfig(params object[] args){}
    }
    #endregion
    #region ClassListEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class ClassListEvents : Ext.BaseEvents
    {
        public ClassListEvents(params object[] args){}
    }
    #endregion
}
