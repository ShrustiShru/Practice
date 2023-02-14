using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiComponents.Models.View_Model
{
    public class ImagesVM
    {
        public int ImageId { get; set; }
        public int PlaceId { get; set; }
        public string ImagePath { get; set; }
    }
}