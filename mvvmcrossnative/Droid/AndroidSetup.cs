using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core;

namespace mvvmccrossnative.Droid
{
    public class AndroidSetup : MvxAppCompatSetup<App>
    {
        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}