//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout.component.field
{
    #region Field
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Layout class for components with <see cref="Ext.form.Labelable">field labeling</see>, handling the sizing and alignment of
    /// the form control, label, and error message treatment.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Field : Ext.layout.component.Auto
    {
        /// <summary>
        /// Error message displayed as content of an element with a given id elsewhere in the app
        /// </summary>
        public JsObject elementId{get;set;}
        /// <summary>
        /// Collection of named strategies for laying out and adjusting insets to accommodate error messages.
        /// An appropriate one will be chosen based on the owner field's Ext.form.Labelable.msgTarget config.
        /// </summary>
        public JsObject errorStrategies{get;set;}
        /// <summary>
        /// Collection of named strategies for laying out and adjusting labels to accommodate error messages.
        /// An appropriate one will be chosen based on the owner field's Ext.form.Labelable.labelAlign config.
        /// </summary>
        public JsObject labelStrategies{get;set;}
        /// <summary>
        /// Label displayed to the left of the bodyEl
        /// </summary>
        public JsObject left{get;set;}
        /// <summary>
        /// Error displayed as QuickTip on hover of the field container
        /// </summary>
        public JsObject qtip{get;set;}
        /// <summary>
        /// Same as left, only difference is text-align in CSS
        /// </summary>
        public JsObject right{get;set;}
        /// <summary>
        /// Error displayed as icon (with QuickTip on hover) to right of the bodyEl
        /// </summary>
        public JsObject side{get;set;}
        /// <summary>
        /// Error displayed as title tip on hover of the field container
        /// </summary>
        public JsObject title{get;set;}
        /// <summary>
        /// Label displayed above the bodyEl
        /// </summary>
        public JsObject top{get;set;}
        /// <summary>
        /// Error message displayed underneath the bodyEl
        /// </summary>
        public JsObject under{get;set;}
        /// <summary>
        /// Return the set of strategy functions from the errorStrategies collection
        /// that is appropriate for the field's msgTarget config.
        /// </summary>
        public void getErrorStrategy(){}
        /// <summary>
        /// Return the set of strategy functions from the labelStrategies collection
        /// that is appropriate for the field's labelAlign config.
        /// </summary>
        public void getLabelStrategy(){}
        /// <summary>
        /// Destroy the error tip instance.
        /// </summary>
        public static void destroyTip(){}
        /// <summary>
        /// Use a custom QuickTip instance separate from the main QuickTips singleton, so that we
        /// can give it a custom frame style. Responds to errorqtip rather than the qtip property.
        /// </summary>
        public static void initTip(){}
        public Field(Ext.layout.component.field.FieldConfig config){}
        public Field(){}
        public Field(params object[] args){}
    }
    #endregion
    #region FieldConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FieldConfig : Ext.layout.component.AutoConfig
    {
        public FieldConfig(params object[] args){}
    }
    #endregion
    #region FieldEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class FieldEvents : Ext.layout.component.AutoEvents
    {
        public FieldEvents(params object[] args){}
    }
    #endregion
}
