using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace KioskSample.Core.ViewModels
{
    public class ViewModelBase : MvxViewModel
    {
        public MvxAsyncCommand Close =>
            new MvxAsyncCommand(() => Mvx.IoCProvider.Resolve<IMvxNavigationService>().Close(this));
    }
}