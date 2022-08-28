using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace RBT.Xperience.Core.Components
{
    public class GoogleMapWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Latitude *")]
        [Required(ErrorMessage = "Please enter latitude.")]
        public string Latitude { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Longitude *")]
        [Required(ErrorMessage = "Please enter longitude.")]
        public string Longitude { get; set; }

        public GoogleMapWidgetProperties()
        {
            
        }
    }
}
