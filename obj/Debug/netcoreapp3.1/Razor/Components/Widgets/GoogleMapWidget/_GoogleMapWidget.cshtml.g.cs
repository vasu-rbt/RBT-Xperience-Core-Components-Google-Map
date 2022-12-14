#pragma checksum "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3619052cdbd8e49f34644000dab3d4e2435a3841"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_Widgets_GoogleMapWidget__GoogleMapWidget), @"mvc.1.0.view", @"/Components/Widgets/GoogleMapWidget/_GoogleMapWidget.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
using RBT.Xperience.Core.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3619052cdbd8e49f34644000dab3d4e2435a3841", @"/Components/Widgets/GoogleMapWidget/_GoogleMapWidget.cshtml")]
    #nullable restore
    public class Components_Widgets_GoogleMapWidget__GoogleMapWidget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoogleMapWidgetViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""text/javascript"">
    function initialize() {
    $('.googlemap_js').each(function () {
        var mapOptions = {
            center: new google.maps.LatLng(this.attributes['data-latitude'].value, this.attributes['data-longitude'].value),
            zoom: 4,
            mapTypeId: 'roadmap',
        };
        var map = new google.maps.Map(document.getElementById(this.attributes['id'].value), mapOptions);
        var bounds = new google.maps.LatLngBounds();
        var latlng = new google.maps.LatLng(this.attributes['data-latitude'].value, this.attributes['data-longitude'].value);
        var marker = new google.maps.Marker({
            map: map,
            position: latlng,
            title: 'Google Map'
        });
        bounds.extend(latlng);
    });
}
</script>

");
#nullable restore
#line 24 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
 if (Model.ApiKey == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"color:red\">Please add API Key in web.config file to display Google Map</p>\r\n");
#nullable restore
#line 27 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script");
            BeginWriteAttribute("src", " src=\"", 1026, "\"", 1109, 3);
            WriteAttributeValue("", 1032, "https://maps.googleapis.com/maps/api/js?key=", 1032, 44, true);
#nullable restore
#line 30 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
WriteAttributeValue("", 1076, Model.ApiKey, 1076, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1089, "&callback=initialize", 1089, 20, true);
            EndWriteAttribute();
            WriteLiteral("\r\n        async defer></script>\r\n");
#nullable restore
#line 32 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
  
    string mapId = String.Concat("map_", DateTime.Now.Ticks.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("id", " id=\"", 1231, "\"", 1242, 1);
#nullable restore
#line 36 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
WriteAttributeValue("", 1236, mapId, 1236, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"googlemap_js\" data-latitude=\"");
#nullable restore
#line 36 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
                                                Write(Model.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-longitude=\"");
#nullable restore
#line 36 "D:\Projects\Xperience13\CoreComponents\RBTXperienceCoreComponentsGoogleMap\Components\Widgets\GoogleMapWidget\_GoogleMapWidget.cshtml"
                                                                                 Write(Model.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" style=\"width: 100%; height: 400px;\">\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoogleMapWidgetViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
