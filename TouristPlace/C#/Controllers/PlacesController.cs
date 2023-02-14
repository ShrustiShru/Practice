using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiComponents.DataBases;
using WebApiComponents.Models.View_Model;

namespace WebApiComponents.Controllers
{
    public class PlacesController : ApiController
    {
        [ResponseType(typeof(List<TouristPlace>))]
        public async Task<IHttpActionResult> GetAllPlaces()
        {
            var context = new TouristEntities();
           var data=context.TouristPlaces.Select((i) => new PlacesVM
            {
                PlaceId=i.PlaceId,
                PlaceName=i.PlaceName,
                Pincode=i.Pincode,
                States=i.States,
                Significance=i.Significance,
                Descriptions=i.Descriptions
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(List<ImageFile>))]
        [Route("api/Images")]
        public async Task<IHttpActionResult> GetAllImages()
        {
            var context = new TouristEntities();
            var data= context.ImageFiles.Select((i) => new ImagesVM
            {
                ImageId=i.ImageId,
                PlaceId=i.PlaceId,
                ImagePath=i.ImagePath,
            }).ToList();
            return await Task.Run<IHttpActionResult>(() => Ok(data));
        }

        [ResponseType(typeof(PlacesVM))]
        public async Task<IHttpActionResult> GetPlaceById(string id)
        {
            var ID = int.Parse(id);
            var context = new TouristEntities();
            var found = context.TouristPlaces.FirstOrDefault((p) => p.PlaceId == ID);
            if (found != null)
            {
                PlacesVM place = new PlacesVM
                {
                    PlaceId=found.PlaceId,
                    PlaceName=found.PlaceName,
                    Pincode=found.Pincode,
                    States=found.States,
                    Significance=found.Significance,
                    Descriptions=found.Descriptions
                };
                return await Task.Run<IHttpActionResult>(() => Ok(place));
            }
            else
                throw new Exception("Id Not Found");
        }

        [ResponseType(typeof(ImagesVM))]
        [Route("api/Images/{id}")]
        public async Task<IHttpActionResult> GetImagesById(string id)
        {
            var ID = int.Parse(id);
            var context = new TouristEntities();
            var found = context.ImageFiles.FirstOrDefault((i) => i.ImageId == ID);
            if (found != null)
            {
                ImagesVM obj = new ImagesVM
                {
                    ImageId = found.ImageId,
                    PlaceId = found.PlaceId,
                    ImagePath = found.ImagePath
                };
                return await Task.Run<IHttpActionResult>(() => Ok(obj));
            }
            else
                throw new Exception("ID not found");
        }

        [Route("api/Tour")]
        [HttpPost]
        public void AddNewTouristPlaces(TouristPlace place)
        {
            try
            {
                var context = new TouristEntities();
                context.TouristPlaces.Add(place);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public void AddNewImage(ImageFile image)
        {
            try
            {
                var context = new TouristEntities();
                context.ImageFiles.Add(image);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public void UpdateTouristPlaces(TouristPlace place)
        {
            var context = new TouristEntities();
            var found = context.TouristPlaces.FirstOrDefault((p) => p.PlaceId == place.PlaceId);
            if (found != null)
            {
                found.PlaceName = place.PlaceName;
                found.Pincode = place.Pincode;
                found.States = place.States;
                found.Significance = place.Significance;
                found.Descriptions = place.Descriptions;
            }
            context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteTouristPlace(string id)
        {
            var ID=int.Parse(id);
            var context = new TouristEntities();
            var found = context.TouristPlaces.FirstOrDefault((p) => p.PlaceId == ID);
            if(found!=null)
                context.TouristPlaces.Remove(found);
            context.SaveChanges();
        }
    }
}
