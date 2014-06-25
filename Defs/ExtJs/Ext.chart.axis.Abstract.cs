//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:39 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.chart.axis
{
    #region Abstract
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Base class for all axis classes.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Abstract : Ext.Base
    {
        /// <summary>
        /// The fields of model to bind to this axis.
        /// For example if you have a data set of lap times per car, each having the fields:
        /// <c>'carName'</c>, <c>'avgSpeed'</c>, <c>'maxSpeed'</c>. Then you might want to show the data on chart
        /// with <c>['carName']</c> on Name axis and <c>['avgSpeed', 'maxSpeed']</c> on Speed axis.
        /// </summary>
        public JsString fields;
        /// <summary>
        /// The config for chart label.
        /// </summary>
        public Ext.chart.Label label;
        /// <summary>
        /// Creates new Axis.
        /// </summary>
        /// <param name="config"><p>Config options.</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div>
        /// </div>
        /// </returns>
        public Abstract(object config=null){}
        public Abstract(AbstractConfig config){}
        public Abstract(params object[] args){}
    }
    #endregion
    #region AbstractConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractConfig : Ext.BaseConfig
    {
        /// <summary>
        /// The fields of model to bind to this axis.
        /// For example if you have a data set of lap times per car, each having the fields:
        /// <c>'carName'</c>, <c>'avgSpeed'</c>, <c>'maxSpeed'</c>. Then you might want to show the data on chart
        /// with <c>['carName']</c> on Name axis and <c>['avgSpeed', 'maxSpeed']</c> on Speed axis.
        /// </summary>
        public JsString fields;
        /// <summary>
        /// The config for chart label.
        /// </summary>
        public Ext.chart.Label label;
        public AbstractConfig(params object[] args){}
    }
    #endregion
    #region AbstractEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class AbstractEvents : Ext.BaseEvents
    {
        public AbstractEvents(params object[] args){}
    }
    #endregion
}
