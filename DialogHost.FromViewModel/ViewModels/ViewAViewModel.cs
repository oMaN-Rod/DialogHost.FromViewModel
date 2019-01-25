using System;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using DialogHost.FromViewModel.Data;
using Prism.Commands;

namespace DialogHost.FromViewModel.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private const string DialogIdentifier = "RootDialogHost";

        private ObservableCollection<ConfigFile> _configFiles;

        public ObservableCollection<ConfigFile> ConfigFiles
        {
            get => _configFiles;
            set => SetProperty(ref _configFiles, value);
        }

        public ConfigFile SelectedConfigFile { get; set; }

        public DelegateCommand<object> EditCommand { get; private set; }

        public ViewAViewModel()
        {
            EditCommand = new DelegateCommand<object>(Edit);
            ConfigFiles = new ObservableCollection<ConfigFile>()
            {
                new ConfigFile()
                {
                    Name = "File1.txt",
                    FilePath = "Somepath"
                },
                new ConfigFile()
                {
                    Name = "File2.txt",
                    FilePath = "Somepath"
                },
                new ConfigFile()
                {
                    Name = "File3.txt",
                    FilePath = "Somepath"
                }
            };
        }

        public async void Edit(object obj)
        {
            var configFile = (ConfigFile) obj;
            var vm = new EditTextViewModel()
            {
                Title = "Edit Filename",
                TextName = "Filename",
                TextValue = configFile.Name
            };
            var dialogResult = await MaterialDesignThemes.Wpf.DialogHost.Show(vm, DialogIdentifier);
            if (dialogResult is bool res && res)
            {
                //Do Stuff
            }
        }
    }
}
