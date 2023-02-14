using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiComponents.Models.View_Model
{
    public class PlacesVM
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public int Pincode { get; set; }
        public string States { get; set; }
        public string Significance { get; set; }
        public string Descriptions { get; set; }
    }
}