﻿#pragma checksum "..\..\..\VIEWS\ProductsView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5A147D39F9C955CA94A4447A64EBEC25F44C2634ACFC53F7DBC0F21C131A68C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MYSHOPMANAGER.VIEWS;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace MYSHOPMANAGER.VIEWS {
    
    
    /// <summary>
    /// ProductsView
    /// </summary>
    public partial class ProductsView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox combo1;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amounttext;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productnametext;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productidtext;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox stockquantitytext;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button savebutton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productcategorytext;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Updatebutton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\VIEWS\ProductsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid productGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/MYSHOPMANAGER;component/views/productsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VIEWS\ProductsView.xaml"
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
            this.combo1 = ((System.Windows.Controls.ComboBox)(target));
            
            #line 19 "..\..\..\VIEWS\ProductsView.xaml"
            this.combo1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Combo1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.amounttext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.productnametext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.productidtext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.stockquantitytext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.savebutton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\VIEWS\ProductsView.xaml"
            this.savebutton.Click += new System.Windows.RoutedEventHandler(this.Savebutton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.productcategorytext = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Updatebutton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\VIEWS\ProductsView.xaml"
            this.Updatebutton.Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.productGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 10:
            
            #line 44 "..\..\..\VIEWS\ProductsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 51 "..\..\..\VIEWS\ProductsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

