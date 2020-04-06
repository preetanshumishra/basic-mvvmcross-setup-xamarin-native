using MvvmCross;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core.Services.Contracts;
using mvvmcrossnative.Core.Services.Implementations;

namespace mvvmcrossnative.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            RegisterServices();
        }

        public override void Initialize()
        {
            // Register Custom AppStart
            RegisterCustomAppStart<AppStart>();
        }

        private void RegisterServices()
        {
            // Register all your services here.
            Mvx.IoCProvider.RegisterType<INavigationService, NavigationService>();
            Mvx.IoCProvider.RegisterType<ISampleService, SampleService>();
        }
    }
}