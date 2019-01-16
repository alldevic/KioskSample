using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using KioskSample.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace KioskSample.Droid.Views
{
    [Activity(Name = "kiosksample.droid.views.FirstView", Label = "FirstView",
        LaunchMode = LaunchMode.SingleTask, ClearTaskOnLaunch = true, ExcludeFromRecents = true)]
    public class FirstView : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e) => true;
    }
}