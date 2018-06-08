using Newtonsoft.Json;
using Portable.Data;
using Portable.Interface;
using Portable.NewsViper.Entity;
using Portable.NewsViper.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portable.NewsViper.Interactor
{
    public class InteractorNews : IInteractorNews
    {
        private IPresenterNews _presenter;

        private IGetNews repository;
        private string Id;

        public InteractorNews(IPresenterNews presenter, IGetNews rep)
        {
            _presenter = presenter;
            repository = rep;
        }

        public void SetData(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position) + " " + position);
            }


                var model = repository.GetModelByIndex(position);
                if (model != null)
                {
                    var usr = new NewsEntity(model.title, model.urlToImage, model.publishedAt);
                    Id = model.source.id;
                    _presenter?.SetData(usr);
                }
            
            
        }
    }
}
