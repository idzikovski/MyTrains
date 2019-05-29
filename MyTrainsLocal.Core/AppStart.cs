using MvvmCross.Core.ViewModels;
using MyTrainsLocal.Core.ViewModel;

namespace MyTrainsLocal.Core
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<MainViewModel>();
        }
    }
}
