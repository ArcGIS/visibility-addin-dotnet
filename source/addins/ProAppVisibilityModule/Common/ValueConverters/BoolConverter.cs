﻿/******************************************************************************* 
  * Copyright 2015 Esri 
  *  
  *  Licensed under the Apache License, Version 2.0 (the "License"); 
  *  you may not use this file except in compliance with the License. 
  *  You may obtain a copy of the License at 
  *  
  *  http://www.apache.org/licenses/LICENSE-2.0 
  *   
  *   Unless required by applicable law or agreed to in writing, software 
  *   distributed under the License is distributed on an "AS IS" BASIS, 
  *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
  *   See the License for the specific language governing permissions and 
  *   limitations under the License. 
  ******************************************************************************/ 

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ProAppVisibilityModule.Common.ValueConverters
{
    
    /// <summary>
    /// Returns the opposite or 'Not' of the input - True for False and False for True
    /// </summary>
    public class ReverseBooleaanConverter : IValueConverter {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            return !(bool)value;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            throw new InvalidOperationException(Properties.Resources.ValueConverterError);
        }

    }

    /// <summary>
    /// Converts the given bool to a Visibility
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter {

        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture) {
            if (value == null)
                return Visibility.Hidden;
            bool val = (bool)value;
            return val ? Visibility.Visible : Visibility.Hidden;
        }

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture) {
            throw new InvalidOperationException(Properties.Resources.ValueConverterError);
        }

    }
}
