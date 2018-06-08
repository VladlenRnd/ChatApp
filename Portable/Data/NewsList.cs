using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Data
{
    public class NewsList : IGetNews,IGetNewsCount
    {

        private List<News> _news = new List<News>();


        

        public int GetCountNews()
        {
            return _news.Count;
        }

        public News GetModelById(int id)
        {
            throw new NotImplementedException();
            //return _news.Find((x) => x.articles.Find((y)=> y.source.id == id.ToString()) );
        }

        public News GetModelByIndex(int index)
        {
            return _news[index];
        }
    }
}
