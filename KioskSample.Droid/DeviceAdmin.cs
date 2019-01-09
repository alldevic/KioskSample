using Android.App;
using Android.App.Admin;
using Android.Content;

namespace KioskSample.Droid
{
    [BroadcastReceiver(Permission = "android.permission.BIND_DEVICE_ADMIN", Name = "kiosksample.droid.DeviceAdmin")]
    [MetaData("android.app.device_admin", Resource = "@xml/device_admin")]
    [IntentFilter(new[] {"android.app.action.DEVICE_ADMIN_ENABLED", Intent.ActionMain})]
    public class DeviceAdmin : DeviceAdminReceiver
    {
    }
}