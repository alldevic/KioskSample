using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using KioskSample.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace KioskSample.Droid.Views
{
    [Activity(Name = "kiosksample.droid.views.SecondView", Label = "SecondView",
        LaunchMode = LaunchMode.SingleTask, ClearTaskOnLaunch = true, ExcludeFromRecents = true)]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e) => true;
    }
}