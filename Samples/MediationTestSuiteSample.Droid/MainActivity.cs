﻿using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Com.Google.Android.Ads.Mediationtestsuite;

namespace MediationTestSuiteSample.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            // TODO:
            // Update your application ID in AndroidManifest.xml
            // Update application ID
            MediationTestSuite.Launch(this, "ca-app-pub-################~##########");
        }
    }
}