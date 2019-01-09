using KioskSample.Core.ViewModels;
using MvvmCross.ViewModels;

namespace KioskSample.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<FirstViewModel>();
        }
    }
}