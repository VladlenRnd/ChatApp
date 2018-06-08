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

        private readonly IGetNews repository;
        private int Id;

        public InteractorNews(IPresenterNews presenter)
        {
            _presenter = presenter;
            _presenter.ClickFindBtn += _presenter_ClickFindBtn;
        }

        private async void _presenter_ClickFindBtn(string searc)
        {
            string res;
            string url = String.Format("https://newsapi.org/v2/top-headlines?q={0}&apiKey=7917a33f77da46a5af1d4849b160e5ec", searc);



            res = await GetNewsByUrl(url);

            News m = JsonConvert.DeserializeObject<News>(res);

      

            Console.WriteLine(res);
        }

        private async Task<string> GetNewsByUrl(string url)
        {
            using (var client = new HttpClient())
            {
                using (var r = await client.GetAsync(new Uri(url)))
                {
                    string result = await r.Content.ReadAsStringAsync();
                    return result;
                }
            }
        }

        public void SetData(int position)
        {
            if (position < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(position) + " " + position);
            }
            /*
            var model = repository.GetModelByIndex(position);
            var usr = new NewsEntity(model.Title, model.UrlImg,model.Time);
            Id = model.Id;
            _presenter?.SetData(usr);
            */
        }
    }
}
