using MvvmCross;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace KioskSample.Core.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
        public string StrHello => "Hello world!";

        public MvxAsyncCommand ShowSecond =>
            new MvxAsyncCommand(() => Mvx.IoCProvider.Resolve<IMvxNavigationService>().Navigate<SecondViewModel>());
    }
}