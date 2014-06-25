// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.bom
{
    /// <summary>
	/// <para>EXPERIMENTAL &#8211; NOT READY FOR PRODUCTION</para>
	/// <para>FileReaders allow retrieving the data from a local file, after the file
	/// name was selected by an &lt;input type=&#8220;file&#8221;&gt; element.</para>
	/// <para>For more information see:
	/// http://www.w3.org/TR/FileAPI/</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.bom.FileReader", OmitOptionalParameters = true, Export = false)]
    public partial class FileReader : qx.core.Object
    {
		#region Events

		/// <summary>
		/// <para>Fired when progression has failed, after the last &#8220;progress&#8221; has been
		/// dispatched, or after &#8220;loadstart&#8221; has been dispatched, if &#8220;progress&#8221; has
		/// not been dispatched&#8221;</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnAbort;

		/// <summary>
		/// <para>Fired when an error occurs</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnError;

		/// <summary>
		/// <para>Fired when progression is successful</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnLoad;

		/// <summary>
		/// <para>Fired when progress has stopped, after any of &#8220;error&#8221;, &#8220;abort&#8221;, or
		/// &#8220;load&#8221; have been dispatched.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnLoadend;

		/// <summary>
		/// <para>Fired when progress has begun.</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnLoadstart;

		/// <summary>
		/// <para>Fired while making progress, presumably at a minimum of every 50ms</para>
		/// </summary>
		public event Action<qx.eventx.type.Data> OnProgress;

		#endregion Events

		#region Methods

		/// <summary>
		/// <para>Create a new instance.</para>
		/// </summary>
		public FileReader() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the native File object selected from an &lt;input type=&#8220;file&#8221;&gt;
		/// element.</para>
		/// </summary>
		/// <param name="inputElement">The Element created as a result of an &lt;input type=&#8220;file&#8221;&gt; tag.</param>
		/// <param name="index">The index of the selected file to return.</param>
		/// <returns>The File object associated with the selected file name.</returns>
		[JsMethod(Name = "getFile")]
		public static object GetFile(qx.html.Element inputElement, double index) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the number of files selected by the user, from an &lt;input
		/// type=&#8220;file&#8221;&gt; element.</para>
		/// </summary>
		/// <param name="inputElement">The Element created as a result of an &lt;input type=&#8220;file&#8221;&gt; tag.</param>
		/// <returns>The number of selected files.</returns>
		[JsMethod(Name = "getNumFiles")]
		public static double GetNumFiles(qx.html.Element inputElement) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Begin reading from the file referenced by the specified file
		/// object. This is an asynchronous request. When the file is fully loaded,
		/// the &#8220;load&#8221; event will be fired.</para>
		/// <para>The data will be provided in a binary format where each byte is in the
		/// range [0,255].</para>
		/// <para>NOTE: On FireFox, this method works if the page was loaded via the
		/// file:// protocol. In Chrome, it does not.</para>
		/// </summary>
		/// <param name="fileObj">A File object, as obtained by calling #getFile with an element of type &lt;input type=&#8220;file&#8221;&gt;.</param>
		[JsMethod(Name = "readAsBinaryString")]
		public void ReadAsBinaryString(object fileObj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Begin reading from the file referenced by the specified file
		/// object. This is an asynchronous request. When the file is fully loaded,
		/// the &#8220;load&#8221; event will be fired.</para>
		/// <para>The data is returned in DataURL format.</para>
		/// <para>NOTE: On FireFox, this method works if the page was loaded via the
		/// file:// protocol. In Chrome, it does not.</para>
		/// </summary>
		/// <param name="fileObj">A File object, as obtained by calling #getFile with an element of type &lt;input type=&#8220;file&#8221;&gt;.</param>
		[JsMethod(Name = "readAsDataURL")]
		public void ReadAsDataURL(object fileObj) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Begin reading from the file referenced by the specified file
		/// object. This is an asynchronous request. When the file is fully loaded,
		/// the &#8220;load&#8221; event will be fired.</para>
		/// <para>The data will be provided as text, in the specified encoding.</para>
		/// <para>NOTE: On FireFox, this method works if the page was loaded via the
		/// file:// protocol. In Chrome, it does not.</para>
		/// </summary>
		/// <param name="fileObj">A File object, as obtained by calling #getFile with an element of type &lt;input type=&#8220;file&#8221;&gt;.</param>
		/// <param name="encoding">The encoding for the resulting string.</param>
		[JsMethod(Name = "readAsText")]
		public void ReadAsText(object fileObj, string encoding = "UTF-8") { throw new NotImplementedException(); }

		#endregion Methods
    }
}