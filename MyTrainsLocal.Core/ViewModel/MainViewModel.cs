using System.Threading.Tasks;
using MyTrainsLocal.Core.Contracts.ViewModels;

namespace MyTrainsLocal.Core.ViewModel
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        private string _greetingText;
        public string GreetingText
        {
            get => _greetingText;
            set => SetProperty(ref _greetingText, value);
        }

        protected async override Task InitializeAsync()
        {
            await Task.Delay(10);
            GreetingText = "Welcome to the first bound application";
        }
    }
}
