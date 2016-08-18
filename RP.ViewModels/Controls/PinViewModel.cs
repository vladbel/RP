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

            SwitchPinMode = new RelayCommand(
                async () =>
                {
                    await SwitchPinModeAsync();
                }
                );
        }

        private int _pinValue;
        public int PinValue
        {
            get
            {
                return _pinValue;
            }
            set
            {
                _pinValue = value;
                OnPropertyChanged();
            }
        }

        private int _pinName;
        public int PinName
        {
            get
            {
                return _pinName;

            }
            set
            {
                _pinName = value;
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

        public ICommand SwitchPinMode { get; set; }

        private async Task SwitchPinModeAsync()
        {
            if (PinMode == PinMode.Write)
            {
                PinMode = PinMode.Read;
            }
            else
            {
                PinMode = PinMode.Write;
            }
            await Task.FromResult(false);
        }
    }
}
