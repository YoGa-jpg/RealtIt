﻿#pragma checksum "..\..\LogInWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3199C4E0C8573577BDB3171BF2771B12107BFC0083545C01D806C4B6CB448FB9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RealtIt;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RealtIt {
    
    
    /// <summary>
    /// LogInWindow
    /// </summary>
    public partial class LogInWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal RealtIt.LogInWindow LogInForm;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CloseLink;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogInButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LogInBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PassBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\LogInWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image SignUpLink;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RealtIt;component/loginwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\LogInWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.LogInForm = ((RealtIt.LogInWindow)(target));
            
            #line 8 "..\..\LogInWindow.xaml"
            this.LogInForm.Deactivated += new System.EventHandler(this.LogInWindow_OnDeactivated);
            
            #line default
            #line hidden
            
            #line 8 "..\..\LogInWindow.xaml"
            this.LogInForm.Activated += new System.EventHandler(this.LogInWindow_OnActivated);
            
            #line default
            #line hidden
            
            #line 8 "..\..\LogInWindow.xaml"
            this.LogInForm.Closed += new System.EventHandler(this.LogInForm_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseLink = ((System.Windows.Controls.Image)(target));
            
            #line 40 "..\..\LogInWindow.xaml"
            this.CloseLink.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseLink_OnMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LogInButton = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\LogInWindow.xaml"
            this.LogInButton.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.LogInButton_OnPreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LogInBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.PassBox = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.SignUpLink = ((System.Windows.Controls.Image)(target));
            
            #line 57 "..\..\LogInWindow.xaml"
            this.SignUpLink.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.SignUpLink_OnMouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
