﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace FlexiMvvm.Views.Generation.Android
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ViewsGenerator : ViewsGeneratorBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            
            #line 1 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"

// =========================================================================
// Copyright 2019 EPAM Systems, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// =========================================================================

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Threading.Tasks;\r\nusing Android.Content;\r\nusing Andro" +
                    "id.OS;\r\nusing Android.Runtime;\r\nusing Android.Views;\r\nusing FlexiMvvm.Persistenc" +
                    "e.Core;\r\nusing FlexiMvvm.ViewModels;\r\nusing FlexiMvvm.Views.Core;\r\n");
            
            #line 32 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
 foreach (var viewGenerationOptions in ViewsGenerationOptions) { 
            
            #line default
            #line hidden
            this.Write("\r\nnamespace ");
            
            #line 34 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetNamespace(viewGenerationOptions)));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    [Register(\"");
            
            #line 36 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetNamespace.ToLower()));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 36 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n    public partial class ");
            
            #line 37 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 37 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.BaseClassName));
            
            #line default
            #line hidden
            this.Write(@", IAndroidView, IOptionsEventSource
    {
        private IViewLifecycleDelegate _lifecycleDelegate;

        public event EventHandler<OptionsItemSelectedEventArgs> OnOptionsItemSelectedCalled;

        protected IViewLifecycleDelegate LifecycleDelegate => _lifecycleDelegate ?? (_lifecycleDelegate = CreateLifecycleDelegate());

        protected virtual IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 47 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(">(this);\r\n        }\r\n\r\n        ");
            
            #line 50 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.LifecycleMethodAccessModifier));
            
            #line default
            #line hidden
            this.Write(" override void OnCreate(Bundle savedInstanceState)\r\n        {\r\n            base.O" +
                    "nCreate(savedInstanceState);\r\n\r\n            LifecycleDelegate.OnCreate(savedInst" +
                    "anceState);\r\n        }\r\n\r\n        ");
            
            #line 57 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.LifecycleMethodAccessModifier));
            
            #line default
            #line hidden
            this.Write(@" override void OnStart()
        {
            base.OnStart();

            LifecycleDelegate.OnStart();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            var optionsItemSelectedEventArgs = new OptionsItemSelectedEventArgs(item);
            OnOptionsItemSelectedCalled?.Invoke(this, optionsItemSelectedEventArgs);

            if (optionsItemSelectedEventArgs.Handled)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        ");
            
            #line 77 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.LifecycleMethodAccessModifier));
            
            #line default
            #line hidden
            this.Write(" override void OnActivityResult(int requestCode, ");
            
            #line 77 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ResultCodeTypeName));
            
            #line default
            #line hidden
            this.Write(" resultCode, Intent data)\r\n        {\r\n            LifecycleDelegate.OnActivityRes" +
                    "ult(requestCode, (Android.App.Result)resultCode, data);\r\n\r\n            base.OnAc" +
                    "tivityResult(requestCode, resultCode, data);\r\n        }\r\n\r\n        ");
            
            #line 84 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.LifecycleMethodAccessModifier));
            
            #line default
            #line hidden
            this.Write(" override void OnSaveInstanceState(Bundle outState)\r\n        {\r\n            Lifec" +
                    "ycleDelegate.OnSaveInstanceState(outState);\r\n\r\n            base.OnSaveInstanceSt" +
                    "ate(outState);\r\n        }\r\n");
            
            #line 90 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      if (viewGenerationOptions.Kind == ViewKind.Fragment) { 
            
            #line default
            #line hidden
            this.Write("\r\n        public override void OnDestroyView()\r\n        {\r\n            LifecycleD" +
                    "elegate.OnDestroyView();\r\n\r\n            base.OnDestroyView();\r\n        }\r\n");
            
            #line 98 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      } 
            
            #line default
            #line hidden
            this.Write("\r\n        ");
            
            #line 100 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.LifecycleMethodAccessModifier));
            
            #line default
            #line hidden
            this.Write(" override void OnDestroy()\r\n        {\r\n            LifecycleDelegate.OnDestroy();" +
                    "\r\n\r\n            base.OnDestroy();\r\n        }\r\n    }\r\n\r\n    public partial class " +
                    "");
            
            #line 108 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel> : ");
            
            #line 108 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@", INavigationView<TViewModel>, ILifecycleViewModelOwner<TViewModel>
        where TViewModel : class, ILifecycleViewModelWithoutParameters, IStateOwner
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 119 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel>, TViewModel>(this);\r\n        }\r\n");
            
            #line 121 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      if (viewGenerationOptions.Kind == ViewKind.Fragment) { 
            
            #line default
            #line hidden
            this.Write(@"
        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }
");
            
            #line 137 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      } 
            
            #line default
            #line hidden
            this.Write(@"
        void ILifecycleViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task ILifecycleViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync();
        }
    }

    public partial class ");
            
            #line 150 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel, TParameters> : ");
            
            #line 150 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write(@", INavigationView<TViewModel>, ILifecycleViewModelOwner<TViewModel>
        where TViewModel : class, ILifecycleViewModelWithParameters<TParameters>, IStateOwner
        where TParameters : Parameters
    {
        private RequestCode _requestCode;

        public TViewModel ViewModel { get; private set; }

        public RequestCode RequestCode => _requestCode ?? (_requestCode = new RequestCode());

        protected override IViewLifecycleDelegate CreateLifecycleDelegate()
        {
            return new ViewLifecycleDelegate<");
            
            #line 162 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ClassName));
            
            #line default
            #line hidden
            this.Write("<TViewModel, TParameters>, TViewModel>(this);\r\n        }\r\n");
            
            #line 164 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      if (viewGenerationOptions.Kind == ViewKind.Fragment) { 
            
            #line default
            #line hidden
            this.Write(@"
        public void SetResult(Android.App.Result resultCode)
        {
            throw new NotSupportedException();
        }

        public void SetResult(Android.App.Result resultCode, Intent data)
        {
            throw new NotSupportedException();
        }

        public void Finish()
        {
            throw new NotImplementedException();
        }
");
            
            #line 180 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
      } 
            
            #line default
            #line hidden
            this.Write(@"
        void ILifecycleViewModelOwner<TViewModel>.SetViewModel(TViewModel viewModel)
        {
            ViewModel = viewModel ?? throw new ArgumentNullException(nameof(viewModel));
        }

        async Task ILifecycleViewModelOwner<TViewModel>.InitializeViewModelAsync()
        {
            await ViewModel.InitializeAsync(");
            
            #line 189 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(viewGenerationOptions.ParametersSourceName));
            
            #line default
            #line hidden
            this.Write("?.GetParameters<TParameters>());\r\n        }\r\n    }\r\n}\r\n");
            
            #line 193 "C:\FlexiMvvm\FlexiMvvm.Generation\Views\Generation\Android\ViewsGenerator.tt"
 } 
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class ViewsGeneratorBase
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
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
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
