﻿#pragma checksum "..\..\..\Window1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16D8B67B3BD9789A92764B3595D6B8170DFBC513"
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
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ara;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image uyeollbl1;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uyeollbl;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image girislbl;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label girisyaplbl;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox iki;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp7;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Window1.xaml"
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
            
            #line 52 "..\..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ara = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Window1.xaml"
            this.ara.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ara_TextChanged);
            
            #line default
            #line hidden
            
            #line 57 "..\..\..\Window1.xaml"
            this.ara.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ara_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uyeollbl1 = ((System.Windows.Controls.Image)(target));
            
            #line 62 "..\..\..\Window1.xaml"
            this.uyeollbl1.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.uyeollbl1_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.uyeollbl = ((System.Windows.Controls.Label)(target));
            
            #line 63 "..\..\..\Window1.xaml"
            this.uyeollbl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.uyeollbl1_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.girislbl = ((System.Windows.Controls.Image)(target));
            
            #line 64 "..\..\..\Window1.xaml"
            this.girislbl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.girisyaplbl_MouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.girisyaplbl = ((System.Windows.Controls.Label)(target));
            
            #line 65 "..\..\..\Window1.xaml"
            this.girisyaplbl.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.girisyaplbl_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.iki = ((System.Windows.Controls.GroupBox)(target));
            
            #line 93 "..\..\..\Window1.xaml"
            this.iki.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.iki_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

