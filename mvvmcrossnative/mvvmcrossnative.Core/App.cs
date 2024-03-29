﻿using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MvvmCross.Views;
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
            Mvx.IoCProvider.RegisterSingleton<INavigationService>(() => new NavigationService(Mvx.IoCProvider.Resolve<IMvxViewModelLoader>(), Mvx.IoCProvider.Resolve<IMvxViewDispatcher>(), Mvx.IoCProvider));
            Mvx.IoCProvider.LazyConstructAndRegisterSingleton<ISampleService, SampleService>();
        }
    }
}