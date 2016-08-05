using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RP.ViewModels.Common;
using System.Windows.Input;
using System.Threading.Tasks;

namespace RP.ViewModels
{
    public class MainPageViewModel: BaseViewModel
    {
        public MainPageViewModel()
        {
            Action = new RelayCommand(
                async() =>
                {
                    await ActionAsync();
                }
                );

        }

        private string _property;
        public string Property
        {
            get
            {
                return _property;
            }
            set
            {
                _property = value;
                OnPropertyChanged();
            }
        }

        public ICommand Action { get; set; }

        private async Task ActionAsync()
        {
            Property = "aaa";
            await Task.Delay(1000);
            Property = "bbb";
        }
    }
}
