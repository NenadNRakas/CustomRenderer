﻿using Android.App;
using Android.OS;
using Android.Content.PM;
using AndroidX.Core.OS;
//using Android.Runtime;
//using AndroidX.AppCompat.App;
//using System;
//using Android.Content;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
namespace CustomRenderer.Droid
{
    [Activity(Label = "CustomRenderer.Droid", Icon ="@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);
            LoadApplication(new App());
        }
        /**public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }**/
    }
}