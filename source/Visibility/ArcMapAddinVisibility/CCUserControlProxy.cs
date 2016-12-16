﻿using System;
using System.Windows.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Framework;
using ArcMapAddinVisibility.ViewModels;
using VisibilityLibrary.Helpers;
using ESRI.ArcGIS.esriSystem;

namespace ArcMapAddinVisibility
{
    public class CCUserControlProxy : UserControl
    {
        public CCUserControlProxy()
            : base()
        {
            //InitializeComponent();
        }

        public IApplication ArcMapApplication
        {
            set
            {
                ArcMap.Application = value;
            }
        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        public class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private System.Windows.Forms.Integration.ElementHost m_windowUI;

            public AddinImpl()
            {
            }

            protected override IntPtr OnCreateChild()
            {
                m_windowUI = new System.Windows.Forms.Integration.ElementHost();
                m_windowUI.Child = new DockableWindowVisibility();
                return m_windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (m_windowUI != null)
                    m_windowUI.Dispose();

                base.Dispose(disposing);
            }

        }
    }
}
