﻿using MvvmCross.IoC;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MvvmCross.Views;
using mvvmcrossnative.Core.Services.Contracts;

namespace mvvmcrossnative.Core.Services.Implementations
{
    public class NavigationService : MvxNavigationService, INavigationService
    {
        public NavigationService(IMvxViewModelLoader viewModelLoader, IMvxViewDispatcher viewDispatcher, IMvxIoCProvider ioCProvider) : base(viewModelLoader, viewDispatcher, ioCProvider)
        {

        }
    }
}