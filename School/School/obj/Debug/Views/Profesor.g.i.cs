﻿#pragma checksum "..\..\..\Views\Profesor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB8C719287797C8E192A6A986F7D0AB1B00CFEB95F474264AA1AC7AB9389216B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using School.Views;
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


namespace School.Views {
    
    
    /// <summary>
    /// Profesor
    /// </summary>
    public partial class Profesor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clasaBox;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox elevBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gradeGrid;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AbsenceGrid;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addGrade;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addAbs;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button motivAbs;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Views\Profesor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label avgProf;
        
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
            System.Uri resourceLocater = new System.Uri("/School;component/views/profesor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Profesor.xaml"
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
            this.clasaBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 10 "..\..\..\Views\Profesor.xaml"
            this.clasaBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.clasaBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.elevBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\Views\Profesor.xaml"
            this.elevBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.elevBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.gradeGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.AbsenceGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.addGrade = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\Views\Profesor.xaml"
            this.addGrade.Click += new System.Windows.RoutedEventHandler(this.addGrade_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addAbs = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Views\Profesor.xaml"
            this.addAbs.Click += new System.Windows.RoutedEventHandler(this.addAbs_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.motivAbs = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Views\Profesor.xaml"
            this.motivAbs.Click += new System.Windows.RoutedEventHandler(this.motivAbs_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.avgProf = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
