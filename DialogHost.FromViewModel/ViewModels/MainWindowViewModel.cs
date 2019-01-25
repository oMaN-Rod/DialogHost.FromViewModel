using Prism.Mvvm;

namespace DialogHost.FromViewModel.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "DialogHost.FromViewModel Prism App";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
