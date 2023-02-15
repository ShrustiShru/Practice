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
        List<SamsungEmployee> GetAllEmployees();
        List<RouteName> GetAllRoutes();
        void AddNewRoute(RouteName routename);
        List<RouteStop> GetAllStops(int id);
        void AddNewStops(RouteStop routestop);
    }
}
