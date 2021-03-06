﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;

namespace App.Droid
{
    [Activity(Label = "Votuca", Icon = "@mipmap/uca", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Forms.SetFlags("CollectionView_Experimental");
            Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            LockRotation(Orientation.Vertical);
        }

        private void LockRotation(Orientation orientation)
        {
            RequestedOrientation = ScreenOrientation.Portrait;
        }
    }
}