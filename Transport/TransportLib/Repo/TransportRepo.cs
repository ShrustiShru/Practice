using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLib.DataBase;
using TransportLib.Interface;

namespace TransportLib.Repo
{
    public class TransportRepo : ITransport
    {
        public List<SamsungEmployee> GetAllEmployees()
        {
            var context = new TransportEntities();
            var data = context.SamsungEmployees.ToList();
            return data;
        }

        public List<RouteName> GetAllRoutes()
        {
            var context = new TransportEntities();
            var data = context.RouteNames.ToList();
            return data;
        }

        public void AddNewRoute(RouteName routename)
        {
            var context = new TransportEntities();
            var data = context.RouteNames.Add(routename);
            context.SaveChanges();
        }
        public RouteStop getFair(string fromPlace,string toPlace,int routeId)
        {
            var context = new TransportEntities();
            return (from e in context.RouteStops where e.RouteNumber == routeId && e.PickUp == fromPlace && e.DropOut == toPlace select e).First();
                       
        }


        public List<RouteStop> GetAllStops(int id)
        {
            var context = new TransportEntities();
            var data = context.RouteStops.ToList().FindAll(p=>p.RouteNumber == id);
            return data;
        }
       
        public void AddNewStops(RouteStop routestop)
        {
            var context = new TransportEntities();
            var data = context.RouteStops.Add(routestop);
            context.SaveChanges();
        }

    }
}
