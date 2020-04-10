﻿using System.Threading.Tasks;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core.Services.Contracts;

namespace mvvmcrossnative.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly ISampleService _sampleService;

        public FirstViewModel(INavigationService navigationService, ISampleService sampleService)
        {
            _navigationService = navigationService;
            _sampleService = sampleService;
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            _sampleService.SampleMethod();
        }
    }
}