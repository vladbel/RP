using RP.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RP.ViewModels.Controls
{

    public enum PinMode
    {
        Read,
        Write
    }

    public class PinViewModel: BaseViewModel
    {
        public PinViewModel()
        {
            PinMode = PinMode.Write;
            PinValue = 0;

            SetPinValue = new RelayCommand(
                async () =>
                {
                    await SetPinValueAsync();
                }
                );
        }

        private int _property;
        public int PinValue
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

        private PinMode _pinMode;
        public PinMode PinMode
        {
            get
            {
                return _pinMode;
            }
            set
            {
                _pinMode = value;
                OnPropertyChanged();
            }
        }

        public ICommand SetPinValue { get; set; }

        private async Task SetPinValueAsync()
        {
            if (PinMode == PinMode.Write)
            {
                // Set pin value
                PinValue += 1;
                await Task.FromResult(false);
            }
        }
    }
}
