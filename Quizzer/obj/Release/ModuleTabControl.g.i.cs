﻿#pragma checksum "..\..\ModuleTabControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "80696FD8A35279106DD7B0D01BD320E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Shaw_Tab {
    
    
    /// <summary>
    /// ModuleTabControl
    /// </summary>
    public partial class ModuleTabControl : System.Windows.Controls.TabControl, System.Windows.Markup.IComponentConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/Quizzer_Classes;component/moduletabcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ModuleTabControl.xaml"
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
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TabControl_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TabControl_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).PreviewMouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.TabControl_MouseLeftButtonUp);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).PreviewMouseMove += new System.Windows.Input.MouseEventHandler(this.TabControl_PreviewMouseMove);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).PreviewMouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.TabControl_PreviewMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).DragEnter += new System.Windows.DragEventHandler(this.TabControl_DragEnter);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).Drop += new System.Windows.DragEventHandler(this.TabControl_Drop);
            
            #line default
            #line hidden
            
            #line 6 "..\..\ModuleTabControl.xaml"
            ((Shaw_Tab.ModuleTabControl)(target)).PreviewDrop += new System.Windows.DragEventHandler(this.TabControl_PreviewDrop);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
