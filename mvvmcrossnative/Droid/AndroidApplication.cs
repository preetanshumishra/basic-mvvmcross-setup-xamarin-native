using System;
using Android.Runtime;
using MvvmCross.Platforms.Android.Views;
using mvvmcrossnative.Core;

namespace mvvmccrossnative.Droid
{
    public class AndroidApplication : MvxAndroidApplication<AndroidSetup, App>
    {
        public AndroidApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }
    }
}