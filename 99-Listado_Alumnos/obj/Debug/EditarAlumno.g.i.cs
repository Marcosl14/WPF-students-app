﻿#pragma checksum "..\..\EditarAlumno.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AAA719B77EF5DE817A5F198496E649A88A64F83170DD1616FDE2F5D0E4986606"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
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
using _99_Listado_Alumnos;


namespace _99_Listado_Alumnos {
    
    
    /// <summary>
    /// EditarAlumno
    /// </summary>
    public partial class EditarAlumno : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editarNombre;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editarApellido;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editarDNI;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editarLegajo;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox editarCiudad;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editarAlumno;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\EditarAlumno.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button eliminarAlumno;
        
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
            System.Uri resourceLocater = new System.Uri("/99-Listado_Alumnos;component/editaralumno.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditarAlumno.xaml"
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
            this.editarNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.editarApellido = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.editarDNI = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.editarLegajo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.editarCiudad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.editarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\EditarAlumno.xaml"
            this.editarAlumno.Click += new System.Windows.RoutedEventHandler(this.editarAlumno_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.eliminarAlumno = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\EditarAlumno.xaml"
            this.eliminarAlumno.Click += new System.Windows.RoutedEventHandler(this.eliminarAlumno_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
