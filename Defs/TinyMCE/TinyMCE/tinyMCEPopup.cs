//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace SharpKit.TinyMCE
{
    /// <summary>
    /// Fires when the popup is initialized.
    /// </summary>
    [JsType(JsMode.Prototype, Name="tinyMCEPopup", Export=false)]
    public static  partial class tinyMCEPopup
    {
        /// <summary>
        /// Creates a alert dialog. Please don't use the blocking behavior of this
        /// native version use the callback method instead then it can be extended.
        /// </summary>
        /// <param name="t">Title for the new alert dialog.</param>
        /// <param name="cb">Callback function to be executed after the user has selected ok.</param>
        /// <param name="s">Optional scope to execute the callback in.</param>
        public static object alert(string t, object cb, object s){return null;}
        /// <summary>
        /// Closes the current window.
        /// </summary>
        public static object close(){return null;}
        /// <summary>
        /// Creates a confirm dialog. Please don't use the blocking behavior of this
        /// native version use the callback method instead then it can be extended.
        /// </summary>
        /// <param name="t">Title for the new confirm dialog.</param>
        /// <param name="cb">Callback function to be executed after the user has selected ok or cancel.</param>
        /// <param name="s">Optional scope to execute the callback in.</param>
        public static object confirm(string t, object cb, object s){return null;}
        /// <summary>
        /// Executed a command on editor that opened the dialog/popup.
        /// </summary>
        /// <param name="cmd">Command to execute.</param>
        /// <param name="ui">Optional boolean value if the UI for the command should be presented or not.</param>
        /// <param name="val">Optional value to pass with the comman like an URL.</param>
        /// <param name="a">Optional arguments object.</param>
        public static object execCommand(string cmd, bool ui, object val, object a){return null;}
        /// <summary>
        /// Will executed the specified string when the page has been loaded. This function
        /// was added for compatibility with the 2.x branch.
        /// </summary>
        /// <param name="s">String to evalutate on init.</param>
        public static object executeOnLoad(string s){return null;}
        /// <summary>
        /// Returns a language item by key.
        /// </summary>
        /// <param name="n">Language item like mydialog.something.</param>
        /// <param name="dv">Optional default value to return.</param>
        public static string getLang(string n, string dv){return null;}
        /// <summary>
        /// Returns a editor parameter/config option value.
        /// </summary>
        /// <param name="n">Name of the editor config option to retrive.</param>
        /// <param name="dv">Optional default value to return.</param>
        public static string getParam(string n, string dv){return null;}
        /// <summary>
        /// Returns the reference to the parent window that opened the dialog.
        /// </summary>
        public static object getWin(){return null;}
        /// <summary>
        /// Returns a window argument/parameter by name.
        /// </summary>
        /// <param name="n">Name of the window argument to retrive.</param>
        /// <param name="dv">Optional default value to return.</param>
        public static string getWindowArg(string n, string dv){return null;}
        /// <summary>
        /// Initializes the popup this will be called automatically.
        /// </summary>
        public static object init(){return null;}
        /// <summary>
        /// Opens a filebrowser/imagebrowser this will set the output value from
        /// the browser as a value on the specified element.
        /// </summary>
        /// <param name="element_id">Id of the element to set value in.</param>
        /// <param name="type">Type of browser to open image/file/flash.</param>
        /// <param name="option">Option name to get the file_broswer_callback function name from.</param>
        public static object openBrowser(string element_id, string type, string option){return null;}
        /// <summary>
        /// Executes a color picker on the specified element id. When the user
        /// then selects a color it will be set as the value of the specified element.
        /// </summary>
        /// <param name="e">DOM event object.</param>
        /// <param name="element_id">Element id to be filled with the color value from the picker.</param>
        public static object pickColor(object e, string element_id){return null;}
        /// <summary>
        /// Loads a specific dialog language pack. If you pass in plugin_url as a arugment
        /// when you open the window it will load the <plugin url>/langs/<code>_dlg.js lang pack file.
        /// </summary>
        public static object requireLangPack(){return null;}
        /// <summary>
        /// Resizes the dialog to the inner size of the window. This is needed since various browsers
        /// have different border sizes on windows.
        /// </summary>
        public static object resizeToInnerSize(){return null;}
        /// <summary>
        /// Restores any stored selection. This can be useful since some browsers
        /// looses it's selection if a control element is selected/focused inside the dialogs.
        /// </summary>
        public static object restoreSelection(){return null;}
        /// <summary>
        /// Stores the current editor selection for later restoration. This can be useful since some browsers
        /// looses it's selection if a control element is selected/focused inside the dialogs.
        /// </summary>
        public static object storeSelection(){return null;}
    }
}
