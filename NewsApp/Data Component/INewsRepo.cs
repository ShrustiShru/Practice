using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Data_Component
{
    interface INewsRepo
    {
        void AddNews(New add);
        void UpdateNews(int id);
        void FindNews(New update);
        List<New> GetAllNews();
        
    }
}
