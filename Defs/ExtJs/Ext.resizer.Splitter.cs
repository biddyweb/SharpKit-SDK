//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.resizer
{
    #region Splitter
    /// <inheritdocs />
    /// <summary>
    /// <p>This class functions <strong>between siblings of a <see cref="Ext.layout.container.VBox">VBox</see> or <see cref="Ext.layout.container.HBox">HBox</see>
    /// layout</strong> to resize both immediate siblings.</p>
    /// <p>A Splitter will preserve the flex ratio of any flexed siblings it is required to resize. It does this by setting the <c>flex</c> property of <em>all</em> flexed siblings
    /// to equal their pixel size. The actual numerical <c>flex</c> property in the Components will change, but the <strong>ratio</strong> to the total flex value will be preserved.</p>
    /// <p>A Splitter may be configured to show a centered mini-collapse tool orientated to collapse the <see cref="Ext.resizer.SplitterConfig.collapseTarget">collapseTarget</see>.
    /// The Splitter will then call that sibling Panel's <see cref="Ext.panel.Panel.collapse">collapse</see> or <see cref="Ext.panel.Panel.expand">expand</see> method
    /// to perform the appropriate operation (depending on the sibling collapse state). To create the mini-collapse tool but take care
    /// of collapsing yourself, configure the splitter with <c><see cref="Ext.resizer.SplitterConfig.performCollapse">performCollapse</see>: false</c>.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Splitter : Ext.Component
    {
        /// <summary>
        /// True to enable dblclick to toggle expand and collapse on the collapseTarget Panel.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool collapseOnDblClick;
        /// <summary>
        /// A string describing the relative position of the immediate sibling Panel to collapse. May be 'prev' or 'next'.
        /// Or the immediate sibling Panel to collapse.
        /// The orientation of the mini-collapse tool will be inferred from this setting.
        /// <strong>Note that only Panels may be collapsed.</strong>
        /// Defaults to: <c>&quot;next&quot;</c>
        /// </summary>
        public object collapseTarget;
        /// <summary>
        /// A class to add to the splitter when it is collapsed. See collapsible.
        /// </summary>
        public JsString collapsedCls;
        /// <summary>
        /// True to show a mini-collapse tool in the Splitter to toggle expand and collapse on the collapseTarget Panel.
        /// Defaults to the collapsible setting of the Panel.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool collapsible;
        /// <summary>
        /// Provides a default maximum width or height for the two components
        /// that the splitter is between.
        /// Defaults to: <c>1000</c>
        /// </summary>
        public JsNumber defaultSplitMax;
        /// <summary>
        /// Provides a default minimum width or height for the two components
        /// that the splitter is between.
        /// Defaults to: <c>40</c>
        /// </summary>
        public JsNumber defaultSplitMin;
        /// <summary>
        /// Set to false to prevent this Splitter's mini-collapse tool from managing the collapse
        /// state of the collapseTarget.
        /// </summary>
        public bool performCollapse;
        /// <summary>
        /// Orientation of this Splitter. 'vertical' when used in an hbox layout, 'horizontal'
        /// when used in a vbox layout.
        /// </summary>
        public JsString orientation{get;set;}
        /// <summary>
        /// Returns the config object (with an xclass property) for the splitter tracker. This
        /// is overridden by BorderSplitter to create a
        /// BorderSplitterTracker.
        /// </summary>
        protected void getTrackerConfig(){}
        public Splitter(SplitterConfig config){}
        public Splitter(){}
        public Splitter(params object[] args){}
    }
    #endregion
    #region SplitterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SplitterConfig : Ext.ComponentConfig
    {
        /// <summary>
        /// True to enable dblclick to toggle expand and collapse on the collapseTarget Panel.
        /// Defaults to: <c>true</c>
        /// </summary>
        public bool collapseOnDblClick;
        /// <summary>
        /// A string describing the relative position of the immediate sibling Panel to collapse. May be 'prev' or 'next'.
        /// Or the immediate sibling Panel to collapse.
        /// The orientation of the mini-collapse tool will be inferred from this setting.
        /// <strong>Note that only Panels may be collapsed.</strong>
        /// Defaults to: <c>&quot;next&quot;</c>
        /// </summary>
        public object collapseTarget;
        /// <summary>
        /// A class to add to the splitter when it is collapsed. See collapsible.
        /// </summary>
        public JsString collapsedCls;
        /// <summary>
        /// True to show a mini-collapse tool in the Splitter to toggle expand and collapse on the collapseTarget Panel.
        /// Defaults to the collapsible setting of the Panel.
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool collapsible;
        /// <summary>
        /// Provides a default maximum width or height for the two components
        /// that the splitter is between.
        /// Defaults to: <c>1000</c>
        /// </summary>
        public JsNumber defaultSplitMax;
        /// <summary>
        /// Provides a default minimum width or height for the two components
        /// that the splitter is between.
        /// Defaults to: <c>40</c>
        /// </summary>
        public JsNumber defaultSplitMin;
        /// <summary>
        /// Set to false to prevent this Splitter's mini-collapse tool from managing the collapse
        /// state of the collapseTarget.
        /// </summary>
        public bool performCollapse;
        public SplitterConfig(params object[] args){}
    }
    #endregion
    #region SplitterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class SplitterEvents : Ext.ComponentEvents
    {
        public SplitterEvents(params object[] args){}
    }
    #endregion
}
