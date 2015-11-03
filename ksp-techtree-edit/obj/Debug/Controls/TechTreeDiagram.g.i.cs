﻿#pragma checksum "..\..\..\Controls\TechTreeDiagram.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "47778F39466E129093787C69FD317E2B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
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
using ksp_techtree_edit.Converters;
using ksp_techtree_edit.ViewModels;


namespace ksp_techtree_edit.Controls {
    
    
    /// <summary>
    /// TechTreeDiagram
    /// </summary>
    public partial class TechTreeDiagram : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\Controls\TechTreeDiagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid TechTreeGrid;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Controls\TechTreeDiagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl NodeConnectionsControl;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Controls\TechTreeDiagram.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl TechItemsControl;
        
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
            System.Uri resourceLocater = new System.Uri("/KSP Tech Tree Editor v0.2.4 Alpha;component/controls/techtreediagram.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Controls\TechTreeDiagram.xaml"
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
            
            #line 10 "..\..\..\Controls\TechTreeDiagram.xaml"
            ((ksp_techtree_edit.Controls.TechTreeDiagram)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TechTreeGrid = ((System.Windows.Controls.Grid)(target));
            
            #line 19 "..\..\..\Controls\TechTreeDiagram.xaml"
            this.TechTreeGrid.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridOnPreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NodeConnectionsControl = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 4:
            this.TechItemsControl = ((System.Windows.Controls.ItemsControl)(target));
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
            case 5:
            
            #line 68 "..\..\..\Controls\TechTreeDiagram.xaml"
            ((System.Windows.Controls.Primitives.Thumb)(target)).DragDelta += new System.Windows.Controls.Primitives.DragDeltaEventHandler(this.TechNode_OnDragDelta);
            
            #line default
            #line hidden
            
            #line 69 "..\..\..\Controls\TechTreeDiagram.xaml"
            ((System.Windows.Controls.Primitives.Thumb)(target)).DragCompleted += new System.Windows.Controls.Primitives.DragCompletedEventHandler(this.Thumb_OnDragCompleted);
            
            #line default
            #line hidden
            
            #line 70 "..\..\..\Controls\TechTreeDiagram.xaml"
            ((System.Windows.Controls.Primitives.Thumb)(target)).DragStarted += new System.Windows.Controls.Primitives.DragStartedEventHandler(this.Thumb_OnDragStarted);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
