// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.layout
{
    /// <summary>
	/// <para>Base class for all layout managers.</para>
	/// <para>Custom layout manager must derive from
	/// this class and implement the methods <see cref="InvalidateLayoutCache"/>,
	/// <see cref="RenderLayout"/> and <see cref="GetSizeHint"/>.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.layout.Abstract", OmitOptionalParameters = true, Export = false)]
    public abstract partial class Abstract : qx.core.Object
    {
		#region Methods

		public Abstract() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called by the widget to connect the widget with the layout.</para>
		/// </summary>
		/// <param name="widget">The widget to connect to.</param>
		[JsMethod(Name = "connectToWidget")]
		public void ConnectToWidget(qx.ui.core.Widget widget) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>If layout wants to trade height for width it has to implement this
		/// method and return the preferred height if it is resized to
		/// the given width. This function returns null if the item
		/// do not support height for width.</para>
		/// </summary>
		/// <param name="width">The computed width</param>
		/// <returns>The desired height</returns>
		[JsMethod(Name = "getHeightForWidth")]
		public double GetHeightForWidth(double width) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Computes the layout dimensions and possible ranges of these.</para>
		/// </summary>
		/// <returns>The map with the preferred width/height and the allowed minimum and maximum values in cases where shrinking or growing is required. Can also return null when this detection is not supported by the layout.</returns>
		[JsMethod(Name = "getSizeHint")]
		public object GetSizeHint() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Whether the layout manager supports height for width.</para>
		/// </summary>
		/// <returns>Whether the layout manager supports height for width</returns>
		[JsMethod(Name = "hasHeightForWidth")]
		public bool HasHeightForWidth() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>This method is called, on each child &#8220;add&#8221; and &#8220;remove&#8221; action and
		/// whenever the layout data of a child is changed. The method should be used
		/// to clear any children relevant cached data.</para>
		/// </summary>
		[JsMethod(Name = "invalidateChildrenCache")]
		public void InvalidateChildrenCache() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Invalidate all layout relevant caches. Automatically deletes the size hint.</para>
		/// </summary>
		[JsMethod(Name = "invalidateLayoutCache")]
		public void InvalidateLayoutCache() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Applies the children layout.</para>
		/// </summary>
		/// <param name="availWidth">Final width available for the content (in pixel)</param>
		/// <param name="availHeight">Final height available for the content (in pixel)</param>
		[JsMethod(Name = "renderLayout")]
		public void RenderLayout(double availWidth, double availHeight) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Verifies the value of a layout property.</para>
		/// <para>Note: This method is only available in the debug builds.</para>
		/// </summary>
		/// <param name="item">The affected layout item</param>
		/// <param name="name">Name of the layout property</param>
		/// <param name="value">Value of the layout property</param>
		[JsMethod(Name = "verifyLayoutProperty")]
		public void VerifyLayoutProperty(object item, object name, object value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}