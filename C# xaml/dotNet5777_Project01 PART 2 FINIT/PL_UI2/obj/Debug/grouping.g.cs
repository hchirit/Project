﻿#pragma checksum "..\..\grouping.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "816CC36F03B6E0EBF3C19AE3D94C85C8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PL_UI2;
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


namespace PL_UI2 {
    
    
    /// <summary>
    /// grouping_expert
    /// </summary>
    public partial class grouping_expert : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button expert;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button city;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button date;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button age;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button branch;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menu;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\grouping.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid_s;
        
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
            System.Uri resourceLocater = new System.Uri("/PL_UI2-5;component/grouping.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\grouping.xaml"
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
            this.expert = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\grouping.xaml"
            this.expert.Click += new System.Windows.RoutedEventHandler(this.expert_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.city = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\grouping.xaml"
            this.city.Click += new System.Windows.RoutedEventHandler(this.city_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.date = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\grouping.xaml"
            this.date.Click += new System.Windows.RoutedEventHandler(this.date_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.age = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\grouping.xaml"
            this.age.Click += new System.Windows.RoutedEventHandler(this.age_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.branch = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\grouping.xaml"
            this.branch.Click += new System.Windows.RoutedEventHandler(this.branch_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.menu = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\grouping.xaml"
            this.menu.Click += new System.Windows.RoutedEventHandler(this.menu_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DataGrid_s = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

