# visibility-addin-dotnet
ArcGIS Add-in provides the capability to quickly do line of sight analyses.

![Image of Visibility Add-In](visibility.png) 

## Features

* Creates LLOS RLOS
* Inputs can be entered manually or via a known coordinate 
* Addin for ArcMap 10.3.1

## Sections

* [Requirements](#requirements)
* [Instructions](#instructions)
* [Developers](#developers)
* [ArcGIS for Desktop Users](#arcgis-for-desktop-users)
* [Workflows](#workflows)
	* [One-to-one Linear Line Of Sight (LLOS)](#one-to-one-linear-line-of-sight-llos)
	* [One-to-many Linear Line of Sight (LLOS)](#one-to-many-linear-line-of-sight-llos)
	* [Many-to-many Linear Line Of Sight (LLOS)](#many-to-many-linear-line-of-sight-llos)
	* [Many-to-one Linear Line Of Sight (LLOS)](#many-to-one-linear-line-of-sight-llos)
	* [Radial Line Of Sight (RLOS)](#radial-line-of-sight-rlos)
* [Resources](#resources)
* [Issues](#issues)
* [Contributing](#contributing)
* [Licensing](#licensing)

## Requirements

## Developers 

* Visual Studio 2013
* ArcGIS Desktop SDK for .NET 10.3.1
	* [ArcGIS Desktop for .NET Requirements](https://desktop.arcgis.com/en/desktop/latest/get-started/system-requirements/arcobjects-sdk-system-requirements.htm)

## ArcGIS for Desktop Users <a name="arcgis-for-desktop-users"></a>

* [ArcGIS Desktop 10.3.1](http://desktop.arcgis.com/en/arcmap/10.3/get-started/system-requirements/arcgis-desktop-system-requirements.htm)

## Instructions

###New to Github

* [New to Github? Get started here.](http://htmlpreview.github.com/?https://github.com/Esri/esri.github.com/blob/master/help/esri-getting-to-know-github.html)

### Working with the Add-In

## Development Environment 

* Building
	* To Build Using Visual Studio
		* Open and build solution file
	* To use MSBuild to build the solution
		* Open a Visual Studio Command Prompt: Start Menu | Visual Studio 2013 | Visual Studio Tools | Developer Command Prompt for VS2013
		* ` cd visibility-addin-dotnet\source\ArcMapAddinVisibility `
		* ` msbuild ArcMapAddinVisibility.sln /property:Configuration=Release `
	* To run Unit test from command prompt: Open a Visual Studio Command Prompt: Start Menu | Visual Studio 2013 | Visual Studio Tools | Developer Command Prompt for VS2013
		* ` cd visibility-addin-dotnet\source\Visibility\ArcMapAddinVisibility.Tests\bin\Release `
		* ` MSTest /testcontainer:ArcMapAddinVisibility.Tests.dll * `

	* Note : Assembly references are based on a default install of the SDK, you may have to update the references if you chose an alternate install option

## Desktop Users
* Running the add-in
	* To run from a stand-alone deployment
		* ArcMap
			* Install the add-in from the latest Release on Github (https://github.com/Esri/visibility-addin-dotnet/releases)
			* Add the add-in command to a toolbar via menu option 
				* "Customize -> Customize mode"
				* Select "Commands" Tab
				* Select "Add-In Controls"
				* Drag/Drop "Show Visibility" command onto a toolbar
				* Close customize mode
				* Open tool by clicking the "Show Visibility" command you just added
				* Dockable visibility tool appears
				* If you add this to a toolbar that you contstantly use the add-in will stay. To remove the add-in delete your [Normal.MXT](https://geonet.esri.com/thread/78692) file
				
## <a name="workflows"></a> Workflows - LLOS

### <a name="one-to-one-linear-line-of-sight-llos"></a> One-to-one Linear Line Of Sight (LLOS) 
1. Add an elevation surface to the map. 
	* This may be a raster dataset, image service, or mosaic dataset.
2. Open the *Visibility Tools*
3. Select the **LLOS** tab
4. Select the **Input Surface** layer from the list
5. Use the **Observer Map Point Tool** to select an observer location on the map.
6. Use the **Target Map Point Tool** to select the target location on the map.
7. Optionally, type an **Observer Offset**, **Target Offset**, and select the offset units.
8. Select **OK**

### <a name="one-to-many-linear-line-of-sight-llos"></a> One-to-many Linear Line Of Sight (LLOS)
1. Add an elevation surface to the map. 
	* This may be a raster dataset, image service, or mosaic dataset.
2. Open the *Visibility Tools*
3. Select the **LLOS** tab
4. Select the **Input Surface** layer from the list
5. Use the **Observer Map Point Tool** to select an observer location on the map.
6. Use the **Target Map Point Tool** to select one or many target location on the map.
7. Optionally, type an **Observer Offset**, **Target Offset**, and select the offset units.
8. Select **OK**

### <a name="many-to-many-linear-line-of-sight-llos"></a> Many-to-many Linear Line Of Sight (LLOS) 
1. Add an elevation surface to the map. 
	* This may be a raster dataset, image service, or mosaic dataset.
2. Open the *Visibility Tools*
3. Select the **LLOS** tab
4. Select the **Input Surface** layer from the list
5. Use the **Observer Map Point Tool** to select one or many observer location on the map.
6. Use the **Target Map Point Tool** to select one or many target location on the map.
7. Optionally, type an **Observer Offset**, **Target Offset**, and select the offset units.
8. Select **OK**

### <a name="many-to-one-linear-line-of-sight-llos"></a> Many-to-one Linear Line Of Sight (LLOS) 
1. Add an elevation surface to the map. 
	* This may be a raster dataset, image service, or mosaic dataset.
2. Open the *Visibility Tools*
3. Select the **LLOS** tab
4. Select the **Input Surface** layer from the list
5. Use the **Observer Map Point Tool** to select many observer locations on the map.
6. Use the **Target Map Point Tool** to select one target location on the map.
7. Optionally, type an **Observer Offset**, **Target Offset**, and select the offset units.
8. Select **OK**

## Workflows - RLOS
Note that the input surface used for RLOS must be in a projected coordinate system (PCS), or the ArcMap Data Frame must be set to  a PCS.

### <a name="radial-line-of-sight-rlos"></a> Radial Line Of Sight (RLOS) 
1. Add an elevation surface to the map. 
	* This may be a raster dataset, image service, or mosaic dataset.
2. Open the *Visibility Tools*
3. Select the **RLOS** tab
4. Select the **Input Surface** layer from the list
5. Use the **Observer Map Point Tool** to select an observer location on the map.
6. Check **Symbolize Non-Visible Data in Output** to add non-visible areas to the output.
	1. If unchecked the output will *only* show areas that are visible to the observers.
7. Optionally, type an **Observer Offset**, **Surface Offset**, and **Distance**, and select the appropriate units.
8. Additional options are **Horizontal Field of View** and **Vertical Field of View**, and select the appropriate units.
8. Select **OK**

## Resources

* [ArcGIS 10.3 Help](http://resources.arcgis.com/en/help/)
* [ArcGIS Blog](http://blogs.esri.com/esri/arcgis/)
* ![Twitter](https://g.twimg.com/twitter-bird-16x16.png)[@EsriDefense](http://twitter.com/EsriDefense)
* [ArcGIS Solutions Website](http://solutions.arcgis.com/military/)

## Issues

Find a bug or want to request a new feature?  Please let us know by submitting an [issue](https://github.com/ArcGIS/visibility-addin-dotnet/issues).

## Contributing

Anyone and everyone is welcome to contribute. Please see our [guidelines for contributing](https://github.com/esri/contributing).

### Repository Points of Contact

#### Repository Owner: [Joe](https://github.com/jmccausland)

* Merge Pull Requests
* Creates Releases and Tags
* Manages Milestones
* Manages and Assigns Issues

#### Secondary: [Lyle](https://github.com/topowright)

* Backup when the Owner is away

## Licensing

Copyright 2016 Esri

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

A copy of the license is available in the repository's [license.txt](license.txt) file.

[](Esri Tags: Military Analyst Defense ArcGIS ArcObjects .NET WPF ArcGISSolutions ArcMap ArcPro Add-In)
[](Esri Language: C#) 
