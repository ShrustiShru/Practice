using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApp.Data_Component
{
    public class NewsRepo : INewsRepo
    {
        static readonly NewsSQLDataContext obj = new NewsSQLDataContext();

        public void AddNews(New add)
        {
            obj.News.InsertOnSubmit(add);
            obj.SubmitChanges();
        }

        public void FindNews(New update)
        {
            throw new NotImplementedException();
        }

        public List<New> GetAllNews() => obj.News.ToList();

        public void UpdateNews(int id)
        {
            throw new NotImplementedException();
        }
    }
}