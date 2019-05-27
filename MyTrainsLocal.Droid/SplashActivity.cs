
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace MyTrainsLocal.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true)]
    public class SplashActivity : MvxSplashScreenActivity
    {
        public SplashActivity(): base(Resource.Layout.activity_splash)
        {

        }
    }
}