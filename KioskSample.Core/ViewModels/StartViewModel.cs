using System;
using MvvmCross.Navigation;

namespace KioskSample.Core.ViewModels
{
    public class StartViewModel : ViewModelBase
    {
        private readonly IMvxNavigationService _nav;

        public StartViewModel(IMvxNavigationService nav)
        {
            _nav = nav;
        }

/*        public override async void ViewAppearing()
        {
            if (new Random().Next(0, 100) > 50)
            {
                await _nav.Navigate<FirstViewModel>();
                return;
            }

            await _nav.Navigate<SecondViewModel>();
        }*/

        public override async void ViewDisappearing()
        {
            if (new Random().Next(0, 100) > 50)
            {
                await _nav.Navigate<FirstViewModel>();
                return;
            }

            await _nav.Navigate<SecondViewModel>();
        }

 
        public override async void ViewAppeared()
        {
            if (new Random().Next(0, 100) > 50)
            {
                await _nav.Navigate<FirstViewModel>();
                return;
            }

            await _nav.Navigate<SecondViewModel>();
        }
    }
}