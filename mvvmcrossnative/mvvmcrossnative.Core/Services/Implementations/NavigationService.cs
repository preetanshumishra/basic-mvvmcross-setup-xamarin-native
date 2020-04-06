using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core.Services.Contracts;

namespace mvvmcrossnative.Core.Services.Implementations
{
    public class NavigationService : MvxNavigationService, INavigationService
    {
        public NavigationService(IMvxNavigationCache navigationCache, IMvxViewModelLoader viewModelLoader) : base(navigationCache, viewModelLoader)
        {
        }
    }
}
