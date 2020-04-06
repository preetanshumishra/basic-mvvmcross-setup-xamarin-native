using System;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core;

namespace mvvmccrossnative.iOS
{
    public class IosSetup : MvxIosSetup<App>
    {
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}