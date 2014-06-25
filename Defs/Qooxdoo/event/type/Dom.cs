// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.eventx.type
{
    /// <summary>
	/// <para>Common base class for all DOM events.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.event.type.Dom", OmitOptionalParameters = true, Export = false)]
    public partial class Dom : qx.eventx.type.Native
    {
		#region Methods

		public Dom() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return in a bit map, which modifier keys are pressed. The constants
		/// <see cref="#SHIFT_MASK"/>, <see cref="#CTRL_MASK"/>, <see cref="#ALT_MASK"/> and
		/// <see cref="#META_MASK"/> define the bit positions of the corresponding keys.</para>
		/// </summary>
		/// <returns>A bit map with the pressed modifier keys.</returns>
		[JsMethod(Name = "getModifiers")]
		public double GetModifiers() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the alt key is pressed.</para>
		/// </summary>
		/// <returns>whether the alt key is pressed.</returns>
		[JsMethod(Name = "isAltPressed")]
		public bool IsAltPressed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the ctrl key or (on the Mac) the command key is pressed.</para>
		/// </summary>
		/// <returns>true if the command key is pressed on the Mac or the ctrl key is pressed on another system.</returns>
		[JsMethod(Name = "isCtrlOrCommandPressed")]
		public bool IsCtrlOrCommandPressed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the ctrl key is pressed.</para>
		/// </summary>
		/// <returns>whether the ctrl key is pressed.</returns>
		[JsMethod(Name = "isCtrlPressed")]
		public bool IsCtrlPressed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the meta key is pressed.</para>
		/// </summary>
		/// <returns>whether the meta key is pressed.</returns>
		[JsMethod(Name = "isMetaPressed")]
		public bool IsMetaPressed() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns whether the shift key is pressed.</para>
		/// </summary>
		/// <returns>whether the shift key is pressed.</returns>
		[JsMethod(Name = "isShiftPressed")]
		public bool IsShiftPressed() { throw new NotImplementedException(); }

		#endregion Methods
    }
}