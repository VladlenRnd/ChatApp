﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace Chat.Android
{
    [Activity(Label = "Chat.Android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
        
        }
    }
}

