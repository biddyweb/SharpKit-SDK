// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom.client
{
    /// <summary>
	/// <para>The class is responsible for device detection. This is specially usefull
	/// if you are on a mobile device.</para>
	/// <para>This class is used by <see cref="qx.core.Environment"/> and should not be used
	/// directly. Please check its class comment for details how to use it.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.client.Device", OmitOptionalParameters = true, Export = false)]
    public partial class Device 
    {
		#region Methods

		public Device() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects the device type, based on given userAgentString.</para>
		/// </summary>
		/// <param name="userAgentString">userAgent parameter, needed for decision.</param>
		/// <returns>The device type name of determined device: &#8220;mobile&#8221;,&#8220;desktop&#8221;,&#8220;tablet&#8221;</returns>
		[JsMethod(Name = "detectDeviceType")]
		public static string DetectDeviceType(string userAgentString) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects if a device is a mobile phone. (Tablets excluded.)</para>
		/// </summary>
		/// <param name="userAgentString">userAgent parameter, needed for decision.</param>
		/// <returns>Flag which indicates whether it is a mobile device.</returns>
		[JsMethod(Name = "detectMobileDevice")]
		public static bool DetectMobileDevice(string userAgentString) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Detects if a device is a tablet device.</para>
		/// </summary>
		/// <param name="userAgentString">userAgent parameter, needed for decision.</param>
		/// <returns>Flag which indicates whether it is a tablet device.</returns>
		[JsMethod(Name = "detectTabletDevice")]
		public static bool DetectTabletDevice(string userAgentString) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Determines on what type of device the application is running.
		/// Valid values are: &#8220;mobile&#8221;, &#8220;tablet&#8221; or &#8220;desktop&#8221;.</para>
		/// </summary>
		/// <returns>The device type name of determined device.</returns>
		[JsMethod(Name = "getType")]
		public static string GetType() { throw new NotImplementedException(); }

		#endregion Methods
    }
}