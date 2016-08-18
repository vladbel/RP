using RP.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP.ViewModels.Controls
{
    public class GpioPinsViewModel : BaseViewModel
    {
        private ObservableCollection<PinViewModel> _pins;

        public ObservableCollection<PinViewModel> Pins
        {
            get
            {
                return _pins;
            }
            set
            {
                _pins = value;
                OnPropertyChanged();
            }
        }
    }
}
