using System;
using Android.App;
using Android.Runtime;
using KioskSample.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace KioskSample.Droid
{
    [Application(Name = "kiosksample.droid.MainApplication", AllowBackup = true, SupportsRtl = true,
        Theme = "@style/AppTheme", Label = "KioskSample")]
    public class MainApplication : MvxAndroidApplication<MvxAndroidSetup<App>, App>
    {
        public MainApplication(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }
    }
}