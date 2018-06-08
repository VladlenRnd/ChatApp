using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using Chat.Android.Collection;
using Com.Wang.Avi;
using Portable.Data;
using Portable.NewsViper.Interface;
using Portable.Repository;

namespace Chat.Android
{
    [Activity(Label = "ChatActivity")]
    public class ChatActivity : Activity,IViewNews
    {

        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private RecuclerViewAdapter mUserCollection;
        private RepositoryData repo;
        private AVLoadingIndicatorView avi;

        public event Action<string> ClickFindBtn;

        public void LoadSpiner()
        {
            avi.Show();
        }

        public void UpdateData(News list)
        {
            mUserCollection.UpdateList(new NewsList(list));
            avi.Hide();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Chat);

             avi = FindViewById<AVLoadingIndicatorView>(Resource.Id.avi);



            repo = new RepositoryData(this);

            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.collectionView);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            mUserCollection = new RecuclerViewAdapter(this,new NewsList(new News()));
            mRecyclerView.SetAdapter(mUserCollection);

            var btn = FindViewById<Button>(Resource.Id.btnFind);
            btn.Click += ((s, e) =>
            {
                var txt = FindViewById<EditText>(Resource.Id.editFind);
                ClickFindBtn?.Invoke(txt.Text);
            });
      
        }



    }
}