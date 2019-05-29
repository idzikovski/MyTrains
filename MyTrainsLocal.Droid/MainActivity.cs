
using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using MyTrainsLocal.Core.ViewModel;

namespace MyTrainsLocal.Droid
{
    [Activity(Label = "MainActivity")]
    public class MainActivity : MvxActivity<MainViewModel>
    {
        public new MainViewModel ViewModel
        {
            get { return (MainViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            await ViewModel.ReloadDataAsync();
        }
    }
}