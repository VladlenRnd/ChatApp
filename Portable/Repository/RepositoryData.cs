using Newtonsoft.Json;
using Portable.Data;
using Portable.NewsViper.Interface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portable.Repository
{
    public class RepositoryData
    {

        IViewNews _view;

        public RepositoryData(IViewNews view)
        {
            _view = view;
            _view.ClickFindBtn += _view_ClickFindBtn;
        }



        private async void _view_ClickFindBtn(string searc)
        {
            string res;
            string url = String.Format("https://newsapi.org/v2/top-headlines?sources=lenta&q={0}&apiKey=7917a33f77da46a5af1d4849b160e5ec", searc);
            _view.LoadSpiner();
            res = await GetNewsByUrl(url);

            News m = JsonConvert.DeserializeObject<News>(res);
            _view.UpdateData(m);
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
    }
}
