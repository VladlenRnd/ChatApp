using Portable.NewsViper.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portable.NewsViper.Presenter
{
    public class PresenterNews : IPresenterNews
    {
        public event Action<string> ClickFindBtn;

        private IViewNewsCard _viewCard;
        private IViewNews _view;
        private IRouterNews _router;

        public PresenterNews(IViewNewsCard viewCard, IViewNews view,IRouterNews router)
        {
            _viewCard = viewCard;
            _view = view;
            _router = router;
            view.ClickFindBtn += View_ClickFindBtn;
        }

        private void View_ClickFindBtn(string obj)
        {
            ClickFindBtn?.Invoke(obj);
        }

        public void SetData(INewsEntity entity)
        {
            _viewCard.SetTitleNews(entity.Title);
            _viewCard.SetImageNews(entity.UrlImg);
            _viewCard.SetTimeNews(entity.Time);
        }
    }
}
