//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_.Plugin_
{
    /// <summary>
    /// A plugin class which adds navigation controls to Calendar.
    /// </summary>
    public partial class CalendarNavigator : Y_.Plugin_.Base
    {
        /// <summary>
        /// Private utility method that adds months to the host calendar date
        /// based on the control click and the shiftByMonths property.
        /// </summary>
        protected void _addMonths(Event ev){}
        [JsMethod(JsonInitializers=true)]
        public CalendarNavigator(){}
        /// <summary>
        /// Protected render assist method that initialized and renders the navigation controls.
        /// </summary>
        protected void _initNavigationControls(){}
        /// <summary>
        /// Private utility method that subtracts months from the host calendar date
        /// based on the control click and the shiftByMonths property.
        /// </summary>
        protected void _subtractMonths(Event ev){}
        /// <summary>
        /// The initializer destructor implementation. Responsible for destroying the initialized
        /// control mechanisms.
        /// </summary>
        public void destructor(){}
        /// <summary>
        /// The initializer lifecycle implementation. Modifies the host widget's
        /// render to add navigation controls.
        /// </summary>
        public void initializer(object config){}
        /// <summary>
        /// Static property used to define the default attribute
        /// configuration for the plugin.
        /// </summary>
        public object ATTRS{get;set;}
        /// <summary>
        /// The CSS classnames for the calendar navigator controls.
        /// </summary>
        protected object CALENDARNAV_STRINGS{get;private set;}
        /// <summary>
        /// The number of months to shift by when the control arrows are clicked.
        /// </summary>
        public Y_.DataType_.Number shiftByMonths{get;set;}
    }
}
