// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.theme.manager
{
    /// <summary>
	/// <para>Manager for color themes</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.theme.manager.Color", OmitOptionalParameters = true, Export = false)]
    public partial class Color : qx.util.ValueManager
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Theme"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeTheme;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>the currently selected color theme</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "theme", NativeField = true)]
		public Theme Theme { get; set; }

		#endregion Properties

		#region Methods

		public Color() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property theme.</para>
		/// </summary>
		[JsMethod(Name = "getTheme")]
		public Theme GetTheme() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property theme
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property theme.</param>
		[JsMethod(Name = "initTheme")]
		public void InitTheme(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether a value is interpreted dynamically</para>
		/// </summary>
		/// <param name="value">dynamically interpreted identifier</param>
		/// <returns>returns true if the value is interpreted dynamically</returns>
		[JsMethod(Name = "isDynamic")]
		public bool IsDynamic(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property theme.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetTheme")]
		public void ResetTheme() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the dynamically interpreted result for the incoming value,
		/// (if available), otherwise returns the original value</para>
		/// </summary>
		/// <param name="value">Value to resolve</param>
		/// <returns>either returns the (translated) result of the incoming value or the value itself</returns>
		[JsMethod(Name = "resolve")]
		public object Resolve(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property theme.</para>
		/// </summary>
		/// <param name="value">New value for property theme.</param>
		[JsMethod(Name = "setTheme")]
		public void SetTheme(Theme value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.theme.manager.Color GetInstance() { throw new NotImplementedException(); }

		#endregion Methods
    }
}