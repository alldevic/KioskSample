using Android.App;
using Android.App.Admin;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Java.Lang;
using KioskSample.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace KioskSample.Droid.Views
{
    [Activity(Name = "kiosksample.droid.views.SecondView", Label = "SecondView",
         LaunchMode = LaunchMode.SingleTask, ClearTaskOnLaunch = true,
         ExcludeFromRecents = true), IntentFilter(new[] {"android.intent.action.MAIN"}, Categories =
         new[] {Intent.CategoryHome})]
    public class SecondView : MvxActivity<SecondViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);

            var intent = new Intent(DevicePolicyManager.ActionAddDeviceAdmin);
            var deviceAdminComponentName = new ComponentName(this, Class.FromType(typeof(DeviceAdmin)).Name);
            intent.PutExtra(DevicePolicyManager.ExtraDeviceAdmin, deviceAdminComponentName);

            StartActivityForResult(intent, 1);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e) => true;
    }
}