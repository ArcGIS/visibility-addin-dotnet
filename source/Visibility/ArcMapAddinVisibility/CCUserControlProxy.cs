﻿// Copyright 2016 Esri 
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
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
