using System;
using Android.App;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.AppCompat;
using mvvmcrossnative.Core;

namespace mvvmccrossnative.Droid
{
    [Application]
    public class AndroidApplication : MvxAppCompatApplication<AndroidSetup, App>
    {
        public AndroidApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {

        }
    }
}