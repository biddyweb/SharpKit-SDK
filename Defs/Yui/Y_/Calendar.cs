//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace Y_
{
    /// <summary>
    /// month range of dates, rendered as a grid with date and
    /// weekday labels.
    /// </summary>
    public partial class Calendar : CalendarBase
    {
        /// <summary>
        /// Overrides the _bindCalendarEvents placeholder in CalendarBase
        /// and binds calendar events during bindUI stage.
        /// </summary>
        protected void _bindCalendarEvents(){}
        /// <summary>
        /// Handler for loss of focus of calendar grid
        /// </summary>
        protected void _blurCalendarGrid(){}
        [JsMethod(JsonInitializers=true)]
        public Calendar(){}
        /// <summary>
        /// Handler for gain of focus of calendar cell
        /// </summary>
        protected void _focusCalendarCell(){}
        /// <summary>
        /// Handler for gain of focus of calendar grid
        /// </summary>
        protected void _focusCalendarGrid(){}
        /// <summary>
        /// Returns the grid number for a specific calendar grid (for multi-grid templates)
        /// </summary>
        protected void _getGridNumber(Node gridNode){}
        /// <summary>
        /// Highlights a specific date node with keyboard highlight class
        /// </summary>
        protected void _highlightDateNode(Y_.DataType_.Date oDate){}
        /// <summary>
        /// Handler for keyboard press on a calendar grid
        /// </summary>
        protected void _keydownCalendar(){}
        /// <summary>
        /// Unhighlights a specific date node currently highlighted with keyboard highlight class
        /// </summary>
        protected void _unhighlightCurrentDateNode(){}
        /// <summary>
        /// Adds one month to the current calendar view.
        /// </summary>
        public void addMonth(){}
        /// <summary>
        /// Adds one year to the current calendar view.
        /// </summary>
        public void addYear(){}
        /// <summary>
        /// Designated initializer. Activates the navigation plugin for the calendar.
        /// </summary>
        public void initializer(){}
        /// <summary>
        /// Subtracts one month from the current calendar view.
        /// </summary>
        public void subtractMonth(){}
        /// <summary>
        /// Subtracts one year from the current calendar view.
        /// </summary>
        public void subtractYear(){}
        /// <summary>
        /// syncUI implementation
        /// Update the scroll position, based on the current value of scrollY
        /// </summary>
        public void syncUI(){}
        /// <summary>
        /// The date corresponding to the current calendar view. Always
        /// normalized to the first of the month that contains the date
        /// at assignment time. Used as the first date visible in the
        /// calendar.
        /// </summary>
        public Y_.DataType_.Date date{get;set;}
        /// <summary>
        /// The maximum date that can be displayed by the calendar. The calendar will not
        /// allow dates later than this one to be set, and will reset any later date to
        /// this date. Should be `null` if no maximum date is needed.
        /// </summary>
        public Y_.DataType_.Date maximumDate{get;set;}
        /// <summary>
        /// The minimum date that can be displayed by the calendar. The calendar will not
        /// allow dates earlier than this one to be set, and will reset any earlier date to
        /// this date. Should be `null` if no minimum date is needed.
        /// </summary>
        public Y_.DataType_.Date minimumDate{get;set;}
    }
}
