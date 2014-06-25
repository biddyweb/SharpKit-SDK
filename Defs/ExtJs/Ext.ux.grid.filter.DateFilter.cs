//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:42 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.ux.grid.filter
{
    #region DateFilter
    /// <inheritdocs />
    /// <summary>
    /// <p>Filter by a configurable Ext.picker.DatePicker menu</p>
    /// <p><b><u>Example Usage:</u></b></p>
    /// <pre><code>var filters = <see cref="Ext.ExtContext.create">Ext.create</see>('Ext.ux.grid.GridFilters', {
    /// ...
    /// filters: [{
    /// // required configs
    /// type: 'date',
    /// dataIndex: 'dateAdded',
    /// // optional configs
    /// dateFormat: 'm/d/Y',  // default
    /// beforeText: 'Before', // default
    /// afterText: 'After',   // default
    /// onText: 'On',         // default
    /// pickerOpts: {
    /// // any DatePicker configs
    /// },
    /// active: true // default is false
    /// }]
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class DateFilter : Ext.ux.grid.filter.Filter
    {
        /// <summary>
        /// Defaults to 'After'.
        /// Defaults to: <c>&quot;After&quot;</c>
        /// </summary>
        public JsString afterText;
        /// <summary>
        /// Defaults to 'Before'.
        /// Defaults to: <c>&quot;Before&quot;</c>
        /// </summary>
        public JsString beforeText;
        /// <summary>
        /// Map for assigning the comparison values used in serialization.
        /// Defaults to: <c>{before: &quot;lt&quot;, after: &quot;gt&quot;, on: &quot;eq&quot;}</c>
        /// </summary>
        public JsObject compareMap;
        /// <summary>
        /// The date format to return when using getValue.
        /// Defaults to 'm/d/Y'.
        /// Defaults to: <c>&quot;m/d/Y&quot;</c>
        /// </summary>
        public JsString dateFormat;
        /// <summary>
        /// Allowable date as passed to the Ext.DatePicker
        /// Defaults to undefined.
        /// </summary>
        public JsDate maxDate;
        /// <summary>
        /// Default configuration options for each menu item
        /// Defaults to: <c>{selectOnFocus: true, width: 125}</c>
        /// </summary>
        public JsObject menuItemCfgs;
        /// <summary>
        /// The items to be shown in this menu
        /// Defaults to:
        /// menuItems : ['before', 'after', '-', 'on'],
        /// Defaults to: <c>[&quot;before&quot;, &quot;after&quot;, &quot;-&quot;, &quot;on&quot;]</c>
        /// </summary>
        public JsArray menuItems;
        /// <summary>
        /// Allowable date as passed to the Ext.DatePicker
        /// Defaults to undefined.
        /// </summary>
        public JsDate minDate;
        /// <summary>
        /// Defaults to 'On'.
        /// Defaults to: <c>&quot;On&quot;</c>
        /// </summary>
        public JsString onText;
        /// <summary>
        /// Configuration options for the date picker associated with each field.
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject pickerOpts;
        /// <summary>
        /// Get and return the date menu picker value
        /// </summary>
        /// <param name="item"><p>The field identifier ('before', 'after', 'on')</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Date">Date</see></span><div><p>Gets the current selected value of the date field</p>
        /// </div>
        /// </returns>
        public JsDate getFieldValue(JsString item){return null;}
        /// <summary>
        /// Gets the menu picker associated with the passed field
        /// </summary>
        /// <param name="item"><p>The field identifier ('before', 'after', 'on')</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Object">Object</see></span><div><p>The menu picker</p>
        /// </div>
        /// </returns>
        public object getPicker(JsString item){return null;}
        /// <summary>
        /// Template method that is to initialize the filter and install required menu items.
        /// </summary>
        /// <param name="config">
        /// </param>
        private void init(object config){}
        /// <summary>
        /// Handler method called when there is a keyup event on an input
        /// item of this menu.
        /// </summary>
        /// <param name="field">
        /// </param>
        /// <param name="e">
        /// </param>
        private void onInputKeyUp(object field, object e){}
        /// <summary>
        /// Handler for when the DatePicker for a field fires the 'select' event
        /// </summary>
        /// <param name="picker">
        /// </param>
        /// <param name="date">
        /// </param>
        public void onMenuSelect(Ext.picker.Date picker, object date){}
        /// <summary>
        /// Template method that is to set the value of the filter.
        /// </summary>
        /// <param name="value"><p>The value to set the filter</p>
        /// </param>
        /// <param name="preserve"><p>true to preserve the checked status
        /// of the other fields.  Defaults to false, unchecking the
        /// other fields</p>
        /// </param>
        private void setValue(object value, bool preserve){}
        public DateFilter(DateFilterConfig config){}
        public DateFilter(){}
        public DateFilter(params object[] args){}
    }
    #endregion
    #region DateFilterConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateFilterConfig : Ext.ux.grid.filter.FilterConfig
    {
        /// <summary>
        /// Defaults to 'After'.
        /// Defaults to: <c>&quot;After&quot;</c>
        /// </summary>
        public JsString afterText;
        /// <summary>
        /// Defaults to 'Before'.
        /// Defaults to: <c>&quot;Before&quot;</c>
        /// </summary>
        public JsString beforeText;
        /// <summary>
        /// Map for assigning the comparison values used in serialization.
        /// Defaults to: <c>{before: &quot;lt&quot;, after: &quot;gt&quot;, on: &quot;eq&quot;}</c>
        /// </summary>
        public JsObject compareMap;
        /// <summary>
        /// The date format to return when using getValue.
        /// Defaults to 'm/d/Y'.
        /// Defaults to: <c>&quot;m/d/Y&quot;</c>
        /// </summary>
        public JsString dateFormat;
        /// <summary>
        /// Allowable date as passed to the Ext.DatePicker
        /// Defaults to undefined.
        /// </summary>
        public JsDate maxDate;
        /// <summary>
        /// Default configuration options for each menu item
        /// Defaults to: <c>{selectOnFocus: true, width: 125}</c>
        /// </summary>
        public JsObject menuItemCfgs;
        /// <summary>
        /// The items to be shown in this menu
        /// Defaults to:
        /// menuItems : ['before', 'after', '-', 'on'],
        /// Defaults to: <c>[&quot;before&quot;, &quot;after&quot;, &quot;-&quot;, &quot;on&quot;]</c>
        /// </summary>
        public JsArray menuItems;
        /// <summary>
        /// Allowable date as passed to the Ext.DatePicker
        /// Defaults to undefined.
        /// </summary>
        public JsDate minDate;
        /// <summary>
        /// Defaults to 'On'.
        /// Defaults to: <c>&quot;On&quot;</c>
        /// </summary>
        public JsString onText;
        /// <summary>
        /// Configuration options for the date picker associated with each field.
        /// Defaults to: <c>{}</c>
        /// </summary>
        public JsObject pickerOpts;
        public DateFilterConfig(params object[] args){}
    }
    #endregion
    #region DateFilterEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class DateFilterEvents : Ext.ux.grid.filter.FilterEvents
    {
        public DateFilterEvents(params object[] args){}
    }
    #endregion
}
