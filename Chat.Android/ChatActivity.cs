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
using Portable.NewsViper.Interface;

namespace Chat.Android
{
    [Activity(Label = "ChatActivity")]
    public class ChatActivity : Activity,IViewNews
    {

        private RecyclerView mRecyclerView;
        private RecyclerView.LayoutManager mLayoutManager;
        private RecuclerViewAdapter mUserCollection;

        public event Action<string> ClickFindBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Chat);


            mRecyclerView = FindViewById<RecyclerView>(Resource.Id.collectionView);
            mLayoutManager = new LinearLayoutManager(this);
            mRecyclerView.SetLayoutManager(mLayoutManager);

            mUserCollection = new RecuclerViewAdapter(this);
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