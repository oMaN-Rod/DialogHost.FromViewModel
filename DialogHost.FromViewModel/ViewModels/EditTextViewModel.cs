using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DialogHost.FromViewModel.ViewModels
{
    public class EditTextViewModel : BindableBase
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _textName;

        public string TextName
        {
            get => _textName;
            set => SetProperty(ref _textName, value);
        }

        private string _textValue;

        public string TextValue
        {
            get => _textValue;
            set => SetProperty(ref _textValue, value);
        }

        public EditTextViewModel()
        {
            
        }
    }
}
