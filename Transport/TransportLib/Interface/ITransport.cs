using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportLib.DataBase;

namespace TransportLib.Interface
{
    interface ITransport
    {
        List<SamsungEmployee> GetAllEmployees(SamsungEmployee employee);
        List<RouteName> GetAllRoutes(RouteName routename);
        void AddNewRoute(RouteName routename);
        List<RouteStop> GetAllStops(RouteStop routestop);
        void AddNewStops(RouteStop routestop);
    }
}
