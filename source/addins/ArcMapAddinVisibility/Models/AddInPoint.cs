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

using CoordinateConversionLibrary.Helpers;
using CoordinateConversionLibrary.Models;
using ESRI.ArcGIS.Geometry;
using VisibilityLibrary.Helpers;

namespace ArcMapAddinVisibility.Models
{
    public class AddInPoint : VisibilityLibrary.Helpers.NotificationObject
    {
        public AddInPoint()
        {

        }

        private IPointToStringConverter pointConverter = new IPointToStringConverter();

        private IPoint point = null;
        public IPoint Point
        {
            get
            {
                return point;
            }
            set
            {
                point = value;

                RaisePropertyChanged(() => Point);
                RaisePropertyChanged(() => Text);
            }
        }
        public string Text
        {
            get
            {
                var pointStr = pointConverter.Convert(point as object, typeof(string), null, null) as string;
                string outFormattedString = string.Empty;
                CoordinateType ccType = ConversionUtils.GetCoordinateString(pointStr, out outFormattedString);
                if (ccType != CoordinateType.Unknown)
                    return outFormattedString;
                return string.Empty;
            }
        }

        private string guid = string.Empty;
        public string GUID
        {
            get
            {
                return guid;
            }
            set
            {
                guid = value;
                RaisePropertyChanged(() => GUID);
            }
        }


    }
}
