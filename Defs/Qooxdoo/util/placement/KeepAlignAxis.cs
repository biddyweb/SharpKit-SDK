// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.util.placement
{
    /// <summary>
	/// <para>Places the object to the target. If parts of the object are outside of the
	/// range this class places the object at the best &#8220;edge&#8221;, &#8220;alignment&#8221;
	/// combination so that the overlap between object and range is maximized.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.util.placement.KeepAlignAxis", OmitOptionalParameters = true, Export = false)]
    public partial class KeepAlignAxis 
    {
		#region Methods

		public KeepAlignAxis() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the start of the object on the axis</para>
		/// </summary>
		/// <param name="size">Size of the object to align</param>
		/// <param name="target">Location of the object to align the object to. This map should have the keys start and end.</param>
		/// <param name="offsets">Map with all offsets on each side. Comes with the keys start and end.</param>
		/// <param name="areaSize">Size of the axis.</param>
		/// <param name="position">Alignment of the object on the target. Valid values are  edge-start The object is placed before the target edge-end The object is placed after the target align-startThe start of the object is aligned with the start of the target align-centerThe center of the object is aligned with the center of the target align-endThe end of the object is aligned with the end of the object </param>
		/// <returns>The computed start position of the object.</returns>
		[JsMethod(Name = "computeStart")]
		public static double ComputeStart(double size, object target, object offsets, double areaSize, string position) { throw new NotImplementedException(); }

		#endregion Methods
    }
}