using ModuleBase;
using System;

namespace ExampleModule
{
    public class ExampleModuleViewModel : ModuleViewModelBase
    {
        private ModuleActionCommand _SaveCommand;
        public ModuleActionCommand SaveCommand
        {
            get
            {
                return _SaveCommand ?? (_SaveCommand = new ModuleActionCommand()
                {
                    ExecuteAction = () =>
                    {
                        RaiseSaveClicked();
                    }
                });
            }
        }

        private string _setting1;
        public string Setting1
        {
            get
            {
                return _setting1;
            }
            set
            {
                if (Equals(_setting1, value))
                {
                    return;
                }

                _setting1 = value;

                NotifyPropertyChanged();
            }
        }

        private bool _setting2;
        public bool Setting2
        {
            get
            {
                return _setting2;
            }
            set
            {
                if (Equals(_setting2, value))
                {
                    return;
                }

                _setting2 = value;

                NotifyPropertyChanged();
            }
        }

        public ExampleModuleViewModel(string guid) : base(guid)
        {

        }
    }
}
