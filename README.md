# Google Map

It displays map obtained from the Google maps service using Latitude,Longitude and Google API Key.

# Installation

Install the [RBT.Xperience.Core.Components.GoogleMap.1.0.0.nupkg](https://www.nuget.org/packages/RBT.Xperience.Core.Components.GoogleMap) NuGet Package to your Kentico Xperience 13.0.73 Core WebSite. 

# Widget

This is a widget which allows you to add a GoogleMap to your screen with certain attributes that can be configured while adding. The properties that can be configured are:

- Latitude*
- Longitude*
- Google API Key*

*Required fields

Make sure to insert your Google Maps API token into appSettings.json:

    "GoogleMapsApiKey":"{key}"
  
# Author

This widget was created by Vasu Yerramsetting @ Ray Business Technologies Pvt Ltd.

# License

This widget is provided under MIT license.

# Reporting issues

Please report any issues seen, in the issue list. We will address at the earliest possibility.

# Compatibility

This widget has been tested on Kentico Xperiecne 13.0.73 Core and can be used on Kentico Xperiecne 13.0.73 Core instance and higher.
# Uninstall instructions

After uninstalling this package from the solution, if you are still seeing the widget on the page tab in Kentico CMS then please follow the below steps.

Go to Solution -> Select Bin folder -> Select the specific widget dll(Ex:RBT.Xperience.Core.Components.YouTubeVideo.dll and RBT.Xperience.Core.Components.YouTubeVideo.Views.dll) and delete from Debug Or Release folders and Rebuild the solution
