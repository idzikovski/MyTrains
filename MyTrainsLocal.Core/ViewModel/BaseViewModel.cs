using MvvmCross.Core.ViewModels;
using MyTrainsLocal.Core.Contracts.ViewModels;
using System;
using System.Threading.Tasks;

namespace MyTrainsLocal.Core.ViewModel
{
    public class BaseViewModel : MvxViewModel, IViewModel
    {
        public async Task ReloadDataAsync()
        {
            try
            {
                await InitializeAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        protected virtual Task InitializeAsync()
        {
            return Task.FromResult(0);
        }
    }
}
