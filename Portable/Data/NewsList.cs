using Portable.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.Data
{
    public class NewsList : IGetNews,IGetNewsCount
    {

        private News _news;


        public NewsList(News data)
        {
            _news = data;
        }
        

        public int GetCountNews()
        {
            if (_news.articles != null)
                return _news.articles.Count;
            else
                return 0;
        }

        public Articles GetModelById(int id)
        {
            throw new NotImplementedException();
            //return _news.Find((x) => x.articles.Find((y)=> y.source.id == id.ToString()) );
        }

        public Articles GetModelByIndex(int index)
        {
            if (_news.articles != null)
                return _news.articles[index];
            else
                return null;
        }
    }
}
