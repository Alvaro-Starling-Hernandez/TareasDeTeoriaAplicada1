﻿#pragma checksum "..\..\..\..\UI\Capitulo5_ejercicio4.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DEAA1E17AEC58BF38939B6073061C96ED29B4C38"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ProyectoTarea2.UI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace ProyectoTarea2.UI {
    
    
    /// <summary>
    /// Capitulo5_ejercicio4
    /// </summary>
    public partial class Capitulo5_ejercicio4 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox numeroTextBox;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox factorialTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calcularBtn;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button limpiarBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ProyectoTarea2;component/ui/capitulo5_ejercicio4.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.numeroTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.factorialTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.calcularBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
            this.calcularBtn.Click += new System.Windows.RoutedEventHandler(this.calcularBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.limpiarBtn = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\UI\Capitulo5_ejercicio4.xaml"
            this.limpiarBtn.Click += new System.Windows.RoutedEventHandler(this.limpiarBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

