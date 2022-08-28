using CMS;
using Kentico.PageBuilder.Web.Mvc;
using RBT.Xperience.Core.Components;

[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget("RBT.Xperience.Core.Components.GoogleMap",
    typeof(GoogleMapWidgetViewComponent),
    "Google Map",
    typeof(GoogleMapWidgetProperties),
    Description = "It displays map obtained from the Google maps service using Latitude,Longitude and Google API Key.",
    IconClass = "icon-map-marker")]
