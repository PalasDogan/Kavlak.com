﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B538FBC388F76615A694B7BE4C6B374D70736F74"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfApp7;


namespace WpfApp7 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox chan;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label kampanyalar;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cokSatanlar;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label firsat;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label yeni;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.chan = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.chan.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.chan_TextChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.chan.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.chan_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.kampanyalar = ((System.Windows.Controls.Label)(target));
            
            #line 74 "..\..\..\MainWindow.xaml"
            this.kampanyalar.MouseEnter += new System.Windows.Input.MouseEventHandler(this.kampanyalar_MouseEnter);
            
            #line default
            #line hidden
            
            #line 74 "..\..\..\MainWindow.xaml"
            this.kampanyalar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.kampanyalar_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cokSatanlar = ((System.Windows.Controls.Label)(target));
            
            #line 77 "..\..\..\MainWindow.xaml"
            this.cokSatanlar.MouseLeave += new System.Windows.Input.MouseEventHandler(this.cokSatanlar_MouseLeave);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\MainWindow.xaml"
            this.cokSatanlar.MouseEnter += new System.Windows.Input.MouseEventHandler(this.cokSatanlar_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.firsat = ((System.Windows.Controls.Label)(target));
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.firsat.MouseLeave += new System.Windows.Input.MouseEventHandler(this.firsat_MouseLeave);
            
            #line default
            #line hidden
            
            #line 80 "..\..\..\MainWindow.xaml"
            this.firsat.MouseEnter += new System.Windows.Input.MouseEventHandler(this.firsat_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.yeni = ((System.Windows.Controls.Label)(target));
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.yeni.MouseLeave += new System.Windows.Input.MouseEventHandler(this.yeni_MouseLeave);
            
            #line default
            #line hidden
            
            #line 82 "..\..\..\MainWindow.xaml"
            this.yeni.MouseEnter += new System.Windows.Input.MouseEventHandler(this.yeni_MouseEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

