/*******************************************************************************************************
  This file was created/modified by Herv� PHILIPPE alchiweb[at]gmail.com
********************************************************************************************************

  Copyright (C) 2013 Herv� PHILIPPE, Web: http://xmadevlab.net

  Project based on the files auto generated with the tool "WebIDLParser"
  Copyright (C) 2013 Sebastian Loncar, Web: http://loncar.de
  Copyright (C) 2009 Apple Inc. All Rights Reserved.

  MIT License:

  Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
  associated documentation files (the "Software"), to deal in the Software without restriction, 
  including without limitation the rights to use, copy, modify, merge, publish, distribute,
  sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all copies or substantial
  portions of the Software.

  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
  NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
  NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES
  OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
  CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*******************************************************************************************************/

using System;
using System.ComponentModel;

namespace SharpKit.DotNet.Html.fileapi
{

    using SharpKit.JavaScript;
    using SharpKit.DotNet.JavaScript;
    using SharpKit.DotNet.Html.fileapi;
    using SharpKit.DotNet.Html.html.shadow;
    using SharpKit.DotNet.Html.html.track;
    using SharpKit.DotNet.Html.inspector;
    using SharpKit.DotNet.Html.loader.appcache;
    using SharpKit.DotNet.Html.battery;
    using SharpKit.DotNet.Html.gamepad;
    using SharpKit.DotNet.Html.geolocation;
    using SharpKit.DotNet.Html.indexeddb;
    using SharpKit.DotNet.Html.intents;
    using SharpKit.DotNet.Html.mediasource;
    using SharpKit.DotNet.Html.mediastream;
    using SharpKit.DotNet.Html.networkinfo;
    using SharpKit.DotNet.Html.notifications;
    using SharpKit.DotNet.Html.proximity;
    using SharpKit.DotNet.Html.quota;
    using SharpKit.DotNet.Html.speech;
    using SharpKit.DotNet.Html.webaudio;
    using SharpKit.DotNet.Html.webdatabase;
    using SharpKit.DotNet.Html.plugins;
    using SharpKit.DotNet.Html.storage;
    using SharpKit.DotNet.Html.svg;
    using SharpKit.DotNet.Html.workers;

    [JsType(JsMode.Prototype, Export = false, PropertiesAsFields = true, NativeCasts = true, Name = "FileReaderSync")]
    public partial class FileReaderSync : EventTarget, IEventTarget<FileReaderProgressEventType, FileReaderProgressEvent<FileReaderSync>>
    {
        public FileReaderSync() { }

#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the read has been aborted. For instance, by invoking the <see cref="Abort"/> method.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onabort", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onAbort { get; set; }
#endif
        /// <summary>
        /// Called when the read has been aborted. For instance, by invoking the <see cref="Abort"/> method.
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnAbort
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"abort\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the read has failed.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onerror", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onError { get; set; }
#endif
        /// <summary>
        /// Called when the read has failed.
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnError
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"error\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the read has successfully completed.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onload", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onLoad { get; set; }
#endif
        /// <summary>
        /// Called when the read has successfully completed.
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnLoad
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"load\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"load\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the read starts.
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadstart", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onLoadStart { get; set; }
#endif
        /// <summary>
        /// Called when the read starts.
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnLoadStart
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadstart\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onloadend", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onLoadEnd { get; set; }
#endif
        /// <summary>
        /// Called when the request has completed (either in success or failure).
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnLoadEnd
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"loadend\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"loadend\"", InsertArg1 = "false")]
            remove { }
        }
#if COMP_WITH_EVENTS_PROP
        /// <summary>
        /// Called while reading the file, reporting progress in terms of "FileReaderEvent.loaded"/"FileReaderEvent.total".
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
#if HIDE_EVENTS_PROP
        [EditorBrowsable(EditorBrowsableState.Never)]
#endif
        [JsProperty(Name = "onprogress", NativeField = true)]
        public EventListener<FileReaderProgressEvent<FileReaderSync>> onProgress { get; set; }
#endif
        /// <summary>
        /// Called while reading the file, reporting progress in terms of "FileReaderEvent.loaded"/"FileReaderEvent.total".
        /// <para>WARNING: this property is not supported by Cordova.</para>
        /// </summary>
        public event EventListener<FileReaderProgressEvent<FileReaderSync>> OnProgress
        {
            [JsMethod(Name = "addEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            add { }
            [JsMethod(Name = "removeEventListener", InsertArg0 = "\"progress\"", InsertArg1 = "false")]
            remove { }
        }


        /// <summary>
        /// Aborts reading file.
        /// </summary>
        [JsMethod(Name = "abort")]
        public void Abort() { }
        [JsMethod(Name = "readAsArrayBuffer")]
        public ArrayBuffer ReadAsArrayBuffer(Blob blob) { return default(ArrayBuffer); }
        [JsMethod(Name = "readAsBinaryString")]
        public JsString ReadAsBinaryString(Blob blob) { return default(JsString); }
        [JsMethod(Name = "readAsText")]
        public JsString ReadAsText(Blob blob) { return default(JsString); }
        [JsMethod(Name = "readAsText")]
        public JsString ReadAsText(Blob blob, JsString encoding) { return default(JsString); }
        [JsMethod(Name = "readAsDataURL")]
        public JsString ReadAsDataURL(Blob blob) { return default(JsString); }

        [JsMethod(Name = "addEventListener")]
        public void AddEventListener(FileReaderProgressEventType type, EventListener<FileReaderProgressEvent<FileReaderSync>> listener, bool useCapture = false) { }
        [JsMethod(Name = "removeEventListener")]
        public void RemoveEventListener(FileReaderProgressEventType type, EventListener<FileReaderProgressEvent<FileReaderSync>> listener, bool useCapture = false) { }
        [JsMethod(Name = "dispatchEvent")]
        public bool DispatchEvent(FileReaderProgressEvent<FileReaderSync> evt) { return default(bool); }


        #region Properties and methods inherited to hide for Intellisense
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "addEventListener")]
        public new void AddEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "dispatchEvent")]
        public new bool DispatchEvent(Event evt) { return default(bool); }
        [EditorBrowsable(EditorBrowsableState.Never)]
        [JsMethod(Name = "removeEventListener")]
        public new void RemoveEventListener(JsString type, EventListener listener, bool useCapture = false) { }
        #endregion
    }

}