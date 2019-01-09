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
    [Activity(Name = "kiosksample.droid.views.FirstView", Label = "KioskSample", MainLauncher = true,
         LaunchMode = LaunchMode.SingleTask, ClearTaskOnLaunch = true, ExcludeFromRecents = true),
     IntentFilter(new[] {"android.intent.action.MAIN"}, Categories =
         new[] {Intent.CategoryDefault, Intent.CategoryHome})]
    public class FirstView : MvxActivity<FirstViewModel>
    {
        private const int ActivationRequest = 1;
        ComponentName _deviceAdminComponentName;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);

            var intent = new Intent(DevicePolicyManager.ActionAddDeviceAdmin);
            _deviceAdminComponentName = new ComponentName(this, Class.FromType(typeof(DeviceAdmin)).Name);
            intent.PutExtra(DevicePolicyManager.ExtraDeviceAdmin, _deviceAdminComponentName);

            StartActivityForResult(intent, ActivationRequest);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            switch (requestCode)
            {
                case ActivationRequest:
                    if (resultCode != Result.Ok) return;
                    var myDevicePolicyManager =
                        (DevicePolicyManager) GetSystemService(DevicePolicyService);

                    if (myDevicePolicyManager.IsDeviceOwnerApp(PackageName))
                    {
                        myDevicePolicyManager.SetLockTaskPackages(_deviceAdminComponentName,
                            new[] {PackageName});
                    }

                    if (myDevicePolicyManager.IsLockTaskPermitted(PackageName))
                    {
                        StartLockTask();
                    }

                    return;
            }

            base.OnActivityResult(requestCode, resultCode, data);
        }

        public override bool OnKeyDown(Keycode keyCode, KeyEvent e) => true;
    }
}