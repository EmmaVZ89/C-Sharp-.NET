#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2481965A83DFACC9715CA23FF95988DAD195835A153BD6371DDCB3945D58F6BD"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Aplicacion6;
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


namespace Aplicacion6 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Capitales;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox vistasCapitales;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox bsAs;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox madrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox lima;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox sgoChile;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox bogota;
        
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
            System.Uri resourceLocater = new System.Uri("/Aplicacion6;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.Capitales = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.vistasCapitales = ((System.Windows.Controls.CheckBox)(target));
            
            #line 29 "..\..\MainWindow.xaml"
            this.vistasCapitales.Checked += new System.Windows.RoutedEventHandler(this.vistasCapitales_Checked);
            
            #line default
            #line hidden
            
            #line 29 "..\..\MainWindow.xaml"
            this.vistasCapitales.Unchecked += new System.Windows.RoutedEventHandler(this.vistasCapitales_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.bsAs = ((System.Windows.Controls.CheckBox)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.bsAs.Checked += new System.Windows.RoutedEventHandler(this.singleChecked);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            this.bsAs.Unchecked += new System.Windows.RoutedEventHandler(this.singleUnchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.madrid = ((System.Windows.Controls.CheckBox)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.madrid.Checked += new System.Windows.RoutedEventHandler(this.singleChecked);
            
            #line default
            #line hidden
            
            #line 33 "..\..\MainWindow.xaml"
            this.madrid.Unchecked += new System.Windows.RoutedEventHandler(this.singleUnchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lima = ((System.Windows.Controls.CheckBox)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.lima.Checked += new System.Windows.RoutedEventHandler(this.singleChecked);
            
            #line default
            #line hidden
            
            #line 34 "..\..\MainWindow.xaml"
            this.lima.Unchecked += new System.Windows.RoutedEventHandler(this.singleUnchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.sgoChile = ((System.Windows.Controls.CheckBox)(target));
            
            #line 35 "..\..\MainWindow.xaml"
            this.sgoChile.Checked += new System.Windows.RoutedEventHandler(this.singleChecked);
            
            #line default
            #line hidden
            
            #line 35 "..\..\MainWindow.xaml"
            this.sgoChile.Unchecked += new System.Windows.RoutedEventHandler(this.singleUnchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bogota = ((System.Windows.Controls.CheckBox)(target));
            
            #line 36 "..\..\MainWindow.xaml"
            this.bogota.Checked += new System.Windows.RoutedEventHandler(this.singleChecked);
            
            #line default
            #line hidden
            
            #line 36 "..\..\MainWindow.xaml"
            this.bogota.Unchecked += new System.Windows.RoutedEventHandler(this.singleUnchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

