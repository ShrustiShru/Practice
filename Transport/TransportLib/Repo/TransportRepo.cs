using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLib.DataBase;
using TransportLib.Interface;

namespace TransportLib.Repo
{
    class TransportRepo : ITransport
    {
        public List<SamsungEmployee> GetAllEmployees(SamsungEmployee employee)
        {
            var context = new TransportEntities();
            var data = context.SamsungEmployees.ToList();
            return data;
        }

        public List<RouteName> GetAllRoutes(RouteName routename)
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


        public List<RouteStop> GetAllStops(RouteStop routestop)
        {
            var context = new TransportEntities();
            var data = context.RouteStops.ToList();
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
