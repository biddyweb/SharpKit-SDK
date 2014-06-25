// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.core.scroll
{
    /// <summary>
	/// <para>The scroll bar widget wraps the native browser scroll bars as a qooxdoo widget.
	/// It can be uses instead of the styled qooxdoo scroll bars.</para>
	/// <para>Scroll bars are used by the <see cref="qx.ui.container.Scroll"/> container. Usually
	/// a scroll bar is not used directly.</para>
	/// <para>Example</para>
	/// <para>Here is a little example of how to use the widget.</para>
	/// <code>
	/// var scrollBar = new qx.ui.core.scroll.NativeScrollBar("horizontal");
	/// scrollBar.set({
	/// maximum: 500
	/// })
	/// this.getRoot().add(scrollBar);
	/// </code>
	/// <para>This example creates a horizontal scroll bar with a maximum value of 500.</para>
	/// <para>External Documentation</para>
	/// 
	/// Documentation of this widget in the qooxdoo manual.
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.core.scroll.NativeScrollBar", OmitOptionalParameters = true, Export = false)]
    public partial class NativeScrollBar : qx.ui.core.Widget, qx.ui.core.scroll.IScrollBar
    {
		#region Events

		/// <summary>
		/// <para>Fired if the user scroll</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnScroll;

		/// <summary>
		/// <para>Fired as soon as the scroll animation ended.</para>
		/// </summary>
		public event Action<qx.eventx.type.Event> OnScrollAnimationEnd;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>The appearance ID. This ID is used to identify the appearance theme
		/// entry to use for this widget. This controls the styling of the element.</para>
		/// </summary>
		[JsProperty(Name = "appearance", NativeField = true)]
		public string Appearance { get; set; }

		/// <summary>
		/// <para>Factor to apply to the width/height of the knob in relation
		/// to the dimension of the underlying area.</para>
		/// </summary>
		[JsProperty(Name = "knobFactor", NativeField = true)]
		public object KnobFactor { get; set; }

		/// <summary>
		/// <para>The maximum value (difference between available size and
		/// content size).</para>
		/// </summary>
		[JsProperty(Name = "maximum", NativeField = true)]
		public object Maximum { get; set; }

		/// <summary>
		/// <para>The scroll bar orientation</para>
		/// </summary>
		[JsProperty(Name = "orientation", NativeField = true)]
		public object Orientation { get; set; }

		/// <summary>
		/// <para>Position of the scrollbar (which means the scroll left/top of the
		/// attached area&#8217;s pane)</para>
		/// <para>Strictly validates according to <see cref="Maximum"/>.
		/// Does not apply any correction to the incoming value. If you depend
		/// on this, please use <see cref="ScrollTo"/> instead.</para>
		/// </summary>
		[JsProperty(Name = "position", NativeField = true)]
		public object Position { get; set; }

		/// <summary>
		/// <para>Step size for each click on the up/down or left/right buttons.</para>
		/// </summary>
		[JsProperty(Name = "singleStep", NativeField = true)]
		public double SingleStep { get; set; }

		#endregion Properties

		#region Methods

		public NativeScrollBar() { throw new NotImplementedException(); }

		/// <param name="orientation">The initial scroll bar orientation</param>
		public NativeScrollBar(string orientation = "horizontal") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property knobFactor.</para>
		/// </summary>
		[JsMethod(Name = "getKnobFactor")]
		public object GetKnobFactor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property maximum.</para>
		/// </summary>
		[JsMethod(Name = "getMaximum")]
		public object GetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property orientation.</para>
		/// </summary>
		[JsMethod(Name = "getOrientation")]
		public object GetOrientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property position.</para>
		/// </summary>
		[JsMethod(Name = "getPosition")]
		public object GetPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property singleStep.</para>
		/// </summary>
		[JsMethod(Name = "getSingleStep")]
		public double GetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property knobFactor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property knobFactor.</param>
		[JsMethod(Name = "initKnobFactor")]
		public void InitKnobFactor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property maximum
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property maximum.</param>
		[JsMethod(Name = "initMaximum")]
		public void InitMaximum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property orientation
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property orientation.</param>
		[JsMethod(Name = "initOrientation")]
		public void InitOrientation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property position
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property position.</param>
		[JsMethod(Name = "initPosition")]
		public void InitPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property singleStep
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property singleStep.</param>
		[JsMethod(Name = "initSingleStep")]
		public void InitSingleStep(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Used by the layout engine to apply coordinates and dimensions.</para>
		/// </summary>
		/// <param name="left">Any integer value for the left position, always in pixels</param>
		/// <param name="top">Any integer value for the top position, always in pixels</param>
		/// <param name="width">Any positive integer value for the width, always in pixels</param>
		/// <param name="height">Any positive integer value for the height, always in pixels</param>
		/// <returns>A map of which layout sizes changed.</returns>
		[JsMethod(Name = "renderLayout")]
		public object RenderLayout(double left, double top, double width, double height) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property knobFactor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetKnobFactor")]
		public void ResetKnobFactor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property maximum.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetMaximum")]
		public void ResetMaximum() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property orientation.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOrientation")]
		public void ResetOrientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property position.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetPosition")]
		public void ResetPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property singleStep.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSingleStep")]
		public void ResetSingleStep() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls by the given offset.</para>
		/// <para>This method automatically corrects the given position to respect
		/// the <see cref="Maximum"/>.</para>
		/// </summary>
		/// <param name="offset">Scroll by this offset</param>
		/// <param name="duration">The time in milliseconds the slide to should take.</param>
		[JsMethod(Name = "scrollBy")]
		public void ScrollBy(double offset, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls by the given number of steps.</para>
		/// <para>This method automatically corrects the given position to respect
		/// the <see cref="Maximum"/>.</para>
		/// </summary>
		/// <param name="steps">Number of steps</param>
		/// <param name="duration">The time in milliseconds the slide to should take.</param>
		[JsMethod(Name = "scrollBySteps")]
		public void ScrollBySteps(double steps, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Scrolls to the given position.</para>
		/// <para>This method automatically corrects the given position to respect
		/// the <see cref="Maximum"/>.</para>
		/// </summary>
		/// <param name="position">Scroll to this position. Must be greater zero.</param>
		/// <param name="duration">The time in milliseconds the slide to should take.</param>
		[JsMethod(Name = "scrollTo")]
		public void ScrollTo(double position, double duration) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property knobFactor.</para>
		/// </summary>
		/// <param name="value">New value for property knobFactor.</param>
		[JsMethod(Name = "setKnobFactor")]
		public void SetKnobFactor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property maximum.</para>
		/// </summary>
		/// <param name="value">New value for property maximum.</param>
		[JsMethod(Name = "setMaximum")]
		public void SetMaximum(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property orientation.</para>
		/// </summary>
		/// <param name="value">New value for property orientation.</param>
		[JsMethod(Name = "setOrientation")]
		public void SetOrientation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property position.</para>
		/// </summary>
		/// <param name="value">New value for property position.</param>
		[JsMethod(Name = "setPosition")]
		public void SetPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property singleStep.</para>
		/// </summary>
		/// <param name="value">New value for property singleStep.</param>
		[JsMethod(Name = "setSingleStep")]
		public void SetSingleStep(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}