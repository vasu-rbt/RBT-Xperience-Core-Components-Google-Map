using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Text;

namespace RBT.Xperience.Core.Components
{
    public class GoogleMapWidgetViewComponent : ViewComponent
    {
        private readonly IConfiguration _configuration;
        public GoogleMapWidgetViewComponent(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IViewComponentResult Invoke(ComponentViewModel<GoogleMapWidgetProperties> componentViewModel)
        {
            var properties = componentViewModel.Properties;
            var viewModel = new GoogleMapWidgetViewModel
            {
                Latitude = properties.Latitude,
                Longitude = properties.Longitude,
                ApiKey = _configuration.GetSection("GoogleMapsApiKey").Value,
            };
            return View("~/Components/Widgets/GoogleMapWidget/_GoogleMapWidget.cshtml", viewModel);
        }
    }
}