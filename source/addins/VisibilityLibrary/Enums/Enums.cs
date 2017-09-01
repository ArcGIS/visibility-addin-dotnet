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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisibilityLibrary.Properties;

namespace VisibilityLibrary
{
    // Here we create all of our globalized enumerations

    public enum LineTypes : int
    {
        [LocalizableDescription(@"EnumGeodesic", typeof(Resources))]
        Geodesic = 1,

        [LocalizableDescription(@"EnumGreatElliptic", typeof(Resources))]
        GreatElliptic = 2,

        [LocalizableDescription(@"EnumLoxodrome", typeof(Resources))]
        Loxodrome = 3
    }

    public enum DistanceTypes : int
    {
        [LocalizableDescription(@"EnumFeet", typeof(Resources))]
        Feet = 1,

        [LocalizableDescription(@"EnumKilometers", typeof(Resources))]
        Kilometers = 2,

        [LocalizableDescription(@"EnumMeters", typeof(Resources))]
        Meters = 3,

        [LocalizableDescription(@"EnumMiles", typeof(Resources))]
        Miles = 4,

        [LocalizableDescription(@"EnumNauticalMile", typeof(Resources))]
        NauticalMile = 5,

        [LocalizableDescription(@"EnumYards", typeof(Resources))]
        Yards = 6
    }

    public enum AngularTypes : int
    {
        [LocalizableDescription(@"EnumDegrees", typeof(Resources))]
        DEGREES = 1,

        [LocalizableDescription(@"EnumGrads", typeof(Resources))]
        GRADS = 2,

        [LocalizableDescription(@"EnumMils", typeof(Resources))]
        MILS = 3
    }

    public enum CoordinateTypes : int
    {
        [LocalizableDescription(@"EnumCTDD", typeof(Resources))]
        DD = 1,

        [LocalizableDescription(@"EnumCTDDM", typeof(Resources))]
        DDM = 2,

        [LocalizableDescription(@"EnumCTDMS", typeof(Resources))]
        DMS = 3,

        //[LocalizableDescription(@"EnumCTGARS", typeof(Resources))]
        //GARS = 4,

        [LocalizableDescription(@"EnumCTMGRS", typeof(Resources))]
        MGRS = 5,

        [LocalizableDescription(@"EnumCTUSNG", typeof(Resources))]
        USNG = 6,

        [LocalizableDescription(@"EnumCTUTM", typeof(Resources))]
        UTM = 7,

        [LocalizableDescription(@"EnumCTNone", typeof(Resources))]
        None = 8
    }

}
