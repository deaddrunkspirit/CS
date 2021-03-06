﻿#pragma checksum "..\..\DrawingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1D133F9B44513DDD23AAFBDAD8664BB0CEAD737009F6587BA782A116A900CC1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FractalDrawingApp;
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace FractalDrawingApp {
    
    
    /// <summary>
    /// DrawingWindow
    /// </summary>
    public partial class DrawingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 39 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ScrollZoom;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas drawingArea;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider recursionDepthSlider;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox recursionDepthTextBox;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label firstLabel;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider firstAngleSlider;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstAngleTextBox;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label secondLabel;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider secondAngleSlider;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox secondAngleTextBox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label coefficentLabel;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider coefficentSlider;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox coefficentTextBox;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backButton;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker startColorPicker;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker endColorPicker;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Zoom;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\DrawingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ZoomTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/FractalDrawingApp;component/drawingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DrawingWindow.xaml"
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
            this.ScrollZoom = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 2:
            this.drawingArea = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.recursionDepthSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 51 "..\..\DrawingWindow.xaml"
            this.recursionDepthSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.recursionDepth_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.recursionDepthTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.firstLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.firstAngleSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 71 "..\..\DrawingWindow.xaml"
            this.firstAngleSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.firstAngleSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.firstAngleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.secondLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.secondAngleSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 91 "..\..\DrawingWindow.xaml"
            this.secondAngleSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.secondAngleSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.secondAngleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.coefficentLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.coefficentSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 112 "..\..\DrawingWindow.xaml"
            this.coefficentSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.coefficentSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 13:
            this.coefficentTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.backButton = ((System.Windows.Controls.Button)(target));
            
            #line 125 "..\..\DrawingWindow.xaml"
            this.backButton.Click += new System.Windows.RoutedEventHandler(this.backButton_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 131 "..\..\DrawingWindow.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.saveButton_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.startColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 136 "..\..\DrawingWindow.xaml"
            this.startColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.startColor_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            this.endColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            
            #line 140 "..\..\DrawingWindow.xaml"
            this.endColorPicker.SelectedColorChanged += new System.Windows.RoutedPropertyChangedEventHandler<System.Nullable<System.Windows.Media.Color>>(this.endColor_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            this.Zoom = ((System.Windows.Controls.Slider)(target));
            
            #line 149 "..\..\DrawingWindow.xaml"
            this.Zoom.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Zoom_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 19:
            this.ZoomTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

