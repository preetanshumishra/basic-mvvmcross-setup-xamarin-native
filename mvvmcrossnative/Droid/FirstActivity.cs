using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using mvvmcrossnative.Core.ViewModels;
using MvvmCross.ViewModels;

namespace mvvmccrossnative.Droid
{
    [MvxViewFor(typeof(FirstViewModel))]
    [Activity(Label = "MvvmCrossNative", MainLauncher = true, Icon = "@mipmap/icon", Theme = "@style/Theme.AppCompat")]
    public class FirstActivity : MvxAppCompatActivity<FirstViewModel>
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.FirstView);

            Button button = FindViewById<Button>(Resource.Id.myButton);
            button.Click += delegate { button.Text = $"{count++} clicks!"; };
        }
    }
}