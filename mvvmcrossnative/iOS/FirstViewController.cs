using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using mvvmcrossnative.Core.ViewModels;

namespace mvvmccrossnative.iOS
{
    [MvxViewFor(typeof(FirstViewModel))]
    public class FirstViewController : MvxViewController<FirstViewModel>
    {
        public FirstViewController()
        {

        }
    }
}