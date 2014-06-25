﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 10.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpKit.Qooxdoo.Generator.Templates
{
    using SharpKit.Qooxdoo.Generator.Metadata;
    using System;
    
    
    #line 1 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public partial class ClassTemplate : ClassTemplateBase
    {
        public virtual string TransformText()
        {
            this.Write("// Generated by SharpKit.QooxDoo.Generator\r\n");
            
            #line 4 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 var model = Session["Model"] as MetaClass; 
            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing SharpKit.Html;\r\nusing Sha" +
                    "rpKit.JavaScript;\r\n");
            
            #line 9 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 foreach (var u in model.Usings) { 
            
            #line default
            #line hidden
            this.Write("using ");
            
            #line 10 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(u));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 11 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 13 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    ");
            
            #line 15 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.ParseXMLComment(1)));
            
            #line default
            #line hidden
            this.Write("[JsType(JsMode.Prototype, Name = \"");
            
            #line 15 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.OriginalFullName));
            
            #line default
            #line hidden
            this.Write("\", OmitOptionalParameters = true, Export = false)]\r\n    public ");
            
            #line 16 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 if (model.IsAbstract) { 
            
            #line default
            #line hidden
            this.Write("abstract ");
            
            #line 16 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("partial class ");
            
            #line 16 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Name));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 16 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.InheritanceList));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n");
            
            #line 18 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 var events = model.GetAllEvents(); if (events.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t#region Events\r\n\r\n");
            
            #line 21 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 foreach (var eventItem in events) { 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 22 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventItem.ParseXMLComment(2)));
            
            #line default
            #line hidden
            this.Write("public event Action<");
            
            #line 22 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventItem.EventType));
            
            #line default
            #line hidden
            this.Write("> ");
            
            #line 22 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(eventItem.FormattedName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n");
            
            #line 24 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Events\r\n\r\n");
            
            #line 27 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 28 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 var properties = model.GetAllProperties(); if (properties.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t#region Properties\r\n\r\n");
            
            #line 31 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 foreach (var property in properties) { 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 32 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.ParseXMLComment(2)));
            
            #line default
            #line hidden
            this.Write("[JsProperty(Name = \"");
            
            #line 32 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\", NativeField = true)]\r\n\t\t");
            
            #line 33 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.AccessType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 33 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 33 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.FormattedName));
            
            #line default
            #line hidden
            this.Write(" { get; set; }\r\n\r\n");
            
            #line 35 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Properties\r\n\r\n");
            
            #line 38 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 39 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 var methods = model.GetAllMethods(); if (methods.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t#region Methods\r\n\r\n");
            
            #line 42 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 foreach (var method in methods) { 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 43 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ParseXMLComment(2)));
            
            #line default
            #line hidden
            
            #line 43 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 if (!method.IsConstructor) { 
            
            #line default
            #line hidden
            this.Write("[JsMethod(Name = \"");
            
            #line 44 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\t");
            
            #line 45 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.AccessType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 if (method.IsStatic) { 
            
            #line default
            #line hidden
            this.Write("static ");
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 if (!method.IsConstructor) { 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ReturnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.FormattedName));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 46 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.GetParametersList()));
            
            #line default
            #line hidden
            this.Write(") { throw new NotImplementedException(); }\r\n\r\n");
            
            #line 48 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t#endregion Methods\r\n");
            
            #line 50 "C:\Users\Nik\Downloads\sharpkit\SharpKit.Qooxdoo.Generator\Templates\ClassTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "10.0.0.0")]
    public class ClassTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
