using Microsoft.Extensions.Logging;
using MvvmCross.IoC;
using MvvmCross.Platforms.Ios.Core;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core;

namespace mvvmccrossnative.iOS
{
    public class IosSetup : MvxIosSetup<App>
    {
        protected override IMvxApplication CreateApp(IMvxIoCProvider iocProvider)
        {
            return new App();
        }

        protected override ILoggerFactory CreateLogFactory() => default;

        protected override ILoggerProvider CreateLogProvider() => default;
    }
}