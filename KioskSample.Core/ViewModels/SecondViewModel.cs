using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace KioskSample.Core.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        public MvxAsyncCommand ShowFirst =>
            new MvxAsyncCommand(() => Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<FirstViewModel>());
    }
}